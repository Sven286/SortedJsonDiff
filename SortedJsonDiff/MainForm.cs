using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortedJsonDiff
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            aJsonUserControl.Filename = @"..\..\TestFiles\a.json";
            bJsonUserControl.Filename = @"..\..\TestFiles\b.json";
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            var jsonSorter = new JsonSorter();
            aJsonUserControl.JSON = jsonSorter.LoadJsonContent(aJsonUserControl.JSON);
            bJsonUserControl.JSON = jsonSorter.LoadJsonContent(bJsonUserControl.JSON);
        }
    }
}
