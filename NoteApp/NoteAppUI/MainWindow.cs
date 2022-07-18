using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteAppUI
{
    public partial class NoteApp : Form
    {
        public NoteApp()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void FileButton_Click(object sender, EventArgs e)
        {

        }

        private void EditButton_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ShowCategoryLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddFileButton_Click(object sender, EventArgs e)
        {
            var addEditWindow = new AddEditWindow();
            addEditWindow.ShowDialog();
        }

        private void EditFileButton_Click(object sender, EventArgs e)
        {
            var addEditWindow = new AddEditWindow();
            addEditWindow.ShowDialog();
        }

        private void RemoveFileButton_Click(object sender, EventArgs e)
        {

        }

        private void HelpButton_Click(object sender, EventArgs e)
        {

        }

        private void NoteListListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void CategoryTextLabel_Click(object sender, EventArgs e)
        {

        }

        private void CreatedLabel_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CategoryLabel_Click(object sender, EventArgs e)
        {

        }

        private void CreatedDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ModifiedLabel_Click(object sender, EventArgs e)
        {

        }

        private void ModifiedDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NoteRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
