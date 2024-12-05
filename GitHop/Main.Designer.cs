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
            lbcurrent = new Label();
            lbCurrentBranch = new Label();
            lbSwitchTo = new Label();
            cbBranches = new ComboBox();
            btnSwitch = new Button();
            btnRefresh = new Button();
            SuspendLayout();
            // 
            // lbcurrent
            // 
            lbcurrent.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbcurrent.Location = new Point(12, 9);
            lbcurrent.Name = "lbcurrent";
            lbcurrent.Size = new Size(69, 23);
            lbcurrent.TabIndex = 0;
            lbcurrent.Text = "Current:";
            lbcurrent.TextAlign = ContentAlignment.MiddleRight;
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
            // lbSwitchTo
            // 
            lbSwitchTo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbSwitchTo.Location = new Point(12, 35);
            lbSwitchTo.Name = "lbSwitchTo";
            lbSwitchTo.Size = new Size(69, 23);
            lbSwitchTo.TabIndex = 2;
            lbSwitchTo.Text = "Switch to:";
            lbSwitchTo.TextAlign = ContentAlignment.MiddleRight;
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
            // btnRefresh
            // 
            btnRefresh.Location = new Point(224, 67);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(71, 32);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // Main
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(384, 111);
            Controls.Add(btnRefresh);
            Controls.Add(btnSwitch);
            Controls.Add(cbBranches);
            Controls.Add(lbSwitchTo);
            Controls.Add(lbCurrentBranch);
            Controls.Add(lbcurrent);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GitHop";
            Load += Main_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lbcurrent;
        private Label lbCurrentBranch;
        private Label lbSwitchTo;
        private ComboBox cbBranches;
        private Button btnSwitch;
        private Button btnRefresh;
    }
}
