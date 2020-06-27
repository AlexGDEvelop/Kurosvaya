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
    public partial class gnrs_fr : Form
    {
        public gnrs_fr()
        {
            InitializeComponent();
        }

        private void gnrsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gnrsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dJDataSet);
            Otchgen otchet = new Otchgen();
            //this.empBindingSource.EndEdit();
            //empTableAdapter.Update(dJDataSet.emp);

            otchet.GenerateOtchet(gnrsDataGridView, "gnrs");

            /*string path = System.IO.Directory.GetCurrentDirectory() + @"\" + "Save_emp.xlsx";

            Excel.Application excelapp = new Excel.Application();
            Excel.Workbook workbook = excelapp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.ActiveSheet;
            string[] ms = new string[3] { "Код жанра", "Наименование", "О жанре" };

            for (int i = 0; i < gnrsDataGridView.RowCount - 1; i++)
            {

                for (int j = 0; j < gnrsDataGridView.ColumnCount; j++)
                {
                    worksheet.Rows[1].Columns[j + 1] = ms[j];
                    worksheet.Rows[i + 2].Columns[j + 1] = gnrsDataGridView.Rows[i].Cells[j].Value;
                    
                }
            }





            excelapp.AlertBeforeOverwriting = false;
            workbook.SaveAs(path);
            excelapp.Quit();*/

        }

        private void gnrs_fr_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dJDataSet.gnrs". При необходимости она может быть перемещена или удалена.
            this.gnrsTableAdapter.Fill(this.dJDataSet.gnrs);

        }

        private void gnrsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
