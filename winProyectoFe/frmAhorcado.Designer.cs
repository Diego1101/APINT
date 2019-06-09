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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAhorcado));
            this.label1 = new System.Windows.Forms.Label();
            this.grpLetras = new System.Windows.Forms.GroupBox();
            this.grbPalabra = new System.Windows.Forms.GroupBox();
            this.lblVidas = new System.Windows.Forms.Label();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.pbHorca = new System.Windows.Forms.PictureBox();
            this.pbRefresh = new System.Windows.Forms.PictureBox();
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.pbHelp = new System.Windows.Forms.PictureBox();
            this.tmrSec = new System.Windows.Forms.Timer(this.components);
            this.lblTiempo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbHorca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ahorcado";
            // 
            // grpLetras
            // 
            this.grpLetras.Location = new System.Drawing.Point(344, 201);
            this.grpLetras.Name = "grpLetras";
            this.grpLetras.Size = new System.Drawing.Size(158, 140);
            this.grpLetras.TabIndex = 7;
            this.grpLetras.TabStop = false;
            // 
            // grbPalabra
            // 
            this.grbPalabra.Location = new System.Drawing.Point(344, 133);
            this.grbPalabra.Name = "grbPalabra";
            this.grbPalabra.Size = new System.Drawing.Size(258, 51);
            this.grbPalabra.TabIndex = 8;
            this.grbPalabra.TabStop = false;
            // 
            // lblVidas
            // 
            this.lblVidas.AutoSize = true;
            this.lblVidas.Location = new System.Drawing.Point(354, 9);
            this.lblVidas.Name = "lblVidas";
            this.lblVidas.Size = new System.Drawing.Size(51, 13);
            this.lblVidas.TabIndex = 9;
            this.lblVidas.Text = "Vidas: 11";
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.Location = new System.Drawing.Point(486, 9);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(52, 13);
            this.lblPuntos.TabIndex = 10;
            this.lblPuntos.Text = "Puntos: 0";
            // 
            // lblPregunta
            // 
            this.lblPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta.Location = new System.Drawing.Point(344, 57);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(258, 61);
            this.lblPregunta.TabIndex = 11;
            this.lblPregunta.Text = "¿Pregunta?";
            this.lblPregunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbHorca
            // 
            this.pbHorca.Image = global::winProyectoFe.Properties.Resources.ah1;
            this.pbHorca.Location = new System.Drawing.Point(12, 75);
            this.pbHorca.Name = "pbHorca";
            this.pbHorca.Size = new System.Drawing.Size(300, 300);
            this.pbHorca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHorca.TabIndex = 6;
            this.pbHorca.TabStop = false;
            // 
            // pbRefresh
            // 
            this.pbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("pbRefresh.Image")));
            this.pbRefresh.Location = new System.Drawing.Point(536, 349);
            this.pbRefresh.Name = "pbRefresh";
            this.pbRefresh.Size = new System.Drawing.Size(30, 30);
            this.pbRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRefresh.TabIndex = 5;
            this.pbRefresh.TabStop = false;
            this.pbRefresh.Click += new System.EventHandler(this.pbRefresh_Click);
            this.pbRefresh.MouseLeave += new System.EventHandler(this.pbExit_MouseLeave);
            this.pbRefresh.MouseHover += new System.EventHandler(this.pbExit_MouseHover);
            // 
            // pbHome
            // 
            this.pbHome.Image = ((System.Drawing.Image)(resources.GetObject("pbHome.Image")));
            this.pbHome.Location = new System.Drawing.Point(572, 349);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(30, 30);
            this.pbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHome.TabIndex = 3;
            this.pbHome.TabStop = false;
            this.pbHome.Click += new System.EventHandler(this.pbHome_Click);
            this.pbHome.MouseLeave += new System.EventHandler(this.pbExit_MouseLeave);
            this.pbHome.MouseHover += new System.EventHandler(this.pbExit_MouseHover);
            // 
            // pbHelp
            // 
            this.pbHelp.Image = ((System.Drawing.Image)(resources.GetObject("pbHelp.Image")));
            this.pbHelp.Location = new System.Drawing.Point(572, 12);
            this.pbHelp.Name = "pbHelp";
            this.pbHelp.Size = new System.Drawing.Size(30, 30);
            this.pbHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHelp.TabIndex = 1;
            this.pbHelp.TabStop = false;
            this.pbHelp.Click += new System.EventHandler(this.pbHelp_Click);
            this.pbHelp.MouseLeave += new System.EventHandler(this.pbExit_MouseLeave);
            this.pbHelp.MouseHover += new System.EventHandler(this.pbExit_MouseHover);
            // 
            // tmrSec
            // 
            this.tmrSec.Enabled = true;
            this.tmrSec.Interval = 1000;
            this.tmrSec.Tick += new System.EventHandler(this.tmrSec_Tick);
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(430, 9);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(33, 13);
            this.lblTiempo.TabIndex = 12;
            this.lblTiempo.Text = "0 seg";
            // 
            // frmAhorcado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(613, 391);
            this.ControlBox = false;
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblPregunta);
            this.Controls.Add(this.lblPuntos);
            this.Controls.Add(this.lblVidas);
            this.Controls.Add(this.grbPalabra);
            this.Controls.Add(this.grpLetras);
            this.Controls.Add(this.pbHorca);
            this.Controls.Add(this.pbRefresh);
            this.Controls.Add(this.pbHome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbHelp);
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(200, 200);
            this.Name = "frmAhorcado";
            this.Text = "Ahorcado";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmAhorcado_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pbHorca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHelp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbHelp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbHome;
        private System.Windows.Forms.PictureBox pbRefresh;
        private System.Windows.Forms.PictureBox pbHorca;
        private System.Windows.Forms.GroupBox grpLetras;
        private System.Windows.Forms.GroupBox grbPalabra;
        private System.Windows.Forms.Label lblVidas;
        private System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.Timer tmrSec;
        private System.Windows.Forms.Label lblTiempo;
    }
}

