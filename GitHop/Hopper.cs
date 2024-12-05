using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace GitHop
{
    public static class Hopper
    {
        public static async Task<List<string>> GetBranchesAsync()
        {
            // Initialize result list
            var branches = new List<string>();
            // Define process info
            var startInfo = new ProcessStartInfo
            {
                FileName = "git",
                Arguments = "branch --list",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            // Initialize process
            using (var process = new Process())
            {
                // Initial process properties
                process.StartInfo = startInfo;
                // Start process
                process.Start();
                // Obtain result from process output
                var output = await process.StandardOutput.ReadToEndAsync();
                // Wait for process to exit with timeout
                await process.WaitForExitAsync();
                // Get branches info
                var branchList = output.Split(['\n', '\r'], StringSplitOptions.RemoveEmptyEntries);
                // Loop for each branch ...
                foreach (var branch in branchList)
                {
                    // Trim whitespace and asterisk (which indicates the current branch)
                    branches.Add(branch.Trim().TrimStart('*').Trim());
                }
            }
            // After all, return branch list
            return branches;
        }

        public static async Task<string> GetCurrentBranchNameAsync()
        {
            // Initialize result
            string currentBranch = "";
            // Define process info
            var startInfo = new ProcessStartInfo
            {
                FileName = "git",
                Arguments = "branch --list",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            // Initialize process
            using (var process = new Process())
            {
                // Initial process properties
                process.StartInfo = startInfo;
                // Start process
                process.Start();
                // Obtain result from process output
                var output = await process.StandardOutput.ReadToEndAsync();
                // Wait for process to exit with timeout
                await process.WaitForExitAsync();
                // Get branches info
                var branchList = output.Split(['\n', '\r'], StringSplitOptions.RemoveEmptyEntries);
                // Loop for each branch ...
                foreach (var branch in branchList)
                {
                    // If asterisk was found ...
                    if (branch.StartsWith('*'))
                    {
                        // Assign current branch name
                        currentBranch = branch.Trim().TrimStart('*').Trim();
                        // Then exit this loop
                        break;

                    }
                }
            }
            // After all, return the current branch name
            return currentBranch;
        }
    }
}
