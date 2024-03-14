using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BinaryStringDetector
{
    public partial class MainForm : Form
    {
        private List<String> notFoundText;

        public MainForm()
        {
            InitializeComponent();
            notFoundText = new List<String> {"(not found)"}; //empty listbox source if nothing found
        }

        private void prepareListboxes(String filename)
        {
            int minimalValidStrLen = (int)numUpDownMinLen.Value;
            
            //ascii strings
            listBoxAsciiStrings.DataSource = StringFinder.getValidStringsFromFile(filename, minimalValidStrLen, false, checkBoxOnlyNullTerminated.Checked);
            if (listBoxAsciiStrings.Items.Count == 0) listBoxAsciiStrings.DataSource = notFoundText;

            //unicode strings only in range 0x0000-0x00FF
            listBoxUnicodeStrings.DataSource = StringFinder.getValidStringsFromFile(filename, minimalValidStrLen, true, checkBoxOnlyNullTerminated.Checked);
            if (listBoxUnicodeStrings.Items.Count == 0) listBoxUnicodeStrings.DataSource = notFoundText;
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) prepareListboxes(openFileDialog1.FileName);
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            prepareListboxes(System.IO.Path.GetFullPath(s[0]));
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void buttonCopyToClipboard_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder copy_buffer = new System.Text.StringBuilder();

            copy_buffer.AppendLine(" === UNICODE strings (only ASCII range) === ");
            foreach (object item in listBoxUnicodeStrings.Items) copy_buffer.AppendLine(item.ToString());

            copy_buffer.AppendLine("\n === ASCII strings === ");
            foreach (object item in listBoxAsciiStrings.Items) copy_buffer.AppendLine(item.ToString());

            Clipboard.SetText(copy_buffer.ToString());
            MessageBox.Show("All strings are copied to clipboard", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
