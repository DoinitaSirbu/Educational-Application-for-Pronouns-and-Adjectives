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
    public partial class FormAdjectiveVariabileInvariabile : Form
    {
        public FormAdjectiveVariabileInvariabile()
        {
            InitializeComponent();
        }

   

        private void btnBack_Click_2(object sender, EventArgs e)
        {
            this.Close();
            FormLectiiAdjective1 formLectiiAdjective1 = new FormLectiiAdjective1();
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
            OpenChildForm(new FormLocutiuniAdjectivale());
        }
    }
}
