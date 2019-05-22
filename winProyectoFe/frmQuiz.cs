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
            String[] lines = System.IO.File.ReadAllLines("C:\\Users\\1041029699\\Desktop\\Quiz.txt");
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
            String[] opc = System.IO.File.ReadAllLines("C:\\Users\\1041029699\\Desktop\\Quiz.txt");
            string[] op = opc[Pre+1].Split(',');

            for (int i = 0; i < 4; i++)
            {
                ra[i] = new RadioButton();
                ra[i].Location = new Point(1, i*30);
                ra[i].Name = "txt" + i.ToString();
                ra[i].Text = op[i];
                ra[i].Enabled = true;
                gbRespuestas.Controls.Add(ra[i]);

            }
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pbNext_Click(object sender, EventArgs e)
        {
            comp = "";
            if (cont <= 5)
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
                    MessageBox.Show("Correcto");
                    p= p + 10;
                    lblPuntaje.Text = "Puntaje:" + p.ToString();
                }
                else
                {
                    MessageBox.Show("Incorrecto");

                    p = p - 5;
                    lblPuntaje.Text = "Puntaje:"+ p.ToString();
                }            
                gbRespuestas.Controls.Clear();
                string Palabra = obtenerPregunta();
                crearCajas(Palabra.Length);
                obj = new clsQuiz(Palabra);
                cont++;
                if (cont == 6)
                {
                    MessageBox.Show("Juego terminado");
                }
                else
                {
                    lblnump.Text = cont.ToString() + "/5";
                }
            }
        }
    }
}
