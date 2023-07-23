using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortedJsonDiff
{
    public partial class JsonUserControl : UserControl
    {

        public string JSON
        {
            get { return fileContentTextBox.Text; }
            set { fileContentTextBox.Text = value; }
        }
        public string Filename
        {
            get { return filenameTextBox.Text; }
            set { filenameTextBox.Text = value; }
        }

        public JsonUserControl()
        {
            InitializeComponent();
        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            var dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                filenameTextBox.Text = openFileDialog.FileName;
            }
        }

        private void loadFileButton_Click(object sender, EventArgs e)
        {
            fileContentTextBox.Text = File.ReadAllText(filenameTextBox.Text);
        }
    }
}
