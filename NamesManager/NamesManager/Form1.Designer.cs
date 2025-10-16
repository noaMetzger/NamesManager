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
            this.SuspendLayout();
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(186, 69);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(100, 22);
            this.nameInput.TabIndex = 0;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(183, 50);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(44, 16);
            this.name.TabIndex = 1;
            this.name.Text = "Name";
            // 
            // namesLst
            // 
            this.namesLst.FormattingEnabled = true;
            this.namesLst.ItemHeight = 16;
            this.namesLst.Items.AddRange(new object[] {
            "Hani",
            "Michael",
            "Stav",
            "Miryam"});
            this.namesLst.Location = new System.Drawing.Point(186, 114);
            this.namesLst.Name = "namesLst";
            this.namesLst.Size = new System.Drawing.Size(120, 84);
            this.namesLst.TabIndex = 2;
            // 
            // resolveName
            // 
            this.resolveName.Location = new System.Drawing.Point(353, 50);
            this.resolveName.Name = "resolveName";
            this.resolveName.Size = new System.Drawing.Size(75, 23);
            this.resolveName.TabIndex = 3;
            this.resolveName.Text = "resolve";
            this.resolveName.UseVisualStyleBackColor = true;
            this.resolveName.Click += new System.EventHandler(this.resolveName_Click);

            // 
            // addName
            // 
            this.addName.Location = new System.Drawing.Point(363, 114);
            this.addName.Name = "addName";
            this.addName.Size = new System.Drawing.Size(75, 23);
            this.addName.TabIndex = 4;
            this.addName.Text = "add";
            this.addName.UseVisualStyleBackColor = true;
            this.addName.Click += new System.EventHandler(this.addName_Click);
            // 
            // removeName
            // 
            this.removeName.Location = new System.Drawing.Point(363, 144);
            this.removeName.Name = "removeName";
            this.removeName.Size = new System.Drawing.Size(75, 23);
            this.removeName.TabIndex = 5;
            this.removeName.Text = "remove";
            this.removeName.UseVisualStyleBackColor = true;
            this.removeName.Click += new System.EventHandler(this.removeName_Click);

            // 
            // names
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.removeName);
            this.Controls.Add(this.addName);
            this.Controls.Add(this.resolveName);
            this.Controls.Add(this.namesLst);
            this.Controls.Add(this.name);
            this.Controls.Add(this.nameInput);
            this.Name = "names";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.ListBox namesLst;
        private System.Windows.Forms.Button resolveName;
        private System.Windows.Forms.Button addName;
        private System.Windows.Forms.Button removeName;
    }
}

