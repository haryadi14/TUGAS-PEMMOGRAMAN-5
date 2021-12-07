using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((rbLk.Checked == true || rbPr.Checked == true) && numTb2.Text != "" && numTb1.Text != "" && tbAlamat.Text != "" && cbProgramStudi.Text != "" && tbTa.Text != "" && userControl12.Text != "")
            {
                if (rbKrk6.Checked == true)
                {
                    matkul.Enabled = false;
                    matkul.Enabled = true;
                    cbPl.Enabled = false;
                    cbMrp.Enabled = false;
                }
                else if (rbKrk7.Checked == true)
                {
                    matkul.Enabled = false;
                    matkul.Enabled = true;
                    cbPl.Enabled = false;
                    cbMtk.Enabled = false;
                }

                else if (rbKrk8.Checked == true)
                {
                    matkul.Enabled = false;
                    matkul.Enabled = true;
                    cbMtk.Enabled = false;
                    cbMrp.Enabled = false;
                }
            }
            Size = new Size(794, 557);
        }



        private void userControl11_TextChanged(object sender, EventArgs e)
        {

        }

        private void userControl14_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbProgramStudi_Leave(object sender, EventArgs e)
        {

        }

        private void tbTa_Leave(object sender, EventArgs e)
        {
            Regex regex = new Regex("^.*/.*$", RegexOptions.IgnoreCase);
            if (regex.IsMatch(tbTa.Text))
            {
                epWarn.Clear();
            }
            else
            {
                epWarn.SetError(tbTa, "Regex Tidak Sesuai");
            }

        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbKrk6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btSimpan_Click(object sender, EventArgs e)
        {
            string kelas = " ";
            if (cbMtk.Checked) { kelas += cbMtk.Text; }
            if (cbPem1.Checked) { kelas += cbPem1.Text; }
            if (cbPem2.Checked) { kelas += cbPem2.Text; }
            if (cbPem3.Checked) { kelas += cbPem3.Text; }
            if (cbPem4.Checked) { kelas += cbPem4.Text; }
            if (cbPem5.Checked) { kelas += cbPem5.Text; }
            if (cbPem6.Checked) { kelas += cbPem6.Text; }
            if (cbPem7.Checked) { kelas += cbPem7.Text; }
            if (cbPl.Checked) { kelas += cbPl.Text; }
            if (cbJk.Checked) { kelas += cbJk.Text; }
            if (cbMrp.Checked) { kelas += cbMrp.Text; }
            if (cbSo.Checked) { kelas += cbSo.Text; }
            string jk = rbLk.Checked == true ? rbLk.Text : rbPr.Text;
            string kuri = "";
            if (rbKrk6.Checked) { kuri = rbKrk6.Text; } else if (rbKrk7.Checked) { kuri = rbKrk7.Text; } else if (rbKrk8.Checked) { kuri = rbKrk8.Text; }
            string message = String.Format("NIM : {0}\nNama : {1}\nJenis Kelamin : {2}\nAlamat : {3}\nProgram Studi : {4}\nTahun Akademik : {5}\nSemester : {6}\nKurikulum : {7}\nKelas : {8}\n", numTb2.Text, numTb1.Text, jk, tbAlamat.Text, cbProgramStudi.Text, userControl12.Text, tbTa.Text, kuri, kelas) ;
            MessageBox.Show(message);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
