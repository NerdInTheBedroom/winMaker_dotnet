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
            SuspendLayout();
            // 
            // Editor
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Gray;
            ClientSize = new Size(842, 493);
            Font = new Font("Courier New", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            Margin = new Padding(5, 4, 5, 4);
            MinimumSize = new Size(860, 540);
            Name = "Editor";
            Text = "Editor";
            WindowState = FormWindowState.Maximized;
            Load += Editor_Load;
            ResumeLayout(false);
        }

        #endregion
    }
}