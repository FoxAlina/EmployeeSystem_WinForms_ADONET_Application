
namespace Employees_TestTaskWinFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectByPositionComboBox = new System.Windows.Forms.ComboBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.reportBtn = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.addEmpTabPage = new System.Windows.Forms.TabPage();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.yearOfBirthLabel = new System.Windows.Forms.Label();
            this.yearOfBirthTextBox = new System.Windows.Forms.TextBox();
            this.positionLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.finddeleteEmpTabPage = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FindButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.employeeLastNameFindTextBox = new System.Windows.Forms.TextBox();
            this.employeeNameFindTextBox = new System.Windows.Forms.TextBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.showDBButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.addEmpTabPage.SuspendLayout();
            this.finddeleteEmpTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectByPositionComboBox
            // 
            this.selectByPositionComboBox.FormattingEnabled = true;
            this.selectByPositionComboBox.Location = new System.Drawing.Point(166, 16);
            this.selectByPositionComboBox.Name = "selectByPositionComboBox";
            this.selectByPositionComboBox.Size = new System.Drawing.Size(292, 24);
            this.selectByPositionComboBox.TabIndex = 0;
            // 
            // addBtn
            // 
            this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addBtn.Location = new System.Drawing.Point(326, 432);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 25);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.deleteBtn.Location = new System.Drawing.Point(82, 379);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(256, 26);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Удалить выбранное";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // reportBtn
            // 
            this.reportBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.reportBtn.Location = new System.Drawing.Point(1173, 629);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(100, 25);
            this.reportBtn.TabIndex = 3;
            this.reportBtn.Text = "Отчёт";
            this.reportBtn.UseVisualStyleBackColor = true;
            this.reportBtn.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 61);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(813, 593);
            this.dataGridView.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.addEmpTabPage);
            this.tabControl1.Controls.Add(this.finddeleteEmpTabPage);
            this.tabControl1.Location = new System.Drawing.Point(841, 61);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(432, 492);
            this.tabControl1.TabIndex = 5;
            // 
            // addEmpTabPage
            // 
            this.addEmpTabPage.Controls.Add(this.label6);
            this.addEmpTabPage.Controls.Add(this.salaryLabel);
            this.addEmpTabPage.Controls.Add(this.salaryTextBox);
            this.addEmpTabPage.Controls.Add(this.yearOfBirthLabel);
            this.addEmpTabPage.Controls.Add(this.yearOfBirthTextBox);
            this.addEmpTabPage.Controls.Add(this.positionLabel);
            this.addEmpTabPage.Controls.Add(this.lastNameLabel);
            this.addEmpTabPage.Controls.Add(this.nameLabel);
            this.addEmpTabPage.Controls.Add(this.positionTextBox);
            this.addEmpTabPage.Controls.Add(this.lastNameTextBox);
            this.addEmpTabPage.Controls.Add(this.nameTextBox);
            this.addEmpTabPage.Controls.Add(this.addBtn);
            this.addEmpTabPage.Location = new System.Drawing.Point(4, 25);
            this.addEmpTabPage.Name = "addEmpTabPage";
            this.addEmpTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.addEmpTabPage.Size = new System.Drawing.Size(424, 463);
            this.addEmpTabPage.TabIndex = 0;
            this.addEmpTabPage.Text = "Добавить сотрудника";
            this.addEmpTabPage.UseVisualStyleBackColor = true;
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Location = new System.Drawing.Point(21, 261);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(72, 17);
            this.salaryLabel.TabIndex = 11;
            this.salaryLabel.Text = "Зарплата";
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.salaryTextBox.Location = new System.Drawing.Point(201, 256);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(200, 22);
            this.salaryTextBox.TabIndex = 10;
            // 
            // yearOfBirthLabel
            // 
            this.yearOfBirthLabel.AutoSize = true;
            this.yearOfBirthLabel.Location = new System.Drawing.Point(21, 220);
            this.yearOfBirthLabel.Name = "yearOfBirthLabel";
            this.yearOfBirthLabel.Size = new System.Drawing.Size(101, 17);
            this.yearOfBirthLabel.TabIndex = 9;
            this.yearOfBirthLabel.Text = "Год рождения";
            // 
            // yearOfBirthTextBox
            // 
            this.yearOfBirthTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.yearOfBirthTextBox.Location = new System.Drawing.Point(201, 215);
            this.yearOfBirthTextBox.Name = "yearOfBirthTextBox";
            this.yearOfBirthTextBox.Size = new System.Drawing.Size(200, 22);
            this.yearOfBirthTextBox.TabIndex = 8;
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Location = new System.Drawing.Point(21, 177);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(81, 17);
            this.positionLabel.TabIndex = 7;
            this.positionLabel.Text = "Должность";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(21, 133);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(70, 17);
            this.lastNameLabel.TabIndex = 6;
            this.lastNameLabel.Text = "Фамилия";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(21, 90);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 17);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Имя";
            // 
            // positionTextBox
            // 
            this.positionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.positionTextBox.Location = new System.Drawing.Point(201, 172);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(200, 22);
            this.positionTextBox.TabIndex = 4;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameTextBox.Location = new System.Drawing.Point(201, 130);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.Location = new System.Drawing.Point(201, 86);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 22);
            this.nameTextBox.TabIndex = 2;
            // 
            // finddeleteEmpTabPage
            // 
            this.finddeleteEmpTabPage.Controls.Add(this.label5);
            this.finddeleteEmpTabPage.Controls.Add(this.label4);
            this.finddeleteEmpTabPage.Controls.Add(this.FindButton);
            this.finddeleteEmpTabPage.Controls.Add(this.label2);
            this.finddeleteEmpTabPage.Controls.Add(this.label3);
            this.finddeleteEmpTabPage.Controls.Add(this.employeeLastNameFindTextBox);
            this.finddeleteEmpTabPage.Controls.Add(this.employeeNameFindTextBox);
            this.finddeleteEmpTabPage.Controls.Add(this.deleteBtn);
            this.finddeleteEmpTabPage.Location = new System.Drawing.Point(4, 25);
            this.finddeleteEmpTabPage.Name = "finddeleteEmpTabPage";
            this.finddeleteEmpTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.finddeleteEmpTabPage.Size = new System.Drawing.Size(424, 463);
            this.finddeleteEmpTabPage.TabIndex = 1;
            this.finddeleteEmpTabPage.Text = "Найти и Удалить сотрудника";
            this.finddeleteEmpTabPage.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(104, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Удалить сотрудника";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(104, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Найти сотрудника";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FindButton
            // 
            this.FindButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.FindButton.Location = new System.Drawing.Point(82, 197);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(256, 26);
            this.FindButton.TabIndex = 11;
            this.FindButton.Text = "Найти";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Имя";
            // 
            // employeeLastNameFindTextBox
            // 
            this.employeeLastNameFindTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeLastNameFindTextBox.Location = new System.Drawing.Point(198, 140);
            this.employeeLastNameFindTextBox.Name = "employeeLastNameFindTextBox";
            this.employeeLastNameFindTextBox.Size = new System.Drawing.Size(200, 22);
            this.employeeLastNameFindTextBox.TabIndex = 8;
            // 
            // employeeNameFindTextBox
            // 
            this.employeeNameFindTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeNameFindTextBox.Location = new System.Drawing.Point(198, 96);
            this.employeeNameFindTextBox.Name = "employeeNameFindTextBox";
            this.employeeNameFindTextBox.Size = new System.Drawing.Size(200, 22);
            this.employeeNameFindTextBox.TabIndex = 7;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(464, 15);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(81, 25);
            this.refreshButton.TabIndex = 6;
            this.refreshButton.Text = "Показать";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Выбрать должность";
            // 
            // showDBButton
            // 
            this.showDBButton.Location = new System.Drawing.Point(575, 15);
            this.showDBButton.Name = "showDBButton";
            this.showDBButton.Size = new System.Drawing.Size(123, 25);
            this.showDBButton.TabIndex = 13;
            this.showDBButton.Text = "Снять фильтр";
            this.showDBButton.UseVisualStyleBackColor = true;
            this.showDBButton.Click += new System.EventHandler(this.showDBButton_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(104, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Добавить сотрудника";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 666);
            this.Controls.Add(this.showDBButton);
            this.Controls.Add(this.reportBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.selectByPositionComboBox);
            this.Name = "Form1";
            this.Text = "Тестовое задание Никитина Алина";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.addEmpTabPage.ResumeLayout(false);
            this.addEmpTabPage.PerformLayout();
            this.finddeleteEmpTabPage.ResumeLayout(false);
            this.finddeleteEmpTabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox selectByPositionComboBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button reportBtn;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage addEmpTabPage;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.Label yearOfBirthLabel;
        private System.Windows.Forms.TextBox yearOfBirthTextBox;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TabPage finddeleteEmpTabPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox employeeLastNameFindTextBox;
        private System.Windows.Forms.TextBox employeeNameFindTextBox;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showDBButton;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}

