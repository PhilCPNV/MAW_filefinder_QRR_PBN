﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurboFinder
{
    public partial class FRM_MainForm : Form
    {
        public FRM_MainForm()
        {
            // Main initializer
            InitializeComponent();

            // Custom initializers
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
            if (LV_Search.SelectedItems.Count > 0)
            {
                if (File.Exists(LV_Search.SelectedItems[0].Text) && LV_Search.SelectedItems.Count > 0)
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
        }

        private void BTN_Clear_Click(object sender, EventArgs e)
        {
            TBX_Search.Text = null;
            LV_Search.Items.Clear();
            PB_Preview.Image = null; // Clear "Preview" image
        }

        private async void BTN_SearchGo_Click(object sender, EventArgs e)
        {
            try
            {
                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();
                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        // Start loading animation
                        CPB_loading.Visible = true;

                        // Load variables with the interface objects values
                        string Filter = CBX_Filter.Text;
                        string Search = TBX_Search.Text;

                        // Run a new task in background that's gathering all the files while not interuppting the main program execution
                        List<string> Files =  await Task.Run(() => LoadItems(fbd.SelectedPath, Search, Filter));

                        // Load the found items into the result object (listview)
                        foreach (string item in Files)
                        {
                            LV_Search.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Impossible de parcours ce dossier: {exception.Message}");
            }

            // Hide loading animation
            CPB_loading.Visible = false;
        }

        private List<string> LoadItems(string SelectedPath, string Search, string Filter)
        {
            List<string> Files;

            Search search = new Search();

            Files = search.Searching(SelectedPath, Search, Filter);

            return Files;
        }

        private void BTN_OpenExplorer_Click(object sender, EventArgs e)
        {
            if (LV_Search.SelectedItems.Count > 0)
            {
                if (File.Exists(LV_Search.SelectedItems[0].Text))
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo
                    {
                        Arguments = Path.GetDirectoryName(LV_Search.SelectedItems[0].Text),
                        FileName = "explorer.exe"
                    };
                    Process.Start(startInfo);
                }
                else
                {
                    MessageBox.Show(string.Format("{0} Directory does not exist!", LV_Search.SelectedItems[0].Text));
                }
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

        private void LV_Search_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            // Check if there is at least 1 item selected due to the unwanted effects of the IndexChange trigger twice!! (once while selecting the item and once on its deselection)
            if (LV_Search.SelectedItems.Count > 0)
            {
                string ext = Path.GetExtension(LV_Search.SelectedItems[0].Text);
                // Check if the SelectedItem is an image (can be displayed)
                if (ext == ".png" || ext == ".jpg" || ext == ".gif")
                {
                    // In some rare scenarios the files is not readable (can be a hidden file with a known extension!)
                    try
                    {
                        PB_Preview.Image = Image.FromFile(LV_Search.SelectedItems[0].Text); // Display image to the user
                    }
                    catch (Exception)
                    {
                        PB_Preview.Image = TurboFinder.Properties.Resources.Img_Error; // Show the corrupted image icon to the user
                    }
                }
                else
                {
                    PB_Preview.Image = TurboFinder.Properties.Resources.Img_File; // Show a default placeholder icon to the user
                }
            }
        }
    }
}
