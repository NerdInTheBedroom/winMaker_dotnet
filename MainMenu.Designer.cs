/*
 * Created on: 03/17/2025
 * Last modified on: 03/23/2025
 * Author: A1EX
 * GitHub: https://github.com/GeekInTheBedroom/winMaker_dotnet
 */

namespace winMaker_dotnet
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LayoutButtons = new TableLayoutPanel();
            ButtonSupport = new Button();
            ButtonInstall = new Button();
            ButtonOpen = new Button();
            ButtonCreate = new Button();
            PanelSubMenu = new Panel();
            LayoutButtons.SuspendLayout();
            SuspendLayout();
            // 
            // LayoutButtons
            // 
            LayoutButtons.AutoSize = true;
            LayoutButtons.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LayoutButtons.ColumnCount = 1;
            LayoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            LayoutButtons.Controls.Add(ButtonSupport, 0, 3);
            LayoutButtons.Controls.Add(ButtonInstall, 0, 2);
            LayoutButtons.Controls.Add(ButtonOpen, 0, 1);
            LayoutButtons.Controls.Add(ButtonCreate, 0, 0);
            LayoutButtons.Location = new Point(12, 64);
            LayoutButtons.Name = "LayoutButtons";
            LayoutButtons.RowCount = 4;
            LayoutButtons.RowStyles.Add(new RowStyle());
            LayoutButtons.RowStyles.Add(new RowStyle());
            LayoutButtons.RowStyles.Add(new RowStyle());
            LayoutButtons.RowStyles.Add(new RowStyle());
            LayoutButtons.Size = new Size(256, 264);
            LayoutButtons.TabIndex = 0;
            // 
            // ButtonSupport
            // 
            ButtonSupport.BackColor = Color.Purple;
            ButtonSupport.FlatAppearance.BorderSize = 3;
            ButtonSupport.FlatAppearance.MouseOverBackColor = Color.HotPink;
            ButtonSupport.FlatStyle = FlatStyle.Popup;
            ButtonSupport.Font = new Font("Cordia New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonSupport.ForeColor = Color.FromArgb(16, 16, 16);
            ButtonSupport.Location = new Point(3, 201);
            ButtonSupport.Name = "ButtonSupport";
            ButtonSupport.Size = new Size(250, 60);
            ButtonSupport.TabIndex = 3;
            ButtonSupport.Text = "GitHub && Support❤";
            ButtonSupport.UseVisualStyleBackColor = false;
            ButtonSupport.Click += ButtonSupport_Click;
            // 
            // ButtonInstall
            // 
            ButtonInstall.BackColor = Color.FromArgb(32, 32, 32);
            ButtonInstall.FlatAppearance.BorderSize = 3;
            ButtonInstall.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 120, 120);
            ButtonInstall.FlatStyle = FlatStyle.Popup;
            ButtonInstall.Font = new Font("Cordia New", 13.8F);
            ButtonInstall.ForeColor = Color.LightGray;
            ButtonInstall.Location = new Point(3, 135);
            ButtonInstall.Name = "ButtonInstall";
            ButtonInstall.Size = new Size(250, 60);
            ButtonInstall.TabIndex = 2;
            ButtonInstall.Text = "Packages && Other Versions";
            ButtonInstall.UseVisualStyleBackColor = false;
            ButtonInstall.Click += ButtonInstall_Click;
            // 
            // ButtonOpen
            // 
            ButtonOpen.BackColor = Color.FromArgb(32, 32, 32);
            ButtonOpen.FlatAppearance.BorderSize = 3;
            ButtonOpen.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 120, 120);
            ButtonOpen.FlatStyle = FlatStyle.Popup;
            ButtonOpen.Font = new Font("Cordia New", 13.8F);
            ButtonOpen.ForeColor = Color.LightGray;
            ButtonOpen.Location = new Point(3, 69);
            ButtonOpen.Name = "ButtonOpen";
            ButtonOpen.Size = new Size(250, 60);
            ButtonOpen.TabIndex = 1;
            ButtonOpen.Text = "Open New Project";
            ButtonOpen.UseVisualStyleBackColor = false;
            ButtonOpen.Click += ButtonOpen_Click;
            // 
            // ButtonCreate
            // 
            ButtonCreate.BackColor = Color.FromArgb(32, 32, 32);
            ButtonCreate.FlatAppearance.BorderSize = 3;
            ButtonCreate.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 120, 120);
            ButtonCreate.FlatStyle = FlatStyle.Popup;
            ButtonCreate.Font = new Font("Cordia New", 13.8F);
            ButtonCreate.ForeColor = Color.LightGray;
            ButtonCreate.Location = new Point(3, 3);
            ButtonCreate.Name = "ButtonCreate";
            ButtonCreate.Size = new Size(250, 60);
            ButtonCreate.TabIndex = 0;
            ButtonCreate.Text = "Create New Project";
            ButtonCreate.UseVisualStyleBackColor = false;
            ButtonCreate.Click += ButtonCreate_Click;
            // 
            // PanelSubMenu
            // 
            PanelSubMenu.BackColor = Color.Transparent;
            PanelSubMenu.BorderStyle = BorderStyle.FixedSingle;
            PanelSubMenu.Location = new Point(295, 29);
            PanelSubMenu.Name = "PanelSubMenu";
            PanelSubMenu.Size = new Size(475, 432);
            PanelSubMenu.TabIndex = 1;
            // 
            // MainMenu
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(48, 48, 48);
            ClientSize = new Size(782, 473);
            Controls.Add(PanelSubMenu);
            Controls.Add(LayoutButtons);
            Font = new Font("Cordia New", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(800, 520);
            MinimumSize = new Size(800, 520);
            Name = "MainMenu";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WinMaker.NET";
            LayoutButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel LayoutButtons;
        private Button ButtonCreate;
        private Button ButtonSupport;
        private Button ButtonInstall;
        private Button ButtonOpen;
        private Panel PanelSubMenu;
    }
}
