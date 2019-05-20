namespace winProyectoFe
{
    partial class frmTopo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTopo));
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpOp = new System.Windows.Forms.GroupBox();
            this.pbHelp = new System.Windows.Forms.PictureBox();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.lblTiempo = new System.Windows.Forms.Label();
            this.tmrColor = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // pbExit
            // 
            this.pbExit.Image = global::winProyectoFe.Properties.Resources.exit1;
            this.pbExit.Location = new System.Drawing.Point(375, 143);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(20, 20);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExit.TabIndex = 7;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            this.pbExit.MouseLeave += new System.EventHandler(this.C_MouseLeave);
            this.pbExit.MouseHover += new System.EventHandler(this.C_MouseHover);
            // 
            // pbHome
            // 
            this.pbHome.Image = ((System.Drawing.Image)(resources.GetObject("pbHome.Image")));
            this.pbHome.Location = new System.Drawing.Point(349, 143);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(20, 20);
            this.pbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHome.TabIndex = 8;
            this.pbHome.TabStop = false;
            this.pbHome.Click += new System.EventHandler(this.pbHome_Click);
            this.pbHome.MouseLeave += new System.EventHandler(this.C_MouseLeave);
            this.pbHome.MouseHover += new System.EventHandler(this.C_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Topo";
            // 
            // grpOp
            // 
            this.grpOp.Location = new System.Drawing.Point(36, 61);
            this.grpOp.Name = "grpOp";
            this.grpOp.Size = new System.Drawing.Size(251, 89);
            this.grpOp.TabIndex = 10;
            this.grpOp.TabStop = false;
            // 
            // pbHelp
            // 
            this.pbHelp.Image = ((System.Drawing.Image)(resources.GetObject("pbHelp.Image")));
            this.pbHelp.Location = new System.Drawing.Point(365, 9);
            this.pbHelp.Name = "pbHelp";
            this.pbHelp.Size = new System.Drawing.Size(20, 20);
            this.pbHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHelp.TabIndex = 11;
            this.pbHelp.TabStop = false;
            this.pbHelp.MouseLeave += new System.EventHandler(this.C_MouseLeave);
            this.pbHelp.MouseHover += new System.EventHandler(this.C_MouseHover);
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.Location = new System.Drawing.Point(300, 26);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(52, 13);
            this.lblPuntos.TabIndex = 12;
            this.lblPuntos.Text = "Puntos: 0";
            // 
            // tmrTime
            // 
            this.tmrTime.Enabled = true;
            this.tmrTime.Interval = 1000;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(244, 26);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(54, 13);
            this.lblTiempo.TabIndex = 13;
            this.lblTiempo.Text = "Tiempo: 0";
            // 
            // tmrColor
            // 
            this.tmrColor.Interval = 250;
            this.tmrColor.Tick += new System.EventHandler(this.tmrColor_Tick);
            // 
            // frmTopo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(407, 175);
            this.ControlBox = false;
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblPuntos);
            this.Controls.Add(this.pbHelp);
            this.Controls.Add(this.grpOp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbHome);
            this.Controls.Add(this.pbExit);
            this.Name = "frmTopo";
            this.Text = "frmTopo";
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHelp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.PictureBox pbHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpOp;
        private System.Windows.Forms.PictureBox pbHelp;
        private System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Timer tmrColor;
    }
}