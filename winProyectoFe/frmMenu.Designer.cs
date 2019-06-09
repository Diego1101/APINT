namespace winProyectoFe
{
    partial class frmMenu
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
            this.btnQuiz = new System.Windows.Forms.Button();
            this.btnAhorcado = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTopo = new System.Windows.Forms.Button();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.btnCreditos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuiz
            // 
            this.btnQuiz.Location = new System.Drawing.Point(40, 56);
            this.btnQuiz.Name = "btnQuiz";
            this.btnQuiz.Size = new System.Drawing.Size(75, 23);
            this.btnQuiz.TabIndex = 0;
            this.btnQuiz.Text = "Quiz";
            this.btnQuiz.UseVisualStyleBackColor = true;
            this.btnQuiz.Click += new System.EventHandler(this.btnQuiz_Click);
            // 
            // btnAhorcado
            // 
            this.btnAhorcado.Location = new System.Drawing.Point(40, 85);
            this.btnAhorcado.Name = "btnAhorcado";
            this.btnAhorcado.Size = new System.Drawing.Size(75, 23);
            this.btnAhorcado.TabIndex = 1;
            this.btnAhorcado.Text = "Ahorcado";
            this.btnAhorcado.UseVisualStyleBackColor = true;
            this.btnAhorcado.Click += new System.EventHandler(this.btnAhorcado_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(40, 148);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 2;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "SIAPIN";
            // 
            // btnTopo
            // 
            this.btnTopo.Location = new System.Drawing.Point(40, 114);
            this.btnTopo.Name = "btnTopo";
            this.btnTopo.Size = new System.Drawing.Size(75, 23);
            this.btnTopo.TabIndex = 7;
            this.btnTopo.Text = "Topo";
            this.btnTopo.UseVisualStyleBackColor = true;
            this.btnTopo.Click += new System.EventHandler(this.btnTopo_Click);
            // 
            // pbExit
            // 
            this.pbExit.Image = global::winProyectoFe.Properties.Resources.exit1;
            this.pbExit.Location = new System.Drawing.Point(127, 187);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(20, 20);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExit.TabIndex = 6;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            this.pbExit.MouseLeave += new System.EventHandler(this.C_MouseLeave);
            this.pbExit.MouseHover += new System.EventHandler(this.C_MouseHover);
            // 
            // btnCreditos
            // 
            this.btnCreditos.Location = new System.Drawing.Point(40, 177);
            this.btnCreditos.Name = "btnCreditos";
            this.btnCreditos.Size = new System.Drawing.Size(75, 23);
            this.btnCreditos.TabIndex = 8;
            this.btnCreditos.Text = "Creditos";
            this.btnCreditos.UseVisualStyleBackColor = true;
            this.btnCreditos.Click += new System.EventHandler(this.btnCreditos_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(159, 219);
            this.ControlBox = false;
            this.Controls.Add(this.btnCreditos);
            this.Controls.Add(this.btnTopo);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnAhorcado);
            this.Controls.Add(this.btnQuiz);
            this.Name = "frmMenu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuiz;
        private System.Windows.Forms.Button btnAhorcado;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.Button btnTopo;
        private System.Windows.Forms.Button btnCreditos;
    }
}