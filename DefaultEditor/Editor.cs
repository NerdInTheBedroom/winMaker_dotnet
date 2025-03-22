/*
 * Created on: 03/21/2025
 * Last modified on: 03/22/2025
 * Author: A1EX
 * GitHub: https://github.com/GeekInTheBedroom
 */

namespace winMaker_dotnet.DefaultEditor
{
    public partial class Editor : Form
    {
        public string LoadProjectName = "";
        public string LoadProjectPath = "";

        public string ProjectNodePath, ProjectCodePath;

        public Editor()
        {
            InitializeComponent();

            string[] Paths = LoadProjectPath.Split('\n', StringSplitOptions.RemoveEmptyEntries); // Parse into two paths(Node and Code)
            ProjectNodePath = Paths[0].Replace('\\', '/');
            ProjectCodePath = Paths[1].Replace('\\', '/');
        }

        private void Editor_Load(object sender, EventArgs e)
        {
            Text = $"{LoadProjectName} - winMaker.NET(Default Editor)"; // Set editor's title to project name
        }
    }
}
