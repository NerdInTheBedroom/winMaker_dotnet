/*
 * Created on: 03/20/2025
 * Last modified on: 03/23/2025
 * Author: A1EX
 * GitHub: https://github.com/GeekInTheBedroom/winMaker_dotnet
 */

using winMaker_dotnet.DefaultEditor;

namespace winMaker_dotnet.Sub_menu
{
    public partial class MenuOpen : UserControl
    {
        public string ProjectName = "", ProjectPath = "";
        public MenuOpen()
        {
            InitializeComponent();
        }

        // Open file browser for opening the project
        private void ButtonProject_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ProjectFolder = new();
            ProjectFolder.ShowDialog();
            BoxDirectory.Text = ProjectFolder.SelectedPath;
            ProjectPath = BoxDirectory.Text;
            ProjectName = Path.GetFileName(ProjectPath);

            // Check if the folder contains project files(Codes, Nodes)
            if (!File.Exists($@"{ProjectPath}\{ProjectName}.wmcodes") && !File.Exists($@"{ProjectPath}\{ProjectName}.wmnodes"))
            {
                MessageBox.Show("This folder doesn't have Codes file or Nodes file.", "Project Folder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Reset everything
                BoxDirectory.Text = string.Empty;
                ProjectPath = string.Empty;
                ProjectName = string.Empty;
            }
        }

        // Open the project in the editor
        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            Editor editor = new()
            {
                LoadProjectName = ProjectName,
                ProjectCodePath = @$"{ProjectPath}\{ProjectName}.wmcodes",
                ProjectNodePath = $@"{ProjectPath}\{ProjectName}.wmnodes"
            };
            editor.Show();
        }
    }
}
