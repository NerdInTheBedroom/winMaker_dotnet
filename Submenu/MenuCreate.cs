/*
 * Created on: 03/17/2025
 * Last modified on: 05/13/2025
 * Author: A1EX
 */

using winMaker_dotnet.DefaultEditor;

namespace winMaker_dotnet.Sub_menu
{
    public partial class MenuCreate : UserControl
    {
        public MenuCreate()
        {
            InitializeComponent();
        }

        #region Detect forbidden characters
        private void BoxName_TextChanged(object sender, EventArgs e)
        {
            foreach (char c in BoxName.Text)
            {
                if (char.IsLetterOrDigit(c) != true)
                {
                    BoxName.Text = string.Empty;
                    MessageBox.Show("Only letters and digits allowed.", "Project Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion
        #region Open the folder browser
        private void ButtonDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ProjectFolderDialog = new();
            ProjectFolderDialog.ShowDialog();
            BoxDirectory.Text = ProjectFolderDialog.SelectedPath;
        }
        #endregion
        #region Create the project
        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            // If everything is filled
            if (BoxName.Text != string.Empty && BoxDirectory.Text != string.Empty)
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
                else if (!Directory.Exists(BoxDirectory.Text))
                {
                    MessageBox.Show("Choosen directory is empty or doesn't exist.", "Project Directory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // If everything is fine
                else
                {
                    char Separator = (char)31;

                    // Set project path
                    string ProjectPath;
                    ProjectPath = @$"{BoxDirectory.Text}\{ProjectName}";
                    // Create the project directory
                    Directory.CreateDirectory(ProjectPath);

                    string MainScriptPath, MainCodePath, MainDesignerPath;
                    MainScriptPath = @$"{ProjectPath}\main.smic";
                    MainCodePath = @$"{ProjectPath}\main.smic.cs";
                    MainDesignerPath = $@"{ProjectPath}\main.draw.smic";

                    // Main script file(.smic)
                    StreamWriter MainScriptFile = new(MainScriptPath);
                    MainScriptFile.Write("winShow(Main)");
                    MainScriptFile.Close();
                    // Main translated script file to C#(.smic.cs)
                    StreamWriter MainCodeFile = new(MainCodePath);
                    MainCodeFile.Write("// Will be written when project is built");
                    MainCodeFile.Close();
                    // Main designer script(.draw.smic)
                    StreamWriter MainDesignerFile = new(MainDesignerPath);
                    MainDesignerFile.Write("window Main");
                    MainDesignerFile.Close();
                    // Project loader file(.wmproj)
                    StreamWriter ProjectLoader = new($@"{ProjectPath}\{ProjectName}.wmproj");
                    ProjectLoader.Write($"{ProjectName}{Separator}{MainScriptPath}{Separator}{MainCodePath}{Separator}{MainDesignerPath}"); // Simple method
                    ProjectLoader.Close();

                    // Open the project
                    Editor editor = new()
                    {
                        ProjectLoaderPath = $@"{ProjectPath}\{ProjectName}.wmproj"
                    };
                    editor.Show();
                }
            }
            else
            {
                MessageBox.Show("Did you fill anything? Check again.", "Create Project", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
