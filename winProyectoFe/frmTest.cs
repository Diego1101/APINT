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
    public partial class frmTest : Form
    {
        int Bud = 0, Tao = 0, Cr = 0, Isl = 0, Hin = 0, Jud=0, preg=10;
        List<string[]> Preguntas;

        private void frmTest_Load(object sender, EventArgs e)
        {

        }

        private void rdbSi_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton op = (RadioButton)sender;
            if (op.Text.Equals("Si"))
            {
                int t = int.Parse(lblTipo.Text);
                switch (t)
                {
                    case 1:
                        Bud++;
                        break;

                    case 2:
                        Tao++;
                        break;

                    case 3:
                        Cr++;
                        break;

                    case 4:
                        Isl++;
                        break;

                    case 5:
                        Hin++;
                        break;

                    case 6:
                        Jud++;
                        break;
                }
            }
            if (preg > 0)
            {
                mostrarPreg();
            }
            else
            {
                if (Bud > Tao && Bud > Cr && Bud > Isl && Bud > Hin && Bud > Jud)
                {
                    MessageBox.Show("Budismo");
                    Program.frm.Visible = true;
                    this.Dispose();
                }
                else if (Tao > Cr && Tao > Isl && Tao > Hin && Tao > Jud)
                {
                    MessageBox.Show("Taoismo");
                    Program.frm.Visible = true;
                    this.Dispose();
                }
                else if (Cr > Isl && Cr > Hin && Cr > Jud)
                {
                    MessageBox.Show("Cristianismo");
                    Program.frm.Visible = true;
                    this.Dispose();
                }
                else if (Isl > Hin && Isl > Jud)
                {
                    MessageBox.Show("Islam");
                    Program.frm.Visible = true;
                    this.Dispose();
                }
                else if (Hin > Jud)
                {
                    MessageBox.Show("Hinduismo");
                    Program.frm.Visible = true;
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Judaismo");
                    Program.frm.Visible = true;
                    this.Dispose();
                }
            }                
        }

        public frmTest()
        {
            InitializeComponent();
            leerArchivo();
            mostrarPreg();
        }

        void leerArchivo()
        {
            string[] lines = System.IO.File.ReadAllLines("...\\Preguntas\\Test.txt");
            Preguntas = new List<string[]>();
            for (int i = 0; i < lines.Length; i+=2)
            {
                string[] aux = new string[2];
                aux[0] = lines[i];
                aux[1] = lines[i+1];
                Preguntas.Add(aux);
            }
        }

        void mostrarPreg()
        {
                int n = new Random().Next(Preguntas.Count);
                string[] aux = Preguntas[n];
                Preguntas.RemoveAt(n);
                lblPreg.Text = aux[0];
                lblTipo.Text = aux[1];
                rdbH.Checked=true;
                preg--;
        }

        private void pbHome_Click(object sender, EventArgs e)
        {
            Program.frm.Visible = true;
            this.Dispose();
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Program.frm.Dispose();
        }
    }
}
