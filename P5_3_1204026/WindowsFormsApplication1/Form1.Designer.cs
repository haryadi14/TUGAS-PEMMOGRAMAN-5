namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTa = new System.Windows.Forms.TextBox();
            this.rbPr = new System.Windows.Forms.RadioButton();
            this.rbLk = new System.Windows.Forms.RadioButton();
            this.cbProgramStudi = new System.Windows.Forms.ComboBox();
            this.tbAlamat = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.userControl12 = new NumTb.UserControl1();
            this.numTb1 = new WindowsFormsControlLibrary1.NumTb();
            this.numTb2 = new WindowsFormsControlLibrary1.NumTb();
            this.epWarn = new System.Windows.Forms.ErrorProvider(this.components);
            this.Kp = new System.Windows.Forms.GroupBox();
            this.rbKrk6 = new System.Windows.Forms.RadioButton();
            this.rbKrk7 = new System.Windows.Forms.RadioButton();
            this.rbKrk8 = new System.Windows.Forms.RadioButton();
            this.matkul = new System.Windows.Forms.GroupBox();
            this.cbPem4 = new System.Windows.Forms.CheckBox();
            this.cbMtk = new System.Windows.Forms.CheckBox();
            this.cbPem1 = new System.Windows.Forms.CheckBox();
            this.cbPem2 = new System.Windows.Forms.CheckBox();
            this.cbPem3 = new System.Windows.Forms.CheckBox();
            this.cbPem5 = new System.Windows.Forms.CheckBox();
            this.cbPem6 = new System.Windows.Forms.CheckBox();
            this.cbPem7 = new System.Windows.Forms.CheckBox();
            this.cbMrp = new System.Windows.Forms.CheckBox();
            this.cbSo = new System.Windows.Forms.CheckBox();
            this.cbJk = new System.Windows.Forms.CheckBox();
            this.cbPl = new System.Windows.Forms.CheckBox();
            this.btSimpan = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.epWarn)).BeginInit();
            this.Kp.SuspendLayout();
            this.matkul.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "PILIHAN MATA KULIAH MAHASISWA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "NIM :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "NAMA :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "JENIS KELAMIN  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "ALAMAT  :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(591, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "SEMESTER  :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(591, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "TAHUN AKADEMIK  :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(591, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "PROGRAM STUDI  :";
            // 
            // tbTa
            // 
            this.tbTa.Location = new System.Drawing.Point(779, 236);
            this.tbTa.Name = "tbTa";
            this.tbTa.Size = new System.Drawing.Size(159, 26);
            this.tbTa.TabIndex = 8;
            this.tbTa.Leave += new System.EventHandler(this.tbTa_Leave);
            // 
            // rbPr
            // 
            this.rbPr.AutoSize = true;
            this.rbPr.Location = new System.Drawing.Point(383, 321);
            this.rbPr.Name = "rbPr";
            this.rbPr.Size = new System.Drawing.Size(135, 24);
            this.rbPr.TabIndex = 9;
            this.rbPr.TabStop = true;
            this.rbPr.Text = "PEREMPUAN";
            this.rbPr.UseVisualStyleBackColor = true;
            // 
            // rbLk
            // 
            this.rbLk.AutoSize = true;
            this.rbLk.Location = new System.Drawing.Point(209, 321);
            this.rbLk.Name = "rbLk";
            this.rbLk.Size = new System.Drawing.Size(117, 24);
            this.rbLk.TabIndex = 10;
            this.rbLk.TabStop = true;
            this.rbLk.Text = "LAKI - LAKI";
            this.rbLk.UseVisualStyleBackColor = true;
            // 
            // cbProgramStudi
            // 
            this.cbProgramStudi.DisplayMember = "Teknik Inforrmatika";
            this.cbProgramStudi.FormattingEnabled = true;
            this.cbProgramStudi.Items.AddRange(new object[] {
            "Teknik Informatika",
            "Logistik Bisnis",
            "Akuntansi"});
            this.cbProgramStudi.Location = new System.Drawing.Point(779, 157);
            this.cbProgramStudi.Name = "cbProgramStudi";
            this.cbProgramStudi.Size = new System.Drawing.Size(186, 28);
            this.cbProgramStudi.TabIndex = 11;
            this.cbProgramStudi.Text = "Pilih Program Studi";
            this.cbProgramStudi.Leave += new System.EventHandler(this.cbProgramStudi_Leave);
            // 
            // tbAlamat
            // 
            this.tbAlamat.Location = new System.Drawing.Point(153, 399);
            this.tbAlamat.Name = "tbAlamat";
            this.tbAlamat.Size = new System.Drawing.Size(239, 26);
            this.tbAlamat.TabIndex = 12;
            this.tbAlamat.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(595, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 34);
            this.button2.TabIndex = 14;
            this.button2.Text = "PILIH MATA KULIAH";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // userControl12
            // 
            this.userControl12.Location = new System.Drawing.Point(153, 239);
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(100, 26);
            this.userControl12.TabIndex = 16;
            // 
            // numTb1
            // 
            this.numTb1.Location = new System.Drawing.Point(153, 162);
            this.numTb1.Name = "numTb1";
            this.numTb1.Size = new System.Drawing.Size(100, 26);
            this.numTb1.TabIndex = 17;
            // 
            // numTb2
            // 
            this.numTb2.Location = new System.Drawing.Point(779, 315);
            this.numTb2.Name = "numTb2";
            this.numTb2.Size = new System.Drawing.Size(100, 26);
            this.numTb2.TabIndex = 18;
            // 
            // epWarn
            // 
            this.epWarn.ContainerControl = this;
            this.epWarn.Icon = ((System.Drawing.Icon)(resources.GetObject("epWarn.Icon")));
            // 
            // Kp
            // 
            this.Kp.Controls.Add(this.rbKrk8);
            this.Kp.Controls.Add(this.rbKrk6);
            this.Kp.Controls.Add(this.rbKrk7);
            this.Kp.Location = new System.Drawing.Point(12, 565);
            this.Kp.Name = "Kp";
            this.Kp.Size = new System.Drawing.Size(257, 242);
            this.Kp.TabIndex = 19;
            this.Kp.TabStop = false;
            this.Kp.Text = "Kurikulum Pilihan";
            // 
            // rbKrk6
            // 
            this.rbKrk6.AutoSize = true;
            this.rbKrk6.Location = new System.Drawing.Point(9, 38);
            this.rbKrk6.Name = "rbKrk6";
            this.rbKrk6.Size = new System.Drawing.Size(143, 24);
            this.rbKrk6.TabIndex = 20;
            this.rbKrk6.TabStop = true;
            this.rbKrk6.Text = "Kurikulum 2006";
            this.rbKrk6.UseVisualStyleBackColor = true;
            this.rbKrk6.CheckedChanged += new System.EventHandler(this.rbKrk6_CheckedChanged);
            // 
            // rbKrk7
            // 
            this.rbKrk7.AutoSize = true;
            this.rbKrk7.Location = new System.Drawing.Point(9, 87);
            this.rbKrk7.Name = "rbKrk7";
            this.rbKrk7.Size = new System.Drawing.Size(143, 24);
            this.rbKrk7.TabIndex = 21;
            this.rbKrk7.TabStop = true;
            this.rbKrk7.Text = "Kurikulum 2010";
            this.rbKrk7.UseVisualStyleBackColor = true;
            // 
            // rbKrk8
            // 
            this.rbKrk8.AutoSize = true;
            this.rbKrk8.Location = new System.Drawing.Point(9, 135);
            this.rbKrk8.Name = "rbKrk8";
            this.rbKrk8.Size = new System.Drawing.Size(143, 24);
            this.rbKrk8.TabIndex = 22;
            this.rbKrk8.TabStop = true;
            this.rbKrk8.Text = "Kurikulum 2014";
            this.rbKrk8.UseVisualStyleBackColor = true;
            // 
            // matkul
            // 
            this.matkul.Controls.Add(this.cbPl);
            this.matkul.Controls.Add(this.cbJk);
            this.matkul.Controls.Add(this.cbSo);
            this.matkul.Controls.Add(this.cbMrp);
            this.matkul.Controls.Add(this.cbPem7);
            this.matkul.Controls.Add(this.cbPem6);
            this.matkul.Controls.Add(this.cbPem5);
            this.matkul.Controls.Add(this.cbPem4);
            this.matkul.Controls.Add(this.cbMtk);
            this.matkul.Controls.Add(this.cbPem1);
            this.matkul.Controls.Add(this.cbPem2);
            this.matkul.Controls.Add(this.cbPem3);
            this.matkul.Location = new System.Drawing.Point(413, 565);
            this.matkul.Name = "matkul";
            this.matkul.Size = new System.Drawing.Size(647, 265);
            this.matkul.TabIndex = 23;
            this.matkul.TabStop = false;
            this.matkul.Text = "Mata Kuliah Pilihan";
            // 
            // cbPem4
            // 
            this.cbPem4.AutoSize = true;
            this.cbPem4.Location = new System.Drawing.Point(162, 49);
            this.cbPem4.Name = "cbPem4";
            this.cbPem4.Size = new System.Drawing.Size(156, 24);
            this.cbPem4.TabIndex = 23;
            this.cbPem4.Text = "Pemmograman 4";
            this.cbPem4.UseVisualStyleBackColor = true;
            // 
            // cbMtk
            // 
            this.cbMtk.AutoSize = true;
            this.cbMtk.Location = new System.Drawing.Point(6, 49);
            this.cbMtk.Name = "cbMtk";
            this.cbMtk.Size = new System.Drawing.Size(118, 24);
            this.cbMtk.TabIndex = 24;
            this.cbMtk.Text = "Matematika";
            this.cbMtk.UseVisualStyleBackColor = true;
            // 
            // cbPem1
            // 
            this.cbPem1.AutoSize = true;
            this.cbPem1.Location = new System.Drawing.Point(6, 88);
            this.cbPem1.Name = "cbPem1";
            this.cbPem1.Size = new System.Drawing.Size(156, 24);
            this.cbPem1.TabIndex = 25;
            this.cbPem1.Text = "Pemmograman 1";
            this.cbPem1.UseVisualStyleBackColor = true;
            // 
            // cbPem2
            // 
            this.cbPem2.AutoSize = true;
            this.cbPem2.Location = new System.Drawing.Point(6, 135);
            this.cbPem2.Name = "cbPem2";
            this.cbPem2.Size = new System.Drawing.Size(156, 24);
            this.cbPem2.TabIndex = 26;
            this.cbPem2.Text = "Pemmograman 2";
            this.cbPem2.UseVisualStyleBackColor = true;
            // 
            // cbPem3
            // 
            this.cbPem3.AutoSize = true;
            this.cbPem3.Location = new System.Drawing.Point(6, 184);
            this.cbPem3.Name = "cbPem3";
            this.cbPem3.Size = new System.Drawing.Size(156, 24);
            this.cbPem3.TabIndex = 27;
            this.cbPem3.Text = "Pemmograman 3";
            this.cbPem3.UseVisualStyleBackColor = true;
            // 
            // cbPem5
            // 
            this.cbPem5.AutoSize = true;
            this.cbPem5.Location = new System.Drawing.Point(162, 88);
            this.cbPem5.Name = "cbPem5";
            this.cbPem5.Size = new System.Drawing.Size(156, 24);
            this.cbPem5.TabIndex = 28;
            this.cbPem5.Text = "Pemmograman 5";
            this.cbPem5.UseVisualStyleBackColor = true;
            // 
            // cbPem6
            // 
            this.cbPem6.AutoSize = true;
            this.cbPem6.Location = new System.Drawing.Point(162, 136);
            this.cbPem6.Name = "cbPem6";
            this.cbPem6.Size = new System.Drawing.Size(156, 24);
            this.cbPem6.TabIndex = 29;
            this.cbPem6.Text = "Pemmograman 6";
            this.cbPem6.UseVisualStyleBackColor = true;
            // 
            // cbPem7
            // 
            this.cbPem7.AutoSize = true;
            this.cbPem7.Location = new System.Drawing.Point(162, 184);
            this.cbPem7.Name = "cbPem7";
            this.cbPem7.Size = new System.Drawing.Size(156, 24);
            this.cbPem7.TabIndex = 30;
            this.cbPem7.Text = "Pemmograman 7";
            this.cbPem7.UseVisualStyleBackColor = true;
            // 
            // cbMrp
            // 
            this.cbMrp.AutoSize = true;
            this.cbMrp.Location = new System.Drawing.Point(318, 184);
            this.cbMrp.Name = "cbMrp";
            this.cbMrp.Size = new System.Drawing.Size(217, 24);
            this.cbMrp.TabIndex = 31;
            this.cbMrp.Text = "Manajemen Rantai Pasok";
            this.cbMrp.UseVisualStyleBackColor = true;
            // 
            // cbSo
            // 
            this.cbSo.AutoSize = true;
            this.cbSo.Location = new System.Drawing.Point(318, 136);
            this.cbSo.Name = "cbSo";
            this.cbSo.Size = new System.Drawing.Size(143, 24);
            this.cbSo.TabIndex = 32;
            this.cbSo.Text = "Sistem Operasi";
            this.cbSo.UseVisualStyleBackColor = true;
            // 
            // cbJk
            // 
            this.cbJk.AutoSize = true;
            this.cbJk.Location = new System.Drawing.Point(318, 97);
            this.cbJk.Name = "cbJk";
            this.cbJk.Size = new System.Drawing.Size(169, 24);
            this.cbJk.TabIndex = 33;
            this.cbJk.Text = "Jaringan Komputer";
            this.cbJk.UseVisualStyleBackColor = true;
            // 
            // cbPl
            // 
            this.cbPl.AutoSize = true;
            this.cbPl.Location = new System.Drawing.Point(318, 49);
            this.cbPl.Name = "cbPl";
            this.cbPl.Size = new System.Drawing.Size(167, 24);
            this.cbPl.TabIndex = 34;
            this.cbPl.Text = "Pengantar Logistik";
            this.cbPl.UseVisualStyleBackColor = true;
            // 
            // btSimpan
            // 
            this.btSimpan.Location = new System.Drawing.Point(542, 851);
            this.btSimpan.Name = "btSimpan";
            this.btSimpan.Size = new System.Drawing.Size(127, 31);
            this.btSimpan.TabIndex = 23;
            this.btSimpan.Text = "simpan";
            this.btSimpan.UseVisualStyleBackColor = true;
            this.btSimpan.Click += new System.EventHandler(this.btSimpan_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(371, 850);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 32);
            this.button3.TabIndex = 25;
            this.button3.Text = "Batal";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 464);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btSimpan);
            this.Controls.Add(this.matkul);
            this.Controls.Add(this.Kp);
            this.Controls.Add(this.numTb2);
            this.Controls.Add(this.numTb1);
            this.Controls.Add(this.userControl12);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbAlamat);
            this.Controls.Add(this.cbProgramStudi);
            this.Controls.Add(this.rbLk);
            this.Controls.Add(this.rbPr);
            this.Controls.Add(this.tbTa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epWarn)).EndInit();
            this.Kp.ResumeLayout(false);
            this.Kp.PerformLayout();
            this.matkul.ResumeLayout(false);
            this.matkul.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbTa;
        private System.Windows.Forms.RadioButton rbPr;
        private System.Windows.Forms.RadioButton rbLk;
        private System.Windows.Forms.ComboBox cbProgramStudi;
        private System.Windows.Forms.TextBox tbAlamat;
        private System.Windows.Forms.Button button2;
        private NumTb.UserControl1 userControl12;
        private WindowsFormsControlLibrary1.NumTb numTb1;
        private WindowsFormsControlLibrary1.NumTb numTb2;
        private System.Windows.Forms.ErrorProvider epWarn;
        private System.Windows.Forms.GroupBox Kp;
        private System.Windows.Forms.GroupBox matkul;
        private System.Windows.Forms.CheckBox cbPl;
        private System.Windows.Forms.CheckBox cbJk;
        private System.Windows.Forms.CheckBox cbSo;
        private System.Windows.Forms.CheckBox cbMrp;
        private System.Windows.Forms.CheckBox cbPem7;
        private System.Windows.Forms.CheckBox cbPem6;
        private System.Windows.Forms.CheckBox cbPem5;
        private System.Windows.Forms.CheckBox cbPem4;
        private System.Windows.Forms.CheckBox cbMtk;
        private System.Windows.Forms.CheckBox cbPem1;
        private System.Windows.Forms.CheckBox cbPem2;
        private System.Windows.Forms.CheckBox cbPem3;
        private System.Windows.Forms.RadioButton rbKrk8;
        private System.Windows.Forms.RadioButton rbKrk6;
        private System.Windows.Forms.RadioButton rbKrk7;
        private System.Windows.Forms.Button btSimpan;
        private System.Windows.Forms.Button button3;
    }
}

