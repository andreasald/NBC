namespace iNBC.Boundary.PendaftaranTransaksiUI
{
    partial class PendaftaranNK
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
            this.txtIDCustomer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBeautician = new System.Windows.Forms.ComboBox();
            this.txtKeluhan = new System.Windows.Forms.TextBox();
            this.btnKembali = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.rightProvider = new System.Windows.Forms.PictureBox();
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
            this.txtIDcs = new System.Windows.Forms.TextBox();
            this.perawatan1 = new iNBC.Boundary.PendaftaranTransaksiUI.Perawatan();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(736, 49);
            this.label1.TabIndex = 11;
            this.label1.Text = "Pendaftaran Transaksi Non Konsultasi";
            // 
            // txtIDCustomer
            // 
            this.txtIDCustomer.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDCustomer.Location = new System.Drawing.Point(254, 115);
            this.txtIDCustomer.MaxLength = 255;
            this.txtIDCustomer.Multiline = true;
            this.txtIDCustomer.Name = "txtIDCustomer";
            this.txtIDCustomer.Size = new System.Drawing.Size(275, 28);
            this.txtIDCustomer.TabIndex = 12;
            this.txtIDCustomer.TextChanged += new System.EventHandler(this.txtIDCustomer_TextChanged);
            this.txtIDCustomer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDCustomer_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(251, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "ID Customer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(251, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Beautician";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(251, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Keluhan";
            // 
            // cmbBeautician
            // 
            this.cmbBeautician.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBeautician.FormattingEnabled = true;
            this.cmbBeautician.Location = new System.Drawing.Point(254, 169);
            this.cmbBeautician.Name = "cmbBeautician";
            this.cmbBeautician.Size = new System.Drawing.Size(275, 24);
            this.cmbBeautician.TabIndex = 16;
            // 
            // txtKeluhan
            // 
            this.txtKeluhan.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeluhan.Location = new System.Drawing.Point(254, 277);
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
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(86)))), ((int)(((byte)(93)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(535, 115);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(99, 28);
            this.button5.TabIndex = 22;
            this.button5.Text = "Verifikasi";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // rightProvider
            // 
            this.rightProvider.Image = global::iNBC.Properties.Resources.success__3_;
            this.rightProvider.Location = new System.Drawing.Point(535, 118);
            this.rightProvider.Name = "rightProvider";
            this.rightProvider.Size = new System.Drawing.Size(25, 28);
            this.rightProvider.TabIndex = 23;
            this.rightProvider.TabStop = false;
            this.rightProvider.Visible = false;
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
            this.cmbRuang.Location = new System.Drawing.Point(254, 224);
            this.cmbRuang.Name = "cmbRuang";
            this.cmbRuang.Size = new System.Drawing.Size(275, 24);
            this.cmbRuang.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(251, 208);
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
            this.dataGridView1.Location = new System.Drawing.Point(658, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(306, 130);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyUp_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(655, 99);
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
            this.btnPilih.Location = new System.Drawing.Point(865, 254);
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
            this.idTransaksi.Size = new System.Drawing.Size(19, 20);
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
            this.btnHapus.Location = new System.Drawing.Point(760, 254);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(99, 28);
            this.btnHapus.TabIndex = 33;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // txtIDdtlPwt
            // 
            this.txtIDdtlPwt.Location = new System.Drawing.Point(774, 69);
            this.txtIDdtlPwt.Name = "txtIDdtlPwt";
            this.txtIDdtlPwt.Size = new System.Drawing.Size(60, 20);
            this.txtIDdtlPwt.TabIndex = 34;
            this.txtIDdtlPwt.Visible = false;
            this.txtIDdtlPwt.TextChanged += new System.EventHandler(this.txtIDdtlPwt_TextChanged);
            // 
            // txtRowdtlPWT
            // 
            this.txtRowdtlPWT.Location = new System.Drawing.Point(774, 92);
            this.txtRowdtlPWT.Name = "txtRowdtlPWT";
            this.txtRowdtlPWT.Size = new System.Drawing.Size(60, 20);
            this.txtRowdtlPWT.TabIndex = 35;
            this.txtRowdtlPWT.Visible = false;
            // 
            // txtIDcs
            // 
            this.txtIDcs.Location = new System.Drawing.Point(233, 4);
            this.txtIDcs.Name = "txtIDcs";
            this.txtIDcs.Size = new System.Drawing.Size(100, 20);
            this.txtIDcs.TabIndex = 36;
            this.txtIDcs.Visible = false;
            // 
            // perawatan1
            // 
            this.perawatan1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.perawatan1.Location = new System.Drawing.Point(456, 169);
            this.perawatan1.Name = "perawatan1";
            this.perawatan1.Size = new System.Drawing.Size(206, 220);
            this.perawatan1.TabIndex = 30;
            // 
            // PendaftaranNK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1021, 468);
            this.Controls.Add(this.txtIDcs);
            this.Controls.Add(this.perawatan1);
            this.Controls.Add(this.txtRowdtlPWT);
            this.Controls.Add(this.txtIDdtlPwt);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.idTransaksi);
            this.Controls.Add(this.btnPilih);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbRuang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rightProvider);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.txtKeluhan);
            this.Controls.Add(this.cmbBeautician);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "PendaftaranNK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PendaftaranTransaksi";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PendaftaranTransaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape taskPane;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape titleHead;
        private System.Windows.Forms.TextBox txtIDCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBeautician;
        private System.Windows.Forms.TextBox txtKeluhan;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox rightProvider;
        private System.Windows.Forms.ComboBox cmbRuang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPilih;
        private System.Windows.Forms.TextBox idTransaksi;
        private Perawatan perawatan1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.TextBox txtRowdtlPWT;
        private System.Windows.Forms.TextBox txtIDdtlPwt;
        private System.Windows.Forms.TextBox txtIDcs;
    }
}