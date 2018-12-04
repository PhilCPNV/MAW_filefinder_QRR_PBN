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
using System.Globalization;

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
            // Write the result of the research in the log file 

            //récupère le chemin du log
            //TurboFinder.Properties.Resources.log
            String Date = System.DateTime.Now.ToString("dddd dd MMMM yyyy HH:mm:ss mm");
            string Line = "# Recherche du : " +  Date;
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\log.txt", true))
            {
                file.WriteLine(Line);
            }
            // read every line of the listView, take one item and all subitems, write it on the logfile, and repeat.
            int i = 0;
            foreach (ListViewItem item in this.LV_Search.Items)
            {


                //string Text = LV_Search.ReadToEnd().Spilt('');
                string LvLine = LV_Search.Items[i].Text;                
               

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:/log.txt", true))
                {
                    file.WriteLine(LvLine);
                }
                  i++;
            }

        }

        private void BTN_OpenExplorer_Click(object sender, EventArgs e)
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

        private void BTN_Search_Click(object sender, EventArgs e)
        {
            PNL_Search.BringToFront();
            LV_log.Clear();
        }

        private void BTN_Recent_Click(object sender, EventArgs e)
        {
            PNL_Recent.BringToFront();

            // Create LogHandler object
            LogHandler LH = new LogHandler();

            foreach (string line in LH.ReadLog(@"c:\log.txt"))
            {
                ListViewItem item = new ListViewItem();

                item.Text = line;

                LV_log.Items.Add(item);
            }
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

        private void BTNL_open_Click(object sender, EventArgs e)
        {
            // display an error message if no file is selected
            if (LV_log.SelectedItems.Count <= 0)
            {
                // Initializes the variables to pass to the MessageBox.Show method.

                string message = "Veuillez sélectionner un fichier avant de clicker sur les boutons";
                string caption = "Erreure : aucun fichier sélectionné";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);

            }
            else
            {
                String link = LV_log.SelectedItems[0].Text;
                Process.Start("explorer.exe", @link);
            }

            // IL FAUT FAIRE UNE FONCTION ICI POUR L'AFFICHAGE DES MESSAGES D'ERREURE
        }

        private void BTN_ExplorerOpen_Click(object sender, EventArgs e)
        {
            if (File.Exists(LV_log.SelectedItems[0].Text))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    Arguments = Path.GetDirectoryName(LV_log.SelectedItems[0].Text),
                    FileName = "explorer.exe"
                };
                Process.Start(startInfo);
            }
            else
            {
                MessageBox.Show(string.Format("{0} Directory does not exist!", Path.GetDirectoryName(LV_log.SelectedItems[0].Text)));
            }
        }
    }
}
