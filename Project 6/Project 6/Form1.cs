using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Project_6
{
    public partial class Form1 : Form
    {
        private List<Teacher> _teachers = new List<Teacher>();
        private const string FilePath = "teachers.dat";

        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void SaveData()
        {
            var lines = _teachers.Select(t => $"{t.LastName},{t.FirstName},{t.MiddleName},{t.DisciplineCode},{t.DisciplineName}");
            File.WriteAllLines("teachers.csv", lines);
        }

        private void LoadData()
        {
            if (!File.Exists("teachers.csv")) return;

            var lines = File.ReadAllLines("teachers.csv");
            _teachers = lines.Select(line =>
            {
                var parts = line.Split(',');
                return new Teacher
                {
                    LastName = parts[0],
                    FirstName = parts[1],
                    MiddleName = parts[2],
                    DisciplineCode = parts[3],
                    DisciplineName = parts[4]
                };
            }).ToList();

            UpdateDataGridView();
        }

        private void UpdateDataGridView()
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = _teachers;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            _teachers.Add(new Teacher
            {
                LastName = lastNameTextBox.Text,
                FirstName = firstNameTextBox.Text,
                MiddleName = middleNameTextBox.Text,
                DisciplineCode = disciplineCodeTextBox.Text,
                DisciplineName = disciplineNameTextBox.Text
            });

            UpdateDataGridView();
            ClearInput();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count <= 0 || !ValidateInput()) return;

            var selectedTeacher = (Teacher)dataGridView.SelectedRows[0].DataBoundItem;
            selectedTeacher.LastName = lastNameTextBox.Text;
            selectedTeacher.FirstName = firstNameTextBox.Text;
            selectedTeacher.MiddleName = middleNameTextBox.Text;
            selectedTeacher.DisciplineCode = disciplineCodeTextBox.Text;
            selectedTeacher.DisciplineName = disciplineNameTextBox.Text;

            UpdateDataGridView();
            ClearInput();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count <= 0) return;

            var selectedTeacher = (Teacher)dataGridView.SelectedRows[0].DataBoundItem;
            _teachers.Remove(selectedTeacher);
            UpdateDataGridView();
        }

        private void SortByLastNameButton_Click(object sender, EventArgs e)
        {
            _teachers.Sort((t1, t2) => string.Compare(t1.LastName, t2.LastName, StringComparison.Ordinal));
            UpdateDataGridView();
        }

        private void SortByDisciplineCodeButton_Click(object sender, EventArgs e)
        {
            _teachers.Sort((t1, t2) => string.Compare(t1.DisciplineCode, t2.DisciplineCode, StringComparison.Ordinal));
            UpdateDataGridView();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(lastNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(firstNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(disciplineCodeTextBox.Text) ||
                string.IsNullOrWhiteSpace(disciplineNameTextBox.Text))
            {
                MessageBox.Show("Все поля должны быть заполнены.");
                return false;
            }

            if (!char.IsUpper(lastNameTextBox.Text[0]) ||
                !char.IsUpper(firstNameTextBox.Text[0]) ||
                !char.IsUpper(middleNameTextBox.Text[0]))
            {
                MessageBox.Show("Фамилия, имя и отчество должны начинаться с заглавной буквы.");
                return false;
            }

            return true;
        }

        private void ClearInput()
        {
            lastNameTextBox.Clear();
            firstNameTextBox.Clear();
            middleNameTextBox.Clear();
            disciplineCodeTextBox.Clear();
            disciplineNameTextBox.Clear();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Сохранить изменения перед закрытием?", "Сохранение", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            SaveData();
        }
    }
}