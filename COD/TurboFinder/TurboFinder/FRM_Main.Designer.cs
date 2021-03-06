﻿namespace TurboFinder
{
    partial class FRM_MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_MainForm));
            this.TLP_MenuLeft = new System.Windows.Forms.TableLayoutPanel();
            this.BTN_Recent = new System.Windows.Forms.Button();
            this.BTN_Search = new System.Windows.Forms.Button();
            this.PNL_Recent = new System.Windows.Forms.Panel();
            this.BTN_OpenExplorer_LOG = new System.Windows.Forms.Button();
            this.BTN_Open_Log = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.PNL_Search = new System.Windows.Forms.Panel();
            this.CPB_loading = new CircularProgressBar.CircularProgressBar();
            this.BTN_SearchGo = new System.Windows.Forms.Button();
            this.CBX_Filter = new System.Windows.Forms.ComboBox();
            this.TBX_Search = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTN_Clear = new System.Windows.Forms.Button();
            this.LV_Search = new System.Windows.Forms.ListView();
            this.PB_Preview = new System.Windows.Forms.PictureBox();
            this.BTN_OpenExplorer = new System.Windows.Forms.Button();
            this.BTN_Open = new System.Windows.Forms.Button();
            this.LBL_Counter = new System.Windows.Forms.Label();
            this.NTF_ico = new System.Windows.Forms.NotifyIcon(this.components);
            this.TLP_MenuLeft.SuspendLayout();
            this.PNL_Recent.SuspendLayout();
            this.PNL_Search.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Preview)).BeginInit();
            this.SuspendLayout();
            // 
            // TLP_MenuLeft
            // 
            this.TLP_MenuLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TLP_MenuLeft.ColumnCount = 1;
            this.TLP_MenuLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_MenuLeft.Controls.Add(this.BTN_Recent, 0, 3);
            this.TLP_MenuLeft.Controls.Add(this.BTN_Search, 0, 1);
            this.TLP_MenuLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.TLP_MenuLeft.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.TLP_MenuLeft.Location = new System.Drawing.Point(0, 0);
            this.TLP_MenuLeft.Margin = new System.Windows.Forms.Padding(0);
            this.TLP_MenuLeft.Name = "TLP_MenuLeft";
            this.TLP_MenuLeft.RowCount = 5;
            this.TLP_MenuLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.TLP_MenuLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.TLP_MenuLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.TLP_MenuLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.TLP_MenuLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.TLP_MenuLeft.Size = new System.Drawing.Size(129, 649);
            this.TLP_MenuLeft.TabIndex = 0;
            // 
            // BTN_Recent
            // 
            this.BTN_Recent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Recent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.BTN_Recent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_Recent.BackgroundImage")));
            this.BTN_Recent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_Recent.FlatAppearance.BorderSize = 0;
            this.BTN_Recent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Recent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.BTN_Recent.ForeColor = System.Drawing.Color.White;
            this.BTN_Recent.Location = new System.Drawing.Point(0, 353);
            this.BTN_Recent.Margin = new System.Windows.Forms.Padding(0);
            this.BTN_Recent.Name = "BTN_Recent";
            this.BTN_Recent.Size = new System.Drawing.Size(129, 117);
            this.BTN_Recent.TabIndex = 2;
            this.BTN_Recent.UseVisualStyleBackColor = false;
            this.BTN_Recent.Click += new System.EventHandler(this.BTN_Recent_Click);
            // 
            // BTN_Search
            // 
            this.BTN_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.BTN_Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_Search.BackgroundImage")));
            this.BTN_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_Search.FlatAppearance.BorderSize = 0;
            this.BTN_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Search.ForeColor = System.Drawing.Color.White;
            this.BTN_Search.Location = new System.Drawing.Point(0, 177);
            this.BTN_Search.Margin = new System.Windows.Forms.Padding(0);
            this.BTN_Search.Name = "BTN_Search";
            this.BTN_Search.Size = new System.Drawing.Size(129, 117);
            this.BTN_Search.TabIndex = 1;
            this.BTN_Search.UseVisualStyleBackColor = false;
            this.BTN_Search.Click += new System.EventHandler(this.BTN_Search_Click);
            // 
            // PNL_Recent
            // 
            this.PNL_Recent.BackColor = System.Drawing.Color.White;
            this.PNL_Recent.Controls.Add(this.BTN_OpenExplorer_LOG);
            this.PNL_Recent.Controls.Add(this.BTN_Open_Log);
            this.PNL_Recent.Controls.Add(this.panel2);
            this.PNL_Recent.Controls.Add(this.listView1);
            this.PNL_Recent.Location = new System.Drawing.Point(144, 77);
            this.PNL_Recent.Name = "PNL_Recent";
            this.PNL_Recent.Size = new System.Drawing.Size(930, 642);
            this.PNL_Recent.TabIndex = 2;
            // 
            // BTN_OpenExplorer_LOG
            // 
            this.BTN_OpenExplorer_LOG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_OpenExplorer_LOG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.BTN_OpenExplorer_LOG.FlatAppearance.BorderSize = 0;
            this.BTN_OpenExplorer_LOG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_OpenExplorer_LOG.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_OpenExplorer_LOG.ForeColor = System.Drawing.Color.White;
            this.BTN_OpenExplorer_LOG.Location = new System.Drawing.Point(681, 582);
            this.BTN_OpenExplorer_LOG.Margin = new System.Windows.Forms.Padding(0);
            this.BTN_OpenExplorer_LOG.Name = "BTN_OpenExplorer_LOG";
            this.BTN_OpenExplorer_LOG.Size = new System.Drawing.Size(231, 47);
            this.BTN_OpenExplorer_LOG.TabIndex = 20;
            this.BTN_OpenExplorer_LOG.Text = "Open in explorer";
            this.BTN_OpenExplorer_LOG.UseVisualStyleBackColor = false;
            // 
            // BTN_Open_Log
            // 
            this.BTN_Open_Log.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Open_Log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.BTN_Open_Log.FlatAppearance.BorderSize = 0;
            this.BTN_Open_Log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Open_Log.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Open_Log.ForeColor = System.Drawing.Color.White;
            this.BTN_Open_Log.Location = new System.Drawing.Point(428, 582);
            this.BTN_Open_Log.Margin = new System.Windows.Forms.Padding(0);
            this.BTN_Open_Log.Name = "BTN_Open_Log";
            this.BTN_Open_Log.Size = new System.Drawing.Size(231, 47);
            this.BTN_Open_Log.TabIndex = 19;
            this.BTN_Open_Log.Text = "Open";
            this.BTN_Open_Log.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(930, 29);
            this.panel2.TabIndex = 17;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Location = new System.Drawing.Point(0, 26);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(931, 544);
            this.listView1.TabIndex = 18;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // PNL_Search
            // 
            this.PNL_Search.BackColor = System.Drawing.Color.White;
            this.PNL_Search.Controls.Add(this.LBL_Counter);
            this.PNL_Search.Controls.Add(this.CPB_loading);
            this.PNL_Search.Controls.Add(this.BTN_SearchGo);
            this.PNL_Search.Controls.Add(this.CBX_Filter);
            this.PNL_Search.Controls.Add(this.TBX_Search);
            this.PNL_Search.Controls.Add(this.panel1);
            this.PNL_Search.Controls.Add(this.LV_Search);
            this.PNL_Search.Controls.Add(this.PB_Preview);
            this.PNL_Search.Controls.Add(this.BTN_OpenExplorer);
            this.PNL_Search.Controls.Add(this.BTN_Open);
            this.PNL_Search.Location = new System.Drawing.Point(202, 16);
            this.PNL_Search.Name = "PNL_Search";
            this.PNL_Search.Size = new System.Drawing.Size(933, 649);
            this.PNL_Search.TabIndex = 1;
            // 
            // CPB_loading
            // 
            this.CPB_loading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CPB_loading.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("CPB_loading.AnimationFunction")));
            this.CPB_loading.AnimationSpeed = 1600;
            this.CPB_loading.BackColor = System.Drawing.Color.Transparent;
            this.CPB_loading.Font = new System.Drawing.Font("Source Sans Pro", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPB_loading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CPB_loading.InnerColor = System.Drawing.Color.Transparent;
            this.CPB_loading.InnerMargin = 0;
            this.CPB_loading.InnerWidth = 0;
            this.CPB_loading.Location = new System.Drawing.Point(154, 183);
            this.CPB_loading.MarqueeAnimationSpeed = 1000;
            this.CPB_loading.Name = "CPB_loading";
            this.CPB_loading.OuterColor = System.Drawing.Color.Gray;
            this.CPB_loading.OuterMargin = -38;
            this.CPB_loading.OuterWidth = 38;
            this.CPB_loading.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.CPB_loading.ProgressWidth = 38;
            this.CPB_loading.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPB_loading.Size = new System.Drawing.Size(320, 320);
            this.CPB_loading.StartAngle = 270;
            this.CPB_loading.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.CPB_loading.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.CPB_loading.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.CPB_loading.SubscriptText = "";
            this.CPB_loading.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.CPB_loading.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.CPB_loading.SuperscriptText = "";
            this.CPB_loading.TabIndex = 0;
            this.CPB_loading.Text = "Loading...";
            this.CPB_loading.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.CPB_loading.UseWaitCursor = true;
            this.CPB_loading.Value = 60;
            this.CPB_loading.Visible = false;
            // 
            // BTN_SearchGo
            // 
            this.BTN_SearchGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_SearchGo.BackColor = System.Drawing.Color.White;
            this.BTN_SearchGo.FlatAppearance.BorderSize = 0;
            this.BTN_SearchGo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BTN_SearchGo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BTN_SearchGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SearchGo.Font = new System.Drawing.Font("Source Sans Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SearchGo.ForeColor = System.Drawing.Color.Black;
            this.BTN_SearchGo.Location = new System.Drawing.Point(767, 8);
            this.BTN_SearchGo.Margin = new System.Windows.Forms.Padding(0);
            this.BTN_SearchGo.Name = "BTN_SearchGo";
            this.BTN_SearchGo.Size = new System.Drawing.Size(153, 38);
            this.BTN_SearchGo.TabIndex = 6;
            this.BTN_SearchGo.Text = "Search";
            this.BTN_SearchGo.UseVisualStyleBackColor = false;
            this.BTN_SearchGo.Click += new System.EventHandler(this.BTN_SearchGo_Click);
            // 
            // CBX_Filter
            // 
            this.CBX_Filter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CBX_Filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBX_Filter.Font = new System.Drawing.Font("Source Sans Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBX_Filter.FormattingEnabled = true;
            this.CBX_Filter.Location = new System.Drawing.Point(530, 7);
            this.CBX_Filter.Name = "CBX_Filter";
            this.CBX_Filter.Size = new System.Drawing.Size(142, 38);
            this.CBX_Filter.TabIndex = 5;
            // 
            // TBX_Search
            // 
            this.TBX_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBX_Search.Font = new System.Drawing.Font("Source Sans Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBX_Search.Location = new System.Drawing.Point(11, 7);
            this.TBX_Search.Name = "TBX_Search";
            this.TBX_Search.Size = new System.Drawing.Size(513, 38);
            this.TBX_Search.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.panel1.Controls.Add(this.BTN_Clear);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 56);
            this.panel1.TabIndex = 16;
            // 
            // BTN_Clear
            // 
            this.BTN_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Clear.BackColor = System.Drawing.Color.White;
            this.BTN_Clear.FlatAppearance.BorderSize = 0;
            this.BTN_Clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BTN_Clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BTN_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Clear.Font = new System.Drawing.Font("Source Sans Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Clear.ForeColor = System.Drawing.Color.Black;
            this.BTN_Clear.Location = new System.Drawing.Point(679, 10);
            this.BTN_Clear.Margin = new System.Windows.Forms.Padding(0);
            this.BTN_Clear.Name = "BTN_Clear";
            this.BTN_Clear.Size = new System.Drawing.Size(80, 38);
            this.BTN_Clear.TabIndex = 7;
            this.BTN_Clear.Text = "Clear";
            this.BTN_Clear.UseVisualStyleBackColor = false;
            this.BTN_Clear.Click += new System.EventHandler(this.BTN_Clear_Click);
            // 
            // LV_Search
            // 
            this.LV_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LV_Search.Location = new System.Drawing.Point(0, 51);
            this.LV_Search.MultiSelect = false;
            this.LV_Search.Name = "LV_Search";
            this.LV_Search.Size = new System.Drawing.Size(620, 598);
            this.LV_Search.TabIndex = 15;
            this.LV_Search.UseCompatibleStateImageBehavior = false;
            this.LV_Search.View = System.Windows.Forms.View.List;
            this.LV_Search.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LV_Search_ItemSelectionChanged);
            // 
            // PB_Preview
            // 
            this.PB_Preview.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PB_Preview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PB_Preview.Location = new System.Drawing.Point(671, 167);
            this.PB_Preview.Name = "PB_Preview";
            this.PB_Preview.Size = new System.Drawing.Size(231, 195);
            this.PB_Preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Preview.TabIndex = 14;
            this.PB_Preview.TabStop = false;
            // 
            // BTN_OpenExplorer
            // 
            this.BTN_OpenExplorer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BTN_OpenExplorer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.BTN_OpenExplorer.FlatAppearance.BorderSize = 0;
            this.BTN_OpenExplorer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_OpenExplorer.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_OpenExplorer.ForeColor = System.Drawing.Color.White;
            this.BTN_OpenExplorer.Location = new System.Drawing.Point(671, 456);
            this.BTN_OpenExplorer.Margin = new System.Windows.Forms.Padding(0);
            this.BTN_OpenExplorer.Name = "BTN_OpenExplorer";
            this.BTN_OpenExplorer.Size = new System.Drawing.Size(231, 47);
            this.BTN_OpenExplorer.TabIndex = 13;
            this.BTN_OpenExplorer.Text = "Open in explorer";
            this.BTN_OpenExplorer.UseVisualStyleBackColor = false;
            this.BTN_OpenExplorer.Click += new System.EventHandler(this.BTN_OpenExplorer_Click);
            // 
            // BTN_Open
            // 
            this.BTN_Open.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BTN_Open.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.BTN_Open.FlatAppearance.BorderSize = 0;
            this.BTN_Open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Open.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Open.ForeColor = System.Drawing.Color.White;
            this.BTN_Open.Location = new System.Drawing.Point(671, 393);
            this.BTN_Open.Margin = new System.Windows.Forms.Padding(0);
            this.BTN_Open.Name = "BTN_Open";
            this.BTN_Open.Size = new System.Drawing.Size(231, 47);
            this.BTN_Open.TabIndex = 12;
            this.BTN_Open.Text = "Open";
            this.BTN_Open.UseVisualStyleBackColor = false;
            this.BTN_Open.Click += new System.EventHandler(this.BTN_Open_Click);
            // 
            // LBL_Counter
            // 
            this.LBL_Counter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_Counter.AutoSize = true;
            this.LBL_Counter.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Bold);
            this.LBL_Counter.Location = new System.Drawing.Point(666, 605);
            this.LBL_Counter.Name = "LBL_Counter";
            this.LBL_Counter.Size = new System.Drawing.Size(132, 26);
            this.LBL_Counter.TabIndex = 17;
            this.LBL_Counter.Text = "Files Found : ";
            // 
            // NTF_ico
            // 
            this.NTF_ico.Icon = ((System.Drawing.Icon)(resources.GetObject("NTF_ico.Icon")));
            this.NTF_ico.Tag = "";
            this.NTF_ico.Text = "TurboFinder";
            this.NTF_ico.Visible = true;
            // 
            // FRM_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1062, 649);
            this.Controls.Add(this.PNL_Search);
            this.Controls.Add(this.PNL_Recent);
            this.Controls.Add(this.TLP_MenuLeft);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "FRM_MainForm";
            this.Text = "TurboFinder";
            this.TLP_MenuLeft.ResumeLayout(false);
            this.PNL_Recent.ResumeLayout(false);
            this.PNL_Search.ResumeLayout(false);
            this.PNL_Search.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Preview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLP_MenuLeft;
        private System.Windows.Forms.Button BTN_Recent;
        private System.Windows.Forms.Button BTN_Search;
        private System.Windows.Forms.Panel PNL_Search;
        private System.Windows.Forms.Panel PNL_Recent;
        private System.Windows.Forms.Button BTN_Clear;
        private System.Windows.Forms.Button BTN_SearchGo;
        private System.Windows.Forms.ComboBox CBX_Filter;
        private System.Windows.Forms.TextBox TBX_Search;
        private System.Windows.Forms.ListView LV_Search;
        private System.Windows.Forms.PictureBox PB_Preview;
        private System.Windows.Forms.Button BTN_OpenExplorer;
        private System.Windows.Forms.Button BTN_Open;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel2;
        private CircularProgressBar.CircularProgressBar CPB_loading;
        private System.Windows.Forms.Button BTN_OpenExplorer_LOG;
        private System.Windows.Forms.Button BTN_Open_Log;
        private System.Windows.Forms.Label LBL_Counter;
        private System.Windows.Forms.NotifyIcon NTF_ico;
    }
}

