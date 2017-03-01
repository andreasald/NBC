namespace iNBC.Boundary.PendaftaranTransaksiUI
{
    partial class availablePromo
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
            this.btnKembali = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.idTransaksi = new System.Windows.Forms.TextBox();
            this.txtIDtsc = new System.Windows.Forms.TextBox();
            this.txtRowTSC = new System.Windows.Forms.TextBox();
            this.txtIDdtlPdk = new System.Windows.Forms.TextBox();
            this.txtRowdtlPDK = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.shapeContainer1.Size = new System.Drawing.Size(635, 346);
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
            this.label1.Size = new System.Drawing.Size(319, 49);
            this.label1.TabIndex = 11;
            this.label1.Text = "Promo Tersedia";
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
            this.btnKembali.Location = new System.Drawing.Point(-1, 275);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(201, 67);
            this.btnKembali.TabIndex = 18;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKembali.UseVisualStyleBackColor = false;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
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
            // idTransaksi
            // 
            this.idTransaksi.Location = new System.Drawing.Point(207, 4);
            this.idTransaksi.Name = "idTransaksi";
            this.idTransaksi.Size = new System.Drawing.Size(88, 20);
            this.idTransaksi.TabIndex = 29;
            this.idTransaksi.Visible = false;
            // 
            // txtIDtsc
            // 
            this.txtIDtsc.Location = new System.Drawing.Point(9, 252);
            this.txtIDtsc.Name = "txtIDtsc";
            this.txtIDtsc.Size = new System.Drawing.Size(60, 20);
            this.txtIDtsc.TabIndex = 34;
            this.txtIDtsc.Visible = false;
            this.txtIDtsc.TextChanged += new System.EventHandler(this.txtIDdtlPwt_TextChanged);
            // 
            // txtRowTSC
            // 
            this.txtRowTSC.Location = new System.Drawing.Point(9, 275);
            this.txtRowTSC.Name = "txtRowTSC";
            this.txtRowTSC.Size = new System.Drawing.Size(60, 20);
            this.txtRowTSC.TabIndex = 35;
            this.txtRowTSC.Visible = false;
            // 
            // txtIDdtlPdk
            // 
            this.txtIDdtlPdk.Location = new System.Drawing.Point(84, 252);
            this.txtIDdtlPdk.Name = "txtIDdtlPdk";
            this.txtIDdtlPdk.Size = new System.Drawing.Size(60, 20);
            this.txtIDdtlPdk.TabIndex = 41;
            this.txtIDdtlPdk.Visible = false;
            // 
            // txtRowdtlPDK
            // 
            this.txtRowdtlPDK.Location = new System.Drawing.Point(84, 275);
            this.txtRowdtlPDK.Name = "txtRowdtlPDK";
            this.txtRowdtlPDK.Size = new System.Drawing.Size(60, 20);
            this.txtRowdtlPDK.TabIndex = 42;
            this.txtRowdtlPDK.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(223, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(393, 196);
            this.dataGridView1.TabIndex = 43;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyUp);
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
            this.button1.Location = new System.Drawing.Point(542, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 28);
            this.button1.TabIndex = 45;
            this.button1.Text = "Pilih";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // availablePromo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(635, 346);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.idTransaksi);
            this.Controls.Add(this.txtRowdtlPDK);
            this.Controls.Add(this.txtIDdtlPdk);
            this.Controls.Add(this.txtRowTSC);
            this.Controls.Add(this.txtIDtsc);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "availablePromo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PendaftaranTransaksi";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PendaftaranTransaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox idTransaksi;
        private System.Windows.Forms.TextBox txtRowTSC;
        private System.Windows.Forms.TextBox txtIDdtlPdk;
        private System.Windows.Forms.TextBox txtRowdtlPDK;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txtIDtsc;
    }
}