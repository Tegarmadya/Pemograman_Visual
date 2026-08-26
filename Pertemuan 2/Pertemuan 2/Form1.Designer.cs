namespace Pertemuan_2
{
    partial class lblProfile_mahasiswa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNama = new Label();
            textBox1 = new TextBox();
            lblNIM = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            lblKOM = new Label();
            btnTampilkan = new Button();
            btnHapus = new Button();
            btnKeluar = new Button();
            SuspendLayout();
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Location = new Point(65, 95);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(52, 19);
            lblNama.TabIndex = 0;
            lblNama.Text = "Nama :";
            lblNama.TextAlign = ContentAlignment.MiddleRight;
            lblNama.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(127, 92);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(266, 26);
            textBox1.TabIndex = 1;
            // 
            // lblNIM
            // 
            lblNIM.AutoSize = true;
            lblNIM.Location = new Point(65, 151);
            lblNIM.Name = "lblNIM";
            lblNIM.Size = new Size(43, 19);
            lblNIM.TabIndex = 2;
            lblNIM.Text = "NIM :";
            lblNIM.Click += label1_Click_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(127, 144);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(266, 26);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(127, 209);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(265, 26);
            textBox3.TabIndex = 4;
            // 
            // lblKOM
            // 
            lblKOM.AutoSize = true;
            lblKOM.Location = new Point(65, 216);
            lblKOM.Name = "lblKOM";
            lblKOM.Size = new Size(47, 19);
            lblKOM.TabIndex = 5;
            lblKOM.Text = "KOM :";
            // 
            // btnTampilkan
            // 
            btnTampilkan.Location = new Point(126, 273);
            btnTampilkan.Name = "btnTampilkan";
            btnTampilkan.Size = new Size(126, 44);
            btnTampilkan.TabIndex = 6;
            btnTampilkan.Text = "Tampilkan";
            btnTampilkan.UseVisualStyleBackColor = true;
            btnTampilkan.Click += btnTampilkan_Click;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(266, 273);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(126, 44);
            btnHapus.TabIndex = 7;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += button1_Click;
            // 
            // btnKeluar
            // 
            btnKeluar.Location = new Point(198, 334);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(125, 44);
            btnKeluar.TabIndex = 8;
            btnKeluar.Text = "Keluar";
            btnKeluar.UseVisualStyleBackColor = true;
            btnKeluar.Click += button1_Click_1;
            // 
            // lblProfile_mahasiswa
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(658, 401);
            Controls.Add(btnKeluar);
            Controls.Add(btnHapus);
            Controls.Add(btnTampilkan);
            Controls.Add(lblKOM);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(lblNIM);
            Controls.Add(textBox1);
            Controls.Add(lblNama);
            Name = "lblProfile_mahasiswa";
            Text = "Profile Mahasiswa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNama;
        private TextBox textBox1;
        private Label lblNIM;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label lblKOM;
        private Button btnTampilkan;
        private Button btnHapus;
        private Button btnKeluar;
    }
}
