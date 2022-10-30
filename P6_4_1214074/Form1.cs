using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace P6_4_1214074
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbName_Leave(object sender, EventArgs e)
        {
            if (tbName.Text == "")
            {
                epWarning.SetError(tbName, "Textbox Nama tidak boleh kosong!");
                epWrong.SetError(tbName, "");
                epCorrect.SetError(tbName, "");
            }
            else
            {
                if ((tbName.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(tbName, "");
                    epWrong.SetError(tbName, "");
                    epCorrect.SetError(tbName, "Betul!");
                }
                else
                {
                    epWrong.SetError(tbName, "Inputan hanya boleh huruf!");
                    epWarning.SetError(tbName, "");
                    epCorrect.SetError(tbName, "");
                }
            }
        }

        private void tbUmur_Leave(object sender, EventArgs e)
        {
            if (tbUmur.Text == "")
            {
                epWarning.SetError(tbUmur, "Textbox Umur tidak boleh kosong!");
                epWrong.SetError(tbUmur, "");
                epCorrect.SetError(tbUmur, "");
            }
            else
            {
                if (tbUmur.Text == "")
                {
                    epWarning.SetError(tbUmur, "Textbox Umur tidak boleh kosong!");
                    epWrong.SetError(tbUmur, "");
                    epCorrect.SetError(tbUmur, "");
                }
                else
                    if ((tbUmur.Text).All(Char.IsNumber))
                {
                    epCorrect.SetError(tbUmur, "Betul!");
                    epWarning.SetError(tbUmur, "");
                    epWrong.SetError(tbUmur, "");
                }
                else
                {
                    epCorrect.SetError(tbUmur, "");
                    epWarning.SetError(tbUmur, "");
                    epWrong.SetError(tbUmur, "Inputan hanya boleh Angka!");
                }
            }
        }

        private void tbEmail_Leave(object sender, EventArgs e)
        {
            if (tbEmail.Text == "")
            {
                epWarning.SetError(tbEmail, "Textbox Email tidak boleh kosong!");
                epWrong.SetError(tbEmail, "");
                epCorrect.SetError(tbEmail, "");
            }
            else
            {
                if (Regex.IsMatch(tbEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
                {
                    epWarning.SetError(tbEmail, "");
                    epWrong.SetError(tbEmail, "");
                    epCorrect.SetError(tbEmail, "Betul!");
                }
                else
                {
                    epWrong.SetError(tbEmail, "Format email salah!\nContoh: a@b.c ");
                    epWarning.SetError(tbEmail, "");
                    epCorrect.SetError(tbEmail, "");
                }
            }
        }

        private void tbGunung1_Leave(object sender, EventArgs e)
        {
            if (tbGunung1.Text == "")
            {
                epWarning.SetError(tbGunung1, "Textbox Gunung tidak boleh kosong!");
                epWrong.SetError(tbGunung1, "");
                epCorrect.SetError(tbGunung1, "");
            }
            else
            {
                if ((tbName.Text).All(Char.IsNumber))
                {
                    epWarning.SetError(tbGunung1, "");
                    epWrong.SetError(tbGunung1, "");
                    epCorrect.SetError(tbGunung1, "Betul!");

                }
                else
                {
                    epCorrect.SetError(tbGunung1, "");
                    epWrong.SetError(tbGunung1, "Inputan hanya boleh Angka!");
                    epWarning.SetError(tbGunung1, "");
                }
            }
            if (tbGunung2.Text == "")
            {
                epWarning.SetError(tbGunung1, "Inputan hanya boleh Angka!");
                epCorrect.SetError(tbGunung1, "");
                epWrong.SetError(tbGunung1, "");
            }
        }

        private void tbGunung2_Leave(object sender, EventArgs e)
        {
            int Gunung1 = int.Parse(tbGunung1.Text);
            int Gunung2 = int.Parse(tbGunung2.Text);


            if (tbGunung1.Text == "")
            {
                epWarning.SetError(tbGunung2, "Textbox Gunung tidak boleh kosong!");
                epWrong.SetError(tbGunung2, "");
                epCorrect.SetError(tbGunung2, "");
            }
            else
            {
                if ((tbName.Text).All(Char.IsNumber))
                {
                    epCorrect.SetError(tbGunung2, "Betul!");
                    epWarning.SetError(tbGunung2, "");
                    epWrong.SetError(tbGunung2, "");
                }
                else
                {
                    epCorrect.SetError(tbGunung2, "");
                    epWarning.SetError(tbGunung2, "");
                    epWrong.SetError(tbGunung2, "Inputan hanya boleh Angka!");
                }
            }

            if (Gunung1 > Gunung2)
            {
                epWarning.SetError(tbGunung2, "Betul!");
                epCorrect.SetError(tbGunung2, "");
                epWrong.SetError(tbGunung2, "");

                epWarning.SetError(tbGunung2, "");
                epWrong.SetError(tbGunung2, "");
                epCorrect.SetError(tbGunung2, "Betul!");
            }
            else
            {
                epWarning.SetError(tbGunung2, "Salah!");
                epCorrect.SetError(tbGunung2, "");
                epWrong.SetError(tbGunung2, "");

                epWarning.SetError(tbGunung2, "");
                epWrong.SetError(tbGunung2, "");
                epCorrect.SetError(tbGunung2, "Salah!");
            }
        }

        private void tbDomisili_Leave(object sender, EventArgs e)
        {

            if (tbDomisili.Text == "")
            {
                epWarning.SetError(tbDomisili, "Textbox Domisili tidak boleh kosong!");
                epWrong.SetError(tbDomisili, "");
                epCorrect.SetError(tbDomisili, "");
            }
            else
            {
                if ((tbDomisili.Text).All(Char.IsUpper))
                {
                    epWarning.SetError(tbDomisili, "");
                    epWrong.SetError(tbDomisili, "");
                    epCorrect.SetError(tbDomisili, "Betul!");
                }
                else
                {
                    epWrong.SetError(tbDomisili, "Inputan hanya boleh huruf kapital!");
                    epWarning.SetError(tbDomisili, "");
                    epCorrect.SetError(tbDomisili, "");
                }
            }
        }

        private void tbPekerjaan_Leave(object sender, EventArgs e)
        {

            if (tbPekerjaan.Text == "")
            {
                epWarning.SetError(tbPekerjaan, "Textbox Pekerjaan tidak boleh kosong!");
                epWrong.SetError(tbPekerjaan, "");
                epCorrect.SetError(tbPekerjaan, "");
            }
            else
            {
                if ((tbPekerjaan.Text).All(Char.IsLower))
                {
                    epWarning.SetError(tbPekerjaan, "");
                    epWrong.SetError(tbPekerjaan, "");
                    epCorrect.SetError(tbPekerjaan, "Betul!");
                }
                else
                {
                    epWrong.SetError(tbPekerjaan, "Inputan hanya boleh huruf kcil!");
                    epWarning.SetError(tbPekerjaan, "");
                    epCorrect.SetError(tbPekerjaan, "");
                }
            }
        }

        private void tbSkill_Leave(object sender, EventArgs e)
        {
            if (tbSkill.Text == "")
            {
                epWarning.SetError(tbSkill, "Textbox Skill tidak boleh kosong!");
                epWrong.SetError(tbSkill, "");
                epCorrect.SetError(tbSkill, "");
            }
            else
            {
                if (tbSkill.Text.Length <= 6)
                {
                    epWarning.SetError(tbSkill, "");
                    epWrong.SetError(tbSkill, "");
                    epCorrect.SetError(tbSkill, "Betul!");
                }
                else
                {
                    epWrong.SetError(tbSkill, "Inputan tidak boleh lebih dari 6!");
                    epWarning.SetError(tbSkill, "");
                    epCorrect.SetError(tbSkill, "");
                }
            }
        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "")
            {
                MessageBox.Show("Masukkan nama anda", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbUmur.Text == "")
            {
                MessageBox.Show("Masukkan umur anda", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbEmail.Text == "")
            {
                MessageBox.Show("Harus email anda", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbGunung1.Text == "")
            {
                MessageBox.Show("Harus memasukan gunung yang pernah didaki", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbGunung2.Text == "")
            {
                MessageBox.Show("Harus memasukan gunung yang pernah didaki", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbDomisili.Text == "")
            {
                MessageBox.Show("Harus memasukan Domisili", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbPekerjaan.Text == "")
            {
                MessageBox.Show("Harus memasukan pekerjaan", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show
                ("Nama : " + tbName.Text +
                "\nUmur : " + tbUmur.Text +
                "\nEmail : " + tbEmail.Text +
                "\nGunung 1 : " + tbGunung1.Text +
                "\nGunung 2 : " + tbGunung2.Text +
                "\nDomisili : " + tbDomisili.Text +
                "\nPekerjaan : " + tbPekerjaan.Text +
                "\nSkill : " + tbSkill.Text,
                "Registration Form",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



