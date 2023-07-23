namespace SortedJsonDiff
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
            this.CompareButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sortButton = new System.Windows.Forms.Button();
            this.comparerCommandTextBox = new System.Windows.Forms.TextBox();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.aJsonUserControl = new SortedJsonDiff.JsonUserControl();
            this.bJsonUserControl = new SortedJsonDiff.JsonUserControl();
            this.rtbComparisonResult = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CompareButton
            // 
            this.CompareButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CompareButton.Location = new System.Drawing.Point(365, 442);
            this.CompareButton.Margin = new System.Windows.Forms.Padding(2);
            this.CompareButton.Name = "CompareButton";
            this.CompareButton.Size = new System.Drawing.Size(65, 25);
            this.CompareButton.TabIndex = 1;
            this.CompareButton.Text = "Compare";
            this.CompareButton.UseVisualStyleBackColor = true;
            this.CompareButton.Click += new System.EventHandler(this.CompareButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(320, 32);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 2;
            // 
            // sortButton
            // 
            this.sortButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sortButton.Location = new System.Drawing.Point(365, 409);
            this.sortButton.Margin = new System.Windows.Forms.Padding(2);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(65, 25);
            this.sortButton.TabIndex = 1;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // comparerCommandTextBox
            // 
            this.comparerCommandTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comparerCommandTextBox.Location = new System.Drawing.Point(9, 445);
            this.comparerCommandTextBox.Name = "comparerCommandTextBox";
            this.comparerCommandTextBox.Size = new System.Drawing.Size(351, 20);
            this.comparerCommandTextBox.TabIndex = 3;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.aJsonUserControl);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.bJsonUserControl);
            this.splitContainer.Size = new System.Drawing.Size(792, 161);
            this.splitContainer.SplitterDistance = 384;
            this.splitContainer.TabIndex = 4;
            // 
            // aJsonUserControl
            // 
            this.aJsonUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aJsonUserControl.Filename = "";
            this.aJsonUserControl.JSON = "";
            this.aJsonUserControl.Location = new System.Drawing.Point(0, 0);
            this.aJsonUserControl.Name = "aJsonUserControl";
            this.aJsonUserControl.Size = new System.Drawing.Size(384, 161);
            this.aJsonUserControl.TabIndex = 0;
            // 
            // bJsonUserControl
            // 
            this.bJsonUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bJsonUserControl.Filename = "";
            this.bJsonUserControl.JSON = "";
            this.bJsonUserControl.Location = new System.Drawing.Point(0, 0);
            this.bJsonUserControl.Name = "bJsonUserControl";
            this.bJsonUserControl.Size = new System.Drawing.Size(404, 161);
            this.bJsonUserControl.TabIndex = 0;
            // 
            // rtbComparisonResult
            // 
            this.rtbComparisonResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbComparisonResult.Location = new System.Drawing.Point(0, 0);
            this.rtbComparisonResult.Name = "rtbComparisonResult";
            this.rtbComparisonResult.Size = new System.Drawing.Size(792, 157);
            this.rtbComparisonResult.TabIndex = 5;
            this.rtbComparisonResult.Text = "";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(9, 79);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rtbComparisonResult);
            this.splitContainer1.Size = new System.Drawing.Size(792, 322);
            this.splitContainer1.SplitterDistance = 161;
            this.splitContainer1.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 478);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.comparerCommandTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.CompareButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Sorted JSON Comparer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CompareButton;
        private System.Windows.Forms.TextBox textBox1;
        private JsonUserControl aJsonUserControl;
        private JsonUserControl bJsonUserControl;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.TextBox comparerCommandTextBox;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.RichTextBox rtbComparisonResult;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

