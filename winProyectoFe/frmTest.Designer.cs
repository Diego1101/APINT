namespace winProyectoFe
{
    partial class frmTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTest));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpPregunta = new System.Windows.Forms.GroupBox();
            this.rdbH = new System.Windows.Forms.RadioButton();
            this.lblPreg = new System.Windows.Forms.Label();
            this.rdbNo = new System.Windows.Forms.RadioButton();
            this.rdbSi = new System.Windows.Forms.RadioButton();
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.pbAyuda = new System.Windows.Forms.PictureBox();
            this.pbSalir = new System.Windows.Forms.PictureBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.grpPregunta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAyuda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(187, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(68, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Test";
            // 
            // grpPregunta
            // 
            this.grpPregunta.Controls.Add(this.rdbH);
            this.grpPregunta.Controls.Add(this.lblPreg);
            this.grpPregunta.Controls.Add(this.rdbNo);
            this.grpPregunta.Controls.Add(this.rdbSi);
            this.grpPregunta.Location = new System.Drawing.Point(12, 70);
            this.grpPregunta.Name = "grpPregunta";
            this.grpPregunta.Size = new System.Drawing.Size(430, 129);
            this.grpPregunta.TabIndex = 1;
            this.grpPregunta.TabStop = false;
            // 
            // rdbH
            // 
            this.rdbH.AutoSize = true;
            this.rdbH.Checked = true;
            this.rdbH.Location = new System.Drawing.Point(21, 83);
            this.rdbH.Name = "rdbH";
            this.rdbH.Size = new System.Drawing.Size(85, 17);
            this.rdbH.TabIndex = 3;
            this.rdbH.TabStop = true;
            this.rdbH.Text = "radioButton1";
            this.rdbH.UseVisualStyleBackColor = true;
            this.rdbH.Visible = false;
            // 
            // lblPreg
            // 
            this.lblPreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreg.Location = new System.Drawing.Point(6, 16);
            this.lblPreg.Name = "lblPreg";
            this.lblPreg.Size = new System.Drawing.Size(418, 49);
            this.lblPreg.TabIndex = 2;
            this.lblPreg.Text = "Pregunta";
            this.lblPreg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdbNo
            // 
            this.rdbNo.AutoSize = true;
            this.rdbNo.Location = new System.Drawing.Point(233, 83);
            this.rdbNo.Name = "rdbNo";
            this.rdbNo.Size = new System.Drawing.Size(39, 17);
            this.rdbNo.TabIndex = 1;
            this.rdbNo.Text = "No";
            this.rdbNo.UseVisualStyleBackColor = true;
            this.rdbNo.Click += new System.EventHandler(this.rdbSi_CheckedChanged);
            // 
            // rdbSi
            // 
            this.rdbSi.AutoSize = true;
            this.rdbSi.Location = new System.Drawing.Point(142, 83);
            this.rdbSi.Name = "rdbSi";
            this.rdbSi.Size = new System.Drawing.Size(34, 17);
            this.rdbSi.TabIndex = 0;
            this.rdbSi.Text = "Si";
            this.rdbSi.UseVisualStyleBackColor = true;
            this.rdbSi.Click += new System.EventHandler(this.rdbSi_CheckedChanged);
            // 
            // pbHome
            // 
            this.pbHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pbHome.Image = ((System.Drawing.Image)(resources.GetObject("pbHome.Image")));
            this.pbHome.Location = new System.Drawing.Point(572, 249);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(27, 26);
            this.pbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHome.TabIndex = 11;
            this.pbHome.TabStop = false;
            this.pbHome.Click += new System.EventHandler(this.pbHome_Click);
            // 
            // pbAyuda
            // 
            this.pbAyuda.Image = global::winProyectoFe.Properties.Resources.help;
            this.pbAyuda.Location = new System.Drawing.Point(604, 11);
            this.pbAyuda.Margin = new System.Windows.Forms.Padding(2);
            this.pbAyuda.Name = "pbAyuda";
            this.pbAyuda.Size = new System.Drawing.Size(25, 26);
            this.pbAyuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAyuda.TabIndex = 10;
            this.pbAyuda.TabStop = false;
            // 
            // pbSalir
            // 
            this.pbSalir.Image = global::winProyectoFe.Properties.Resources.exit;
            this.pbSalir.Location = new System.Drawing.Point(604, 249);
            this.pbSalir.Margin = new System.Windows.Forms.Padding(2);
            this.pbSalir.Name = "pbSalir";
            this.pbSalir.Size = new System.Drawing.Size(25, 26);
            this.pbSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSalir.TabIndex = 9;
            this.pbSalir.TabStop = false;
            this.pbSalir.Click += new System.EventHandler(this.pbSalir_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(383, 23);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(0, 13);
            this.lblTipo.TabIndex = 12;
            this.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTipo.Visible = false;
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(641, 286);
            this.ControlBox = false;
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.pbHome);
            this.Controls.Add(this.pbAyuda);
            this.Controls.Add(this.pbSalir);
            this.Controls.Add(this.grpPregunta);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmTest";
            this.Text = "frmTest";
            this.Load += new System.EventHandler(this.frmTest_Load);
            this.grpPregunta.ResumeLayout(false);
            this.grpPregunta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAyuda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpPregunta;
        private System.Windows.Forms.RadioButton rdbNo;
        private System.Windows.Forms.RadioButton rdbSi;
        private System.Windows.Forms.PictureBox pbHome;
        private System.Windows.Forms.PictureBox pbAyuda;
        private System.Windows.Forms.PictureBox pbSalir;
        private System.Windows.Forms.Label lblPreg;
        private System.Windows.Forms.RadioButton rdbH;
        private System.Windows.Forms.Label lblTipo;
    }
}