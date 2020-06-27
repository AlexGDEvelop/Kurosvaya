using Kurosvaya.Dj_DSTableAdapters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Kurosvaya
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>

    //DataGrid[] dataGrids;
    public partial class MainWindow : Window
    {
        DataGrid[] Tabs;
        DataGrid[] Qest;
        DataGrid[] Filters;
        Dj_DS dj = new Dj_DS();
        Dj_DS dj_DS;
        empTableAdapter dj_DSempTableAdapter;
        CollectionViewSource empViewSource;
        pstionsTableAdapter dj_DSpstionsTableAdapter;
        CollectionViewSource pstionsViewSource;
        gnrsTableAdapter dj_DSgnrsTableAdapter;
        CollectionViewSource gnrsViewSource;
        cmpstnTableAdapter dj_DScmpstnTableAdapter;
        CollectionViewSource cmpstnViewSource;
        mscnTableAdapter dj_DSmscnTableAdapter;
        CollectionViewSource mscnViewSource;
        schdlTableAdapter dj_DSschdlTableAdapter;
        CollectionViewSource schdlViewSource;


        public MainWindow()
        {
            InitializeComponent();

        }

        void DataGridInitialize()
        {
            Tabs = new DataGrid[6];
            Qest = new DataGrid[3];
            cmpstnTableAdapter f = new cmpstnTableAdapter();
            

            var query =
            from emp in dj.emp
            select new{ emp.id_emp, emp.fn, emp.age, emp.sex, emp.nmbr, emp.psprt_nmbr };


            var pstions = f;
            
            
            
            //Tabs[0].ItemsSource = dj.pstions;
            //employe_grid.Children.Add(Tabs[0]);

            //Tabs[0].UpdateLayout;


        }

        /// <summary>
        /// Пока не придумал
        /// </summary>
        public void Paint()
        {
            
        }

        private void Child_Tab_Tab_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (Child_Tab_Tab.SelectedIndex)
            {
                case 0:
                    DataGridInitialize();
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            dj_DS = ((Kurosvaya.Dj_DS)(this.FindResource("dj_DS")));
            // Загрузить данные в таблицу emp. Можно изменить этот код как требуется.
            dj_DSempTableAdapter = new Kurosvaya.Dj_DSTableAdapters.empTableAdapter();
            dj_DSempTableAdapter.Fill(dj_DS.emp);
            empViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("empViewSource")));
            empViewSource.View.MoveCurrentToFirst();
            // Загрузить данные в таблицу pstions. Можно изменить этот код как требуется.
            dj_DSpstionsTableAdapter = new Kurosvaya.Dj_DSTableAdapters.pstionsTableAdapter();
            dj_DSpstionsTableAdapter.Fill(dj_DS.pstions);
            pstionsViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("pstionsViewSource")));
            pstionsViewSource.View.MoveCurrentToFirst();
            // Загрузить данные в таблицу gnrs. Можно изменить этот код как требуется.
            dj_DSgnrsTableAdapter = new Kurosvaya.Dj_DSTableAdapters.gnrsTableAdapter();
            dj_DSgnrsTableAdapter.Fill(dj_DS.gnrs);
            gnrsViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("gnrsViewSource")));
            gnrsViewSource.View.MoveCurrentToFirst();
            // Загрузить данные в таблицу cmpstn. Можно изменить этот код как требуется.
            dj_DScmpstnTableAdapter = new Kurosvaya.Dj_DSTableAdapters.cmpstnTableAdapter();
            dj_DScmpstnTableAdapter.Fill(dj_DS.cmpstn);
            cmpstnViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("cmpstnViewSource")));
            cmpstnViewSource.View.MoveCurrentToFirst();
            // Загрузить данные в таблицу mscn. Можно изменить этот код как требуется.
            dj_DSmscnTableAdapter = new Kurosvaya.Dj_DSTableAdapters.mscnTableAdapter();
            dj_DSmscnTableAdapter.Fill(dj_DS.mscn);
            mscnViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("mscnViewSource")));
            mscnViewSource.View.MoveCurrentToFirst();
            // Загрузить данные в таблицу schdl. Можно изменить этот код как требуется.
            dj_DSschdlTableAdapter = new Kurosvaya.Dj_DSTableAdapters.schdlTableAdapter();
            dj_DSschdlTableAdapter.Fill(dj_DS.schdl);
            schdlViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("schdlViewSource")));
            schdlViewSource.View.MoveCurrentToFirst();
        }
    }
}
