namespace CDE.DirTree.DesktopApp
{
    partial class MainForm
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
            SelectFolderButton = new Button();
            RootFolderTextBox = new TextBox();
            GetDirTreeButton = new Button();
            DirTreeTextBox = new TextBox();
            RootFolderLabel = new Label();
            MaxFolderLevelLabel = new Label();
            MaxFolderLevelComboBox = new ComboBox();
            SuspendLayout();
            // 
            // SelectFolderButton
            // 
            SelectFolderButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SelectFolderButton.Location = new Point(664, 11);
            SelectFolderButton.Name = "SelectFolderButton";
            SelectFolderButton.Size = new Size(124, 29);
            SelectFolderButton.TabIndex = 0;
            SelectFolderButton.Text = "Select folder...";
            SelectFolderButton.UseVisualStyleBackColor = true;
            SelectFolderButton.Click += SelectFolderButton_Click;
            // 
            // RootFolderTextBox
            // 
            RootFolderTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RootFolderTextBox.Location = new Point(137, 12);
            RootFolderTextBox.Name = "RootFolderTextBox";
            RootFolderTextBox.Size = new Size(521, 27);
            RootFolderTextBox.TabIndex = 1;
            // 
            // GetDirTreeButton
            // 
            GetDirTreeButton.Location = new Point(218, 44);
            GetDirTreeButton.Name = "GetDirTreeButton";
            GetDirTreeButton.Size = new Size(124, 29);
            GetDirTreeButton.TabIndex = 2;
            GetDirTreeButton.Text = "Get DirTree (folder tree)";
            GetDirTreeButton.UseVisualStyleBackColor = true;
            GetDirTreeButton.Click += GetDirTreeButton_Click;
            // 
            // DirTreeTextBox
            // 
            DirTreeTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DirTreeTextBox.Location = new Point(12, 79);
            DirTreeTextBox.Multiline = true;
            DirTreeTextBox.Name = "DirTreeTextBox";
            DirTreeTextBox.ScrollBars = ScrollBars.Both;
            DirTreeTextBox.Size = new Size(776, 359);
            DirTreeTextBox.TabIndex = 3;
            // 
            // RootFolderLabel
            // 
            RootFolderLabel.AutoSize = true;
            RootFolderLabel.Location = new Point(12, 15);
            RootFolderLabel.Name = "RootFolderLabel";
            RootFolderLabel.Size = new Size(88, 20);
            RootFolderLabel.TabIndex = 4;
            RootFolderLabel.Text = "Root folder:";
            // 
            // MaxFolderLevelLabel
            // 
            MaxFolderLevelLabel.AutoSize = true;
            MaxFolderLevelLabel.Location = new Point(12, 48);
            MaxFolderLevelLabel.Name = "MaxFolderLevelLabel";
            MaxFolderLevelLabel.Size = new Size(119, 20);
            MaxFolderLevelLabel.TabIndex = 5;
            MaxFolderLevelLabel.Text = "Max folder level:";
            // 
            // MaxFolderLevelComboBox
            // 
            MaxFolderLevelComboBox.FormattingEnabled = true;
            MaxFolderLevelComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            MaxFolderLevelComboBox.Location = new Point(137, 45);
            MaxFolderLevelComboBox.Name = "MaxFolderLevelComboBox";
            MaxFolderLevelComboBox.Size = new Size(75, 28);
            MaxFolderLevelComboBox.TabIndex = 6;
            MaxFolderLevelComboBox.KeyPress += SubfolderLevelsComboBox_KeyPress;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MaxFolderLevelComboBox);
            Controls.Add(MaxFolderLevelLabel);
            Controls.Add(RootFolderLabel);
            Controls.Add(DirTreeTextBox);
            Controls.Add(GetDirTreeButton);
            Controls.Add(RootFolderTextBox);
            Controls.Add(SelectFolderButton);
            Name = "MainForm";
            Text = "DirTree";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SelectFolderButton;
        private TextBox RootFolderTextBox;
        private Button GetDirTreeButton;
        private TextBox DirTreeTextBox;
        private Label RootFolderLabel;
        private Label MaxFolderLevelLabel;
        private ComboBox MaxFolderLevelComboBox;
    }
}
