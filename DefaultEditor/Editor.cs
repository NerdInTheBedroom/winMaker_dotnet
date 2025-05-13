/*
 * Created on: 03/21/2025
 * Last modified on: 05/13/2025
 * Author: A1EX
 */

namespace winMaker_dotnet.DefaultEditor
{
    public partial class Editor : Form
    {
        public required string ProjectLoaderPath;
        private string? ProjectName, MainScriptPath, MainCodePath, MainDesignerPath;

        public Editor()
        {
            InitializeComponent();
        }

        #region Parse project loader
        private void Editor_Load(object sender, EventArgs e)
        {
            // Read loader and parse
            StreamReader ProjectLoader = new(ProjectLoaderPath);
            string[] Paths = ProjectLoader.ReadToEnd().Split((char)31, StringSplitOptions.None);
            ProjectLoader.Close();

            // Assign parts to variables
            ProjectName = Paths[0];
            MainScriptPath = Paths[1];
            MainCodePath = Paths[2];
            MainDesignerPath = Paths[3];

            #region Double check file extension
            if (!MainScriptPath.EndsWith(".smic"))
            {
                MessageBox.Show($"Wrong file extension: {MainScriptPath}", "File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            if (!MainCodePath.EndsWith(".smic.cs"))
            {
                MessageBox.Show($"Wrong file extension: {MainCodePath}", "File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            if (!MainDesignerPath.EndsWith(".draw.smic"))
            {
                MessageBox.Show($"Wrong file extension: {MainDesignerPath}", "File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            #endregion
            // Everything is fine
            // Set title to project name
            Text = $"{ProjectName} - winMaker.NET(Default Editor)";
            // Set design path to window designer
            DesignerMain.Controls.Add(new WindowDesigner() { DesignerScriptPath = MainDesignerPath, Dock = DockStyle.Fill });
        }
        #endregion
    }
}
