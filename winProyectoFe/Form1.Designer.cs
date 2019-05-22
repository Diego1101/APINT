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
            this.grbPalabra = new System.Windows.Forms.GroupBox();
            this.lblVidas = new System.Windows.Forms.Label();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.lblPregunta = new System.Windows.Forms.Label();
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
            this.label1.Location = new System.Drawing.Point(69, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ahorcado";
            // 
            // pbRefresh
            // 
            this.pbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("pbRefresh.Image")));
            this.pbRefresh.Location = new System.Drawing.Point(980, 554);
            this.pbRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbRefresh.Name = "pbRefresh";
            this.pbRefresh.Size = new System.Drawing.Size(45, 46);
            this.pbRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRefresh.TabIndex = 5;
            this.pbRefresh.TabStop = false;
            // 
            // pbExit
            // 
            this.pbExit.Image = global::winProyectoFe.Properties.Resources.exit1;
            this.pbExit.Location = new System.Drawing.Point(1034, 554);
            this.pbExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(45, 46);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExit.TabIndex = 4;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            this.pbExit.MouseLeave += new System.EventHandler(this.pbExit_MouseLeave);
            this.pbExit.MouseHover += new System.EventHandler(this.pbExit_MouseHover);
            // 
            // pbHome
            // 
            this.pbHome.Image = ((System.Drawing.Image)(resources.GetObject("pbHome.Image")));
            this.pbHome.Location = new System.Drawing.Point(926, 554);
            this.pbHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(45, 46);
            this.pbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHome.TabIndex = 3;
            this.pbHome.TabStop = false;
            this.pbHome.Click += new System.EventHandler(this.pbHome_Click);
            // 
            // pbHelp
            // 
            this.pbHelp.Image = ((System.Drawing.Image)(resources.GetObject("pbHelp.Image")));
            this.pbHelp.Location = new System.Drawing.Point(1047, 18);
            this.pbHelp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbHelp.Name = "pbHelp";
            this.pbHelp.Size = new System.Drawing.Size(45, 46);
            this.pbHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHelp.TabIndex = 1;
            this.pbHelp.TabStop = false;
            this.pbHelp.Click += new System.EventHandler(this.pbHelp_Click);
            // 
            // pbHorca
            // 
            this.pbHorca.Image = global::winProyectoFe.Properties.Resources.ah1;
            this.pbHorca.Location = new System.Drawing.Point(18, 115);
            this.pbHorca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbHorca.Name = "pbHorca";
            this.pbHorca.Size = new System.Drawing.Size(450, 462);
            this.pbHorca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHorca.TabIndex = 6;
            this.pbHorca.TabStop = false;
            // 
            // grpLetras
            // 
            this.grpLetras.Location = new System.Drawing.Point(516, 258);
            this.grpLetras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpLetras.Name = "grpLetras";
            this.grpLetras.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpLetras.Size = new System.Drawing.Size(237, 215);
            this.grpLetras.TabIndex = 7;
            this.grpLetras.TabStop = false;
            // 
            // grbPalabra
            // 
            this.grbPalabra.Location = new System.Drawing.Point(516, 145);
            this.grbPalabra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbPalabra.Name = "grbPalabra";
            this.grbPalabra.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbPalabra.Size = new System.Drawing.Size(387, 78);
            this.grbPalabra.TabIndex = 8;
            this.grbPalabra.TabStop = false;
            // 
            // lblVidas
            // 
            this.lblVidas.AutoSize = true;
            this.lblVidas.Location = new System.Drawing.Point(18, 602);
            this.lblVidas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVidas.Name = "lblVidas";
            this.lblVidas.Size = new System.Drawing.Size(75, 20);
            this.lblVidas.TabIndex = 9;
            this.lblVidas.Text = "Vidas: 11";
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.Location = new System.Drawing.Point(926, 43);
            this.lblPuntos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(76, 20);
            this.lblPuntos.TabIndex = 10;
            this.lblPuntos.Text = "Puntos: 0";
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Location = new System.Drawing.Point(512, 74);
            this.lblPregunta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(92, 20);
            this.lblPregunta.TabIndex = 11;
            this.lblPregunta.Text = "¿Pregunta?";
            // 
            // frmAhorcado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1110, 632);
            this.Controls.Add(this.lblPregunta);
            this.Controls.Add(this.lblPuntos);
            this.Controls.Add(this.lblVidas);
            this.Controls.Add(this.grbPalabra);
            this.Controls.Add(this.grpLetras);
            this.Controls.Add(this.pbHorca);
            this.Controls.Add(this.pbRefresh);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.pbHome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbHelp);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAhorcado";
            this.Text = "Ahorcado";
            this.Load += new System.EventHandler(this.frmAhorcado_Load);
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
        private System.Windows.Forms.GroupBox grbPalabra;
        private System.Windows.Forms.Label lblVidas;
        private System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.Label lblPregunta;
    }
}

