namespace iNBC.Boundary.PendaftaranTransaksiUI
{
    partial class inputPemeriksaan
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
            this.components = new System.ComponentModel.Container();
            this.taskPane = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.titleHead = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBeautician = new System.Windows.Forms.ComboBox();
            this.txtKeluhan = new System.Windows.Forms.TextBox();
            this.btnKembali = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbRuang = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPilih = new System.Windows.Forms.Button();
            this.idTransaksi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.txtIDdtlPwt = new System.Windows.Forms.TextBox();
            this.txtRowdtlPWT = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtIDdtlPdk = new System.Windows.Forms.TextBox();
            this.txtRowdtlPDK = new System.Windows.Forms.TextBox();
            this.pilihPerawatan1 = new iNBC.Boundary.PendaftaranTransaksiUI.PilihPerawatan();
            this.pilihProduk1 = new iNBC.Boundary.PendaftaranTransaksiUI.PilihProduk();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // taskPane
            // 
            this.taskPane.BackColor = System.Drawing.Color.WhiteSmoke;
            this.taskPane.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.taskPane.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.taskPane.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.taskPane.Location = new System.Drawing.Point(-1, 85);
            this.taskPane.Name = "taskPane";
            this.taskPane.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.taskPane.Size = new System.Drawing.Size(201, 605);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.titleHead,
            this.taskPane});
            this.shapeContainer1.Size = new System.Drawing.Size(1021, 468);
            this.shapeContainer1.TabIndex = 10;
            this.shapeContainer1.TabStop = false;
            // 
            // titleHead
            // 
            this.titleHead.BackColor = System.Drawing.Color.WhiteSmoke;
            this.titleHead.BorderColor = System.Drawing.Color.Transparent;
            this.titleHead.FillColor = System.Drawing.Color.WhiteSmoke;
            this.titleHead.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.titleHead.Location = new System.Drawing.Point(199, 0);
            this.titleHead.Name = "titleHead";
            this.titleHead.Size = new System.Drawing.Size(822, 85);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 49);
            this.label1.TabIndex = 11;
            this.label1.Text = "Input Pemeriksaan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(251, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Beautician";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(251, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Keluhan";
            // 
            // cmbBeautician
            // 
            this.cmbBeautician.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBeautician.FormattingEnabled = true;
            this.cmbBeautician.Location = new System.Drawing.Point(254, 285);
            this.cmbBeautician.Name = "cmbBeautician";
            this.cmbBeautician.Size = new System.Drawing.Size(275, 24);
            this.cmbBeautician.TabIndex = 16;
            // 
            // txtKeluhan
            // 
            this.txtKeluhan.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeluhan.Location = new System.Drawing.Point(254, 118);
            this.txtKeluhan.MaxLength = 200;
            this.txtKeluhan.Multiline = true;
            this.txtKeluhan.Name = "txtKeluhan";
            this.txtKeluhan.Size = new System.Drawing.Size(275, 134);
            this.txtKeluhan.TabIndex = 17;
            // 
            // btnKembali
            // 
            this.btnKembali.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.btnKembali.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.btnKembali.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(71)))), ((int)(((byte)(138)))));
            this.btnKembali.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(71)))), ((int)(((byte)(138)))));
            this.btnKembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKembali.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKembali.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnKembali.Location = new System.Drawing.Point(-1, 401);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(201, 67);
            this.btnKembali.TabIndex = 18;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKembali.UseVisualStyleBackColor = false;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.Transparent;
            this.btnSimpan.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSimpan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(86)))), ((int)(((byte)(93)))));
            this.btnSimpan.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.ForeColor = System.Drawing.Color.Black;
            this.btnSimpan.Location = new System.Drawing.Point(890, 425);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(74, 28);
            this.btnSimpan.TabIndex = 19;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::iNBC.Properties.Resources.onlinelogomaker_111116_2229_5795;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // cmbRuang
            // 
            this.cmbRuang.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRuang.FormattingEnabled = true;
            this.cmbRuang.Location = new System.Drawing.Point(254, 340);
            this.cmbRuang.Name = "cmbRuang";
            this.cmbRuang.Size = new System.Drawing.Size(275, 24);
            this.cmbRuang.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(251, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Ruang";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(553, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(203, 130);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyUp_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(550, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Perawatan";
            // 
            // btnPilih
            // 
            this.btnPilih.BackColor = System.Drawing.Color.Transparent;
            this.btnPilih.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnPilih.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(86)))), ((int)(((byte)(93)))));
            this.btnPilih.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnPilih.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPilih.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPilih.ForeColor = System.Drawing.Color.Black;
            this.btnPilih.Location = new System.Drawing.Point(657, 254);
            this.btnPilih.Name = "btnPilih";
            this.btnPilih.Size = new System.Drawing.Size(99, 28);
            this.btnPilih.TabIndex = 28;
            this.btnPilih.Text = "Tambah";
            this.btnPilih.UseVisualStyleBackColor = false;
            this.btnPilih.Click += new System.EventHandler(this.btnPilih_Click);
            // 
            // idTransaksi
            // 
            this.idTransaksi.Location = new System.Drawing.Point(207, 4);
            this.idTransaksi.Name = "idTransaksi";
            this.idTransaksi.Size = new System.Drawing.Size(88, 20);
            this.idTransaksi.TabIndex = 29;
            this.idTransaksi.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(86)))), ((int)(((byte)(93)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(810, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 28);
            this.button1.TabIndex = 31;
            this.button1.Text = "Batal";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.Transparent;
            this.btnHapus.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnHapus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(86)))), ((int)(((byte)(93)))));
            this.btnHapus.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.ForeColor = System.Drawing.Color.Black;
            this.btnHapus.Location = new System.Drawing.Point(553, 254);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(98, 28);
            this.btnHapus.TabIndex = 33;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // txtIDdtlPwt
            // 
            this.txtIDdtlPwt.Location = new System.Drawing.Point(657, 65);
            this.txtIDdtlPwt.Name = "txtIDdtlPwt";
            this.txtIDdtlPwt.Size = new System.Drawing.Size(60, 20);
            this.txtIDdtlPwt.TabIndex = 34;
            this.txtIDdtlPwt.Visible = false;
            this.txtIDdtlPwt.TextChanged += new System.EventHandler(this.txtIDdtlPwt_TextChanged);
            // 
            // txtRowdtlPWT
            // 
            this.txtRowdtlPWT.Location = new System.Drawing.Point(657, 88);
            this.txtRowdtlPWT.Name = "txtRowdtlPWT";
            this.txtRowdtlPWT.Size = new System.Drawing.Size(60, 20);
            this.txtRowdtlPWT.TabIndex = 35;
            this.txtRowdtlPWT.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(788, 118);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(203, 130);
            this.dataGridView2.TabIndex = 36;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridView2_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(785, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Produk";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(86)))), ((int)(((byte)(93)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(788, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 28);
            this.button2.TabIndex = 39;
            this.button2.Text = "Hapus";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(86)))), ((int)(((byte)(93)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(892, 254);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 28);
            this.button3.TabIndex = 38;
            this.button3.Text = "Tambah";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtIDdtlPdk
            // 
            this.txtIDdtlPdk.Location = new System.Drawing.Point(732, 65);
            this.txtIDdtlPdk.Name = "txtIDdtlPdk";
            this.txtIDdtlPdk.Size = new System.Drawing.Size(60, 20);
            this.txtIDdtlPdk.TabIndex = 41;
            this.txtIDdtlPdk.Visible = false;
            // 
            // txtRowdtlPDK
            // 
            this.txtRowdtlPDK.Location = new System.Drawing.Point(732, 88);
            this.txtRowdtlPDK.Name = "txtRowdtlPDK";
            this.txtRowdtlPDK.Size = new System.Drawing.Size(60, 20);
            this.txtRowdtlPDK.TabIndex = 42;
            this.txtRowdtlPDK.Visible = false;
            // 
            // pilihPerawatan1
            // 
            this.pilihPerawatan1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pilihPerawatan1.Location = new System.Drawing.Point(554, 118);
            this.pilihPerawatan1.Name = "pilihPerawatan1";
            this.pilihPerawatan1.Size = new System.Drawing.Size(202, 217);
            this.pilihPerawatan1.TabIndex = 43;
            this.pilihPerawatan1.Load += new System.EventHandler(this.pilihPerawatan1_Load);
            // 
            // pilihProduk1
            // 
            this.pilihProduk1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pilihProduk1.Location = new System.Drawing.Point(789, 118);
            this.pilihProduk1.Name = "pilihProduk1";
            this.pilihProduk1.Size = new System.Drawing.Size(202, 217);
            this.pilihProduk1.TabIndex = 40;
            this.pilihProduk1.Visible = false;
            // 
            // inputPemeriksaan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1021, 468);
            this.Controls.Add(this.pilihPerawatan1);
            this.Controls.Add(this.idTransaksi);
            this.Controls.Add(this.pilihProduk1);
            this.Controls.Add(this.txtRowdtlPDK);
            this.Controls.Add(this.txtIDdtlPdk);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.txtRowdtlPWT);
            this.Controls.Add(this.txtIDdtlPwt);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPilih);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbRuang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.txtKeluhan);
            this.Controls.Add(this.cmbBeautician);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "inputPemeriksaan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PendaftaranTransaksi";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PendaftaranTransaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape taskPane;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape titleHead;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBeautician;
        private System.Windows.Forms.TextBox txtKeluhan;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cmbRuang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPilih;
        private System.Windows.Forms.TextBox idTransaksi;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.TextBox txtRowdtlPWT;
        private System.Windows.Forms.TextBox txtIDdtlPwt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private PilihProduk pilihProduk1;
        private System.Windows.Forms.TextBox txtIDdtlPdk;
        private System.Windows.Forms.TextBox txtRowdtlPDK;
        private PilihPerawatan pilihPerawatan1;
    }
}