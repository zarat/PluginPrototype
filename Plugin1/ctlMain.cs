using PluginInterface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Plugin1Namespace
{


    public class ctlMain : System.Windows.Forms.UserControl
    {

        private Button button_Abfragen;
        private DataGridView dataGridView1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private TextBox textBox_Filter;
        private Label label_Filter;
        private CheckBox checkBox_Filter;
        private Button button_Filter;
        private Button button1;
        private System.ComponentModel.Container components = null;

        public IPluginHost Host { get; set; }
        public IPlugin PluginContext { get; set; }

        public string query = String.Empty;

        public ctlMain()
        {

            InitializeComponent();

        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.button_Abfragen = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBox_Filter = new System.Windows.Forms.TextBox();
            this.label_Filter = new System.Windows.Forms.Label();
            this.checkBox_Filter = new System.Windows.Forms.CheckBox();
            this.button_Filter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Abfragen
            // 
            this.button_Abfragen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Abfragen.Location = new System.Drawing.Point(662, 17);
            this.button_Abfragen.Name = "button_Abfragen";
            this.button_Abfragen.Size = new System.Drawing.Size(102, 23);
            this.button_Abfragen.TabIndex = 1;
            this.button_Abfragen.Text = "abfragen";
            this.button_Abfragen.UseVisualStyleBackColor = true;
            this.button_Abfragen.Click += new System.EventHandler(this.button_Abfragen_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(737, 355);
            this.dataGridView1.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 483);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(793, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // textBox_Filter
            // 
            this.textBox_Filter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Filter.Location = new System.Drawing.Point(123, 65);
            this.textBox_Filter.Name = "textBox_Filter";
            this.textBox_Filter.Size = new System.Drawing.Size(422, 22);
            this.textBox_Filter.TabIndex = 5;
            // 
            // label_Filter
            // 
            this.label_Filter.AutoSize = true;
            this.label_Filter.Location = new System.Drawing.Point(24, 68);
            this.label_Filter.Name = "label_Filter";
            this.label_Filter.Size = new System.Drawing.Size(36, 16);
            this.label_Filter.TabIndex = 6;
            this.label_Filter.Text = "Filter";
            // 
            // checkBox_Filter
            // 
            this.checkBox_Filter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_Filter.AutoSize = true;
            this.checkBox_Filter.Location = new System.Drawing.Point(562, 67);
            this.checkBox_Filter.Name = "checkBox_Filter";
            this.checkBox_Filter.Size = new System.Drawing.Size(85, 20);
            this.checkBox_Filter.TabIndex = 7;
            this.checkBox_Filter.Text = "SQL Style";
            this.checkBox_Filter.UseVisualStyleBackColor = true;
            // 
            // button_Filter
            // 
            this.button_Filter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Filter.Location = new System.Drawing.Point(662, 64);
            this.button_Filter.Name = "button_Filter";
            this.button_Filter.Size = new System.Drawing.Size(102, 23);
            this.button_Filter.TabIndex = 8;
            this.button_Filter.Text = "filtern";
            this.button_Filter.UseVisualStyleBackColor = true;
            this.button_Filter.Click += new System.EventHandler(this.button_Filter_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(525, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Query Editor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ctlMain
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_Filter);
            this.Controls.Add(this.checkBox_Filter);
            this.Controls.Add(this.label_Filter);
            this.Controls.Add(this.textBox_Filter);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_Abfragen);
            this.Name = "ctlMain";
            this.Size = new System.Drawing.Size(793, 505);
            this.Load += new System.EventHandler(this.ctlMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void ctlMain_Load(object sender, System.EventArgs e)
        {
            this.Host.Feedback("Welcome Feedback", this.PluginContext);
        }

        public void TestSQL(string query)
        {

            this.Invoke((MethodInvoker)delegate
            {
                this.toolStripStatusLabel1.Text = "Die Datenbankabfrage wird gestartet.";
            });
            Application.DoEvents();

            try
            {

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                string connectionString = "Server=SQL04\\MyInstance;Database=DATA;User ID=admin; Password=Pa$$w0rd;TrustServerCertificate=True;Connection Timeout=30";

                SqlConnection conn = new SqlConnection(connectionString);

                conn.Open();

                if (conn.State == ConnectionState.Open)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        this.toolStripStatusLabel1.Text = "Verbindung zur Datenbank erfolgreich hergestellt.";
                    });
                    Application.DoEvents();
                }
                else
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        this.toolStripStatusLabel1.Text = "Verbindung zur Datenbank konnte nicht hergestellt werden.";
                    });
                    Application.DoEvents();
                    return;
                }

                string queryString = query; //string.Empty;


                SqlCommand command = new SqlCommand(queryString, conn);
                command.CommandTimeout = 1500; // timeout 15 minuten zu lange?

                this.Invoke((MethodInvoker)delegate
                {
                    this.toolStripStatusLabel1.Text = "Die Abfrage wurde übermittelt und wird von der Datenbank verarbeitet. Dieser Vorgang kann mitunter einige Zeit in Anspruch nehmen.";
                });
                Application.DoEvents();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        this.toolStripStatusLabel1.Text = "Die Abfrage wurde verarbeitet und die Ergebnisse werden empfangen. Dieser Vorgang kann mitunter einige Zeit in Anspruch nehmen.";
                    });
                    Application.DoEvents();

                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    this.Invoke((MethodInvoker)delegate
                    {
                        this.toolStripStatusLabel1.Text = "Empfangene Daten werden aufbereitet.";
                        this.dataGridView1.DataSource = dataTable;
                        this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    });
                    Application.DoEvents();
                }

                stopwatch.Stop();

                this.Invoke((MethodInvoker)delegate
                {
                    this.toolStripStatusLabel1.Text = "Die Datenbankabfrage wurde erfolgreich beendet und lieferte " + dataGridView1.RowCount + " Ergebnisse in " + stopwatch.Elapsed.ToString(@"hh\:mm\:ss\.fff") + " Sekunden.";
                });
                Application.DoEvents();
            }
            catch (Exception Ex)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    this.toolStripStatusLabel1.Text = Ex.Message;
                });
                Application.DoEvents();
                // throw Ex;
            }
        }

        private async void button_Abfragen_Click(object sender, EventArgs e)
        {

            // replace groupname from textbox
            //string query = ""; // textBox_query.Text;
            this.Host.Feedback("Starte Abfrage", this.PluginContext);

            await Task.Run(() => TestSQL(query));

        }

        private void button_Filter_Click(object sender, EventArgs e)
        {
            // template
            //var dt = (DataTable)dataGridView1.DataSource;
            //dt.DefaultView.RowFilter = string.Format("fld_name like '%{0}%'", textBox2.Text.Trim().Replace("'", "''"));
            //dataGridView1.Refresh();
            this.Host.Feedback("Filtere Abfrage", this.PluginContext);

            var dt = (DataTable)dataGridView1.DataSource;
            string filterValue = textBox_Filter.Text.Trim();

            if (checkBox_Filter.Checked == false)
            {

                List<string> filterConditions = new List<string>();

                foreach (DataColumn column in dt.Columns)
                {
                    if (column.DataType == typeof(string))
                    {
                        // Bedingung für Textspalten
                        filterConditions.Add($"{column.ColumnName} LIKE '%{filterValue}%'");
                    }
                    else if (column.DataType == typeof(int) || column.DataType == typeof(double) || column.DataType == typeof(float) || column.DataType == typeof(decimal))
                    {
                        // Bedingung für numerische Spalten
                        if (decimal.TryParse(filterValue, out decimal decimalValue))
                        {
                            filterConditions.Add($"{column.ColumnName} <> {decimalValue}");
                        }
                    }
                    else if (column.DataType == typeof(DateTime))
                    {
                        // Bedingung für Datumsspalten
                        if (DateTime.TryParse(filterValue, out DateTime dateTimeValue))
                        {
                            filterConditions.Add($"{column.ColumnName} <> #{dateTimeValue:MM/dd/yyyy}#");
                        }
                    }
                }

                /*
                foreach (DataColumn column in dt.Columns)
                {
                    filterConditions.Add($"{column.ColumnName} LIKE '%{filterValue}%'");
                }
                */

                dt.DefaultView.RowFilter = string.Join(" OR ", filterConditions);

                dataGridView1.Refresh();

            }
            else
            {

                dt.DefaultView.RowFilter = string.Format("{0}", filterValue);
                dataGridView1.Refresh();

            }

            

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Host.Feedback("Starte Query Editor", this.PluginContext);

            // Instanziiere das QueryEditorForm und zeige es an
            using (QueryEditorForm editor = new QueryEditorForm(this.query))
            {
                if (editor.ShowDialog() == DialogResult.OK)
                {
                    // Wenn OK gedrückt wurde, speichere den Query und aktualisiere das Control
                    this.query = editor.QueryText;
                }
            }

        }
    }

}
