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
            EditorContainer = new SplitContainer();
            ProjectContainer = new SplitContainer();
            ListBoxFunctions = new ListBox();
            TablePanelFunctions = new TableLayoutPanel();
            ButtonDeleteFunction = new Button();
            BoxFunction = new TextBox();
            ButtonCreateFunction = new Button();
            EditorTab = new TabControl();
            MainEditor = new TabPage();
            EditorStatus = new StatusStrip();
            LabelCursor = new ToolStripStatusLabel();
            PanelEditor = new Panel();
            CustomEditorTab = new TabPage();
            ((System.ComponentModel.ISupportInitialize)EditorContainer).BeginInit();
            EditorContainer.Panel1.SuspendLayout();
            EditorContainer.Panel2.SuspendLayout();
            EditorContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProjectContainer).BeginInit();
            ProjectContainer.Panel1.SuspendLayout();
            ProjectContainer.SuspendLayout();
            TablePanelFunctions.SuspendLayout();
            EditorTab.SuspendLayout();
            MainEditor.SuspendLayout();
            EditorStatus.SuspendLayout();
            SuspendLayout();
            // 
            // EditorContainer
            // 
            EditorContainer.BackColor = Color.Transparent;
            EditorContainer.Dock = DockStyle.Fill;
            EditorContainer.Location = new Point(0, 0);
            EditorContainer.Name = "EditorContainer";
            // 
            // EditorContainer.Panel1
            // 
            EditorContainer.Panel1.BackColor = Color.FromArgb(48, 48, 48);
            EditorContainer.Panel1.Controls.Add(ProjectContainer);
            EditorContainer.Panel1MinSize = 300;
            // 
            // EditorContainer.Panel2
            // 
            EditorContainer.Panel2.BackColor = Color.FromArgb(72, 72, 72);
            EditorContainer.Panel2.Controls.Add(EditorTab);
            EditorContainer.Panel2MinSize = 400;
            EditorContainer.Size = new Size(842, 493);
            EditorContainer.SplitterDistance = 300;
            EditorContainer.SplitterIncrement = 5;
            EditorContainer.TabIndex = 0;
            // 
            // ProjectContainer
            // 
            ProjectContainer.BackColor = Color.Transparent;
            ProjectContainer.Dock = DockStyle.Fill;
            ProjectContainer.ForeColor = Color.White;
            ProjectContainer.Location = new Point(0, 0);
            ProjectContainer.Name = "ProjectContainer";
            ProjectContainer.Orientation = Orientation.Horizontal;
            // 
            // ProjectContainer.Panel1
            // 
            ProjectContainer.Panel1.Controls.Add(ListBoxFunctions);
            ProjectContainer.Panel1.Controls.Add(TablePanelFunctions);
            ProjectContainer.Panel1MinSize = 180;
            ProjectContainer.Panel2MinSize = 180;
            ProjectContainer.Size = new Size(300, 493);
            ProjectContainer.SplitterDistance = 246;
            ProjectContainer.TabIndex = 0;
            // 
            // ListBoxFunctions
            // 
            ListBoxFunctions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ListBoxFunctions.BackColor = Color.FromArgb(48, 48, 48);
            ListBoxFunctions.BorderStyle = BorderStyle.FixedSingle;
            ListBoxFunctions.ForeColor = Color.WhiteSmoke;
            ListBoxFunctions.FormattingEnabled = true;
            ListBoxFunctions.Location = new Point(5, 39);
            ListBoxFunctions.Name = "ListBoxFunctions";
            ListBoxFunctions.Size = new Size(290, 202);
            ListBoxFunctions.TabIndex = 1;
            // 
            // TablePanelFunctions
            // 
            TablePanelFunctions.BackColor = Color.FromArgb(40, 40, 40);
            TablePanelFunctions.ColumnCount = 3;
            TablePanelFunctions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TablePanelFunctions.ColumnStyles.Add(new ColumnStyle());
            TablePanelFunctions.ColumnStyles.Add(new ColumnStyle());
            TablePanelFunctions.Controls.Add(ButtonDeleteFunction, 2, 0);
            TablePanelFunctions.Controls.Add(BoxFunction, 0, 0);
            TablePanelFunctions.Controls.Add(ButtonCreateFunction, 1, 0);
            TablePanelFunctions.Dock = DockStyle.Top;
            TablePanelFunctions.Location = new Point(0, 0);
            TablePanelFunctions.Name = "TablePanelFunctions";
            TablePanelFunctions.RowCount = 1;
            TablePanelFunctions.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TablePanelFunctions.Size = new Size(300, 34);
            TablePanelFunctions.TabIndex = 0;
            // 
            // ButtonDeleteFunction
            // 
            ButtonDeleteFunction.BackColor = Color.FromArgb(48, 48, 48);
            ButtonDeleteFunction.FlatAppearance.BorderColor = Color.FromArgb(84, 84, 84);
            ButtonDeleteFunction.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 84, 84);
            ButtonDeleteFunction.FlatStyle = FlatStyle.Popup;
            ButtonDeleteFunction.Image = Properties.Resources.trash;
            ButtonDeleteFunction.Location = new Point(269, 3);
            ButtonDeleteFunction.Name = "ButtonDeleteFunction";
            ButtonDeleteFunction.Size = new Size(28, 28);
            ButtonDeleteFunction.TabIndex = 2;
            ButtonDeleteFunction.UseVisualStyleBackColor = false;
            // 
            // BoxFunction
            // 
            BoxFunction.BackColor = Color.FromArgb(64, 64, 64);
            BoxFunction.BorderStyle = BorderStyle.FixedSingle;
            BoxFunction.Dock = DockStyle.Fill;
            BoxFunction.ForeColor = Color.White;
            BoxFunction.Location = new Point(3, 3);
            BoxFunction.Name = "BoxFunction";
            BoxFunction.PlaceholderText = "Custom function name";
            BoxFunction.Size = new Size(226, 27);
            BoxFunction.TabIndex = 0;
            // 
            // ButtonCreateFunction
            // 
            ButtonCreateFunction.BackColor = Color.FromArgb(48, 48, 48);
            ButtonCreateFunction.FlatAppearance.BorderColor = Color.FromArgb(84, 84, 84);
            ButtonCreateFunction.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 84, 84);
            ButtonCreateFunction.FlatStyle = FlatStyle.Popup;
            ButtonCreateFunction.Image = Properties.Resources.plus;
            ButtonCreateFunction.Location = new Point(235, 3);
            ButtonCreateFunction.Name = "ButtonCreateFunction";
            ButtonCreateFunction.Size = new Size(28, 28);
            ButtonCreateFunction.TabIndex = 1;
            ButtonCreateFunction.UseVisualStyleBackColor = false;
            // 
            // EditorTab
            // 
            EditorTab.Controls.Add(MainEditor);
            EditorTab.Controls.Add(CustomEditorTab);
            EditorTab.Dock = DockStyle.Fill;
            EditorTab.ImeMode = ImeMode.NoControl;
            EditorTab.Location = new Point(0, 0);
            EditorTab.Name = "EditorTab";
            EditorTab.SelectedIndex = 0;
            EditorTab.Size = new Size(538, 493);
            EditorTab.TabIndex = 0;
            // 
            // MainEditor
            // 
            MainEditor.BackColor = Color.FromArgb(72, 72, 72);
            MainEditor.Controls.Add(EditorStatus);
            MainEditor.Controls.Add(PanelEditor);
            MainEditor.Location = new Point(4, 29);
            MainEditor.Name = "MainEditor";
            MainEditor.Padding = new Padding(3);
            MainEditor.Size = new Size(530, 460);
            MainEditor.TabIndex = 0;
            MainEditor.Text = "Main";
            // 
            // EditorStatus
            // 
            EditorStatus.BackColor = Color.FromArgb(48, 48, 48);
            EditorStatus.Font = new Font("Courier New", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EditorStatus.ImageScalingSize = new Size(20, 20);
            EditorStatus.Items.AddRange(new ToolStripItem[] { LabelCursor });
            EditorStatus.Location = new Point(3, 435);
            EditorStatus.Name = "EditorStatus";
            EditorStatus.Size = new Size(524, 22);
            EditorStatus.TabIndex = 1;
            EditorStatus.Text = "Activity Status";
            // 
            // LabelCursor
            // 
            LabelCursor.BackColor = Color.Transparent;
            LabelCursor.ForeColor = Color.WhiteSmoke;
            LabelCursor.Name = "LabelCursor";
            LabelCursor.Size = new Size(55, 16);
            LabelCursor.Text = "(0, 0)";
            // 
            // PanelEditor
            // 
            PanelEditor.BackColor = Color.FromArgb(36, 36, 36);
            PanelEditor.BorderStyle = BorderStyle.FixedSingle;
            PanelEditor.Dock = DockStyle.Fill;
            PanelEditor.Location = new Point(3, 3);
            PanelEditor.Name = "PanelEditor";
            PanelEditor.Size = new Size(524, 454);
            PanelEditor.TabIndex = 0;
            // 
            // CustomEditorTab
            // 
            CustomEditorTab.BackColor = Color.FromArgb(64, 64, 64);
            CustomEditorTab.Location = new Point(4, 29);
            CustomEditorTab.Name = "CustomEditorTab";
            CustomEditorTab.Padding = new Padding(3);
            CustomEditorTab.Size = new Size(530, 460);
            CustomEditorTab.TabIndex = 1;
            CustomEditorTab.Text = "Custom";
            // 
            // Editor
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Gray;
            ClientSize = new Size(842, 493);
            Controls.Add(EditorContainer);
            Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            Margin = new Padding(5, 4, 5, 4);
            MinimumSize = new Size(860, 540);
            Name = "Editor";
            Text = "Editor";
            WindowState = FormWindowState.Maximized;
            Load += Editor_Load;
            EditorContainer.Panel1.ResumeLayout(false);
            EditorContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)EditorContainer).EndInit();
            EditorContainer.ResumeLayout(false);
            ProjectContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ProjectContainer).EndInit();
            ProjectContainer.ResumeLayout(false);
            TablePanelFunctions.ResumeLayout(false);
            TablePanelFunctions.PerformLayout();
            EditorTab.ResumeLayout(false);
            MainEditor.ResumeLayout(false);
            MainEditor.PerformLayout();
            EditorStatus.ResumeLayout(false);
            EditorStatus.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer EditorContainer;
        private TabControl EditorTab;
        private TabPage MainEditor;
        private TabPage CustomEditorTab;
        private Panel PanelEditor;
        private StatusStrip EditorStatus;
        private ToolStripStatusLabel LabelCursor;
        private SplitContainer ProjectContainer;
        private TableLayoutPanel TablePanelFunctions;
        private TextBox BoxFunction;
        private Button ButtonCreateFunction;
        private ListBox ListBoxFunctions;
        private Button ButtonDeleteFunction;
    }
}