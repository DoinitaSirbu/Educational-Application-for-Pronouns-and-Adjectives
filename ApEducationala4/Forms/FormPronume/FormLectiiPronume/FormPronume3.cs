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
    public partial class FormPronume3 : Form
    {
        public FormPronume3()
        {
            InitializeComponent();
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

        private void buttonBack_Click_1(object sender, EventArgs e)
        {
            this.Close(); 
            FormPronume2 formLectiiPronume1 = new FormPronume2();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormPronume4());
        }
    }
}
