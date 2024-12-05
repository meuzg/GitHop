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
            // Update current label
            lbCurrentBranch.Text = currentBranchName;
            // Clear all item in existing combobox
            cbBranches.Items.Clear();
            // Then add a new one into it
            cbBranches.Items.AddRange(allBranchNames.ToArray());
            // If item is found ...
            if (cbBranches.Items.Count > 0)
            {
                // ... then select first index if able
                cbBranches.SelectedIndex = 0;
                // And enable switch button
                btnSwitch.Enabled = true;
            }
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
    }
}
