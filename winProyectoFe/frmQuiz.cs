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
    public partial class frmQuiz : Form
    {
        clsQuiz obj;
        RadioButton[] ra;
        int Pre = 0;
        string[] pregunta;
        string comp;
        int cont = 1;
        int p=0;


        public frmQuiz()
        {
            InitializeComponent();
            string Palabra = obtenerPregunta();
            crearCajas(Palabra.Length);
            obj = new clsQuiz(Palabra);
        }

        private void frmQuiz_Load(object sender, EventArgs e)
        {

        }

        string obtenerPregunta()
        {
            String[] lines = System.IO.File.ReadAllLines("...\\Preguntas\\Quiz.txt");
            int l = new Random().Next(0, lines.Length - 1);
            if (l % 2 == 0)
            {
                Pre = l;
            }
            else
            {
                Pre = l+1;
            }
            pregunta = lines[Pre].Split(',');
            lblPregunta.Text = pregunta[0];
            return pregunta[0];
        }
 
        private void crearCajas(int n)
        {
            ra = new RadioButton[4];
            String[] opc = System.IO.File.ReadAllLines("...\\Preguntas\\Quiz.txt");
            string[] op = opc[Pre+1].Split(',');

            for (int i = 0; i < 4; i++)
            {
                ra[i] = new RadioButton();
                ra[i].Location = new Point(5, i*30+20);
                ra[i].Name = "txt" + i.ToString();
                ra[i].Text = op[i];
                ra[i].Enabled = true;
                ra[i].Click += FrmQuiz_Click;
                gbRespuestas.Controls.Add(ra[i]);

            }
        }

        private void FrmQuiz_Click(object sender, EventArgs e)
        {
            pbNext_Click(sender, e);
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            Program.frm.Dispose();
            this.Dispose();
        }

        private void pbNext_Click(object sender, EventArgs e)
        {
            comp = "";
            if (cont <= 10)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (ra[i].Checked)
                    {
                        comp = ra[i].Text;
                    }
                }

                if (comp == pregunta[1])
                {
                    //MessageBox.Show("Correcto");
                    p= p + 10;
                    lblPuntaje.Text = "Puntaje:" + p.ToString();
                }
                else
                {
                    //MessageBox.Show("Incorrecto");

                    p = p - 5;
                    if (p < 0) p = 0;
                    lblPuntaje.Text = "Puntaje:"+ p.ToString();
                }            
                gbRespuestas.Controls.Clear();
                string Palabra = obtenerPregunta();
                crearCajas(Palabra.Length);
                obj = new clsQuiz(Palabra);
                cont++;
                if (cont == 11)
                {
                    if (p < 0) p = 0;
                    MessageBox.Show("Obtuviste: "+p.ToString()+" puntos");
                }
                else
                {
                    lblnump.Text = cont.ToString() + "/10";
                }
            }
        }

        private void pbHome_Click(object sender, EventArgs e)
        {
            Program.frm.Visible = true;
            this.Dispose();
        }
    }
}
