using ApEducationala4.Forms.FormPronume.FormTestePronume;
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
    public partial class FormTestePagina4 : Form
    {
        public FormTestePagina4()
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
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); 
            FormTeste form1 = new FormTeste();
        }

        private void btnTestAdj_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTestAdjectiv());
        }

        private void btnTestPronume_Click(object sender, EventArgs e)
        {

            OpenChildForm(new FormTestPronume());
        }
    }
}
