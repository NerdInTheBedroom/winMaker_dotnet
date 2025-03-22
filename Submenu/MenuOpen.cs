/*
 * Created on: 03/20/2025
 * Last modified on: 03/22/2025
 * Author: A1EX
 * GitHub: https://github.com/GeekInTheBedroom/winMaker_dotnet
 */

using winMaker_dotnet.DefaultEditor;

namespace winMaker_dotnet.Sub_menu
{
    public partial class MenuOpen : UserControl
    {
        public string ProjectName = "";
        public MenuOpen()
        {
            InitializeComponent();
        }

        // Open file browser for opening the project
        private void ButtonProject_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenProject = new()
            {
                DefaultExt = ".wmp",
                Filter = "winMaker.NET Project (.wmp)|*.wmp"
            };
            if (DialogResult.OK == OpenProject.ShowDialog())
            {
                ProjectName = OpenProject.FileName; // Project Name
                BoxDirectory.Text = Path.GetFullPath(OpenProject.FileName); // Project Path
            }
        }

        // Open the project in the editor
        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            Editor editor = new()
            {
                LoadProjectName = ProjectName,
                LoadProjectPath = BoxDirectory.Text
            };
            editor.Show();
        }
    }
}
