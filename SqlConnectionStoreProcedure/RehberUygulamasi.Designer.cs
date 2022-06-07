
namespace SqlConnectionStoreProcedure
{
    partial class RehberUygulamasi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewKisi = new System.Windows.Forms.DataGridView();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelExeCuteNonQuery = new System.Windows.Forms.Label();
            this.labelExeCuteScalar = new System.Windows.Forms.Label();
            this.labelKisiSayisi = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKisi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxTel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxSoyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxAdi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KİŞİ BİLGİLERİ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADI";
            // 
            // textBoxAdi
            // 
            this.textBoxAdi.Location = new System.Drawing.Point(20, 47);
            this.textBoxAdi.Name = "textBoxAdi";
            this.textBoxAdi.Size = new System.Drawing.Size(166, 20);
            this.textBoxAdi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "SOYADI";
            // 
            // textBoxSoyad
            // 
            this.textBoxSoyad.Location = new System.Drawing.Point(20, 108);
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.Size = new System.Drawing.Size(166, 20);
            this.textBoxSoyad.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "TELEFON";
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(20, 171);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(166, 20);
            this.textBoxTel.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewKisi);
            this.groupBox2.Location = new System.Drawing.Point(250, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(538, 426);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dataGridViewKisi
            // 
            this.dataGridViewKisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKisi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewKisi.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewKisi.Name = "dataGridViewKisi";
            this.dataGridViewKisi.Size = new System.Drawing.Size(532, 407);
            this.dataGridViewKisi.TabIndex = 0;
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(12, 221);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(217, 58);
            this.buttonInsert.TabIndex = 2;
            this.buttonInsert.Text = "EKLE";
            this.buttonInsert.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(12, 285);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(217, 58);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "GÜNCELLE";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(12, 349);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(217, 58);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "SİL";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // labelExeCuteNonQuery
            // 
            this.labelExeCuteNonQuery.AutoSize = true;
            this.labelExeCuteNonQuery.Location = new System.Drawing.Point(250, 445);
            this.labelExeCuteNonQuery.Name = "labelExeCuteNonQuery";
            this.labelExeCuteNonQuery.Size = new System.Drawing.Size(101, 13);
            this.labelExeCuteNonQuery.TabIndex = 3;
            this.labelExeCuteNonQuery.Text = "ExeCuteNonQuery: ";
            // 
            // labelExeCuteScalar
            // 
            this.labelExeCuteScalar.AutoSize = true;
            this.labelExeCuteScalar.Location = new System.Drawing.Point(250, 468);
            this.labelExeCuteScalar.Name = "labelExeCuteScalar";
            this.labelExeCuteScalar.Size = new System.Drawing.Size(80, 13);
            this.labelExeCuteScalar.TabIndex = 3;
            this.labelExeCuteScalar.Text = "ExeCuteScalar:";
            // 
            // labelKisiSayisi
            // 
            this.labelKisiSayisi.AutoSize = true;
            this.labelKisiSayisi.Location = new System.Drawing.Point(17, 424);
            this.labelKisiSayisi.Name = "labelKisiSayisi";
            this.labelKisiSayisi.Size = new System.Drawing.Size(97, 13);
            this.labelKisiSayisi.TabIndex = 4;
            this.labelKisiSayisi.Text = "Toplam Kişi Sayısı: ";
            // 
            // RehberUygulamasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.labelKisiSayisi);
            this.Controls.Add(this.labelExeCuteScalar);
            this.Controls.Add(this.labelExeCuteNonQuery);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "RehberUygulamasi";
            this.Text = "RehberUygulamasi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewKisi;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelExeCuteNonQuery;
        private System.Windows.Forms.Label labelExeCuteScalar;
        private System.Windows.Forms.Label labelKisiSayisi;
    }
}