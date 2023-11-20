namespace Lab2
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnSelectXMLPath = new Button();
            cmbStrategy = new ComboBox();
            txtXmlPath = new TextBox();
            btnStart = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtXslPath = new TextBox();
            btnSelectXSLPath = new Button();
            label4 = new Label();
            txtHtmlPath = new TextBox();
            btnSelectHTMLPath = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            cmbFaculty = new ComboBox();
            cmbDepartment = new ComboBox();
            cmbDiscipline = new ComboBox();
            cmbStudentName = new ComboBox();
            txtMarkFrom = new TextBox();
            txtMarkTo = new TextBox();
            btnAnalyze = new Button();
            btnClear = new Button();
            dataGridView1 = new DataGridView();
            Faculty = new DataGridViewTextBoxColumn();
            Department = new DataGridViewTextBoxColumn();
            Discipline = new DataGridViewTextBoxColumn();
            StudentName = new DataGridViewTextBoxColumn();
            Grade = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnSelectXMLPath
            // 
            btnSelectXMLPath.Location = new Point(532, 46);
            btnSelectXMLPath.Name = "btnSelectXMLPath";
            btnSelectXMLPath.Size = new Size(94, 29);
            btnSelectXMLPath.TabIndex = 0;
            btnSelectXMLPath.Text = "Огляд";
            btnSelectXMLPath.UseVisualStyleBackColor = true;
            btnSelectXMLPath.Click += btnSelectXMLPath_Click;
            // 
            // cmbStrategy
            // 
            cmbStrategy.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStrategy.FormattingEnabled = true;
            cmbStrategy.Items.AddRange(new object[] { "SAX API", "DOM API", "LINQ to XML" });
            cmbStrategy.Location = new Point(23, 232);
            cmbStrategy.Name = "cmbStrategy";
            cmbStrategy.RightToLeft = RightToLeft.No;
            cmbStrategy.Size = new Size(130, 28);
            cmbStrategy.TabIndex = 1;
            // 
            // txtXmlPath
            // 
            txtXmlPath.Location = new Point(23, 48);
            txtXmlPath.Name = "txtXmlPath";
            txtXmlPath.Size = new Size(474, 27);
            txtXmlPath.TabIndex = 2;
            txtXmlPath.TextChanged += txtXmlPath_TextChanged;
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnStart.Location = new Point(479, 209);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(147, 51);
            btnStart.TabIndex = 4;
            btnStart.Text = "Трансформувати в HTML";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 25);
            label1.Name = "label1";
            label1.Size = new Size(210, 20);
            label1.TabIndex = 6;
            label1.Text = "Виберіть шлях до XML файлу";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 209);
            label2.Name = "label2";
            label2.Size = new Size(252, 20);
            label2.TabIndex = 7;
            label2.Text = "Виберіть спосіб аналізу документа";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 81);
            label3.Name = "label3";
            label3.Size = new Size(205, 20);
            label3.TabIndex = 10;
            label3.Text = "Виберіть шлях до XSL файлу";
            // 
            // txtXslPath
            // 
            txtXslPath.Location = new Point(23, 104);
            txtXslPath.Name = "txtXslPath";
            txtXslPath.Size = new Size(474, 27);
            txtXslPath.TabIndex = 9;
            // 
            // btnSelectXSLPath
            // 
            btnSelectXSLPath.Location = new Point(532, 102);
            btnSelectXSLPath.Name = "btnSelectXSLPath";
            btnSelectXSLPath.Size = new Size(94, 29);
            btnSelectXSLPath.TabIndex = 8;
            btnSelectXSLPath.Text = "Огляд";
            btnSelectXSLPath.UseVisualStyleBackColor = true;
            btnSelectXSLPath.Click += btnSelectXSLPath_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 137);
            label4.Name = "label4";
            label4.Size = new Size(358, 20);
            label4.TabIndex = 13;
            label4.Text = "Виберіть шлях до результуючого HTML документу";
            // 
            // txtHtmlPath
            // 
            txtHtmlPath.Location = new Point(23, 160);
            txtHtmlPath.Name = "txtHtmlPath";
            txtHtmlPath.Size = new Size(474, 27);
            txtHtmlPath.TabIndex = 12;
            // 
            // btnSelectHTMLPath
            // 
            btnSelectHTMLPath.Location = new Point(532, 158);
            btnSelectHTMLPath.Name = "btnSelectHTMLPath";
            btnSelectHTMLPath.Size = new Size(94, 29);
            btnSelectHTMLPath.TabIndex = 11;
            btnSelectHTMLPath.Text = "Огляд";
            btnSelectHTMLPath.UseVisualStyleBackColor = true;
            btnSelectHTMLPath.Click += btnSelectHTMLPath_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 297);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 16;
            label5.Text = "Факультет";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 341);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 17;
            label6.Text = "Кафедра";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 383);
            label7.Name = "label7";
            label7.Size = new Size(91, 20);
            label7.TabIndex = 18;
            label7.Text = "Дисципліна";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 429);
            label8.Name = "label8";
            label8.Size = new Size(35, 20);
            label8.TabIndex = 19;
            label8.Text = "Ім'я";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 470);
            label9.Name = "label9";
            label9.Size = new Size(57, 20);
            label9.TabIndex = 20;
            label9.Text = "Оцінка";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(119, 470);
            label10.Name = "label10";
            label10.Size = new Size(29, 20);
            label10.TabIndex = 21;
            label10.Text = "від";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(213, 470);
            label11.Name = "label11";
            label11.Size = new Size(26, 20);
            label11.TabIndex = 22;
            label11.Text = "до";
            // 
            // cmbFaculty
            // 
            cmbFaculty.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbFaculty.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbFaculty.FormattingEnabled = true;
            cmbFaculty.Location = new Point(120, 294);
            cmbFaculty.Name = "cmbFaculty";
            cmbFaculty.Size = new Size(385, 28);
            cmbFaculty.TabIndex = 23;
            // 
            // cmbDepartment
            // 
            cmbDepartment.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbDepartment.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(120, 338);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(385, 28);
            cmbDepartment.TabIndex = 24;
            // 
            // cmbDiscipline
            // 
            cmbDiscipline.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbDiscipline.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbDiscipline.FormattingEnabled = true;
            cmbDiscipline.Location = new Point(120, 380);
            cmbDiscipline.Name = "cmbDiscipline";
            cmbDiscipline.Size = new Size(385, 28);
            cmbDiscipline.TabIndex = 25;
            // 
            // cmbStudentName
            // 
            cmbStudentName.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbStudentName.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbStudentName.FormattingEnabled = true;
            cmbStudentName.Location = new Point(120, 426);
            cmbStudentName.Name = "cmbStudentName";
            cmbStudentName.Size = new Size(385, 28);
            cmbStudentName.TabIndex = 26;
            // 
            // txtMarkFrom
            // 
            txtMarkFrom.Location = new Point(154, 467);
            txtMarkFrom.Name = "txtMarkFrom";
            txtMarkFrom.Size = new Size(50, 27);
            txtMarkFrom.TabIndex = 27;
            txtMarkFrom.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMarkTo
            // 
            txtMarkTo.Location = new Point(242, 467);
            txtMarkTo.Name = "txtMarkTo";
            txtMarkTo.Size = new Size(50, 27);
            txtMarkTo.TabIndex = 28;
            txtMarkTo.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAnalyze
            // 
            btnAnalyze.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAnalyze.Location = new Point(517, 326);
            btnAnalyze.Name = "btnAnalyze";
            btnAnalyze.Size = new Size(109, 40);
            btnAnalyze.TabIndex = 29;
            btnAnalyze.Text = "Аналізувати";
            btnAnalyze.UseVisualStyleBackColor = true;
            btnAnalyze.Click += btnAnalyze_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Location = new Point(517, 380);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(109, 40);
            btnClear.TabIndex = 30;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Faculty, Department, Discipline, StudentName, Grade });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Dock = DockStyle.Right;
            dataGridView1.Location = new Point(651, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(761, 531);
            dataGridView1.TabIndex = 31;
            // 
            // Faculty
            // 
            Faculty.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Faculty.HeaderText = "Факультет";
            Faculty.MinimumWidth = 6;
            Faculty.Name = "Faculty";
            Faculty.ReadOnly = true;
            Faculty.Width = 113;
            // 
            // Department
            // 
            Department.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Department.HeaderText = "Кафедра";
            Department.MinimumWidth = 6;
            Department.Name = "Department";
            Department.ReadOnly = true;
            Department.Width = 102;
            // 
            // Discipline
            // 
            Discipline.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Discipline.HeaderText = "Дисципліна";
            Discipline.MinimumWidth = 6;
            Discipline.Name = "Discipline";
            Discipline.ReadOnly = true;
            Discipline.Width = 124;
            // 
            // StudentName
            // 
            StudentName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            StudentName.HeaderText = "П.І.Б. студента";
            StudentName.MinimumWidth = 6;
            StudentName.Name = "StudentName";
            StudentName.ReadOnly = true;
            StudentName.Width = 142;
            // 
            // Grade
            // 
            Grade.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grade.DefaultCellStyle = dataGridViewCellStyle2;
            Grade.HeaderText = "Оцінка";
            Grade.MinimumWidth = 6;
            Grade.Name = "Grade";
            Grade.ReadOnly = true;
            Grade.Width = 88;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1412, 531);
            Controls.Add(dataGridView1);
            Controls.Add(btnClear);
            Controls.Add(btnAnalyze);
            Controls.Add(txtMarkTo);
            Controls.Add(txtMarkFrom);
            Controls.Add(cmbStudentName);
            Controls.Add(cmbDiscipline);
            Controls.Add(cmbDepartment);
            Controls.Add(cmbFaculty);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtHtmlPath);
            Controls.Add(btnSelectHTMLPath);
            Controls.Add(label3);
            Controls.Add(txtXslPath);
            Controls.Add(btnSelectXSLPath);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnStart);
            Controls.Add(txtXmlPath);
            Controls.Add(cmbStrategy);
            Controls.Add(btnSelectXMLPath);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "XML Parser";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelectXMLPath;
        private ComboBox cmbStrategy;
        private TextBox txtXmlPath;
        private Button btnStart;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtXslPath;
        private Button btnSelectXSLPath;
        private Label label4;
        private TextBox txtHtmlPath;
        private Button btnSelectHTMLPath;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private ComboBox cmbFaculty;
        private ComboBox cmbDepartment;
        private ComboBox cmbDiscipline;
        private ComboBox cmbStudentName;
        private TextBox txtMarkFrom;
        private TextBox txtMarkTo;
        private Button btnAnalyze;
        private Button btnClear;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Faculty;
        private DataGridViewTextBoxColumn Department;
        private DataGridViewTextBoxColumn Discipline;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn Grade;
    }
}