using NamesManager.Class;
using NamesManager.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using System.Xml.Linq;
using NamesManager.Interface;

namespace NamesManager
{
    public partial class names : Form
    {
        private IRepository<Person> repository; 
        private string sourcePath; 
        private ISource<Person> source;
        public names()
        {
            InitializeComponent();
            sourcePath = "people.json";
            source = new JsonFile<Person>(sourcePath);
            repository = new Repository<Person>();
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.MinimumSize = new Size(600, 400);
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void names_Load(object sender, EventArgs e)
        {
            repository.Set(source.Read());
            RefreshListBox();
        }

        private void names_FormClosing(object sender, FormClosingEventArgs e)
        {
            source.Write(repository.GetAll());
        }

        private void addName_Click(object sender, EventArgs e)
        {
            string name = nameInput.Text.Trim();
            if (string.IsNullOrEmpty(name))
                MessageBox.Show("הקלד שם!", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (repository.GetAll().Any(p => p.FirstName.Equals(name, StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("השם כבר קיים ברשימה!", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                repository.Add(new Person { FirstName = name });
                SortPeople();
                RefreshListBox();
                nameInput.Clear();
            }

        }

        private void removeName_Click(object sender, EventArgs e)
        {
            if (namesLst.SelectedItem != null)
            {
                string selected = namesLst.SelectedItem.ToString();
                repository.GetAll().RemoveAll(p => p.FirstName == selected);
                RefreshListBox();
            }
            else
                MessageBox.Show("בחר שם למחיקה", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void resolveName_Click(object sender, EventArgs e)
        {
            string partial = nameInput.Text.Trim();
            var matches = repository.GetAll().Where(p => p.FirstName.StartsWith(partial, StringComparison.OrdinalIgnoreCase)).Select(p => p.FirstName).ToList();

            if (matches.Count == 1)
            {
                nameInput.Text = matches[0];
            }
            else if (matches.Count > 1)
            {
                FiltersForm form = new FiltersForm(matches);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    nameInput.Text = form.SelectedName;
                }
            }
            else
            {
                MessageBox.Show("לא נמצאו התאמות.", "השלמה", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SortPeople()
        {
            repository.Set(repository.GetAll().OrderBy(p => p.FirstName).ToList());
        }

        private void RefreshListBox()
        {
            namesLst.Items.Clear();
            foreach (var person in repository.GetAll())
            {
                namesLst.Items.Add(person.FirstName);
            }
        }


    }
}
