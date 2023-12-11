using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApEducationala4.Models;
using System.Windows.Forms;

namespace ApEducationala4.Forms.FormPronume.FormTestePronume
{
    public partial class FormTestPronume : Form
    {
        public FormTestPronume()
        {
            InitializeComponent();
            FormTestPagina1Pronume_Load(this, EventArgs.Empty);
        }

        private void FormTestPagina1Pronume_Load(object sender, EventArgs e)
        {
            DatabaseAccess databaseAccess = new DatabaseAccess();
            DataTable pronounQuestionsTable = databaseAccess.GetPronounQuestions();
            DataTable pronounAnswersTable = databaseAccess.GetPronounAnswers();

            label1.Text = pronounQuestionsTable.Rows[0]["TextIntrebare"].ToString();
            label2.Text = pronounQuestionsTable.Rows[1]["TextIntrebare"].ToString();
            label3.Text = pronounQuestionsTable.Rows[2]["TextIntrebare"].ToString();
            label4.Text = pronounQuestionsTable.Rows[3]["TextIntrebare"].ToString();
            label5.Text = pronounQuestionsTable.Rows[4]["TextIntrebare"].ToString();
            label6.Text = pronounQuestionsTable.Rows[5]["TextIntrebare"].ToString();
            label7.Text = pronounQuestionsTable.Rows[6]["TextIntrebare"].ToString();
            label8.Text = pronounQuestionsTable.Rows[7]["TextIntrebare"].ToString();
            label9.Text = pronounQuestionsTable.Rows[8]["TextIntrebare"].ToString();
            label10.Text = pronounQuestionsTable.Rows[9]["TextIntrebare"].ToString();

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
                        radioButton1.Text = pronounAnswersTable.Rows[row]["Answer"].ToString();

                    if (radioButton2 != null)
                        radioButton2.Text = pronounAnswersTable.Rows[row + 1]["Answer"].ToString();

                    if (radioButton3 != null)
                        radioButton3.Text = pronounAnswersTable.Rows[row + 2]["Answer"].ToString();

                    row += 3;
                }
            }
        }
     
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            int totalQuestions = 10; // Numărul total de întrebări
            int score = 0; // Scorul utilizatorului

            DatabaseAccess databaseAccess = new DatabaseAccess();

            // Obțineți răspunsurile corecte din baza de date
            DataTable correctAnswers = databaseAccess.GetPronounAnswers();

            // Verifică dacă utilizatorul a selectat un răspuns la fiecare întrebare
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


        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            FormTeste form1 = new FormTeste();
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
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show
                ("Sigur doriți să părăsiți pagina curentă și să începeți un alt test? Veți pierde tot parcursul dvs!", 
                "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                OpenChildForm(new FormTestPronume());
            }
        }
    }
}
