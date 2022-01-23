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
    public partial class Form4 : Form
    {
       
        public Form4()
        {
            InitializeComponent();
        }
        

        Dictionary<string, int> listeler = new Dictionary<string, int>();
        Dictionary<string, int> listeler2 = new Dictionary<string, int>();
        Dictionary<string, int> listeler3 = new Dictionary<string, int>();
        Dictionary<string, int> listeler4 = new Dictionary<string, int>();
        private void btnmenu_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in listeler)
            {
                dataGridView1.Rows.Add(item.Key, item.Value);
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            listeler.Add("2li Menü", 20);
            listeler.Add("Köfte Menü", 22);
            listeler.Add("Kral Menü", 22);
            listeler.Add("Çocuk Menüsü", 14);
            listeler.Add("20.Yıl Menü", 18);
            listeler2.Add("Patates", 3);
            listeler2.Add("Büyük Boy", 3);
            listeler2.Add("Soğan Halkası", 5);
            listeler2.Add("SOSLAR", 1);
            listeler2.Add("Kola", 3);
            listeler3.Add("Kola", 3);
            listeler3.Add("Ayran", 2);
            listeler3.Add("Gazoz", 3);
            listeler3.Add("Fanta", 3);
            listeler4.Add("Tiramisu", 12);
            listeler4.Add("Mozaik Pasta", 12);
            listeler4.Add("Sufle", 12);



        }

        private void btnekstra_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in listeler2)
            {
                dataGridView1.Rows.Add(item.Key, item.Value);
            }
        }

        private void btnicecek_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in listeler3)
            {
                dataGridView1.Rows.Add(item.Key, item.Value);
            }
        }

        private void btntatlı_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in listeler4)
            {
                dataGridView1.Rows.Add(item.Key, item.Value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow satir = dataGridView1.CurrentRow;
                dataGridView5.Rows.Add(satir.Cells[0].Value, satir.Cells[1].Value);



            }
            else
            {
                MessageBox.Show("Bir Ürün Seçiniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }





        }

        private void dataGridView5_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

            if (dataGridView5.Rows.Count != 0)
            {
                dolubtn.Checked = true;
            }

            int tutar = 0;
            foreach (DataGridViewRow item in dataGridView5.Rows)
            {
                tutar += Convert.ToInt32(item.Cells[1].Value);
            }

            textBox1.Text = tutar.ToString();

        }




        private void button3_Click(object sender, EventArgs e)
        {


            this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (dataGridView5.SelectedRows.Count > 0)
            {
                dataGridView5.Rows.Remove(dataGridView5.SelectedRows[0]);
            }
            else
                MessageBox.Show("Bir Ürün Seçiniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dataGridView5_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dataGridView5.RowCount == 0)
            {
                dolubtn.Checked = false;
            }
            int tutar = 0;
            foreach (DataGridViewRow item in dataGridView5.Rows)
            {
                tutar += Convert.ToInt32(item.Cells[1].Value);
            }

            textBox1.Text = tutar.ToString();




        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView5.Rows.Clear();
        }

        private void kredi_CheckedChanged(object sender, EventArgs e)
        {
            if (kredi.Checked == true)
            {
                kredi.BackColor = Color.Red;
            }
            else
            {
                kredi.BackColor = Color.White;
            }
        }

        private void nakit_CheckedChanged(object sender, EventArgs e)
        {
            if (nakit.Checked == true)
            {
                nakit.BackColor = Color.Red;
            }
            else
            {
                nakit.BackColor = Color.White;
            }
        }

       
    }
}
