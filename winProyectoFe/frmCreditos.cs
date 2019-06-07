using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winProyectoFe
{
    public partial class frmCreditos : Form
    {
        public frmCreditos()
        {
            InitializeComponent();
            txtCreditos.Text = "Elaborado por alumnos de la Universiad La Salle Pachuca\n";
            txtCreditos.Text += "Proyecto de la materia de Fe Religiosa y mundo Actual\n";
            txtCreditos.Text += "Iconos elaboradis por Linh Pham de www.flaticon.com\n";
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void C_MouseHover(object sender, EventArgs e)
        {
            Control send = (Control)sender;
            send.Size = new Size(25, 25);
        }

        private void C_MouseLeave(object sender, EventArgs e)
        {
            Control send = (Control)sender;
            send.Size = new Size(20, 20);
        }
    }
}
