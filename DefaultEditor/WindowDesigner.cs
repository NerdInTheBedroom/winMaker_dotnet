/*
 * Created on: 05/11/2025
 * Last modified on: 05/13/2025
 * Author: A1EX
 */
using winMaker_dotnet.DefaultEditor.Scriptings;

namespace winMaker_dotnet.DefaultEditor
{
    public partial class WindowDesigner : UserControl
    {
        public required string DesignerScriptPath;
        public WindowDesigner()
        {
            InitializeComponent();
        }
        #region Load designing script
        public string Script = string.Empty;
        private void WindowDesigner_Load(object sender, EventArgs e)
        {
            // Set path to property label
            LabelDesignPath.Text = $"Path: {DesignerScriptPath}";

            // Read the script
            StreamReader ReadDesign = new(DesignerScriptPath);
            Script = ReadDesign.ReadToEnd();
            ReadDesign.Close();
            BoxDesginScript.Text = Script;
        }
        #endregion
        #region Show/Hide designer script
        private void CheckDesignCode_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckDesignCode.Checked == true)
                DesignerEditor.Panel2Collapsed = false;
            else
                DesignerEditor.Panel2Collapsed = true;
        }
        #endregion
        #region Execute designing script and draw*
        private void BoxDesginScript_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F7)
            {
                // Overwrite the designer script file
                Script = BoxDesginScript.Text;
                StreamWriter WriteDesign = new(DesignerScriptPath);
                WriteDesign.WriteLine(Script);
                WriteDesign.Close();

                // Draw the panel
                Scriptings.DesigningScript Designer = new();
                
            }
        }
        #endregion


    }
}
