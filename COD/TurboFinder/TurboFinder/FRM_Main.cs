using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurboFinder
{
    public partial class FRM_MainForm : Form
    {
        public FRM_MainForm()
        {
            InitializeComponent();
            InitializeInterface();
            InitializeFilters();
            InitializeContainer();
        }

        private void InitializeInterface()
        {
            PNL_Search.Dock = DockStyle.Fill;
            PNL_Recent.Dock = DockStyle.Fill;
            PNL_Search.BringToFront();
        }

        private void InitializeContainer()
        {
            RefreshContainer();
        }

        private void RefreshContainer()
        {
            LV_Search.Items.Clear();

            /*
            string[] files = Directory.GetFiles(CBX_Drive.Text);
            foreach (string file in files)
            {

                string fileName = Path.GetFileName(file);
                ListViewItem item = new ListViewItem(fileName);
                item.Tag = file;
                LV_Search.Items.Add(item);
            }
            */
        }

        private void InitializeFilters()
        {
            string[] filters = { "Words", "Dates", "Images", "Music", "Videos", "Extentions"};
            CBX_Filter.Items.AddRange(filters);

            // Select the first result by default
            CBX_Filter.SelectedIndex = 0;
        }

        private void BTN_Open_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Clear_Click(object sender, EventArgs e)
        {
            TBX_Search.Text = null;
            LV_Search.Items.Clear();
        }

        private void BTN_SearchGo_Click(object sender, EventArgs e)
        {
            Search search = new Search();

            List<string> Files = new List<string>();

            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    if ((Files = search.Searching(fbd.SelectedPath, TBX_Search.Text, CBX_Filter.Text)) != null)
                    {
                        foreach (string item in Files)
                        {
                            LV_Search.Items.Add(item);
                        }
                    }
                }
            }
        }

        private void BTN_OpenExplorer_Click(object sender, EventArgs e)
        {
            if (File.Exists(LV_Search.SelectedItems[0].Text))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    Arguments = LV_Search.SelectedItems[0].Text,
                    FileName = "explorer.exe"
                };
                Process.Start(startInfo);
            }
            else
            {
                MessageBox.Show(string.Format("{0} Directory does not exist!", LV_Search.SelectedItems[0].Text));
            }
        }

        private void BTN_Search_Click(object sender, EventArgs e)
        {
            PNL_Search.BringToFront();
        }

        private void BTN_Recent_Click(object sender, EventArgs e)
        {
            PNL_Recent.BringToFront();
        }

        private void CBX_Drive_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshContainer();
        }
    }
}
