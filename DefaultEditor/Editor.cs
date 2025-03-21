using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winMaker_dotnet.DefaultEditor
{
    public partial class Editor : Form
    {
        public string LoadProjectName = "";
        public string LoadProjectPath = "";

        public Editor()
        {
            InitializeComponent();
        }

        private void Editor_Load(object sender, EventArgs e)
        {
            Text = LoadProjectName; // Set editor's title to project name
        }
    }
}
