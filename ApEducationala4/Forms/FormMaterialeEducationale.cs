using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApEducationala4.Forms
{
    public partial class FormMaterialeEducationale : Form
    {   
        public FormMaterialeEducationale()
        {
            InitializeComponent();
        }

        private void btnWikiPronume_Click(object sender, EventArgs e)
        {
            string videoUrl = "https://ro.wikipedia.org/wiki/Pronume";

            System.Diagnostics.Process.Start(videoUrl);
        }

        private void btnWikiAdjectiv_Click(object sender, EventArgs e)
        {
            string videoUrl = "https://ro.wikipedia.org/wiki/Adjectiv";

            System.Diagnostics.Process.Start(videoUrl);
        }

        private void btnPdfAdj_Click(object sender, EventArgs e)
        {
            string sourceFilePath = @"C:\Users\Doinita\Desktop\Aplicatie Educationala Pentru Învatarea Pronumelor Si Adjectivelor\ApEducationala4\Resources\Adjectivul.pdf";

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "Adjectiv.pdf";
            saveFileDialog.Filter = "Fișiere PDF (*.pdf)|*.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string destinationFilePath = saveFileDialog.FileName;

                try
                {
                    File.Copy(sourceFilePath, destinationFilePath);
                    MessageBox.Show("Fișierul a fost descărcat cu succes!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fișierul PDF nu a fost găsit! " + ex.Message);
                }
            }
        }

        private void btnPdfPron_Click(object sender, EventArgs e)
        {
            string sourceFilePath = @"C:\Users\Doinita\Desktop\Aplicatie Educationala Pentru Învatarea Pronumelor Si Adjectivelor\ApEducationala4\Resources\Pronumele.pdf";

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "Pronumele.pdf";
            saveFileDialog.Filter = "Fișiere PDF (*.pdf)|*.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string destinationFilePath = saveFileDialog.FileName;

                try
                {
                    File.Copy(sourceFilePath, destinationFilePath);
                    MessageBox.Show("Fișierul a fost descărcat cu succes!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fișierul PDF nu a fost găsit!" + ex.Message);
                }
            }
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {

            this.Close(); 
            FormTeste form1 = new FormTeste();
        }

        private void btnVideoAdj_Click(object sender, EventArgs e)
        {
            string videoUrl = "https://www.youtube.com/watch?v=seFg-r7dCqs";

            System.Diagnostics.Process.Start(videoUrl);
        }

        private void btnVideoPron_Click(object sender, EventArgs e)
        {
            string videoUrl = "https://www.youtube.com/watch?v=oZiSKuCKjp4";

            System.Diagnostics.Process.Start(videoUrl);
        }
    }
}
