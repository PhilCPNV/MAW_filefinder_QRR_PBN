using System;
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
            LBL_Counter.Text = "";
        }

        private void InitializeFilters()
        {
            string[] filters = { "Standard", "Dates", "Images", "Music", "Videos", "XLS", "DOC", "PDF", "Extentions"};
            CBX_Filter.Items.AddRange(filters);

            // Select the first result by default
            CBX_Filter.SelectedIndex = 0;
        }

        private void BTN_Open_Click(object sender, EventArgs e)
        {
            if (LV_Search.SelectedItems.Count > 0)
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
        }

        private void BTN_Clear_Click(object sender, EventArgs e)
        {
            TBX_Search.Text = null;
            PB_Preview.Image = null; // Clear "Preview" image
            RefreshContainer();
        }

        private async void BTN_SearchGo_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> Files;
                using (var fbd = new FolderBrowserDialog())
                {
                    // Show dialog box
                    DialogResult result = fbd.ShowDialog();

                    // Check for confirmation and a correct Path
                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        // Start loading animation
                        CPB_loading.Visible = true;

                        // Saves all the values to variables (could be replaced)
                        string Path = fbd.SelectedPath;
                        string SearchText = TBX_Search.Text;
                        string Filter = CBX_Filter.Text;

                        // Start gathering all specific files (background task) and saving the results into "Files"
                        Files = await Task.Run(() => GetFilesList(Path, SearchText, Filter));

                        // Stop loading animation
                        CPB_loading.Visible = false;

                        // Load the result ListView with the found files
                        foreach (string item in Files)
                        {
                            LV_Search.Items.Add(item);
                        }

                        // Display the number of files found to the UI
                        LBL_Counter.Text = "Files Found : " + LV_Search.Items.Count.ToString();

                        // Display Notification
                        NTF_ico.BalloonTipIcon = ToolTipIcon.Info;
                        if (LV_Search.Items.Count > 0)
                        {
                            NTF_ico.BalloonTipText = "Successfully found " + LV_Search.Items.Count.ToString() + " files";
                        }
                        else
                        {
                            NTF_ico.BalloonTipText = "No files found";
                        }
                        NTF_ico.BalloonTipTitle = "Search Finished";
                        NTF_ico.ShowBalloonTip(1000);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Impossible d'executer la recherche car certains dossiers require des droits systèmes");
            }
        }

        private List<string> GetFilesList(string Path, string SearchText, string Filter)
        {
            // Initialize objects
            Search search = new Search();
            List<string> Files;

            // Search all files for the specific atributes
            Files = search.Searching(Path, SearchText, Filter);
            
            // Return the result of the research
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
