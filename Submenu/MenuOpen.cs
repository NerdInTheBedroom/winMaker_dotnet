/*
 * Created on: 03/20/2025
 * Last modified on: 05/12/2025
 * Author: A1EX
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

        #region Open file browser for opening the project
        private void ButtonProject_Click(object sender, EventArgs e)
        {
            OpenFileDialog ProjectFile = new();
            ProjectFile.ShowDialog();
            ProjectFile.DefaultExt = ".wmproj";
            ProjectFile.Filter = "winMaker.NET (.wmproj)|*.wmproj";
            BoxDirectory.Text = ProjectFile.FileName;
            ProjectPath = BoxDirectory.Text;

            // Check if the file exists
            if (!File.Exists(ProjectPath))
            {
                MessageBox.Show("The file you selected doesn't exist.", "Project File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Reset everything
                BoxDirectory.Text = string.Empty;
                ProjectPath = string.Empty;
                ProjectName = string.Empty;
            }
        }
        #endregion
        #region Open the project in the editor
        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            // Check if loader has all paths
            StreamReader ReadLoader = new(ProjectPath);
            string[] Parts = ReadLoader.ReadToEnd().Split((char)31, StringSplitOptions.None);
            if (Parts.Length != 4)
            {
                MessageBox.Show("The project loader doesn't contain every paths.", "Project Loader", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // i = 1 to skip the first part(project name)
                for (int i = 1; i < Parts.Length - 1; i++)
                {
                    if (!File.Exists(Parts[i]))
                    {
                        MessageBox.Show($"File that doesn't exist in the project: {Parts[i]}", "Project Loader", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                
                // If everything is fine, open the project
                Editor editor = new()
                {
                    ProjectLoaderPath = ProjectPath
                };
                editor.Show();
            }
        }
        #endregion
    }
}
