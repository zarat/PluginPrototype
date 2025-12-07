using System;
using System.Windows.Forms;

namespace Plugin1Namespace
{

    partial class QueryEditorForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button button_Save;
        private Button button_Cancel;

        private void InitializeComponent()
        {
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.textBox_Query = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_Save
            // 
            this.button_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Save.Location = new System.Drawing.Point(316, 268);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.TabIndex = 1;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Cancel.Location = new System.Drawing.Point(397, 268);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 2;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // textBox_Query
            // 
            this.textBox_Query.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Query.Location = new System.Drawing.Point(12, 12);
            this.textBox_Query.Multiline = true;
            this.textBox_Query.Name = "textBox_Query";
            this.textBox_Query.Size = new System.Drawing.Size(460, 250);
            this.textBox_Query.TabIndex = 0;
            this.textBox_Query.ScrollBars = System.Windows.Forms.ScrollBars.Both; // Hinzugefügt: Aktiviert horizontale und vertikale Scrollbalken

            // 
            // QueryEditorForm
            // 
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.textBox_Query);
            this.Name = "QueryEditorForm";
            this.Text = "Query Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private TextBox textBox_Query;
    }


}