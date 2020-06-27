using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace bd
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private System.Windows.Data.CollectionViewSource empViewSource;
        private bd.DJDataSetTableAdapters.empTableAdapter dJDataSetempTableAdapter;
        private bd.DJDataSet dJDataSet;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            dJDataSet = ((bd.DJDataSet)(this.FindResource("dJDataSet")));
            // Загрузить данные в таблицу emp. Можно изменить этот код как требуется.
            dJDataSetempTableAdapter = new bd.DJDataSetTableAdapters.empTableAdapter();
            dJDataSetempTableAdapter.Fill(dJDataSet.emp);
            empViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("empViewSource")));
            empViewSource.View.MoveCurrentToFirst();
            // Загрузить данные в таблицу cmpstn. Можно изменить этот код как требуется.
            bd.DJDataSetTableAdapters.cmpstnTableAdapter dJDataSetcmpstnTableAdapter = new bd.DJDataSetTableAdapters.cmpstnTableAdapter();
            dJDataSetcmpstnTableAdapter.Fill(dJDataSet.cmpstn);
            System.Windows.Data.CollectionViewSource cmpstnViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("cmpstnViewSource")));
            cmpstnViewSource.View.MoveCurrentToFirst();
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            if (empViewSource.View.CurrentPosition > 0)
            {
                empViewSource.View.MoveCurrentToPrevious();
            }
        }

        private void nextButton_Click(object sender, RoutedEventArgs e)
        {
            if (empViewSource.View.CurrentPosition < ((CollectionView)empViewSource.View).Count - 1)
            {
                empViewSource.View.MoveCurrentToNext();
            }
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            dJDataSetempTableAdapter.Update(dJDataSet.emp);
        }
    }
}
