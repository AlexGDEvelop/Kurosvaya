using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Itog.querys;

namespace Itog
{


    public partial class Form1 : Form
    {
        Form fr;
        public Form1()
        {
            InitializeComponent();
        }

        private void empBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dJDataSet.schdl". При необходимости она может быть перемещена или удалена.
           
            //cmpstnDataGridView.DataSource = empBindingSource;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (listBox1.SelectedIndex)
            {
                case 1:
                    fr = new empl_fr();
                    fr.Show(this);
                    

                    break;
                case 2:
                    fr = new pstions_fr();
                    fr.Show(this);


                    break;
                case 3:
                     fr = new mscn_fr();
                    fr.Show(this);


                    break;
                case 4:
                     fr = new gnrs_fr();
                    fr.Show(this);


                    break;
                case 5:
                    fr = new cmstn_fr();
                    fr.Show(this);


                    break;
                case 6:
                    fr = new schdl_fr();
                    fr.Show(this);
                    break;
                case 8:
                    fr = new query1();
                    fr.Show(this);


                    break;
                case 9:
                    fr = new query2();
                    fr.Show(this);


                    break;
                case 10:
                    fr = new query3();
                    fr.Show(this);
                    break;
            }
        }
    }
}
