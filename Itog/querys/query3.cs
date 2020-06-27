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
    public partial class query3 : Form
    {
        string query = "";
        public query3()
        {
            InitializeComponent();
        }

        private void query3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dJDataSet.pstions". При необходимости она может быть перемещена или удалена.
            this.pstionsTableAdapter.Fill(this.dJDataSet.pstions);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dJDataSet.QueryOtdelKad". При необходимости она может быть перемещена или удалена.
            this.queryOtdelKadTableAdapter.Fill(this.dJDataSet.QueryOtdelKad);

        }

        private void filter_btn_Click(object sender, EventArgs e)
        {
            if (query != "")
            {
                queryOtdelKadBindingSource.Filter = query;
                queryOtdelKadDataGridView.Update();
            }
            query = "";

        }


        private void gnrs_comb_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "pstion_n='" + gnrs_comb.Text + "'";
        }


        private void cancel_filer_btn_Click(object sender, EventArgs e)
        {
            queryOtdelKadBindingSource.Filter = null;
            queryOtdelKadDataGridView.Update();
            query = "";
            label2.Visible = true;
        }



        private void gnrs_comb_Click(object sender, EventArgs e)
        {
            if (label2.Visible)
            {
                label2.Visible = false;
                gnrs_comb_SelectedIndexChanged(sender, e);
            }
        }
        private void queryOtdelKadBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Otchgen otchgen = new Otchgen();
            otchgen.GenerateOtchet(queryOtdelKadDataGridView, "emp");
        }
    }
}
