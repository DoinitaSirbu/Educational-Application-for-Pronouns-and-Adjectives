using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApEducationala4.Forms.FormPronume
{
    public partial class FormPronume1 : Form
    {
        public FormPronume1()
        {
            InitializeComponent();
        }
        public void OpenChildForm(Form childForm)
        {
            foreach (Control control in this.Controls)
            {
                if (control.GetType() == childForm.GetType())
                {
                    control.BringToFront();
                    return;
                }
            }

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnMaiDeparte_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormPronume2());

        }

        private void FormPronume1_Load(object sender, EventArgs e)
        {
            richTextBoxExempluPronume1.Text = "Exemplu: Tu cum te numești?";

            int index = richTextBoxExempluPronume1.Find("Tu");
            if (index >= 0)
            {
                richTextBoxExempluPronume1.Select(index, "Tu".Length);
                richTextBoxExempluPronume1.SelectionFont = new Font(richTextBoxExempluPronume1.Font, FontStyle.Bold);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            FormInstruire formInstruire = new FormInstruire();
        }

        private void linkLabelPronumePersonale_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenChildForm(new FormPronume2());
        }

        private void linkLabelPronReflexive_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenChildForm(new FormPronume2());
        }

        private void linkLabelPronPosesive_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenChildForm(new FormPronume4());
        }

        private void linkLabelPronDemonstrative_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenChildForm(new FormPronume3());

        }

        private void linkLabelPronumeInterogative_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenChildForm(new FormPronume3());

        }
    }
}
