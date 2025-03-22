/*
 * Created on: 03/21/2025
 * Last modified on: 03/23/2025
 * Author: A1EX
 * GitHub: https://github.com/GeekInTheBedroom
 */

using System.Diagnostics.Eventing.Reader;

namespace winMaker_dotnet.DefaultEditor
{
    public partial class Editor : Form
    {
        public required string LoadProjectName, ProjectCodePath, ProjectNodePath;

        public Editor()
        {
            InitializeComponent();
        }

        // Set editor's title to project name
        private void Editor_Load(object sender, EventArgs e)
        {
            Text = $"{LoadProjectName} - winMaker.NET(Default Editor)";
        }
    }
}
