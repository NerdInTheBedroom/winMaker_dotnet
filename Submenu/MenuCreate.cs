/*
 * Created on: 03/17/2025
 * Last modified on: 03/21/2025
 * Author: A1EX
 * GitHub: https://github.com/GeekInTheBedroom
 */

using System.Media;

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
                if (char.IsLetter(c) != true)
                {
                    BoxName.Text = "";
                    SystemSounds.Hand.Play();
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
                // Set project path
                string ProjectPath;
                ProjectPath = $"{BoxDirectory.Text}/{ProjectName}";

                // If project directory isn't empty and exists
                if (Directory.Exists(BoxDirectory.Text) && ProjectName != string.Empty)
                {
                    // Create the project directory
                    Directory.CreateDirectory(ProjectPath);

                    // Create a directory for the project files inside the directory
                    Directory.CreateDirectory($"{ProjectPath}/src");
                    // Create the project files
                    File.Create($"{ProjectPath}/src/{ProjectName}.wmnodes"); // Nodes file
                    File.Create($"{ProjectPath}/src/{ProjectName}.wmcodes"); // Codes file

                    // Create the project loader
                    StreamWriter ProjectLoader = new StreamWriter($"{ProjectPath}/{ProjectName}.wmp");
                    ProjectLoader.Write($"{ProjectPath}/src/{ProjectName}.wmnodes\n{ProjectPath}/src/{ProjectName}.wmcodes"); // Nodes, Codes
                }
                else
                {
                    MessageBox.Show("Choosen directory is empty or doesn't exist.", "Project Directory", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Project name can't be empty.", "Project Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
