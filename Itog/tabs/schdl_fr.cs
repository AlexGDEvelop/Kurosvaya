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
    public partial class schdl_fr : Form
    {
        public schdl_fr()
        {
            InitializeComponent();
        }

        private void schdlBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.schdlBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dJDataSet);

        }

        private void schdl_fr_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dJDataSet.schdl". При необходимости она может быть перемещена или удалена.
            this.schdlTableAdapter.Fill(this.dJDataSet.schdl);

        }
    }
}
