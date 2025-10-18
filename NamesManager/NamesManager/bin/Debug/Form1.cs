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
        private IPeopleRepository peopleRepository; 
        private string sourcePath; 
        private ISource source;
        public names()
        {
            InitializeComponent();
            sourcePath = "people.json";
            source = new JsonFile(sourcePath);
            peopleRepository = new PeopleRepository();
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.MinimumSize = new Size(600, 400);
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void names_Load(object sender, EventArgs e)
        {
            peopleRepository.SetPeople(source.Read());
            RefreshListBox();
        }

        private void names_FormClosing(object sender, FormClosingEventArgs e)
        {
            source.Write(peopleRepository.GetAllPeople().Cast<Object>().ToList());
        }

        private void addName_Click(object sender, EventArgs e)
        {
            string name = nameInput.Text.Trim();
            if (string.IsNullOrEmpty(name))
                MessageBox.Show("הקלד שם!", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (peopleRepository.GetAllPeople().Any(p => p.FirstName.Equals(name, StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("השם כבר קיים ברשימה!", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                peopleRepository.AddPerson(new Person { FirstName = name });
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
                peopleRepository.GetAllPeople().RemoveAll(p => p.FirstName == selected);
                RefreshListBox();
            }
            else
                MessageBox.Show("בחר שם למחיקה", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void resolveName_Click(object sender, EventArgs e)
        {
            string partial = nameInput.Text.Trim();
            var matches = peopleRepository.GetAllPeople().Where(p => p.FirstName.StartsWith(partial, StringComparison.OrdinalIgnoreCase)).Select(p => p.FirstName).ToList();

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
            peopleRepository.SetPeople(peopleRepository.GetAllPeople().OrderBy(p => p.FirstName).ToList());
        }

        private void RefreshListBox()
        {
            namesLst.Items.Clear();
            foreach (var person in peopleRepository.GetAllPeople())
            {
                namesLst.Items.Add(person.FirstName);
            }
        }


    }
}
