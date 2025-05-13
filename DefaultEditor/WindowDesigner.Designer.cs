namespace winMaker_dotnet.DefaultEditor
{
    partial class WindowDesigner
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
            components = new System.ComponentModel.Container();
            DesignerContainer = new SplitContainer();
            DesignerEditor = new SplitContainer();
            CheckDesignCode = new CheckBox();
            PreviewPanel = new Panel();
            BoxDesginScript = new RichTextBox();
            DesignerSidebar = new TabControl();
            PropertiesPage = new TabPage();
            PropertiesTable = new TableLayoutPanel();
            LabelDesignPath = new Label();
            ToolboxPage = new TabPage();
            DesignerToolTip = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)DesignerContainer).BeginInit();
            DesignerContainer.Panel1.SuspendLayout();
            DesignerContainer.Panel2.SuspendLayout();
            DesignerContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DesignerEditor).BeginInit();
            DesignerEditor.Panel1.SuspendLayout();
            DesignerEditor.Panel2.SuspendLayout();
            DesignerEditor.SuspendLayout();
            DesignerSidebar.SuspendLayout();
            PropertiesPage.SuspendLayout();
            PropertiesTable.SuspendLayout();
            SuspendLayout();
            // 
            // DesignerContainer
            // 
            DesignerContainer.BackColor = Color.Transparent;
            DesignerContainer.BorderStyle = BorderStyle.FixedSingle;
            DesignerContainer.Dock = DockStyle.Fill;
            DesignerContainer.Location = new Point(0, 0);
            DesignerContainer.Name = "DesignerContainer";
            // 
            // DesignerContainer.Panel1
            // 
            DesignerContainer.Panel1.Controls.Add(DesignerEditor);
            DesignerContainer.Panel1MinSize = 300;
            // 
            // DesignerContainer.Panel2
            // 
            DesignerContainer.Panel2.Controls.Add(DesignerSidebar);
            DesignerContainer.Panel2MinSize = 100;
            DesignerContainer.Size = new Size(835, 404);
            DesignerContainer.SplitterDistance = 471;
            DesignerContainer.SplitterWidth = 3;
            DesignerContainer.TabIndex = 0;
            // 
            // DesignerEditor
            // 
            DesignerEditor.BorderStyle = BorderStyle.FixedSingle;
            DesignerEditor.Dock = DockStyle.Fill;
            DesignerEditor.Location = new Point(0, 0);
            DesignerEditor.Name = "DesignerEditor";
            DesignerEditor.Orientation = Orientation.Horizontal;
            // 
            // DesignerEditor.Panel1
            // 
            DesignerEditor.Panel1.AutoScroll = true;
            DesignerEditor.Panel1.Controls.Add(CheckDesignCode);
            DesignerEditor.Panel1.Controls.Add(PreviewPanel);
            DesignerEditor.Panel1MinSize = 250;
            // 
            // DesignerEditor.Panel2
            // 
            DesignerEditor.Panel2.Controls.Add(BoxDesginScript);
            DesignerEditor.Panel2Collapsed = true;
            DesignerEditor.Panel2MinSize = 150;
            DesignerEditor.Size = new Size(471, 404);
            DesignerEditor.SplitterDistance = 250;
            DesignerEditor.SplitterWidth = 2;
            DesignerEditor.TabIndex = 0;
            // 
            // CheckDesignCode
            // 
            CheckDesignCode.AutoSize = true;
            CheckDesignCode.Font = new Font("Courier New", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CheckDesignCode.Location = new Point(3, 3);
            CheckDesignCode.Name = "CheckDesignCode";
            CheckDesignCode.Size = new Size(197, 20);
            CheckDesignCode.TabIndex = 1;
            CheckDesignCode.Text = "Show designing script";
            DesignerToolTip.SetToolTip(CheckDesignCode, "Show designing script");
            CheckDesignCode.UseVisualStyleBackColor = true;
            CheckDesignCode.CheckedChanged += CheckDesignCode_CheckedChanged;
            // 
            // PreviewPanel
            // 
            PreviewPanel.BackColor = Color.White;
            PreviewPanel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PreviewPanel.ForeColor = Color.Black;
            PreviewPanel.Location = new Point(20, 20);
            PreviewPanel.Name = "PreviewPanel";
            PreviewPanel.Size = new Size(640, 480);
            PreviewPanel.TabIndex = 0;
            // 
            // BoxDesginScript
            // 
            BoxDesginScript.AcceptsTab = true;
            BoxDesginScript.AutoWordSelection = true;
            BoxDesginScript.BackColor = Color.FromArgb(70, 70, 70);
            BoxDesginScript.BorderStyle = BorderStyle.None;
            BoxDesginScript.Dock = DockStyle.Fill;
            BoxDesginScript.ForeColor = Color.White;
            BoxDesginScript.Location = new Point(0, 0);
            BoxDesginScript.Name = "BoxDesginScript";
            BoxDesginScript.Size = new Size(469, 150);
            BoxDesginScript.TabIndex = 0;
            BoxDesginScript.Text = "";
            BoxDesginScript.KeyDown += BoxDesginScript_KeyDown;
            // 
            // DesignerSidebar
            // 
            DesignerSidebar.Controls.Add(PropertiesPage);
            DesignerSidebar.Controls.Add(ToolboxPage);
            DesignerSidebar.Dock = DockStyle.Fill;
            DesignerSidebar.Location = new Point(0, 0);
            DesignerSidebar.Name = "DesignerSidebar";
            DesignerSidebar.SelectedIndex = 0;
            DesignerSidebar.Size = new Size(359, 402);
            DesignerSidebar.TabIndex = 0;
            // 
            // PropertiesPage
            // 
            PropertiesPage.BackColor = Color.FromArgb(64, 64, 64);
            PropertiesPage.Controls.Add(PropertiesTable);
            PropertiesPage.Location = new Point(4, 29);
            PropertiesPage.Name = "PropertiesPage";
            PropertiesPage.Padding = new Padding(3);
            PropertiesPage.Size = new Size(351, 369);
            PropertiesPage.TabIndex = 0;
            PropertiesPage.Text = "Properties";
            // 
            // PropertiesTable
            // 
            PropertiesTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PropertiesTable.AutoScroll = true;
            PropertiesTable.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PropertiesTable.BackColor = Color.Transparent;
            PropertiesTable.ColumnCount = 1;
            PropertiesTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            PropertiesTable.Controls.Add(LabelDesignPath, 0, 0);
            PropertiesTable.Location = new Point(0, 0);
            PropertiesTable.Name = "PropertiesTable";
            PropertiesTable.RowCount = 2;
            PropertiesTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            PropertiesTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            PropertiesTable.Size = new Size(353, 369);
            PropertiesTable.TabIndex = 0;
            // 
            // LabelDesignPath
            // 
            LabelDesignPath.AutoSize = true;
            LabelDesignPath.Location = new Point(3, 0);
            LabelDesignPath.Name = "LabelDesignPath";
            LabelDesignPath.Size = new Size(59, 20);
            LabelDesignPath.TabIndex = 0;
            LabelDesignPath.Text = "path:";
            // 
            // ToolboxPage
            // 
            ToolboxPage.BackColor = Color.FromArgb(64, 64, 64);
            ToolboxPage.Location = new Point(4, 29);
            ToolboxPage.Name = "ToolboxPage";
            ToolboxPage.Padding = new Padding(3);
            ToolboxPage.Size = new Size(351, 369);
            ToolboxPage.TabIndex = 1;
            ToolboxPage.Text = "Toolbox";
            // 
            // DesignerToolTip
            // 
            DesignerToolTip.BackColor = Color.FromArgb(28, 28, 28);
            DesignerToolTip.ForeColor = Color.White;
            // 
            // WindowDesigner
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(48, 48, 48);
            Controls.Add(DesignerContainer);
            Font = new Font("Courier New", 10.2F);
            ForeColor = Color.WhiteSmoke;
            Name = "WindowDesigner";
            Size = new Size(835, 404);
            Load += WindowDesigner_Load;
            DesignerContainer.Panel1.ResumeLayout(false);
            DesignerContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DesignerContainer).EndInit();
            DesignerContainer.ResumeLayout(false);
            DesignerEditor.Panel1.ResumeLayout(false);
            DesignerEditor.Panel1.PerformLayout();
            DesignerEditor.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DesignerEditor).EndInit();
            DesignerEditor.ResumeLayout(false);
            DesignerSidebar.ResumeLayout(false);
            PropertiesPage.ResumeLayout(false);
            PropertiesTable.ResumeLayout(false);
            PropertiesTable.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer DesignerContainer;
        private SplitContainer DesignerEditor;
        private Panel PreviewPanel;
        private CheckBox CheckDesignCode;
        private TabControl DesignerSidebar;
        private TabPage PropertiesPage;
        private TabPage ToolboxPage;
        private TableLayoutPanel PropertiesTable;
        private Label LabelDesignPath;
        private ToolTip DesignerToolTip;
        private RichTextBox BoxDesginScript;
    }
}
