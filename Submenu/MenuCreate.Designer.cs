/*
 * Created on: 03/17/2025
 * Last modified on: 03/23/2025
 * Author: A1EX
 * GitHub: https://github.com/GeekInTheBedroom
 */

namespace winMaker_dotnet.Sub_menu
{
    partial class MenuCreate
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LayoutMenu = new TableLayoutPanel();
            ButtonCreate = new Button();
            BoxDirectory = new TextBox();
            BoxName = new TextBox();
            LabelName = new Label();
            ButtonDirectory = new Button();
            ComboType = new ComboBox();
            LayoutMenu.SuspendLayout();
            SuspendLayout();
            // 
            // LayoutMenu
            // 
            LayoutMenu.BackColor = Color.Transparent;
            LayoutMenu.ColumnCount = 1;
            LayoutMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            LayoutMenu.Controls.Add(ButtonCreate, 0, 5);
            LayoutMenu.Controls.Add(BoxDirectory, 0, 2);
            LayoutMenu.Controls.Add(BoxName, 0, 0);
            LayoutMenu.Controls.Add(LabelName, 0, 1);
            LayoutMenu.Controls.Add(ButtonDirectory, 0, 3);
            LayoutMenu.Controls.Add(ComboType, 0, 4);
            LayoutMenu.Dock = DockStyle.Fill;
            LayoutMenu.Location = new Point(0, 0);
            LayoutMenu.Name = "LayoutMenu";
            LayoutMenu.RowCount = 6;
            LayoutMenu.RowStyles.Add(new RowStyle());
            LayoutMenu.RowStyles.Add(new RowStyle());
            LayoutMenu.RowStyles.Add(new RowStyle());
            LayoutMenu.RowStyles.Add(new RowStyle());
            LayoutMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 77.04918F));
            LayoutMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 22.950819F));
            LayoutMenu.Size = new Size(475, 432);
            LayoutMenu.TabIndex = 0;
            // 
            // ButtonCreate
            // 
            ButtonCreate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            ButtonCreate.BackColor = Color.SeaGreen;
            ButtonCreate.FlatAppearance.BorderColor = Color.MediumAquamarine;
            ButtonCreate.FlatAppearance.MouseOverBackColor = Color.MediumSeaGreen;
            ButtonCreate.FlatStyle = FlatStyle.Popup;
            ButtonCreate.Location = new Point(160, 380);
            ButtonCreate.Margin = new Padding(6);
            ButtonCreate.Name = "ButtonCreate";
            ButtonCreate.Size = new Size(155, 46);
            ButtonCreate.TabIndex = 5;
            ButtonCreate.Text = "Create project";
            ButtonCreate.UseVisualStyleBackColor = false;
            ButtonCreate.Click += ButtonCreate_Click;
            // 
            // BoxDirectory
            // 
            BoxDirectory.BackColor = Color.Silver;
            BoxDirectory.BorderStyle = BorderStyle.None;
            BoxDirectory.Dock = DockStyle.Fill;
            BoxDirectory.Font = new Font("Cordia New", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BoxDirectory.Location = new Point(3, 105);
            BoxDirectory.MaxLength = 0;
            BoxDirectory.Name = "BoxDirectory";
            BoxDirectory.PlaceholderText = "Project directory";
            BoxDirectory.ReadOnly = true;
            BoxDirectory.Size = new Size(469, 32);
            BoxDirectory.TabIndex = 2;
            // 
            // BoxName
            // 
            BoxName.BackColor = Color.Silver;
            BoxName.BorderStyle = BorderStyle.None;
            BoxName.Dock = DockStyle.Fill;
            BoxName.Font = new Font("Cordia New", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BoxName.Location = new Point(3, 3);
            BoxName.MaxLength = 25;
            BoxName.Name = "BoxName";
            BoxName.PlaceholderText = "Project name";
            BoxName.Size = new Size(469, 32);
            BoxName.TabIndex = 0;
            BoxName.TextChanged += BoxName_TextChanged;
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.ForeColor = Color.DarkGray;
            LabelName.Location = new Point(3, 38);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(462, 64);
            LabelName.TabIndex = 1;
            LabelName.Text = "*A project name must have 10-25 characters. Only letters and digits allowed.\r\n";
            // 
            // ButtonDirectory
            // 
            ButtonDirectory.BackColor = Color.Gray;
            ButtonDirectory.FlatAppearance.BorderColor = Color.LightGray;
            ButtonDirectory.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            ButtonDirectory.FlatStyle = FlatStyle.Popup;
            ButtonDirectory.Location = new Point(3, 143);
            ButtonDirectory.Name = "ButtonDirectory";
            ButtonDirectory.Size = new Size(155, 37);
            ButtonDirectory.TabIndex = 3;
            ButtonDirectory.Text = "Choose a directory";
            ButtonDirectory.UseVisualStyleBackColor = false;
            ButtonDirectory.Click += ButtonDirectory_Click;
            // 
            // ComboType
            // 
            ComboType.BackColor = Color.Silver;
            ComboType.FlatStyle = FlatStyle.Flat;
            ComboType.FormattingEnabled = true;
            ComboType.Items.AddRange(new object[] { "Console Application", "Window Desktop Aplication" });
            ComboType.Location = new Point(3, 186);
            ComboType.Name = "ComboType";
            ComboType.Size = new Size(220, 40);
            ComboType.TabIndex = 4;
            ComboType.Text = "Select your project type";
            // 
            // MenuCreate
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(50, 50, 50);
            Controls.Add(LayoutMenu);
            Font = new Font("Cordia New", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "MenuCreate";
            Size = new Size(475, 432);
            LayoutMenu.ResumeLayout(false);
            LayoutMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel LayoutMenu;
        private TextBox BoxName;
        private Label LabelName;
        private TextBox BoxDirectory;
        private Button ButtonDirectory;
        private ComboBox ComboType;
        private Button ButtonCreate;
    }
}
