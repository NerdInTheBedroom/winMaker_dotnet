/*
 * Created on: 03/17/2025
 * Last modified on: 03/20/2025
 * Author: A1EX
 * GitHub: https://github.com/GeekInTheBedroom
 */

using System.Media;

namespace winMaker_dotnet.Sub_menu
{
    public partial class MenuCreate : UserControl
    {
        public MenuCreate()
        {
            InitializeComponent();
        }

        // Detect forbidden characters
        private void BoxName_TextChanged(object sender, EventArgs e)
        {
            foreach(char c in BoxName.Text)
            {
                if(char.IsLetter(c) != true)
                {
                    BoxName.Text = "";
                    SystemSounds.Hand.Play();
                }
            }
        }
    }
}
