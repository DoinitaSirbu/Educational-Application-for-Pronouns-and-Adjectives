using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;

namespace ApEducationala4.Forms
{
    public partial class FormTestAdjectiv : Form
    {
        public FormTestAdjectiv()
        {
            InitializeComponent();
            FormTestPagina1Adj_Load(this, EventArgs.Empty);
        }    
        private void FormTestPagina1Adj_Load(object sender, EventArgs e)
        {
            DatabaseAccess databaseAccess = new DatabaseAccess();
            DataTable adjectiveQuestionsTable = databaseAccess.GetAdjectiveQuestions();
            DataTable adjectiveAnswersTable = databaseAccess.GetAdjectiveAnswers();

            label1.Text = adjectiveQuestionsTable.Rows[0]["TextIntrebare"].ToString();
            label2.Text = adjectiveQuestionsTable.Rows[1]["TextIntrebare"].ToString();
            label3.Text = adjectiveQuestionsTable.Rows[2]["TextIntrebare"].ToString();
            label4.Text = adjectiveQuestionsTable.Rows[3]["TextIntrebare"].ToString();
            label5.Text = adjectiveQuestionsTable.Rows[4]["TextIntrebare"].ToString();
            label6.Text = adjectiveQuestionsTable.Rows[5]["TextIntrebare"].ToString();
            label7.Text = adjectiveQuestionsTable.Rows[6]["TextIntrebare"].ToString();
            label8.Text = adjectiveQuestionsTable.Rows[7]["TextIntrebare"].ToString();
            label9.Text = adjectiveQuestionsTable.Rows[8]["TextIntrebare"].ToString();
            label10.Text = adjectiveQuestionsTable.Rows[9]["TextIntrebare"].ToString();

            int row = 0;
            for (int i = 0; i < 10; i++)
            {
                GroupBox groupBox = Controls.Find("groupBox" + (i + 1), true).FirstOrDefault() as GroupBox;

                if (groupBox != null)
                {
                    RadioButton radioButton1 = groupBox.Controls.OfType<RadioButton>().FirstOrDefault();
                    RadioButton radioButton2 = groupBox.Controls.OfType<RadioButton>().Skip(1).FirstOrDefault();
                    RadioButton radioButton3 = groupBox.Controls.OfType<RadioButton>().Skip(2).FirstOrDefault();

                    if (radioButton1 != null)
                        radioButton1.Text = adjectiveAnswersTable.Rows[row]["Answer"].ToString();

                    if (radioButton2 != null)
                        radioButton2.Text = adjectiveAnswersTable.Rows[row + 1]["Answer"].ToString();

                    if (radioButton3 != null)
                        radioButton3.Text = adjectiveAnswersTable.Rows[row + 2]["Answer"].ToString();

                    row += 3;
                }
            }
        }
        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
            FormTestePagina4 formTeste = new FormTestePagina4();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            int totalQuestions = 10; 
            int score = 0;

            DatabaseAccess databaseAccess = new DatabaseAccess();

            DataTable correctAnswers = databaseAccess.GetAdjectiveAnswers();

            for (int i = 1; i <= totalQuestions; i++)
            {
                GroupBox groupBox = Controls.Find("groupBox" + i, true).FirstOrDefault() as GroupBox;
                RadioButton selectedRadioButton = groupBox.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked);

                if (selectedRadioButton == null)
                {
                    MessageBox.Show($"Vă rugăm să selectați un răspuns la întrebarea {i}.");
                    return;
                }
                DataRow[] correctRows = correctAnswers.Select($"Answer = '{selectedRadioButton.Text}'");
                if (correctRows.Length > 0 && (bool)correctRows[0]["IsCorrect"])
                {
                    score++; 
                }
            }
            MessageBox.Show($"Răspunsurile dumneavoastră corecte sunt în număr de: {score}/{totalQuestions}");

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
        private void buttonRestart_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sigur doriți să părăsiți pagina curentă și să începeți un alt test? Veți pierde tot parcursul dvs!", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                OpenChildForm(new FormTestAdjectiv());
            }
        }
    }
}

