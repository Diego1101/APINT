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
            this.gbRespuestas = new System.Windows.Forms.GroupBox();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.pbNext = new System.Windows.Forms.PictureBox();
            this.pbSalir = new System.Windows.Forms.PictureBox();
            this.pbAyuda = new System.Windows.Forms.PictureBox();
            this.lblnump = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAyuda)).BeginInit();
            this.SuspendLayout();
            // 
            // gbRespuestas
            // 
            this.gbRespuestas.Location = new System.Drawing.Point(44, 172);
            this.gbRespuestas.Name = "gbRespuestas";
            this.gbRespuestas.Size = new System.Drawing.Size(728, 251);
            this.gbRespuestas.TabIndex = 1;
            this.gbRespuestas.TabStop = false;
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.Location = new System.Drawing.Point(623, 437);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(71, 20);
            this.lblPuntaje.TabIndex = 2;
            this.lblPuntaje.Text = "Puntaje: ";
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Location = new System.Drawing.Point(324, 65);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(78, 20);
            this.lblPregunta.TabIndex = 3;
            this.lblPregunta.Text = "Pregunta ";
            // 
            // pbNext
            // 
            this.pbNext.Image = global::winProyectoFe.Properties.Resources.next;
            this.pbNext.Location = new System.Drawing.Point(735, 98);
            this.pbNext.Name = "pbNext";
            this.pbNext.Size = new System.Drawing.Size(37, 40);
            this.pbNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNext.TabIndex = 5;
            this.pbNext.TabStop = false;
            this.pbNext.Click += new System.EventHandler(this.pbNext_Click);
            // 
            // pbSalir
            // 
            this.pbSalir.Image = global::winProyectoFe.Properties.Resources.exit;
            this.pbSalir.Location = new System.Drawing.Point(873, 460);
            this.pbSalir.Name = "pbSalir";
            this.pbSalir.Size = new System.Drawing.Size(37, 40);
            this.pbSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSalir.TabIndex = 4;
            this.pbSalir.TabStop = false;
            this.pbSalir.Click += new System.EventHandler(this.pbSalir_Click);
            // 
            // pbAyuda
            // 
            this.pbAyuda.Image = global::winProyectoFe.Properties.Resources.help;
            this.pbAyuda.Location = new System.Drawing.Point(873, 21);
            this.pbAyuda.Name = "pbAyuda";
            this.pbAyuda.Size = new System.Drawing.Size(37, 40);
            this.pbAyuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAyuda.TabIndex = 6;
            this.pbAyuda.TabStop = false;
            // 
            // lblnump
            // 
            this.lblnump.AutoSize = true;
            this.lblnump.Location = new System.Drawing.Point(380, 149);
            this.lblnump.Name = "lblnump";
            this.lblnump.Size = new System.Drawing.Size(31, 20);
            this.lblnump.TabIndex = 7;
            this.lblnump.Text = "1/5";
            // 
            // frmQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 512);
            this.ControlBox = false;
            this.Controls.Add(this.lblnump);
            this.Controls.Add(this.pbAyuda);
            this.Controls.Add(this.pbNext);
            this.Controls.Add(this.pbSalir);
            this.Controls.Add(this.lblPregunta);
            this.Controls.Add(this.lblPuntaje);
            this.Controls.Add(this.gbRespuestas);
            this.Name = "frmQuiz";
            this.Text = "Quiz";
            this.Load += new System.EventHandler(this.frmQuiz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAyuda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbRespuestas;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.PictureBox pbSalir;
        private System.Windows.Forms.PictureBox pbNext;
        private System.Windows.Forms.PictureBox pbAyuda;
        private System.Windows.Forms.Label lblnump;
    }
}