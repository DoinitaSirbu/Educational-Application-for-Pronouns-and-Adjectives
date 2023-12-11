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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // inchide formularul curent (FormInstruire)
            FormLectiiAdjective1 formLectiiAdjective1 = new FormLectiiAdjective1();
        }
    }
}
