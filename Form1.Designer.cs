
namespace AracIslem
{
    partial class Form1
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
            this.txtMark = new System.Windows.Forms.TextBox();
            this.txtPlak = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblMarka = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblPlaka = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtTarih = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.lblNo = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMark
            // 
            this.txtMark.Location = new System.Drawing.Point(113, 27);
            this.txtMark.Name = "txtMark";
            this.txtMark.Size = new System.Drawing.Size(100, 20);
            this.txtMark.TabIndex = 0;
            // 
            // txtPlak
            // 
            this.txtPlak.Location = new System.Drawing.Point(113, 157);
            this.txtPlak.Name = "txtPlak";
            this.txtPlak.Size = new System.Drawing.Size(100, 20);
            this.txtPlak.TabIndex = 2;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(113, 69);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 3;
            this.txtModel.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Location = new System.Drawing.Point(34, 34);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(65, 13);
            this.lblMarka.TabIndex = 4;
            this.lblMarka.Text = "Araç Marka:";
            this.lblMarka.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(35, 76);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(64, 13);
            this.lblModel.TabIndex = 5;
            this.lblModel.Text = "Araç Model:";
            this.lblModel.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblPlaka
            // 
            this.lblPlaka.AutoSize = true;
            this.lblPlaka.Location = new System.Drawing.Point(61, 164);
            this.lblPlaka.Name = "lblPlaka";
            this.lblPlaka.Size = new System.Drawing.Size(37, 13);
            this.lblPlaka.TabIndex = 6;
            this.lblPlaka.Text = "Plaka:";
            this.lblPlaka.Click += new System.EventHandler(this.lblTel_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(79, 244);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(73, 32);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(2, 202);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(97, 13);
            this.lblDate.TabIndex = 11;
            this.lblDate.Text = "Trafiğe Çıkış Tarihi:";
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(113, 195);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Size = new System.Drawing.Size(109, 20);
            this.txtTarih.TabIndex = 12;
            this.txtTarih.ValueChanged += new System.EventHandler(this.txtTarih_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(262, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(510, 297);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(26, 301);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(73, 32);
            this.btnSil.TabIndex = 14;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(140, 301);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(73, 32);
            this.btnGüncelle.TabIndex = 15;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Location = new System.Drawing.Point(49, 120);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(49, 13);
            this.lblNo.TabIndex = 16;
            this.lblNo.Text = "Araç No:";
            this.lblNo.Click += new System.EventHandler(this.lblNo_Click);
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(113, 113);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(100, 20);
            this.txtNo.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(795, 357);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lblPlaka);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblMarka);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtPlak);
            this.Controls.Add(this.txtMark);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMark;
        private System.Windows.Forms.TextBox txtPlak;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblPlaka;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker txtTarih;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.TextBox txtNo;
    }
}

