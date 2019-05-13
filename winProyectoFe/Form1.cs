using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace winProyectoFe
{
    public partial class frmAhorcado : Form
    {
        
        clsAhorcado obj;
        TextBox[] txt;
        int puntos;

        public frmAhorcado()
        {
            InitializeComponent();
            string Palabra = obtenerPalabra();
            crearBotones();
            crearCajas(Palabra.Length);
            obj = new clsAhorcado(Palabra);
            puntos = 0;
        }

        string obtenerPalabra()
        {
            string[] lines = System.IO.File.ReadAllLines("...\\Preguntas\\Ahorcado.txt");
            int l = new Random().Next(0, lines.Length-1);
            if (l % 2 == 0) l++;
            lblPregunta.Text = lines[l - 1];
            return lines[l];
        }

        private void crearBotones()
        {
            char letra = 'A';
            grpLetras.Size = new Size(160, 140);
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                {

                    Button btnLetra = new Button();
                    btnLetra.Location = new Point(j * 25 + 5, i * 25 + 10);
                    btnLetra.Size = new Size(24, 24);
                    btnLetra.Name = "btn" + letra;
                    btnLetra.Text = letra++.ToString();
                    btnLetra.Click += new System.EventHandler(this.Letra_Click);
                    grpLetras.Controls.Add(btnLetra);
                    if (letra.Equals('O'))
                    {
                        btnLetra = new Button();
                        btnLetra.Location = new Point(++j * 25 + 5, i * 25 + 10);
                        btnLetra.Size = new Size(24, 24);
                        btnLetra.Name = "btn" + "n-";
                        btnLetra.Text = "Ñ";
                        btnLetra.Click += new System.EventHandler(this.Letra_Click);
                        grpLetras.Controls.Add(btnLetra);
                    }
                }
            }

            for (int j = 0; j < 3; j++)
            {
                Button btnLetra = new Button();
                btnLetra.Location = new Point(j * 25 + 5, 4 * 25 + 10);
                btnLetra.Size = new Size(24, 24);
                btnLetra.Name = "btn" + letra;
                btnLetra.Text = letra++.ToString();
                btnLetra.Click += new System.EventHandler(this.Letra_Click);
                grpLetras.Controls.Add(btnLetra);
            }
        }

        private void crearCajas(int n)
        {
            txt = new TextBox[n];
            for (int i = 0; i < n; i++)
            {
                txt[i] = new TextBox();
                txt[i].Location = new Point(i * 26+5, 10);
                txt[i].Size = new Size(24, 24);
                txt[i].Name = "txt" + i.ToString();
                txt[i].Text = "";
                txt[i].Enabled = false;
                txt[i].Font = new Font("Microsoft Sans Serif", 15F);
                grbPalabra.Controls.Add(txt[i]);
            }
            grbPalabra.Size = new Size(n*26+10, 45);
        }

        private void Letra_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int res = obj.probarLetra(btn.Text.ElementAt(0));
            lblVidas.Text = "Vidas: " + obj.getVidas().ToString();

            switch (res)
            {
                case 0:
                    MessageBox.Show("Ganaste");
                    mostrarLetra(btn.Text.ElementAt(0));
                    grpLetras.Enabled = false;
                    break;


                case -2:
                    MessageBox.Show("Perdiste");
                    grpLetras.Enabled = false;
                    for (int i = 0; i < obj.PalabrAux.Length; i++)
                    {
                        txt[i].Text = obj.PalabrAux[i].ToString();
                    }
                    puntos = 0;
                    break;

                case -1:
                    //letra incorrecta
                    puntos -= 50;
                    break;

                default:
                    mostrarLetra(btn.Text.ElementAt(0));
                    puntos += 100;
                    break;
            }
            lblPuntos.Text = "Puntos: " + puntos.ToString();
            btn.Enabled = false;

            actualizarImagen(obj.getVidas());
        }

        void actualizarImagen(int vidas)
        {
            switch (vidas)
            {
                case 0:
                    pbHorca.Image = Properties.Resources.ah12;
                    break;

                case 1:
                    pbHorca.Image = Properties.Resources.ah11;
                    break;

                case 2:
                    pbHorca.Image = Properties.Resources.ah10;
                    break;

                case 3:
                    pbHorca.Image = Properties.Resources.ah9;
                    break;

                case 4:
                    pbHorca.Image = Properties.Resources.ah8;
                    break;

                case 5:
                    pbHorca.Image = Properties.Resources.ah7;
                    break;

                case 6:
                    pbHorca.Image = Properties.Resources.ah6;
                    break;

                case 7:
                    pbHorca.Image = Properties.Resources.ah5;
                    break;

                case 8:
                    pbHorca.Image = Properties.Resources.ah4;
                    break;

                case 9:
                    pbHorca.Image = Properties.Resources.ah3;
                    break;

                case 10:
                    pbHorca.Image = Properties.Resources.ah2;
                    break;

                case 11:
                    pbHorca.Image = Properties.Resources.ah1;
                    break;


                default:
                    break;

            }
        }

        void mostrarLetra(char letra)
        {
            for (int i = 0; i < obj.PalabrAux.Length; i++)
            {
                if (obj.PalabrAux.ToUpper()[i] == letra)
                {
                    txt[i].Text = obj.PalabrAux[i].ToString();
                }
            }
        }
        
        private void pbHelp_Click(object sender, EventArgs e)
        {

        }

        private void pbHome_Click(object sender, EventArgs e)
        {

        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pbExit_MouseHover(object sender, EventArgs e)
        {
            PictureBox obj = (PictureBox)sender;
            obj.Size = new Size(35,35);
        }

        private void pbExit_MouseLeave(object sender, EventArgs e)
        {
            PictureBox obj = (PictureBox)sender;
            obj.Size = new Size(30, 30);
        }
    }
}
