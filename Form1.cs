using System.ComponentModel;
using System.Windows.Forms;
using System.Xml;

namespace Lab2
{
    public partial class Form1 : Form
    {
        List<Student> final = new List<Student>();
        public Form1()
        {
            InitializeComponent();

            txtMarkFrom.KeyPress += new KeyPressEventHandler(NumericTextBox_KeyPress);
            txtMarkTo.KeyPress += new KeyPressEventHandler(NumericTextBox_KeyPress);

            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
            this.FormClosing += MainForm_FormClosing;

            dataGridView1.RowHeadersWidth = 30;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Чи дійсно ви хочете завершити роботу з програмою?", "Підтвердження виходу", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnSelectXMLPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML Files|*.xml";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtXmlPath.Text = openFileDialog.FileName;
            }
        }
        private void btnSelectXSLPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XSL Files|*.xsl";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtXslPath.Text = openFileDialog.FileName;
            }
        }
        private void btnSelectHTMLPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "HTML Files|*.html";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtHtmlPath.Text = openFileDialog.FileName;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            List<string> errors = new List<string>();

            string xmlPath = txtXmlPath.Text;
            string xslPath = txtXslPath.Text;
            string htmlPath = txtHtmlPath.Text;

            if (!IsValidPath(xmlPath, ".xml"))
            {
                errors.Add("Невірний шлях до XML файлу.");
            }

            if (!IsValidPath(xslPath, ".xsl"))
            {
                errors.Add("Невірний шлях до XSL файлу.");
            }

            if (!IsValidPath(htmlPath, ".html"))
            {
                errors.Add("Невірний шлях до HTML файлу.");
            }

            if (errors.Count > 0)
            {
                ShowErrorMessageBox(string.Join("\n", errors));
                return;
            }

            Transformator transformator = new Transformator();
            List<Student> filteredStudent = final;
            transformator.Transform(filteredStudent, xmlPath, xslPath, htmlPath);
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            //cmbStrategy.Text = null;
            cmbFaculty.Text = null;
            cmbDepartment.Text = null;
            cmbDiscipline.Text = null;
            cmbStudentName.Text = null;
            txtMarkFrom.Text = null;
            txtMarkTo.Text = null;
            final = null;
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            List<string> errors = new List<string>();

            string xmlPath = txtXmlPath.Text;

            if (!IsValidPath(xmlPath, ".xml"))
            {
                errors.Add("Невірний шлях до XML файлу.");
            }
            if (cmbStrategy.SelectedItem == null)
            {
                errors.Add("Будь ласка, виберіть спосіб аналізу документа.");
            }

            if (errors.Count > 0)
            {
                ShowErrorMessageBox(string.Join("\n", errors));
                return;
            }

            dataGridView1.Rows.Clear();

            Student _student = OurStudent();

            string selectedStrategy = cmbStrategy.SelectedItem.ToString();

            if (selectedStrategy == "SAX API")
            {
                IXmlParserStrategy strategy = new SAXParsingStrategy();
                final = strategy.Analyze(_student, xmlPath);
                Output(final);
            }
            else if (selectedStrategy == "DOM API")
            {
                IXmlParserStrategy strategy = new DOMParsingStrategy();
                final = strategy.Analyze(_student, xmlPath);
                Output(final);
            }
            else if (selectedStrategy == "LINQ to XML")
            {
                IXmlParserStrategy strategy = new LINQParsingStrategy();
                final = strategy.Analyze(_student, xmlPath);
                Output(final);
            }
        }

        private void txtXmlPath_TextChanged(object sender, EventArgs e)
        {
            LoadFaculties();
            LoadDepartments();
            LoadDisciplines();
            LoadStudentNames();
        }

        //
        //FUNCTIONS
        //

        private Student OurStudent()
        {
            string[] info = new string[5];
            if (cmbFaculty.SelectedItem != null) { info[0] = Convert.ToString(cmbFaculty.Text); }
            else if (cmbFaculty.SelectedItem == null && cmbFaculty.Text != "") { info[0] = Convert.ToString(cmbFaculty.Text); }

            if (cmbDepartment.SelectedItem != null) info[1] = Convert.ToString(cmbDepartment.Text);
            else if (cmbDepartment.SelectedItem == null && cmbDepartment.Text != "") { info[0] = Convert.ToString(cmbDepartment.Text); }

            if (cmbDiscipline.SelectedItem != null) info[2] = Convert.ToString(cmbDiscipline.Text);
            else if (cmbDiscipline.SelectedItem == null && cmbDiscipline.Text != "") { info[0] = Convert.ToString(cmbDiscipline.Text); }

            if (cmbStudentName.SelectedItem != null) info[3] = Convert.ToString(cmbStudentName.Text);
            else if (cmbStudentName.SelectedItem == null && cmbStudentName.Text != "") { info[0] = Convert.ToString(cmbStudentName.Text); }

            Student filteredStudent = new Student(info);

            if (int.TryParse(txtMarkFrom.Text, out int minGrade))
            {
                filteredStudent.MinGrade = minGrade;
            }

            if (int.TryParse(txtMarkTo.Text, out int maxGrade))
            {
                filteredStudent.MaxGrade = maxGrade;
            }

            return filteredStudent;
        }

        private void Output(List<Student> students)
        {
            dataGridView1.Rows.Clear();

            foreach (Student student in students)
            {
                if (int.TryParse(student.Grade, out int grade))
                {
                    dataGridView1.Rows.Add(student.Faculty, student.Department, student.Discipline, student.Name, grade);
                }
                else
                {
                    dataGridView1.Rows.Add(student.Faculty, student.Department, student.Discipline, student.Name, null);
                }
            }

            dataGridView1.CurrentCell = null;
        }

        private void ShowErrorMessageBox(string errorMessage)
        {
            MessageBox.Show(errorMessage, "Отакої!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool IsValidPath(string path, string fileType)
        {
            try
            {
                if (Path.IsPathRooted(path) && File.Exists(path))
                {
                    string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(path);
                    if (!string.IsNullOrWhiteSpace(fileNameWithoutExtension) && Path.GetExtension(path).Equals(fileType, StringComparison.OrdinalIgnoreCase))
                    {
                        return true;
                    }
                }
            }
            catch (Exception)
            {
            }

            return false;
        }

        private void LoadComboBoxItems(string xpath, ComboBox comboBox)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(txtXmlPath.Text);

                XmlNodeList nodes = xmlDoc.SelectNodes(xpath);

                HashSet<string> unique = new HashSet<string>();

                if (nodes.Count > 0)
                {
                    foreach (XmlNode node in nodes)
                    {
                        string nodeName = node.Attributes["name"].Value;
                        unique.Add(nodeName);
                    }

                    comboBox.Items.Clear();
                    comboBox.Items.AddRange(unique.ToArray());
                    comboBox.DropDownHeight = 106;
                }
                else
                {
                    comboBox.Items.Clear();
                    comboBox.DropDownHeight = 106;
                }
            }
            catch (Exception ex)
            {
                comboBox.Items.Clear();
                comboBox.DropDownHeight = 106;
            }
        }
        private void LoadFaculties()
        {
            LoadComboBoxItems("/university/faculty", cmbFaculty);
        }
        private void LoadDepartments()
        {
            LoadComboBoxItems("//department", cmbDepartment);
        }
        private void LoadDisciplines()
        {
            LoadComboBoxItems("//discipline", cmbDiscipline);
        }
        private void LoadStudentNames()
        {
            LoadComboBoxItems("//student", cmbStudentName);
        }

        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}