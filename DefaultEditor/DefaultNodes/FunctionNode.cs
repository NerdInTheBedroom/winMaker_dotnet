/*
 * Created on: 03/23/2025
 * Last modified on: 03/23/2025
 * Author: A1EX
 * GitHub: https://github.com/GeekInTheBedroom
 */

using System.ComponentModel;

namespace winMaker_dotnet.DefaultEditor.DefaultNodes
{
    public partial class FunctionNode : Component
    {
        public FunctionNode()
        {
            InitializeComponent();
        }

        public FunctionNode(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
