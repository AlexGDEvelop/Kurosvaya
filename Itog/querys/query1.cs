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
    public partial class query1 : Form
    {
        string query = "";
        public query1()
        {
            InitializeComponent();
        }

        private void schdlBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableAdapterManager.UpdateAll(this.dJDataSet);

        }

        private void query1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dJDataSet.gnrs". При необходимости она может быть перемещена или удалена.
            this.gnrsTableAdapter.Fill(this.dJDataSet.gnrs);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dJDataSet.mscn". При необходимости она может быть перемещена или удалена.
            this.mscnTableAdapter.Fill(this.dJDataSet.mscn);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dJDataSet.QueryMusArch". При необходимости она может быть перемещена или удалена.
            this.queryMusArchTableAdapter.Fill(this.dJDataSet.QueryMusArch);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dJDataSet.schdl". При необходимости она может быть перемещена или удалена.



        }



        private void filter_btn_Click(object sender, EventArgs e)
        {
            if (query != "")
            {
                queryMusArchBindingSource.Filter = query;
                queryMusArchDataGridView.Update();
            }
            query = "";

        }

        private void mscn_comb_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "mscn_n='" + mscn_comb.Text + "'";
            label1.Visible = false;
            label2.Visible = true;
        }

        private void gnrs_comb_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "gnr_n='" + gnrs_comb.Text + "'";
            label1.Visible = true;
            label2.Visible = false;


        }


        private void cancel_filer_btn_Click(object sender, EventArgs e)
        {
            queryMusArchBindingSource.Filter = null;
            queryMusArchDataGridView.Update();
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

        private void queryMusArchBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void queryMusArchBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Otchgen otchgen = new Otchgen();
            otchgen.GenerateOtchet(queryMusArchDataGridView, "cmpstn");
        }
    }
}
