namespace winMaker_dotnet.DefaultEditor
{
    partial class Editor
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            EditorToolTip = new ToolTip(components);
            EditorTab = new TabControl();
            DesignerMain = new TabPage();
            CodeMain = new TabPage();
            TabsPage = new TabPage();
            EditorTab.SuspendLayout();
            SuspendLayout();
            // 
            // EditorToolTip
            // 
            EditorToolTip.BackColor = Color.FromArgb(28, 28, 28);
            EditorToolTip.ForeColor = Color.White;
            // 
            // EditorTab
            // 
            EditorTab.Controls.Add(DesignerMain);
            EditorTab.Controls.Add(CodeMain);
            EditorTab.Controls.Add(TabsPage);
            EditorTab.Dock = DockStyle.Fill;
            EditorTab.ImeMode = ImeMode.NoControl;
            EditorTab.Location = new Point(0, 0);
            EditorTab.Name = "EditorTab";
            EditorTab.SelectedIndex = 0;
            EditorTab.Size = new Size(843, 437);
            EditorTab.TabIndex = 1;
            // 
            // DesignerMain
            // 
            DesignerMain.BackColor = Color.FromArgb(48, 48, 48);
            DesignerMain.Location = new Point(4, 29);
            DesignerMain.Name = "DesignerMain";
            DesignerMain.Padding = new Padding(3);
            DesignerMain.Size = new Size(835, 404);
            DesignerMain.TabIndex = 0;
            DesignerMain.Text = "Main(Design)";
            // 
            // CodeMain
            // 
            CodeMain.BackColor = Color.FromArgb(48, 48, 48);
            CodeMain.Location = new Point(4, 29);
            CodeMain.Name = "CodeMain";
            CodeMain.Padding = new Padding(3);
            CodeMain.Size = new Size(835, 404);
            CodeMain.TabIndex = 2;
            CodeMain.Text = "Main(Code)";
            // 
            // TabsPage
            // 
            TabsPage.BackColor = Color.FromArgb(48, 48, 48);
            TabsPage.Location = new Point(4, 29);
            TabsPage.Name = "TabsPage";
            TabsPage.Padding = new Padding(3);
            TabsPage.Size = new Size(835, 404);
            TabsPage.TabIndex = 3;
            TabsPage.Text = "Tabs Manager";
            // 
            // Editor
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(48, 48, 48);
            ClientSize = new Size(843, 437);
            Controls.Add(EditorTab);
            Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            Margin = new Padding(5, 4, 5, 4);
            MinimumSize = new Size(860, 484);
            Name = "Editor";
            Text = "Editor";
            WindowState = FormWindowState.Maximized;
            Load += Editor_Load;
            EditorTab.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ToolTip EditorToolTip;
        private TabControl EditorTab;
        private TabPage DesignerMain;
        private TabPage CodeMain;
        private TabPage TabsPage;
    }
}