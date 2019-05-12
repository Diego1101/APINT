namespace winProyectoFe
{
    partial class frmAhorcado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAhorcado));
            this.label1 = new System.Windows.Forms.Label();
            this.pbRefresh = new System.Windows.Forms.PictureBox();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.pbHelp = new System.Windows.Forms.PictureBox();
            this.pbHorca = new System.Windows.Forms.PictureBox();
            this.grpLetras = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHorca)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ahorcado";
            // 
            // pbRefresh
            // 
            this.pbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("pbRefresh.Image")));
            this.pbRefresh.Location = new System.Drawing.Point(653, 332);
            this.pbRefresh.Name = "pbRefresh";
            this.pbRefresh.Size = new System.Drawing.Size(30, 30);
            this.pbRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRefresh.TabIndex = 5;
            this.pbRefresh.TabStop = false;
            // 
            // pbExit
            // 
            this.pbExit.Image = global::winProyectoFe.Properties.Resources.exit1;
            this.pbExit.Location = new System.Drawing.Point(689, 332);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(30, 30);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExit.TabIndex = 4;
            this.pbExit.TabStop = false;
            // 
            // pbHome
            // 
            this.pbHome.Image = ((System.Drawing.Image)(resources.GetObject("pbHome.Image")));
            this.pbHome.Location = new System.Drawing.Point(617, 332);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(30, 30);
            this.pbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHome.TabIndex = 3;
            this.pbHome.TabStop = false;
            this.pbHome.Click += new System.EventHandler(this.pbHome_Click);
            // 
            // pbHelp
            // 
            this.pbHelp.Image = ((System.Drawing.Image)(resources.GetObject("pbHelp.Image")));
            this.pbHelp.Location = new System.Drawing.Point(698, 12);
            this.pbHelp.Name = "pbHelp";
            this.pbHelp.Size = new System.Drawing.Size(30, 30);
            this.pbHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHelp.TabIndex = 1;
            this.pbHelp.TabStop = false;
            this.pbHelp.Click += new System.EventHandler(this.pbHelp_Click);
            // 
            // pbHorca
            // 
            this.pbHorca.Image = global::winProyectoFe.Properties.Resources.ah1;
            this.pbHorca.Location = new System.Drawing.Point(12, 47);
            this.pbHorca.Name = "pbHorca";
            this.pbHorca.Size = new System.Drawing.Size(300, 300);
            this.pbHorca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHorca.TabIndex = 6;
            this.pbHorca.TabStop = false;
            // 
            // grpLetras
            // 
            this.grpLetras.Location = new System.Drawing.Point(344, 122);
            this.grpLetras.Name = "grpLetras";
            this.grpLetras.Size = new System.Drawing.Size(158, 140);
            this.grpLetras.TabIndex = 7;
            this.grpLetras.TabStop = false;
            // 
            // frmAhorcado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(740, 382);
            this.Controls.Add(this.grpLetras);
            this.Controls.Add(this.pbHorca);
            this.Controls.Add(this.pbRefresh);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.pbHome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbHelp);
            this.Name = "frmAhorcado";
            this.Text = "Ahorcado";
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHorca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbHelp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbHome;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.PictureBox pbRefresh;
        private System.Windows.Forms.PictureBox pbHorca;
        private System.Windows.Forms.GroupBox grpLetras;
    }
}

