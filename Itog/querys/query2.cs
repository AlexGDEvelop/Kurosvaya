using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Itog.querys
{
    public partial class query2 : Form
    {
        string query = "";
        public query2()
        {
            InitializeComponent();
        }

        private void query2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dJDataSet.schdl". При необходимости она может быть перемещена или удалена.
            this.schdlTableAdapter.Fill(this.dJDataSet.schdl);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dJDataSet.emp". При необходимости она может быть перемещена или удалена.
            this.empTableAdapter.Fill(this.dJDataSet.emp);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dJDataSet.QueryNetVesch". При необходимости она может быть перемещена или удалена.
            this.queryNetVeschTableAdapter.Fill(this.dJDataSet.QueryNetVesch);

        }

        private void filter_btn_Click(object sender, EventArgs e)
        {
            if (query != "")
            {
                queryNetVeschBindingSource.Filter = query;
                queryNetVeschDataGridView.Update();
            }
            query = "";

        }

        private void mscn_comb_SelectedIndexChanged(object sender, EventArgs e)
        {

            query = "date='" + mscn_comb.Text + "'";
            label1.Visible = false;
            label2.Visible = true;




        }

        private void gnrs_comb_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Visible = false;
            query = "fn='" + gnrs_comb.Text + "'";
            label1.Visible = true;

        }


        private void cancel_filer_btn_Click(object sender, EventArgs e)
        {
            queryNetVeschBindingSource.Filter = null;
            queryNetVeschDataGridView.Update();
            query = "";
            label1.Visible = true;
            label2.Visible = true;
        }

        private void mscn_comb_Click(object sender, EventArgs e)
        {
            if (label1.Visible)
            {
                label1.Visible = false;
                mscn_comb_SelectedIndexChanged(sender, e);
            }
        }

        private void gnrs_comb_Click(object sender, EventArgs e)
        {
            if (label2.Visible)
            {
                label2.Visible = false;
                gnrs_comb_SelectedIndexChanged(sender, e);
            }
        }

        private void queryNetVeschBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Otchgen otchgen = new Otchgen();
            otchgen.GenerateOtchet(queryNetVeschDataGridView, "schdl");
        }
    }
}
