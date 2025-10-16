namespace NamesManager.Forms
{
    partial class FiltersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.filterNames = new System.Windows.Forms.ListBox();
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // filterNames
            // 
            this.filterNames.FormattingEnabled = true;
            this.filterNames.ItemHeight = 16;
            this.filterNames.Location = new System.Drawing.Point(268, 158);
            this.filterNames.Name = "filterNames";
            this.filterNames.Size = new System.Drawing.Size(120, 84);
            this.filterNames.TabIndex = 0;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(461, 158);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 1;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(461, 198);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // FiltersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.filterNames);
            this.Name = "FiltersForm";
            this.Text = "FiltersForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox filterNames;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
    }
}