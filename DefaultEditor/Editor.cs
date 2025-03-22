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

        #region Functions and Variables panel
        // Checking for forbidden character in function name and variable name
        private void BoxFunction_TextChanged(object sender, EventArgs e)
        {
            foreach (char c in BoxFunction.Text)
            {
                if (char.IsLetterOrDigit(c) != true || char.IsWhiteSpace(c) == true)
                {
                    BoxFunction.Text = "";
                    MessageBox.Show("A function name only contains letters and numbers.", "Function Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BoxVariable_TextChanged(object sender, EventArgs e)
        {
            foreach (char c in BoxVariable.Text)
            {
                if (char.IsLetterOrDigit(c) != true || char.IsWhiteSpace(c) == true)
                {
                    BoxVariable.Text = "";
                    MessageBox.Show("A variable name only contains letters and numbers.", "Variable Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Create function and variable
        private void ButtonCreateFunction_Click(object sender, EventArgs e)
        {
            if (ListBoxFunctions.Items.Contains(BoxFunction.Text))
            {
                MessageBox.Show("A function with this name already exists.", "Function Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ListBoxFunctions.Items.Add(BoxFunction.Text);
            }
        }

        private void ButtonCreateVariable_Click(object sender, EventArgs e)
        {
            if (ListBoxVariables.Items.Contains(BoxVariable.Text))
            {
                MessageBox.Show("A variable with this name already exists.", "Variable Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ListBoxVariables.Items.Add(BoxVariable.Text);
            }
        }
        #endregion
    }
}
