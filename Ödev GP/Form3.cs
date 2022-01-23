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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        Dictionary<string, int> listeler = new Dictionary<string, int>();
        Dictionary<string, int> listeler2 = new Dictionary<string, int>();
        Dictionary<string, int> listeler3 = new Dictionary<string, int>();
        Dictionary<string, int> listeler4 = new Dictionary<string, int>();


        private void Form3_Load(object sender, EventArgs e)
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

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow satir = dataGridView1.CurrentRow;
                dataGridView6.Rows.Add(satir.Cells[0].Value, satir.Cells[1].Value);
            }
            else
            {
                MessageBox.Show("Bir Ürün Seçiniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in listeler)
            {
                dataGridView1.Rows.Add(item.Key, item.Value);
            }
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

        private void dataGridView6_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dataGridView6.Rows.Count != 0)
            {
                dolubtn.Checked = true;
            }


            int tutar = 0;
            foreach (DataGridViewRow item in dataGridView6.Rows)
            {
                tutar += Convert.ToInt32(item.Cells[1].Value);
            }

            textBox1.Text = tutar.ToString();
        }

       

        private void dataGridView6_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dataGridView6.Rows.Count == 0)
            {
                dolubtn.Checked = false;
            }


            int tutar = 0;
            foreach (DataGridViewRow item in dataGridView6.Rows)
            {
                tutar += Convert.ToInt32(item.Cells[1].Value);
            }

            textBox1.Text = tutar.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView6.SelectedRows.Count > 0)
            {
                dataGridView6.Rows.Remove(dataGridView6.SelectedRows[0]);
            }
            else
                MessageBox.Show("Bir Ürün Seçiniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

     
     
    }
    
}


