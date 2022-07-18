namespace NoteAppUI
{
    partial class NoteApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteApp));
            this.FileButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.HelpButton = new System.Windows.Forms.Button();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.ShowCategoryLabel = new System.Windows.Forms.Label();
            this.NoteListListBox = new System.Windows.Forms.ListBox();
            this.AddFileButton = new System.Windows.Forms.Button();
            this.EditFileButton = new System.Windows.Forms.Button();
            this.RemoveFileButton = new System.Windows.Forms.Button();
            this.NoteRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ModifiedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ModifiedLabel = new System.Windows.Forms.Label();
            this.CreatedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CreatedLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CategoryTextLabel = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileButton
            // 
            this.FileButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.FileButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.FileButton.FlatAppearance.BorderSize = 0;
            this.FileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileButton.Location = new System.Drawing.Point(12, 3);
            this.FileButton.Name = "FileButton";
            this.FileButton.Size = new System.Drawing.Size(57, 29);
            this.FileButton.TabIndex = 0;
            this.FileButton.Text = "File";
            this.FileButton.UseVisualStyleBackColor = false;
            this.FileButton.Click += new System.EventHandler(this.FileButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.EditButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditButton.Location = new System.Drawing.Point(75, 3);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(57, 29);
            this.EditButton.TabIndex = 1;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.FlatAppearance.BorderSize = 0;
            this.HelpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelpButton.Location = new System.Drawing.Point(138, 3);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(57, 29);
            this.HelpButton.TabIndex = 2;
            this.HelpButton.Text = "Help";
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Items.AddRange(new object[] {
            "All",
            "Work",
            "Home",
            "Health and Sports",
            "People",
            "Documents",
            "Finance",
            "Other"});
            this.CategoryComboBox.Location = new System.Drawing.Point(120, 36);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(225, 24);
            this.CategoryComboBox.TabIndex = 3;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // ShowCategoryLabel
            // 
            this.ShowCategoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowCategoryLabel.AutoSize = true;
            this.ShowCategoryLabel.Location = new System.Drawing.Point(9, 39);
            this.ShowCategoryLabel.Name = "ShowCategoryLabel";
            this.ShowCategoryLabel.Size = new System.Drawing.Size(105, 17);
            this.ShowCategoryLabel.TabIndex = 4;
            this.ShowCategoryLabel.Text = "Show category:";
            this.ShowCategoryLabel.Click += new System.EventHandler(this.ShowCategoryLabel_Click);
            // 
            // NoteListListBox
            // 
            this.NoteListListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteListListBox.FormattingEnabled = true;
            this.NoteListListBox.ItemHeight = 16;
            this.NoteListListBox.Location = new System.Drawing.Point(12, 66);
            this.NoteListListBox.Name = "NoteListListBox";
            this.NoteListListBox.Size = new System.Drawing.Size(333, 372);
            this.NoteListListBox.TabIndex = 5;
            this.NoteListListBox.SelectedIndexChanged += new System.EventHandler(this.NoteListListBox_SelectedIndexChanged_1);
            // 
            // AddFileButton
            // 
            this.AddFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddFileButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.AddFileButton.Image = ((System.Drawing.Image)(resources.GetObject("AddFileButton.Image")));
            this.AddFileButton.Location = new System.Drawing.Point(12, 497);
            this.AddFileButton.Name = "AddFileButton";
            this.AddFileButton.Size = new System.Drawing.Size(51, 45);
            this.AddFileButton.TabIndex = 6;
            this.AddFileButton.UseVisualStyleBackColor = true;
            this.AddFileButton.Click += new System.EventHandler(this.AddFileButton_Click);
            // 
            // EditFileButton
            // 
            this.EditFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditFileButton.Image = ((System.Drawing.Image)(resources.GetObject("EditFileButton.Image")));
            this.EditFileButton.Location = new System.Drawing.Point(69, 497);
            this.EditFileButton.Name = "EditFileButton";
            this.EditFileButton.Size = new System.Drawing.Size(51, 45);
            this.EditFileButton.TabIndex = 7;
            this.EditFileButton.UseVisualStyleBackColor = true;
            this.EditFileButton.Click += new System.EventHandler(this.EditFileButton_Click);
            // 
            // RemoveFileButton
            // 
            this.RemoveFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveFileButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoveFileButton.Image")));
            this.RemoveFileButton.Location = new System.Drawing.Point(126, 497);
            this.RemoveFileButton.Name = "RemoveFileButton";
            this.RemoveFileButton.Size = new System.Drawing.Size(51, 45);
            this.RemoveFileButton.TabIndex = 8;
            this.RemoveFileButton.UseVisualStyleBackColor = true;
            this.RemoveFileButton.Click += new System.EventHandler(this.RemoveFileButton_Click);
            // 
            // NoteRichTextBox
            // 
            this.NoteRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoteRichTextBox.Location = new System.Drawing.Point(21, 123);
            this.NoteRichTextBox.Name = "NoteRichTextBox";
            this.NoteRichTextBox.Size = new System.Drawing.Size(675, 419);
            this.NoteRichTextBox.TabIndex = 20;
            this.NoteRichTextBox.Text = "";
            this.NoteRichTextBox.TextChanged += new System.EventHandler(this.NoteRichTextBox_TextChanged);
            // 
            // ModifiedDateTimePicker
            // 
            this.ModifiedDateTimePicker.Location = new System.Drawing.Point(366, 90);
            this.ModifiedDateTimePicker.Name = "ModifiedDateTimePicker";
            this.ModifiedDateTimePicker.Size = new System.Drawing.Size(161, 22);
            this.ModifiedDateTimePicker.TabIndex = 19;
            this.ModifiedDateTimePicker.ValueChanged += new System.EventHandler(this.ModifiedDateTimePicker_ValueChanged);
            // 
            // ModifiedLabel
            // 
            this.ModifiedLabel.AutoSize = true;
            this.ModifiedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModifiedLabel.Location = new System.Drawing.Point(282, 94);
            this.ModifiedLabel.Name = "ModifiedLabel";
            this.ModifiedLabel.Size = new System.Drawing.Size(68, 18);
            this.ModifiedLabel.TabIndex = 18;
            this.ModifiedLabel.Text = "Modified:";
            this.ModifiedLabel.Click += new System.EventHandler(this.ModifiedLabel_Click);
            // 
            // CreatedDateTimePicker
            // 
            this.CreatedDateTimePicker.Location = new System.Drawing.Point(101, 91);
            this.CreatedDateTimePicker.Name = "CreatedDateTimePicker";
            this.CreatedDateTimePicker.Size = new System.Drawing.Size(157, 22);
            this.CreatedDateTimePicker.TabIndex = 17;
            this.CreatedDateTimePicker.ValueChanged += new System.EventHandler(this.CreatedDateTimePicker_ValueChanged);
            // 
            // CreatedLabel
            // 
            this.CreatedLabel.AutoSize = true;
            this.CreatedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreatedLabel.Location = new System.Drawing.Point(20, 95);
            this.CreatedLabel.Name = "CreatedLabel";
            this.CreatedLabel.Size = new System.Drawing.Size(64, 18);
            this.CreatedLabel.TabIndex = 16;
            this.CreatedLabel.Text = "Created:";
            this.CreatedLabel.Click += new System.EventHandler(this.CreatedLabel_Click);
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryLabel.Location = new System.Drawing.Point(20, 66);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(72, 18);
            this.CategoryLabel.TabIndex = 14;
            this.CategoryLabel.Text = "Category:";
            this.CategoryLabel.Click += new System.EventHandler(this.CategoryLabel_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel.Location = new System.Drawing.Point(16, 36);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(54, 25);
            this.TitleLabel.TabIndex = 13;
            this.TitleLabel.Text = "Title";
            this.TitleLabel.Click += new System.EventHandler(this.TitleLabel_Click);
            // 
            // CategoryTextLabel
            // 
            this.CategoryTextLabel.AutoSize = true;
            this.CategoryTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryTextLabel.Location = new System.Drawing.Point(98, 66);
            this.CategoryTextLabel.Name = "CategoryTextLabel";
            this.CategoryTextLabel.Size = new System.Drawing.Size(51, 18);
            this.CategoryTextLabel.TabIndex = 21;
            this.CategoryTextLabel.Text = "default";
            this.CategoryTextLabel.Click += new System.EventHandler(this.CategoryTextLabel_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.EditButton);
            this.splitContainer1.Panel1.Controls.Add(this.FileButton);
            this.splitContainer1.Panel1.Controls.Add(this.AddFileButton);
            this.splitContainer1.Panel1.Controls.Add(this.EditFileButton);
            this.splitContainer1.Panel1.Controls.Add(this.RemoveFileButton);
            this.splitContainer1.Panel1.Controls.Add(this.HelpButton);
            this.splitContainer1.Panel1.Controls.Add(this.CategoryComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.ShowCategoryLabel);
            this.splitContainer1.Panel1.Controls.Add(this.NoteListListBox);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.NoteRichTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.CategoryTextLabel);
            this.splitContainer1.Panel2.Controls.Add(this.ModifiedDateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(this.TitleLabel);
            this.splitContainer1.Panel2.Controls.Add(this.CategoryLabel);
            this.splitContainer1.Panel2.Controls.Add(this.ModifiedLabel);
            this.splitContainer1.Panel2.Controls.Add(this.CreatedLabel);
            this.splitContainer1.Panel2.Controls.Add(this.CreatedDateTimePicker);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(1067, 554);
            this.splitContainer1.SplitterDistance = 355;
            this.splitContainer1.TabIndex = 22;
            // 
            // NoteApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NoteApp";
            this.Text = "NoteApp";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FileButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Label ShowCategoryLabel;
        private System.Windows.Forms.ListBox NoteListListBox;
        private System.Windows.Forms.Button AddFileButton;
        private System.Windows.Forms.Button EditFileButton;
        private System.Windows.Forms.Button RemoveFileButton;
        private System.Windows.Forms.RichTextBox NoteRichTextBox;
        private System.Windows.Forms.DateTimePicker ModifiedDateTimePicker;
        private System.Windows.Forms.Label ModifiedLabel;
        private System.Windows.Forms.DateTimePicker CreatedDateTimePicker;
        private System.Windows.Forms.Label CreatedLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label CategoryTextLabel;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

