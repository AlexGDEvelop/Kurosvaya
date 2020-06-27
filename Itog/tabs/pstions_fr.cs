using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Itog
{
    public partial class pstions_fr : Form
    {
        public pstions_fr()
        {
            InitializeComponent();
        }

        private void pstionsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pstionsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dJDataSet);

        }

        private void pstions_fr_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dJDataSet.pstions". При необходимости она может быть перемещена или удалена.
            this.pstionsTableAdapter.Fill(this.dJDataSet.pstions);

        }

        private void pstionsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
