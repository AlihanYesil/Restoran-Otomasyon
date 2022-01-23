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
    public partial class Form1 : Form
    {
        
        
        public Form1()
        {
            InitializeComponent();
        }
        public bool admincontrol;



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(id.Text=="admin" && sifre.Text == "123456789")
            {
                Form2 frm2 = new Form2();
                frm2.Show();
                frm2.admincontrol = true;
                this.Hide();
            }

            else if (id.Text=="personel"&& sifre.Text == "123456789")
            {
                Form2 frm2 = new Form2();
                frm2.Show();
                frm2.admincontrol = false;
                this.Hide();
            }

            else
            {
                MessageBox.Show("Kullanıcı id veya Sifre YANLIŞ", "HATA",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            } 

        }

       
    }
}
