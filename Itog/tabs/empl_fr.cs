using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace Itog
{
    public partial class empl_fr : Form
    {
        public empl_fr()
        {
            InitializeComponent();
        }

        private void empBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            string[,] ar = new string[2,2];
            Dictionary<int,string> pairs = new Dictionary<int,string>();
            //this.tableAdapterManager.UpdateAll(this.dJDataSet);
            empTableAdapter.Update(dJDataSet.emp);
            //this.empBindingSource.EndEdit();
            //empTableAdapter.Update(dJDataSet.emp);



            string path = System.IO.Directory.GetCurrentDirectory() + @"\" + "Save_emp.xlsx";


            string[] ms = new string[8] { "Код сотрудника","ФИО","Возраст","Пол","Адрес","Номер","Паспортные данные","Должность"};

            for (int i = 0; i < empDataGridView.RowCount - 1; i++)
            {

                for (int j = 0; j < empDataGridView.ColumnCount; j++)
                {
      
                    if (j == 7)
                    {
                        try
                        {
                            n_ps_comb.SelectedIndex = int.Parse(empDataGridView.Rows[i].Cells[j].Value.ToString()) - 1;
                            pairs.Add(i,n_ps_comb.GetItemText(n_ps_comb.SelectedItem) + " 7");
                        }
                        catch
                        {

                        }

                    }
                    if(j == 3)
                    {
                        /*if ((bool)empDataGridView.Rows[i].Cells[j].EditedFormattedValue)
                            worksheet.Rows[i + 2].Columns[j + 1] = "Мужчина";
                        else worksheet.Rows[i + 2].Columns[j + 1] = "Женщина";*/

                        if ((bool)empDataGridView.Rows[i].Cells[j].EditedFormattedValue)
                            pairs.Add(i,"Мужчина 3");
                        else pairs.Add(i, "Женщина 3");

                    }

                }

  
            }


            Otchgen d = new Otchgen();
            d.GenerateOtchet(empDataGridView, "empl", pairs);
            

            /*excelapp.AlertBeforeOverwriting = false;
            workbook.SaveAs(path);
            excelapp.Quit()/*/

        }

        private void empl_fr_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dJDataSet.pstions". При необходимости она может быть перемещена или удалена.
            this.pstionsTableAdapter.Fill(this.dJDataSet.pstions);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dJDataSet.emp". При необходимости она может быть перемещена или удалена.
            this.empTableAdapter.Fill(this.dJDataSet.emp);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.pstionsTableAdapter.Fill(this.dJDataSet.pstions);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void empBindingNavigator_RefreshItems(object sender, EventArgs e)
        {
            try
            {
                n_ps_comb.SelectedIndex = int.Parse(id_pstionTextBox.Text) - 1 ;
            }
            catch
            {

            }
        }

        private void n_ps_comb_SelectedIndexChanged(object sender, EventArgs e)
        {
            id_pstionTextBox.Text = (n_ps_comb.SelectedIndex + 1).ToString();
        }
    }
}
