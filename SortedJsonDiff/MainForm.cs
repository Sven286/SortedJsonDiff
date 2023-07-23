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

        private void CompareButton_Click(object sender, EventArgs e)
        {
            CompareFiles(aJsonUserControl.JSON, bJsonUserControl.JSON);
        }

        private void CompareFiles(string file1Content, string file2Content)
        {
            rtbComparisonResult.Clear();
            List<string> lines1 = new List<string>(file1Content.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries));
            List<string> lines2 = new List<string>(file2Content.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries));

            List<DiffResult> diffResults = MyersDiffAlgorithm.Compute(lines1, lines2);

            foreach (var diffResult in diffResults)
            {
                if (diffResult.Status == DiffStatus.Common)
                {
                    rtbComparisonResult.SelectionColor = Color.Black;
                    rtbComparisonResult.AppendText(string.Join(Environment.NewLine, diffResult.Elements));
                }
                else if (diffResult.Status == DiffStatus.Added)
                {
                    rtbComparisonResult.SelectionColor = Color.Green;
                    rtbComparisonResult.AppendText(string.Join(Environment.NewLine, diffResult.Elements));
                }
                else if (diffResult.Status == DiffStatus.Deleted)
                {
                    rtbComparisonResult.SelectionColor = Color.Red;
                    rtbComparisonResult.AppendText(string.Join(Environment.NewLine, diffResult.Elements));
                }

                rtbComparisonResult.AppendText(Environment.NewLine);
            }
        }
    }
}

