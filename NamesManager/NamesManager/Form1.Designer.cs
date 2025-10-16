namespace NamesManager
{
    partial class names
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
            this.nameInput = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.namesLst = new System.Windows.Forms.ListBox();
            this.resolveName = new System.Windows.Forms.Button();
            this.addName = new System.Windows.Forms.Button();
            this.removeName = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(20, 22);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(100, 22);
            this.nameInput.TabIndex = 0;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(17, 3);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(44, 16);
            this.name.TabIndex = 1;
            this.name.Text = "Name";
            // 
            // namesLst
            // 
            this.namesLst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.namesLst.FormattingEnabled = true;
            this.namesLst.ItemHeight = 16;
            this.namesLst.Location = new System.Drawing.Point(277, 228);
            this.namesLst.Name = "namesLst";
            this.namesLst.Size = new System.Drawing.Size(120, 100);
            this.namesLst.TabIndex = 2;
            // 
            // resolveName
            // 
            this.resolveName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.resolveName.Location = new System.Drawing.Point(403, 199);
            this.resolveName.Name = "resolveName";
            this.resolveName.Size = new System.Drawing.Size(75, 23);
            this.resolveName.TabIndex = 3;
            this.resolveName.Text = "resolve";
            this.resolveName.UseVisualStyleBackColor = true;
            this.resolveName.Click += new System.EventHandler(this.resolveName_Click);
            // 
            // addName
            // 
            this.addName.Location = new System.Drawing.Point(3, 20);
            this.addName.Name = "addName";
            this.addName.Size = new System.Drawing.Size(75, 23);
            this.addName.TabIndex = 4;
            this.addName.Text = "add";
            this.addName.UseVisualStyleBackColor = true;
            this.addName.Click += new System.EventHandler(this.addName_Click);
            // 
            // removeName
            // 
            this.removeName.Location = new System.Drawing.Point(3, 60);
            this.removeName.Name = "removeName";
            this.removeName.Size = new System.Drawing.Size(75, 23);
            this.removeName.TabIndex = 5;
            this.removeName.Text = "remove";
            this.removeName.UseVisualStyleBackColor = true;
            this.removeName.Click += new System.EventHandler(this.removeName_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.resolveName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.namesLst, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.removeName);
            this.panel1.Controls.Add(this.addName);
            this.panel1.Location = new System.Drawing.Point(403, 228);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(97, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.nameInput);
            this.panel2.Controls.Add(this.name);
            this.panel2.Location = new System.Drawing.Point(259, 170);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(138, 52);
            this.panel2.TabIndex = 3;
            // 
            // names
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "names";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.names_FormClosing);
            this.Load += new System.EventHandler(this.names_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.ListBox namesLst;
        private System.Windows.Forms.Button resolveName;
        private System.Windows.Forms.Button addName;
        private System.Windows.Forms.Button removeName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

