using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ApEducationala4.Forms
{
    public partial class FormTestAdjectiv1 : Form
    {
        // Declarati un dictionar in care sa retineti raspunsurile utilizatorului
        Dictionary<string, string> userAnswers = new Dictionary<string, string>();
        DatabaseAccess dbAccess = new DatabaseAccess();
        DataTable dataTable;
        private string intrebare;
        public FormTestAdjectiv1()
        {
            InitializeComponent();
            this.intrebare = intrebare;
            label1.Text = intrebare;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); 
            FormTeste formTeste = new FormTeste();
        }

        private void FormTestAdjectiv_Load_1(object sender, EventArgs e)
        {
            List<string> adjectiveQuestions = dbAccess.GetAdjectiveQuestions().AsEnumerable().Select(r => r.Field<string>("TextIntrebare")).ToList();

            // afișați prima întrebare în Label1
            if (adjectiveQuestions.Count > 0)
            {
                label1.Text = adjectiveQuestions[0];
                int questionId = dbAccess.GetQuestionIdByQuestionText(adjectiveQuestions[0]);

                DisplayAnswers(label1.Text);
            }
             


        }
        List<string> GetAdjectivesAnswers(string TextIntrebare)
        {
            List<string> answers = new List<string>();

            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-9B7P6M7\\SQLEXPRESS; Initial Catalog=Aplicatie Educationala Pentru Invatarea Pronumelor Si Adjectivelor ;Integrated Security=True"))
            {
                conn.Open();

                string query = "SELECT Varianta1, Varianta2, Varianta3 FROM AdjectiveQuestions WHERE TextIntrebare = @TextIntrebare";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TextIntrebare", TextIntrebare);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string answer1 = reader.GetString(0);
                    string answer2 = reader.GetString(1);
                    string answer3 = reader.GetString(2);
                    answers.Add(answer1);
                    answers.Add(answer2);
                    answers.Add(answer3);
                }

                reader.Close();
            }

            return answers;
        }
        private void DisplayAnswers(string textIntrebare)
        {
            List<string> answers = GetAdjectivesAnswers(textIntrebare);

            if (answers.Count >= 3)
            {
                radioButton1.Text = answers[0];
                radioButton2.Text = answers[1];
                radioButton3.Text = answers[2];
                
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            int correctAnswers = 0;
            int incorrectAnswers = 0;

            if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked)
            {
                // Obțineți răspunsul corect din baza de date
                DataTable table = dbAccess.GetAdjectiveAnswers();
                string raspunsCorect = table.Rows[0][0].ToString();

                // Verificați dacă răspunsul utilizatorului este corect
                if ((radioButton1.Checked && radioButton1.Text == raspunsCorect) ||
                    (radioButton2.Checked && radioButton2.Text == raspunsCorect) ||
                    (radioButton3.Checked && radioButton3.Text == raspunsCorect))
                {
                    MessageBox.Show("Răspunsul este corect!");
                    correctAnswers++; 
                    // Continuați cu următoarea întrebare
                }
                else
                {
                    MessageBox.Show("Răspunsul este incorect. Vă rugăm să încercați din nou.");
                    incorrectAnswers++;
                    // Permiteți utilizatorului să încerce din nou
                }
            }
            else
            {
                MessageBox.Show("Vă rugăm să selectați un răspuns.");
                // Permiteți utilizatorului să selecteze un răspuns
            }
          
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
        private void btnContinua_Click(object sender, EventArgs e)
        {

            OpenChildForm(new FormIntrebareAdj2());
            // Obțineți întrebările de adjectiv din baza de date
            List<string> adjectiveQuestions = dbAccess.GetAdjectiveQuestions().AsEnumerable().Select(r => r.Field<string>("TextIntrebare")).ToList();

            // Verificați dacă există cel puțin două întrebări de adjectiv în baza de date
            //if (adjectiveQuestions.Count >= 2)
            //{
            //    // Afișați a doua întrebare de adjectiv
            //    string intrebare2 = adjectiveQuestions[1];
            //    FormIntrebareAdj2 formIntrebare2 = new FormIntrebareAdj2(intrebare2);
            //    formIntrebare2.Show();

            //    // Afișați variantele de răspuns asociate celei de-a doua întrebări
            //    DisplayAnswers(intrebare2);
            //}
        }
        //public FormIntrebareAdj2(string intrebare)
        //{
        //    InitializeComponent();
        //    this.intrebare = intrebare;
        //    label1.Text = intrebare;
        //}
    }
}
