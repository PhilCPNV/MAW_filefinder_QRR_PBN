using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void InitializeInterface()
        {
            PNL_Search.Dock = DockStyle.Fill;
            PNL_Recent.Dock = DockStyle.Fill;
            PNL_Search.BringToFront();
        }

        private void BTN_Open_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Clear_Click(object sender, EventArgs e)
        {

        }

        private void BTN_SearchGo_Click(object sender, EventArgs e)
        {

        }

        private void BTN_OpenExplorer_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Search_Click(object sender, EventArgs e)
        {
            PNL_Search.BringToFront();
        }

        private void BTN_Recent_Click(object sender, EventArgs e)
        {
            PNL_Recent.BringToFront();
        }
    }
}
