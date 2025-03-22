/*
 * Created on: 03/17/2025
 * Last modified on: 03/23/2025
 * Author: A1EX
 * GitHub: https://github.com/GeekInTheBedroom
 */

using System.Media;
using winMaker_dotnet.DefaultEditor;

namespace winMaker_dotnet.Sub_menu
{
    public partial class MenuCreate : UserControl
    {
        public MenuCreate()
        {
            InitializeComponent();
        }

        // Detect forbidden characters
        private void BoxName_TextChanged(object sender, EventArgs e)
        {
            foreach (char c in BoxName.Text)
            {
                if (char.IsLetterOrDigit(c) != true)
                {
                    BoxName.Text = "";
                    MessageBox.Show("Only letters and digits allowed.", "Project Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Show the folder browser
        private void ButtonDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ProjectFolder = new();
            ProjectFolder.ShowDialog();
            BoxDirectory.Text = ProjectFolder.SelectedPath;
        }

        // Create the project
        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            // If project name isn't empty
            if (BoxName.Text != string.Empty)
            {
                // Set project name
                string ProjectName;
                ProjectName = BoxName.Text;

                // If a directory with the same name as the project name already exist
                if (Directory.Exists(@$"{BoxDirectory.Text}\{ProjectName}"))
                {
                    MessageBox.Show("A directory with this project name already exist.", "Project Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // If the path(project directory location) doesn't exist
                else if (!Directory.Exists(BoxDirectory.Text) || ProjectName == string.Empty)
                {
                    MessageBox.Show("Choosen directory is empty or doesn't exist.", "Project Directory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // If project name isn't empty and the path(project directory location) exists
                else
                {
                    // Set project path
                    string ProjectPath;
                    ProjectPath = @$"{BoxDirectory.Text}\{ProjectName}";

                    // Create the project directory
                    Directory.CreateDirectory(ProjectPath);

                    // Create the project files
                    File.Create(@$"{ProjectPath}\{ProjectName}.wmcodes"); // Codes file
                    File.Create(@$"{ProjectPath}\{ProjectName}.wmnodes"); // Nodes file

                    // Open the project
                    Editor editor = new()
                    {
                        LoadProjectName = ProjectName,
                        ProjectCodePath = $@"{ProjectPath}\{ProjectName}.wmcodes",
                        ProjectNodePath = $@"{ProjectPath}\{ProjectName}.wmnodes"
                    };
                    editor.Show();
                }
            }
            else
            {
                MessageBox.Show("Project name can't be empty.", "Project Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
