namespace winMaker_dotnet.Sub_menu
{
    partial class MenuPackages
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
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cordia New", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MistyRose;
            label1.Location = new Point(3, 163);
            label1.Name = "label1";
            label1.Size = new Size(466, 84);
            label1.TabIndex = 0;
            label1.Text = "Chill... I'm still developing, bro. I'm alone here.\r\nGive me some time :)";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MenuPackages
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(70, 50, 75);
            Controls.Add(label1);
            Font = new Font("Cordia New", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "MenuPackages";
            Size = new Size(475, 432);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}
