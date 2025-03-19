namespace winMaker_dotnet.Sub_menu
{
    partial class MenuOpen
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
            BoxDirectory = new TextBox();
            ButtonOpen = new Button();
            ButtonProject = new Button();
            SuspendLayout();
            // 
            // BoxDirectory
            // 
            BoxDirectory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BoxDirectory.BackColor = Color.Silver;
            BoxDirectory.BorderStyle = BorderStyle.None;
            BoxDirectory.Font = new Font("Cordia New", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BoxDirectory.Location = new Point(3, 3);
            BoxDirectory.MaxLength = 0;
            BoxDirectory.Name = "BoxDirectory";
            BoxDirectory.PlaceholderText = "Choose the project loader (.wmp)";
            BoxDirectory.ReadOnly = true;
            BoxDirectory.Size = new Size(469, 32);
            BoxDirectory.TabIndex = 0;
            // 
            // ButtonOpen
            // 
            ButtonOpen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ButtonOpen.BackColor = Color.SeaGreen;
            ButtonOpen.FlatAppearance.BorderColor = Color.MediumAquamarine;
            ButtonOpen.FlatAppearance.MouseOverBackColor = Color.MediumSeaGreen;
            ButtonOpen.FlatStyle = FlatStyle.Popup;
            ButtonOpen.Location = new Point(317, 41);
            ButtonOpen.Margin = new Padding(6);
            ButtonOpen.Name = "ButtonOpen";
            ButtonOpen.Size = new Size(155, 46);
            ButtonOpen.TabIndex = 2;
            ButtonOpen.Text = "Open project";
            ButtonOpen.UseVisualStyleBackColor = false;
            // 
            // ButtonProject
            // 
            ButtonProject.BackColor = Color.Gray;
            ButtonProject.FlatAppearance.BorderColor = Color.LightGray;
            ButtonProject.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            ButtonProject.FlatStyle = FlatStyle.Popup;
            ButtonProject.Location = new Point(3, 41);
            ButtonProject.Name = "ButtonProject";
            ButtonProject.Size = new Size(151, 37);
            ButtonProject.TabIndex = 1;
            ButtonProject.Text = "Choose the project";
            ButtonProject.UseVisualStyleBackColor = false;
            // 
            // MenuOpen
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(50, 62, 75);
            Controls.Add(ButtonProject);
            Controls.Add(ButtonOpen);
            Controls.Add(BoxDirectory);
            Font = new Font("Cordia New", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 5, 3, 5);
            Name = "MenuOpen";
            Size = new Size(475, 432);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox BoxDirectory;
        private Button ButtonOpen;
        private Button ButtonProject;
    }
}
