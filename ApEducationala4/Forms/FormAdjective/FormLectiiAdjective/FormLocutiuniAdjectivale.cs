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
    public partial class FormLocutiuniAdjectivale : Form
    {
        public FormLocutiuniAdjectivale()
        {
            InitializeComponent();
        }

        private void FormLocutiuniAdjectivale_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLectiiAdjective1 formLectiiAdjective1 = new FormLectiiAdjective1();
        }
    }
}
