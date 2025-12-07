using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using PluginInterface;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.IO;
using System.Linq;
using System.Text;

namespace Host
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmMain : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.StatusBar statusBar;
		private System.Windows.Forms.StatusBarPanel statusBarPanel;
		private System.Windows.Forms.TreeView tvwPlugins;
		private System.Windows.Forms.Panel pnlPlugin;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblPluginName;
		private System.Windows.Forms.Label lblPluginDesc;
        private MenuItem menuItem3;
        private MenuItem menuItem4;
        private MenuItem menuItem5;
        private MenuItem menuItem6;
        private IContainer components;

        public frmMain()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			Application.EnableVisualStyles();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.statusBar = new System.Windows.Forms.StatusBar();
            this.statusBarPanel = new System.Windows.Forms.StatusBarPanel();
            this.tvwPlugins = new System.Windows.Forms.TreeView();
            this.pnlPlugin = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPluginDesc = new System.Windows.Forms.Label();
            this.lblPluginName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem3,
            this.menuItem5});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2});
            this.menuItem1.Text = "&File";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.Text = "&Exit";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem4});
            this.menuItem3.Text = "Export";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 0;
            this.menuItem4.Text = "Aktuelles Ergebnis";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 2;
            this.menuItem5.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem6});
            this.menuItem5.Text = "Hilfe";
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 0;
            this.menuItem6.Text = "Hilfeartikel";
            this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 800);
            this.statusBar.Name = "statusBar";
            this.statusBar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel});
            this.statusBar.ShowPanels = true;
            this.statusBar.Size = new System.Drawing.Size(1264, 24);
            this.statusBar.TabIndex = 1;
            // 
            // statusBarPanel
            // 
            this.statusBarPanel.Name = "statusBarPanel";
            this.statusBarPanel.Width = 10000;
            // 
            // tvwPlugins
            // 
            this.tvwPlugins.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvwPlugins.FullRowSelect = true;
            this.tvwPlugins.Location = new System.Drawing.Point(8, 8);
            this.tvwPlugins.Name = "tvwPlugins";
            this.tvwPlugins.ShowLines = false;
            this.tvwPlugins.ShowPlusMinus = false;
            this.tvwPlugins.ShowRootLines = false;
            this.tvwPlugins.Size = new System.Drawing.Size(184, 634);
            this.tvwPlugins.TabIndex = 2;
            this.tvwPlugins.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwPlugins_AfterSelect);
            // 
            // pnlPlugin
            // 
            this.pnlPlugin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPlugin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPlugin.Location = new System.Drawing.Point(200, 8);
            this.pnlPlugin.Name = "pnlPlugin";
            this.pnlPlugin.Size = new System.Drawing.Size(1054, 779);
            this.pnlPlugin.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.lblPluginDesc);
            this.groupBox1.Controls.Add(this.lblPluginName);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(8, 650);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 137);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Plugin Information:";
            // 
            // lblPluginDesc
            // 
            this.lblPluginDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPluginDesc.Location = new System.Drawing.Point(8, 54);
            this.lblPluginDesc.Name = "lblPluginDesc";
            this.lblPluginDesc.Size = new System.Drawing.Size(168, 75);
            this.lblPluginDesc.TabIndex = 3;
            // 
            // lblPluginName
            // 
            this.lblPluginName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPluginName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPluginName.Location = new System.Drawing.Point(8, 16);
            this.lblPluginName.Name = "lblPluginName";
            this.lblPluginName.Size = new System.Drawing.Size(168, 26);
            this.lblPluginName.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1264, 824);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.tvwPlugins);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlPlugin);
            this.Menu = this.mainMenu;
            this.MinimumSize = new System.Drawing.Size(1067, 712);
            this.Name = "frmMain";
            this.Text = "Semacore Desktop Client";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.frmMain_Closing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
        #endregion

        private void TreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // Überprüfen, ob der Rechtsklick ausgeführt wurde
            if (e.Button == MouseButtons.Right)
            {
                // Optional: Gewählten Knoten markieren
                System.Windows.Forms.TreeView treeView = sender as System.Windows.Forms.TreeView;
                if (treeView != null)
                {
                    treeView.SelectedNode = e.Node;
                }

                /*
                Types.AvailablePlugin selectedPlugin = Global.Plugins.AvailablePlugins.Find(e.Node.Text);
                Global.Plugins.ClosePluginByName(selectedPlugin.Instance.Name);
                treeView.Nodes.Remove(e.Node);
                treeView.Refresh();
                */
                
            }
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
		static void Main() 
		{
			Application.Run(new frmMain());
		}

		private void frmMain_Load(object sender, System.EventArgs e)
		{
			//Call the find plugins routine, to search in our Plugins Folder
			Global.Plugins.FindPlugins(Application.StartupPath + @"\Plugins");
			
			//Add each plugin to the treeview
			foreach (Types.AvailablePlugin pluginOn in Global.Plugins.AvailablePlugins)
			{
				TreeNode newNode = new TreeNode(pluginOn.Instance.Name);
				this.tvwPlugins.Nodes.Add(newNode);
				newNode = null;
			}
		}

		private void tvwPlugins_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			//Make sure there's a selected Plugin
			if (this.tvwPlugins.SelectedNode != null)
			{
				//Get the selected Plugin
				Types.AvailablePlugin selectedPlugin = Global.Plugins.AvailablePlugins.Find(tvwPlugins.SelectedNode.Text.ToString());
				
				if (selectedPlugin != null)
				{

					this.lblPluginName.Text = selectedPlugin.Instance.Name;
					//this.lblPluginVersion.Text = "(" + selectedPlugin.Instance.Version + ")";					
					//this.lblPluginAuthor.Text = "By: " + selectedPlugin.Instance.Author;
					this.lblPluginDesc.Text = selectedPlugin.Instance.Description;

					// this only affects visuals.. doesn't close the instance of the plugin
					this.pnlPlugin.Controls.Clear();
					
					selectedPlugin.Instance.MainInterface.Dock = DockStyle.Fill;
					
					this.pnlPlugin.Controls.Add(selectedPlugin.Instance.MainInterface);
					
				}
			
			}
		}
		
        private void menuItem2_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void frmMain_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			// free all loaded plugins
			Global.Plugins.ClosePlugins();

		}

        private void menuItem4_Click(object sender, EventArgs e)
        {
            //Make sure there's a selected Plugin
            if (this.tvwPlugins.SelectedNode != null)
            {
                //Get the selected Plugin
                Types.AvailablePlugin selectedPlugin = Global.Plugins.AvailablePlugins.Find(tvwPlugins.SelectedNode.Text.ToString());

                if (selectedPlugin != null)
                {

                    if (selectedPlugin.Instance.MainInterface is UserControl mainControl)
                    {
                       
                        foreach (Control ctrl in mainControl.Controls)
                        {
                            // Überprüfen, ob eines der Controls ein DataGridView ist
                            if (ctrl is DataGridView dgv)
                            {

                                // SaveFileDialog zum Speichern der CSV-Datei anzeigen
                                SaveFileDialog saveFileDialog = new SaveFileDialog
                                {
                                    Filter = "CSV-Dateien (*.csv)|*.csv|Alle Dateien (*.*)|*.*",
                                    Title = "Exportiere als CSV",
                                    FileName = "Export.csv"
                                };

                                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                                {
                                    try
                                    {
                                        // Die CSV-Datei öffnen
                                        //using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                                        using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8))
                                        {
                                            // Kopfzeilen der CSV-Datei schreiben
                                            string[] columnNames = dgv.Columns.Cast<DataGridViewColumn>()
                                                                               .Select(column => column.HeaderText)
                                                                               .ToArray();
                                            writer.WriteLine(string.Join(";", columnNames));

                                            // Daten aus den Zeilen des DataGridView schreiben
                                            foreach (DataGridViewRow row in dgv.Rows)
                                            {
                                                if (!row.IsNewRow)
                                                {
                                                    //string[] cellValues = row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value?.ToString().Replace(",", ";")).ToArray();
                                                    string[] cellValues = row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value?.ToString()).ToArray();
                                                    writer.WriteLine(string.Join(";", cellValues));
                                                }
                                            }
                                        }

                                        MessageBox.Show("Die Daten wurden erfolgreich exportiert!", "Export abgeschlossen");
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show($"Fehler beim Exportieren der Daten: {ex.Message}", "Fehler");
                                    }
                                }

                                break;  // Verlassen, wenn das DataGridView gefunden wurde

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Das MainInterface ist kein UserControl.", "Fehler");
                    }

                }

            }
        }

        private void menuItem6_Click(object sender, EventArgs e)
        {
            Form f = new Help_Filter();
            f.Show();
        }
    }
}
