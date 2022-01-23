using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev_GP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Form4 form4 = new Form4();
        Form3 form3 = new Form3();
        Form3 teras2 = new Form3();
        Form3 teras3 = new Form3();
        Form3 teras4 = new Form3();
        Form3 teras5 = new Form3();
        Form3 teras6 = new Form3();
       

        Form4 bahce2 = new Form4();
        Form4 bahce3 = new Form4();
        Form4 bahce4 = new Form4();
        Form4 bahce5 = new Form4();
        Form4 bahce6 = new Form4();

        public bool admincontrol;

        private void masa1_Click(object sender, EventArgs e)
        {
            if (admincontrol == true)
            {


                form4.Show();
                


            }
            else
            {

                form3.Show();
            }
        }

        private void masa2_Click(object sender, EventArgs e)
        {
            if (admincontrol == true)
            {

                bahce2.Show();
            }
            else
            {

                teras2.Show();
            }
        }

        private void masa3_Click(object sender, EventArgs e)
        {
            if (admincontrol == true)
            {




                bahce3.Show();


            }
            else
            {

                teras3.Show();
            }
        }

        private void masa4_Click(object sender, EventArgs e)
        {
            if (admincontrol == true)
            {




                bahce4.Show();


            }
            else
            {

                teras4.Show();
            }
        }

        private void masa5_Click(object sender, EventArgs e)
        {
            if (admincontrol == true)
            {




                bahce5.Show();


            }
            else
            {

                teras5.Show();
            }
        }

        private void masa6_Click(object sender, EventArgs e)
        {
            if (admincontrol == true)
            {




                bahce6.Show();


            }
            else
            {


                teras6.Show();
            }
        }
    }
}
