namespace CDE.DirTree.DesktopApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            MaxFolderLevelComboBox.SelectedItem = "3";
        }

        private void SelectFolderButton_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Select root folder";
                dialog.UseDescriptionForTitle = true;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    RootFolderTextBox.Text = dialog.SelectedPath;
                }
            }
        }

        private void SubfolderLevelsComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control keys.
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void GetDirTreeButton_Click(object sender, EventArgs e)
        {
            string rootFolder = RootFolderTextBox.Text;
            if (string.IsNullOrWhiteSpace(rootFolder) || !Directory.Exists(rootFolder))
            {
                DirTreeTextBox.Text = "Please select a valid root folder.";
                return;
            }

            if (!int.TryParse(MaxFolderLevelComboBox.Text, out int maxFolderLevel) || maxFolderLevel < 1)
            {
                DirTreeTextBox.Text = "Please enter a valid number of subfolder levels.";
                return;
            }

            DirTreeTextBox.Text = BuildDirTree(rootFolder, maxFolderLevel);
        }

        private string BuildDirTree(string path, 
                                    int maxDepth, 
                                    int currentDepth = 0, 
                                    string indent = "")
        {
            if (currentDepth >= maxDepth) return "";

            var dirTreeBuilder = new System.Text.StringBuilder();
            var dirInfo = new DirectoryInfo(path);

            // List subdirectories.
            var subdirs = dirInfo.GetDirectories();
            for (int x = 0; x < subdirs.Length; x++)
            {
                var subdir = subdirs[x];
                bool isLast = (x == subdirs.Length - 1);
                dirTreeBuilder.AppendLine($"{indent}{(isLast ? "\\--" : "|--")}{subdir.Name}");
                string childIndent = indent + (isLast ? "    " : "|   ");
                dirTreeBuilder.Append(BuildDirTree(subdir.FullName, maxDepth, currentDepth + 1, childIndent));
            }

            return dirTreeBuilder.ToString();
        }
    }
}
