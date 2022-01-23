
namespace Ödev_GP
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btntatlı = new System.Windows.Forms.Button();
            this.btnicecek = new System.Windows.Forms.Button();
            this.btnekstra = new System.Windows.Forms.Button();
            this.btnmenu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.urun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dolubtn = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.kredi = new System.Windows.Forms.RadioButton();
            this.nakit = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btntatlı);
            this.groupBox2.Controls.Add(this.btnicecek);
            this.groupBox2.Controls.Add(this.btnekstra);
            this.groupBox2.Controls.Add(this.btnmenu);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 264);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // btntatlı
            // 
            this.btntatlı.Location = new System.Drawing.Point(0, 207);
            this.btntatlı.Name = "btntatlı";
            this.btntatlı.Size = new System.Drawing.Size(150, 52);
            this.btntatlı.TabIndex = 4;
            this.btntatlı.Text = "Tatlılar";
            this.btntatlı.UseVisualStyleBackColor = true;
            this.btntatlı.Click += new System.EventHandler(this.btntatlı_Click);
            // 
            // btnicecek
            // 
            this.btnicecek.Location = new System.Drawing.Point(0, 147);
            this.btnicecek.Name = "btnicecek";
            this.btnicecek.Size = new System.Drawing.Size(150, 52);
            this.btnicecek.TabIndex = 2;
            this.btnicecek.Text = "İçecekler";
            this.btnicecek.UseVisualStyleBackColor = true;
            this.btnicecek.Click += new System.EventHandler(this.btnicecek_Click);
            // 
            // btnekstra
            // 
            this.btnekstra.Location = new System.Drawing.Point(0, 89);
            this.btnekstra.Name = "btnekstra";
            this.btnekstra.Size = new System.Drawing.Size(150, 52);
            this.btnekstra.TabIndex = 1;
            this.btnekstra.Text = "Ekstralar";
            this.btnekstra.UseVisualStyleBackColor = true;
            this.btnekstra.Click += new System.EventHandler(this.btnekstra_Click);
            // 
            // btnmenu
            // 
            this.btnmenu.Location = new System.Drawing.Point(0, 31);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(150, 52);
            this.btnmenu.TabIndex = 0;
            this.btnmenu.Text = "Menüler";
            this.btnmenu.UseVisualStyleBackColor = true;
            this.btnmenu.Click += new System.EventHandler(this.btnmenu_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urun,
            this.fiyat});
            this.dataGridView1.Location = new System.Drawing.Point(156, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(204, 259);
            this.dataGridView1.TabIndex = 1;
            // 
            // urun
            // 
            this.urun.HeaderText = "Ürün";
            this.urun.Name = "urun";
            // 
            // fiyat
            // 
            this.fiyat.HeaderText = "Fiyat";
            this.fiyat.Name = "fiyat";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(425, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 65);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(425, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 65);
            this.button2.TabIndex = 2;
            this.button2.Text = "Çıkar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AllowUserToDeleteRows = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dataGridView5.Location = new System.Drawing.Point(594, 0);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            this.dataGridView5.RowHeadersVisible = false;
            this.dataGridView5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView5.Size = new System.Drawing.Size(205, 264);
            this.dataGridView5.TabIndex = 1;
            this.dataGridView5.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView5_RowsAdded);
            this.dataGridView5.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView5_RowsRemoved);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Ürün";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Fiyat";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dolubtn
            // 
            this.dolubtn.AutoSize = true;
            this.dolubtn.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.dolubtn.Location = new System.Drawing.Point(445, 226);
            this.dolubtn.Name = "dolubtn";
            this.dolubtn.Size = new System.Drawing.Size(77, 17);
            this.dolubtn.TabIndex = 9;
            this.dolubtn.Text = "Masa Dolu";
            this.dolubtn.UseVisualStyleBackColor = true;
            
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Location = new System.Drawing.Point(25, 384);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 54);
            this.button3.TabIndex = 10;
            this.button3.Text = "Geri";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(673, 270);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(621, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tutar";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(673, 326);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 58);
            this.button4.TabIndex = 13;
            this.button4.Text = "Hesap Kapat";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // kredi
            // 
            this.kredi.AutoSize = true;
            this.kredi.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.kredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kredi.Location = new System.Drawing.Point(20, 19);
            this.kredi.Name = "kredi";
            this.kredi.Size = new System.Drawing.Size(99, 24);
            this.kredi.TabIndex = 14;
            this.kredi.TabStop = true;
            this.kredi.Text = "Kredi Kartı";
            this.kredi.UseVisualStyleBackColor = true;
            this.kredi.CheckedChanged += new System.EventHandler(this.kredi_CheckedChanged);
            // 
            // nakit
            // 
            this.nakit.AutoSize = true;
            this.nakit.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nakit.Location = new System.Drawing.Point(54, 49);
            this.nakit.Name = "nakit";
            this.nakit.Size = new System.Drawing.Size(63, 24);
            this.nakit.TabIndex = 14;
            this.nakit.TabStop = true;
            this.nakit.Text = "Nakit";
            this.nakit.UseVisualStyleBackColor = true;
            this.nakit.CheckedChanged += new System.EventHandler(this.nakit_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kredi);
            this.groupBox1.Controls.Add(this.nakit);
            this.groupBox1.Location = new System.Drawing.Point(388, 270);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dolubtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btntatlı;
        private System.Windows.Forms.Button btnicecek;
        private System.Windows.Forms.Button btnekstra;
        private System.Windows.Forms.Button btnmenu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.DataGridView dataGridView5;
        public System.Windows.Forms.CheckBox dolubtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RadioButton kredi;
        private System.Windows.Forms.RadioButton nakit;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}