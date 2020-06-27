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
    public partial class cmstn_fr : Form
    {
        public cmstn_fr()
        {
            InitializeComponent();
        }

        private void cmstn_fr_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dJDataSet.cmpstn". При необходимости она может быть перемещена или удалена.
            this.cmpstnTableAdapter.Fill(this.dJDataSet.cmpstn);

        }

        private void cmpstnBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cmpstnBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dJDataSet);

        }

        private void cmpstnDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void id_cmpstnLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
