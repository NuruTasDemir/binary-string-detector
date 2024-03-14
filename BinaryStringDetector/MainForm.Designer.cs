namespace BinaryStringDetector
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxAsciiStrings = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listBoxUnicodeStrings = new System.Windows.Forms.ListBox();
            this.numUpDownMinLen = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxOnlyNullTerminated = new System.Windows.Forms.CheckBox();
            this.buttonCopyToClipboard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMinLen)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(896, 567);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open File (Drag&&Drop works too)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // listBoxAsciiStrings
            // 
            this.listBoxAsciiStrings.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAsciiStrings.FormattingEnabled = true;
            this.listBoxAsciiStrings.ItemHeight = 17;
            this.listBoxAsciiStrings.Location = new System.Drawing.Point(6, 21);
            this.listBoxAsciiStrings.Name = "listBoxAsciiStrings";
            this.listBoxAsciiStrings.Size = new System.Drawing.Size(1146, 242);
            this.listBoxAsciiStrings.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listBoxUnicodeStrings
            // 
            this.listBoxUnicodeStrings.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxUnicodeStrings.FormattingEnabled = true;
            this.listBoxUnicodeStrings.ItemHeight = 17;
            this.listBoxUnicodeStrings.Location = new System.Drawing.Point(6, 21);
            this.listBoxUnicodeStrings.Name = "listBoxUnicodeStrings";
            this.listBoxUnicodeStrings.Size = new System.Drawing.Size(1146, 242);
            this.listBoxUnicodeStrings.TabIndex = 2;
            // 
            // numUpDownMinLen
            // 
            this.numUpDownMinLen.Location = new System.Drawing.Point(159, 567);
            this.numUpDownMinLen.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numUpDownMinLen.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numUpDownMinLen.Name = "numUpDownMinLen";
            this.numUpDownMinLen.Size = new System.Drawing.Size(42, 22);
            this.numUpDownMinLen.TabIndex = 3;
            this.numUpDownMinLen.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxAsciiStrings);
            this.groupBox1.Location = new System.Drawing.Point(10, 288);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1160, 270);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ASCII strings";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxUnicodeStrings);
            this.groupBox2.Location = new System.Drawing.Point(11, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1160, 270);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "UNICODE strings (only ASCII range)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 569);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Minimal string length:";
            // 
            // checkBoxOnlyNullTerminated
            // 
            this.checkBoxOnlyNullTerminated.AutoSize = true;
            this.checkBoxOnlyNullTerminated.Checked = true;
            this.checkBoxOnlyNullTerminated.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOnlyNullTerminated.Location = new System.Drawing.Point(249, 568);
            this.checkBoxOnlyNullTerminated.Name = "checkBoxOnlyNullTerminated";
            this.checkBoxOnlyNullTerminated.Size = new System.Drawing.Size(238, 21);
            this.checkBoxOnlyNullTerminated.TabIndex = 7;
            this.checkBoxOnlyNullTerminated.Text = "Show only null-terminated strings";
            this.checkBoxOnlyNullTerminated.UseVisualStyleBackColor = true;
            // 
            // buttonCopyToClipboard
            // 
            this.buttonCopyToClipboard.Location = new System.Drawing.Point(681, 567);
            this.buttonCopyToClipboard.Name = "buttonCopyToClipboard";
            this.buttonCopyToClipboard.Size = new System.Drawing.Size(186, 27);
            this.buttonCopyToClipboard.TabIndex = 8;
            this.buttonCopyToClipboard.Text = "Copy to Clipboard";
            this.buttonCopyToClipboard.UseVisualStyleBackColor = true;
            this.buttonCopyToClipboard.Click += new System.EventHandler(this.buttonCopyToClipboard_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1182, 603);
            this.Controls.Add(this.buttonCopyToClipboard);
            this.Controls.Add(this.checkBoxOnlyNullTerminated);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numUpDownMinLen);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Binary String Finder";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMinLen)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxAsciiStrings;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listBoxUnicodeStrings;
        private System.Windows.Forms.NumericUpDown numUpDownMinLen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxOnlyNullTerminated;
        private System.Windows.Forms.Button buttonCopyToClipboard;
    }
}

