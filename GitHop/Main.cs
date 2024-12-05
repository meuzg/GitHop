namespace GitHop
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // Invoke refresh once
            DoRefresh();
        }

        private async void DoRefresh()
        {
            // Disable switch button
            btnSwitch.Enabled = false;
            // Get current branch name
            var currentBranchName = await Hopper.GetCurrentBranchNameAsync();
            // Get all branch names
            var allBranchNames = await Hopper.GetBranchesAsync();
            // Update current label if able
            if (! string.IsNullOrWhiteSpace(currentBranchName))
            {
                lbCurrentBranch.Text = currentBranchName;
            }
            else
            {
                lbCurrentBranch.Text = "Git not found";
            }
            // Clear all item in existing combobox
            cbBranches.Items.Clear();
            // Then add a new one into it
            cbBranches.Items.AddRange(allBranchNames.ToArray());
            // And there have items in collection ...
            if (cbBranches.Items.Count > 0)
            {
                // Then select first index as default
                cbBranches.SelectedIndex = 0;
            }
            // Ater all, re-enable switch button
            btnSwitch.Enabled = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Disable button
            btnRefresh.Enabled = false;
            // Do refresh once
            DoRefresh();
            // Re-enable button
            btnRefresh.Enabled = true;
        }

        private async void btnSwitch_Click(object sender, EventArgs e)
        {
            // Disable button
            btnSwitch.Enabled = false;
            // Get selected branch name
            var selectedBranchName = cbBranches.Text;
            // Do switch branch with force checkout argument
            await Hopper.SwitchBranchAsync(selectedBranchName, chkForceCheckout.Checked);
            // Then do refresh again
            DoRefresh();
        }
    }
}
