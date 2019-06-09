namespace winProyectoFe
{
    partial class frmQuiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuiz));
            this.gbRespuestas = new System.Windows.Forms.GroupBox();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.pbAyuda = new System.Windows.Forms.PictureBox();
            this.lblnump = new System.Windows.Forms.Label();
            this.pbHome = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAyuda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            this.SuspendLayout();
            // 
            // gbRespuestas
            // 
            this.gbRespuestas.Location = new System.Drawing.Point(41, 90);
            this.gbRespuestas.Margin = new System.Windows.Forms.Padding(2);
            this.gbRespuestas.Name = "gbRespuestas";
            this.gbRespuestas.Padding = new System.Windows.Forms.Padding(2);
            this.gbRespuestas.Size = new System.Drawing.Size(261, 163);
            this.gbRespuestas.TabIndex = 1;
            this.gbRespuestas.TabStop = false;
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.Location = new System.Drawing.Point(38, 255);
            this.lblPuntaje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(49, 13);
            this.lblPuntaje.TabIndex = 2;
            this.lblPuntaje.Text = "Puntaje: ";
            // 
            // lblPregunta
            // 
            this.lblPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta.Location = new System.Drawing.Point(38, 11);
            this.lblPregunta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(264, 76);
            this.lblPregunta.TabIndex = 3;
            this.lblPregunta.Text = "Pregunta ";
            this.lblPregunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbAyuda
            // 
            this.pbAyuda.Image = global::winProyectoFe.Properties.Resources.help;
            this.pbAyuda.Location = new System.Drawing.Point(340, 11);
            this.pbAyuda.Margin = new System.Windows.Forms.Padding(2);
            this.pbAyuda.Name = "pbAyuda";
            this.pbAyuda.Size = new System.Drawing.Size(25, 26);
            this.pbAyuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAyuda.TabIndex = 6;
            this.pbAyuda.TabStop = false;
            // 
            // lblnump
            // 
            this.lblnump.AutoSize = true;
            this.lblnump.Location = new System.Drawing.Point(39, 75);
            this.lblnump.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnump.Name = "lblnump";
            this.lblnump.Size = new System.Drawing.Size(30, 13);
            this.lblnump.TabIndex = 7;
            this.lblnump.Text = "1/10";
            // 
            // pbHome
            // 
            this.pbHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pbHome.Image = ((System.Drawing.Image)(resources.GetObject("pbHome.Image")));
            this.pbHome.Location = new System.Drawing.Point(340, 267);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(27, 26);
            this.pbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHome.TabIndex = 8;
            this.pbHome.TabStop = false;
            this.pbHome.Click += new System.EventHandler(this.pbHome_Click);
            // 
            // frmQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(379, 305);
            this.ControlBox = false;
            this.Controls.Add(this.pbHome);
            this.Controls.Add(this.lblnump);
            this.Controls.Add(this.pbAyuda);
            this.Controls.Add(this.lblPregunta);
            this.Controls.Add(this.lblPuntaje);
            this.Controls.Add(this.gbRespuestas);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmQuiz";
            this.Text = "Quiz";
            this.Load += new System.EventHandler(this.frmQuiz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAyuda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbRespuestas;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.PictureBox pbAyuda;
        private System.Windows.Forms.Label lblnump;
        private System.Windows.Forms.PictureBox pbHome;
    }
}