using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Host
{
    public partial class Help_Filter : Form
    {
        // Ordner, in dem die HTML-Dateien gespeichert sind
        private string helpFolderPath = Path.Combine(Application.StartupPath, "Hilfe");
        

        public Help_Filter()
        {
            InitializeComponent();
            InitializeHelpForm();
        }

        private void InitializeHelpForm()
        {

            // Überprüfen, ob der Ordner existiert
            if (Directory.Exists(helpFolderPath))
            {
                // Alle HTML-Dateien im Ordner laden und in der ListBox anzeigen
                string[] helpFiles = Directory.GetFiles(helpFolderPath, "*.html");
                foreach (string file in helpFiles)
                {
                    this.listBox1.Items.Add(Path.GetFileName(file));  // Nur den Dateinamen anzeigen
                }
            }
            else
            {
                MessageBox.Show("Der Hilfeartikel-Ordner wurde nicht gefunden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Event, wenn ein Artikel ausgewählt wird
            this.listBox1.SelectedIndexChanged += (sender, e) =>
            {
                if (this.listBox1.SelectedIndex >= 0)
                {
                    string selectedFile = Directory.GetFiles(helpFolderPath, "*.html")[listBox1.SelectedIndex];
                    this.webBrowser1.Navigate(selectedFile);  // HTML-Datei im WebBrowser anzeigen
                }
            };

            // Steuerelemente zum Formular hinzufügen
            //Controls.Add(this.listBox1);
            //Controls.Add(this.webBrowser1);
        }
    }
}
