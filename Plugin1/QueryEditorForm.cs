using System;
using System.Windows.Forms;

namespace Plugin1Namespace
{
    public partial class QueryEditorForm : Form
    {
        public string QueryText { get; set; }

        public QueryEditorForm(string currentQuery)
        {
            InitializeComponent();
            QueryText = currentQuery;
            textBox_Query.Text = currentQuery; // Aktuellen Query in die TextBox setzen
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            QueryText = textBox_Query.Text; // Abfrage speichern
            DialogResult = DialogResult.OK; // Fenster schließen und OK zurückgeben
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; // Fenster schließen ohne Änderung
        }
    }
}
