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
    public partial class FormPronume2 : Form
    {
        public FormPronume2()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); 
            FormPronume1 formLectiiPronume1 = new FormPronume1();
        }

        private void FormPronume2_Load(object sender, EventArgs e)
        {

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

        private void buttonMaiDeparte_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormPronume3());
        }

        private void btnMaiDeparte_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormPronume3());
        }
    }
}
