using ApEducationala4.Forms.Pronom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApEducationala4.Forms
{
    public partial class FormLectiiPronume1 : Form
    {
        public FormLectiiPronume1()
        {
            InitializeComponent();
        }
        public void OpenChildForm(Form childForm)
        {
            // Verificați dacă formularul există deja în lista de controale
            foreach (Control control in this.Controls)
            {
                if (control.GetType() == childForm.GetType())
                {
                    // Afișați formularul existent și ieșiți din metodă
                    control.BringToFront();
                    return;
                }
            }

            // Dacă formularul nu există, creați o nouă instanță și adăugați-o ca fiind un control al formularului existent
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void FormLectiiPronume1_Load(object sender, EventArgs e)
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
            this.Close(); // închide formularul curent (FormInstruire)
            FormInstruire formInstruire = new FormInstruire();
        }

        private void linkLabelPronumePersonale_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           // OpenChildForm(new FormPronumePersonale());
        }

        private void linkLabelPronumeReflexive_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenChildForm(new FormPronumeReflexive());
        }

        private void linkLabelPronumePosesive_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenChildForm(new FormPronumePosesive());
        }

        private void linkLabelPronumeDemonstrative_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenChildForm(new FormPronumeDemonstrative());
        }

        private void linkLabelPronumeInterogative_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenChildForm(new FormPronumeInterogative());
        }
    }
}
