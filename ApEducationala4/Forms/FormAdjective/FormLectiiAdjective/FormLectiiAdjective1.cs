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
    public partial class FormLectiiAdjective1 : Form
    {
        public FormLectiiAdjective1()
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

       
        private void FormLectiiAdjective1_Load(object sender, EventArgs e)
        {
            richTextBoxExempleAdjective.Text = "Exemple: om frumos";


            int index = richTextBoxExempleAdjective.Find("frumos");
            if (index >= 0)
            {
                richTextBoxExempleAdjective.Select(index, "frumos".Length);
                richTextBoxExempleAdjective.SelectionFont = new Font(richTextBoxExempleAdjective.Font, FontStyle.Bold);
            }
        }

        private void linkLabelAdjSimpleCompuse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenChildForm(new FormAdjectiveSimpleCompuse());
        }

        private void linkLabelAdjVariabileInvariabile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenChildForm(new FormAdjectiveVariabileInvariabile());
        }

        private void linkLabelLocutiuniAdj_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenChildForm(new FormLocutiuniAdjectivale());
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); 
            FormInstruire formInstruire = new FormInstruire();
        }

        private void btnMaiDeparte_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormAdjectiveSimpleCompuse());
        }
    }
}
