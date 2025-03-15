namespace Project_6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lastNameTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            middleNameTextBox = new TextBox();
            disciplineNameTextBox = new TextBox();
            disciplineCodeTextBox = new TextBox();
            dataGridView = new DataGridView();
            addButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            sortByLastNameButton = new Button();
            sortByDisciplineCodeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(97, 69);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(100, 23);
            lastNameTextBox.TabIndex = 0;
            lastNameTextBox.Text = "last name";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(97, 107);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(100, 23);
            firstNameTextBox.TabIndex = 1;
            firstNameTextBox.Text = "firstNameTextBox";
            // 
            // middleNameTextBox
            // 
            middleNameTextBox.Location = new Point(97, 159);
            middleNameTextBox.Name = "middleNameTextBox";
            middleNameTextBox.Size = new Size(100, 23);
            middleNameTextBox.TabIndex = 2;
            middleNameTextBox.Text = "middleNameTextBox";
            // 
            // disciplineNameTextBox
            // 
            disciplineNameTextBox.Location = new Point(97, 243);
            disciplineNameTextBox.Name = "disciplineNameTextBox";
            disciplineNameTextBox.Size = new Size(100, 23);
            disciplineNameTextBox.TabIndex = 3;
            disciplineNameTextBox.Text = "disciplineNameTextBox";
            // 
            // disciplineCodeTextBox
            // 
            disciplineCodeTextBox.Location = new Point(97, 204);
            disciplineCodeTextBox.Name = "disciplineCodeTextBox";
            disciplineCodeTextBox.Size = new Size(100, 23);
            disciplineCodeTextBox.TabIndex = 4;
            disciplineCodeTextBox.Text = "disciplineCodeTextBox";
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(358, 12);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(430, 118);
            dataGridView.TabIndex = 5;
            // 
            // addButton
            // 
            addButton.Location = new Point(133, 317);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 6;
            addButton.Text = "addButton";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += AddButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(280, 317);
            editButton.Name = "editButton";
            editButton.Size = new Size(75, 23);
            editButton.TabIndex = 7;
            editButton.Text = "editButton";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += EditButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(411, 317);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 23);
            deleteButton.TabIndex = 8;
            deleteButton.Text = "deleteButton";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += DeleteButton_Click;
            // 
            // sortByLastNameButton
            // 
            sortByLastNameButton.Location = new Point(225, 380);
            sortByLastNameButton.Name = "sortByLastNameButton";
            sortByLastNameButton.Size = new Size(75, 23);
            sortByLastNameButton.TabIndex = 9;
            sortByLastNameButton.Text = "sortByLastNameButton";
            sortByLastNameButton.UseVisualStyleBackColor = true;
            sortByLastNameButton.Click += SortByLastNameButton_Click;
            // 
            // sortByDisciplineCodeButton
            // 
            sortByDisciplineCodeButton.Location = new Point(329, 380);
            sortByDisciplineCodeButton.Name = "sortByDisciplineCodeButton";
            sortByDisciplineCodeButton.Size = new Size(75, 23);
            sortByDisciplineCodeButton.TabIndex = 10;
            sortByDisciplineCodeButton.Text = "sortByDisciplineCodeButton";
            sortByDisciplineCodeButton.UseVisualStyleBackColor = true;
            sortByDisciplineCodeButton.Click += SortByDisciplineCodeButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(sortByDisciplineCodeButton);
            Controls.Add(sortByLastNameButton);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(addButton);
            Controls.Add(dataGridView);
            Controls.Add(disciplineCodeTextBox);
            Controls.Add(disciplineNameTextBox);
            Controls.Add(middleNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(lastNameTextBox);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox lastNameTextBox;
        private TextBox firstNameTextBox;
        private TextBox middleNameTextBox;
        private TextBox disciplineNameTextBox;
        private TextBox disciplineCodeTextBox;
        private DataGridView dataGridView;
        private Button addButton;
        private Button editButton;
        private Button deleteButton;
        private Button sortByLastNameButton;
        private Button sortByDisciplineCodeButton;
    }
}
