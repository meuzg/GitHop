namespace GitHop
{
    partial class Main
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
            label1 = new Label();
            lbCurrentBranch = new Label();
            label3 = new Label();
            cbBranches = new ComboBox();
            btnSwitch = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(69, 23);
            label1.TabIndex = 0;
            label1.Text = "Current:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbCurrentBranch
            // 
            lbCurrentBranch.Location = new Point(87, 9);
            lbCurrentBranch.Name = "lbCurrentBranch";
            lbCurrentBranch.Size = new Size(285, 23);
            lbCurrentBranch.TabIndex = 1;
            lbCurrentBranch.Text = "---";
            lbCurrentBranch.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(12, 35);
            label3.Name = "label3";
            label3.Size = new Size(69, 23);
            label3.TabIndex = 2;
            label3.Text = "Switch to:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cbBranches
            // 
            cbBranches.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBranches.FormattingEnabled = true;
            cbBranches.Location = new Point(87, 36);
            cbBranches.Name = "cbBranches";
            cbBranches.Size = new Size(285, 23);
            cbBranches.TabIndex = 3;
            // 
            // btnSwitch
            // 
            btnSwitch.Location = new Point(301, 65);
            btnSwitch.Name = "btnSwitch";
            btnSwitch.Size = new Size(71, 32);
            btnSwitch.TabIndex = 4;
            btnSwitch.Text = "Switch";
            btnSwitch.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(384, 111);
            Controls.Add(btnSwitch);
            Controls.Add(cbBranches);
            Controls.Add(label3);
            Controls.Add(lbCurrentBranch);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GitHop";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label lbCurrentBranch;
        private Label label3;
        private ComboBox cbBranches;
        private Button btnSwitch;
    }
}
