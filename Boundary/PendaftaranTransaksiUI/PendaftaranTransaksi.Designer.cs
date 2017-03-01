namespace iNBC.Boundary.PendaftaranTransaksiUI
{
    partial class PendaftaranTransaksi
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
            this.cmbDokter = new System.Windows.Forms.ComboBox();
            this.txtKeluhan = new System.Windows.Forms.TextBox();
            this.btnKembali = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.rightProvider = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtIDcs = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.shapeContainer1.Size = new System.Drawing.Size(731, 468);
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
            this.titleHead.Size = new System.Drawing.Size(549, 85);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 49);
            this.label1.TabIndex = 11;
            this.label1.Text = "Pendaftaran Transaksi";
            // 
            // txtIDCustomer
            // 
            this.txtIDCustomer.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDCustomer.Location = new System.Drawing.Point(214, 115);
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
            this.label2.Location = new System.Drawing.Point(211, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "ID Customer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(211, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Dokter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(646, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Keluhan";
            this.label4.Visible = false;
            // 
            // cmbDokter
            // 
            this.cmbDokter.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDokter.FormattingEnabled = true;
            this.cmbDokter.Location = new System.Drawing.Point(214, 169);
            this.cmbDokter.Name = "cmbDokter";
            this.cmbDokter.Size = new System.Drawing.Size(275, 24);
            this.cmbDokter.TabIndex = 16;
            // 
            // txtKeluhan
            // 
            this.txtKeluhan.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeluhan.Location = new System.Drawing.Point(649, 153);
            this.txtKeluhan.Multiline = true;
            this.txtKeluhan.Name = "txtKeluhan";
            this.txtKeluhan.Size = new System.Drawing.Size(275, 134);
            this.txtKeluhan.TabIndex = 17;
            this.txtKeluhan.Visible = false;
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
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(86)))), ((int)(((byte)(93)))));
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(335, 199);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(74, 28);
            this.btnReset.TabIndex = 21;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
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
            this.btnSimpan.Location = new System.Drawing.Point(415, 199);
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
            this.button5.Location = new System.Drawing.Point(495, 115);
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
            this.rightProvider.Location = new System.Drawing.Point(495, 115);
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
            // txtIDcs
            // 
            this.txtIDcs.Location = new System.Drawing.Point(199, 1);
            this.txtIDcs.Name = "txtIDcs";
            this.txtIDcs.Size = new System.Drawing.Size(100, 20);
            this.txtIDcs.TabIndex = 24;
            this.txtIDcs.Visible = false;
            // 
            // PendaftaranTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(731, 468);
            this.Controls.Add(this.txtIDcs);
            this.Controls.Add(this.rightProvider);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.txtKeluhan);
            this.Controls.Add(this.cmbDokter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "PendaftaranTransaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PendaftaranTransaksi";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PendaftaranTransaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.ComboBox cmbDokter;
        private System.Windows.Forms.TextBox txtKeluhan;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox rightProvider;
        private System.Windows.Forms.TextBox txtIDcs;
    }
}