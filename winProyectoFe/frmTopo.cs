using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace winProyectoFe
{
    public partial class frmTopo : Form
    {
        List<string[]> Preguntas;
        Button Respuesta;
        Button aux;
        Button[] btn;
        Stopwatch sp;
        int puntos;
        int time;
        int preg;

        public frmTopo()
        {
            InitializeComponent();
            sp = new Stopwatch();
            leerArchivo();
            generarBotones();
            mostrarPregunta();
            puntos = 0;
            time = 0;
            preg = 10;
        }

        void generarBotones()
        {
            btn = new Button[5];
            for (int i = 0; i < 5; i++)
            {
                btn[i] = new Button();
                btn[i].Name = "btn" + i.ToString(); ;
                btn[i].Text = i.ToString();
                btn[i].Click += new System.EventHandler(this.Op_Click);
                grpOp.Controls.Add(btn[i]);
            }
            btn[0].Location = new Point(6, 19);
            btn[1].Location = new Point(87, 19);
            btn[2].Location = new Point(168, 19);
            btn[3].Location = new Point(42, 48);
            btn[4].Location = new Point(140, 48);
        }

        void mostrarPregunta()
        {
            string[] preg = obtenerPregunta();
            int[] num = { -1, -1, -1, -1, -1 };

            for(int i = 0; i < 5; i++)
            {
                int n;
                do
                {
                    n = new Random().Next(5);
                } while (num.Contains(n));

                num[i] = n;
                btn[n].Text = preg[i];
                if (i == 0)
                {
                    Respuesta = btn[n];
                }
            }
            sp.Reset();
            sp.Start();
        }

        void leerArchivo()
        {
            string[] lines = System.IO.File.ReadAllLines("...\\Preguntas\\Topo.txt");
            Preguntas = new List<string[]>();
            for (int i = 0; i < lines.Length; i++)
            {
                Preguntas.Add(lines[i].Split(' '));
            }
        }

        private string[] obtenerPregunta()
        {
            int l = new Random().Next(0, Preguntas.Count - 1);
            string[] preg = Preguntas.ElementAt(l);
            Preguntas.RemoveAt(l);
            return preg;
        }

        private void Op_Click(object sender, EventArgs e)
        {
            sp.Stop();
            aux = (Button)sender;
            if (aux == Respuesta)
            {
                aux.BackColor= Color.FromArgb(0, 130, 0);
                tmrColor.Enabled = true;
                puntos += (10000/(int)sp.ElapsedMilliseconds)*3;
            }
            else
            {
                aux.BackColor = Color.FromArgb(202, 0, 0);
                tmrColor.Enabled = true;
            }
            lblPuntos.Text = "Puntos: " + puntos.ToString();

            preg--;
            if (preg > 0)
            {
                
                mostrarPregunta();
            }
            else
            {
                tmrTime.Enabled = false;
                grpOp.Enabled = false;
                MessageBox.Show("Obtuviste: "+lblPuntos.Text+" puntos");
            }
         }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Program.frm.Dispose();
        }

        private void pbHome_Click(object sender, EventArgs e)
        {
            Program.frm.Visible = true;
            this.Dispose();
        }

        private void C_MouseHover(object sender, EventArgs e)
        {
            Control send = (Control)sender;
            send.Size = new Size(30, 30);
        }

        private void C_MouseLeave(object sender, EventArgs e)
        {

            Control send = (Control)sender;
            send.Size = new Size(25, 25);
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            time++;
            lblTiempo.Text = "Tiempo: " + time.ToString();
        }

        private void tmrColor_Tick(object sender, EventArgs e)
        {
            aux.BackColor = Color.FromArgb(255, 255, 192);

            tmrColor.Enabled = false;
        }
    }
}
