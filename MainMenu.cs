/*
 * Created on: 03/17/2025
 * Last modified on: 03/20/2025
 * Author: A1EX
 */

using System.Diagnostics;
using winMaker_dotnet.Sub_menu;

namespace winMaker_dotnet
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        // Show create project submenu
        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            PanelSubMenu.Controls.Clear();
            PanelSubMenu.Controls.Add(new MenuCreate());
        }

        // Show open project submenu
        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            PanelSubMenu.Controls.Clear();
            PanelSubMenu.Controls.Add(new MenuOpen());
        }

        // Show online packages submenu
        private void ButtonInstall_Click(object sender, EventArgs e)
        {
            PanelSubMenu.Controls.Clear();
            PanelSubMenu.Controls.Add(new MenuPackages());
        }

        // Navigate to GitHub profile
        private void ButtonSupport_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "https://github.com/GeekInTheBedroom");
        }
    }
}
