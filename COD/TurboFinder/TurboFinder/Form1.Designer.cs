namespace TurboFinder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_MainForm));
            this.TLP_MenuLeft = new System.Windows.Forms.TableLayoutPanel();
            this.BTN_Search = new System.Windows.Forms.Button();
            this.BTN_Recent = new System.Windows.Forms.Button();
            this.PNL_Search = new System.Windows.Forms.Panel();
            this.PNL_Recent = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TLP_MenuLeft.SuspendLayout();
            this.PNL_Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLP_MenuLeft
            // 
            this.TLP_MenuLeft.BackColor = System.Drawing.Color.OrangeRed;
            this.TLP_MenuLeft.ColumnCount = 1;
            this.TLP_MenuLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_MenuLeft.Controls.Add(this.BTN_Recent, 0, 1);
            this.TLP_MenuLeft.Controls.Add(this.BTN_Search, 0, 0);
            this.TLP_MenuLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.TLP_MenuLeft.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.TLP_MenuLeft.Location = new System.Drawing.Point(0, 0);
            this.TLP_MenuLeft.Margin = new System.Windows.Forms.Padding(0);
            this.TLP_MenuLeft.Name = "TLP_MenuLeft";
            this.TLP_MenuLeft.RowCount = 2;
            this.TLP_MenuLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_MenuLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_MenuLeft.Size = new System.Drawing.Size(166, 649);
            this.TLP_MenuLeft.TabIndex = 0;
            // 
            // BTN_Search
            // 
            this.BTN_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.BTN_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_Search.FlatAppearance.BorderSize = 0;
            this.BTN_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Search.ForeColor = System.Drawing.Color.White;
            this.BTN_Search.Location = new System.Drawing.Point(0, 0);
            this.BTN_Search.Margin = new System.Windows.Forms.Padding(0);
            this.BTN_Search.Name = "BTN_Search";
            this.BTN_Search.Size = new System.Drawing.Size(166, 324);
            this.BTN_Search.TabIndex = 1;
            this.BTN_Search.Text = "Search";
            this.BTN_Search.UseVisualStyleBackColor = false;
            // 
            // BTN_Recent
            // 
            this.BTN_Recent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.BTN_Recent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_Recent.FlatAppearance.BorderSize = 0;
            this.BTN_Recent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Recent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.BTN_Recent.ForeColor = System.Drawing.Color.White;
            this.BTN_Recent.Location = new System.Drawing.Point(0, 324);
            this.BTN_Recent.Margin = new System.Windows.Forms.Padding(0);
            this.BTN_Recent.Name = "BTN_Recent";
            this.BTN_Recent.Size = new System.Drawing.Size(166, 325);
            this.BTN_Recent.TabIndex = 2;
            this.BTN_Recent.Text = "Recent";
            this.BTN_Recent.UseVisualStyleBackColor = false;
            // 
            // PNL_Search
            // 
            this.PNL_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PNL_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.PNL_Search.Controls.Add(this.button2);
            this.PNL_Search.Controls.Add(this.button1);
            this.PNL_Search.Controls.Add(this.comboBox2);
            this.PNL_Search.Controls.Add(this.comboBox1);
            this.PNL_Search.Controls.Add(this.PNL_Recent);
            this.PNL_Search.Controls.Add(this.textBox1);
            this.PNL_Search.Location = new System.Drawing.Point(161, 0);
            this.PNL_Search.Name = "PNL_Search";
            this.PNL_Search.Size = new System.Drawing.Size(901, 649);
            this.PNL_Search.TabIndex = 1;
            // 
            // PNL_Recent
            // 
            this.PNL_Recent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.PNL_Recent.Location = new System.Drawing.Point(0, 123);
            this.PNL_Recent.Name = "PNL_Recent";
            this.PNL_Recent.Size = new System.Drawing.Size(893, 594);
            this.PNL_Recent.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(18, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(79, 39);
            this.comboBox1.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(103, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(428, 38);
            this.textBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(537, 11);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(115, 39);
            this.comboBox2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(728, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(660, 12);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 39);
            this.button2.TabIndex = 7;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // FRM_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1062, 649);
            this.Controls.Add(this.PNL_Search);
            this.Controls.Add(this.TLP_MenuLeft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_MainForm";
            this.Text = "TurboFinder";
            this.TLP_MenuLeft.ResumeLayout(false);
            this.PNL_Search.ResumeLayout(false);
            this.PNL_Search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLP_MenuLeft;
        private System.Windows.Forms.Button BTN_Recent;
        private System.Windows.Forms.Button BTN_Search;
        private System.Windows.Forms.Panel PNL_Search;
        private System.Windows.Forms.Panel PNL_Recent;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

