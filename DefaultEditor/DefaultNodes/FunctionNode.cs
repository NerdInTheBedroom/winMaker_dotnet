/*
 * Created on: 03/27/2025
 * Last modified on: 03/28/2025
 * Author: A1EX
 * GitHub: https://github.com/GeekInTheBedroom
 */

namespace winMaker_dotnet.DefaultEditor.DefaultNodes
{
    public class FunctionNode : Control
    {
        // Construct
        public FunctionNode()
        {
            Width = 150;
            Height = 50;
        }

        // Public Properties
        public string FunctionName = "Title";
        public string FunctionDescription = "Description";

        // Draw node
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            // Draw node border
            g.DrawRectangle(Pens.WhiteSmoke, 0, 0, Width, Height);
            g.FillRectangle(Brushes.White, 0, 0, Width, Height);

            // Draw node name
            g.DrawString(FunctionName, Font, Brushes.Transparent, 5, 5);
        }
    }
}
