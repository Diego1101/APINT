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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnQuiz_Click(object sender, EventArgs e)
        {
            frmQuiz frm = new frmQuiz();
            frm.Visible = true;
            this.Visible = false;

        }

        private void C_MouseHover(object sender, EventArgs e)
        {
            Control send = (Control)sender;
            send.Size = new Size(30, 30);
        }

        private void C_MouseLeave(object sender, EventArgs e)
        {

            Control send = (Control)sender;
            send.Size = new Size(20, 20);
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAhorcado_Click(object sender, EventArgs e)
        {
            frmAhorcado frm = new frmAhorcado();
            frm.Visible = true;
            this.Visible = false;
        }

        private void btnTopo_Click(object sender, EventArgs e)
        {
            frmTopo frm = new frmTopo();
            frm.Visible = true;
            this.Visible = false;
        }

        private void btnCreditos_Click(object sender, EventArgs e)
        {
            frmCreditos frm = new frmCreditos();
            frm.ShowDialog();
        }
    }
}
