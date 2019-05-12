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
    public partial class frmAhorcado : Form
    {

        //iconos: Miu Icons
        clsAhorcado obj;
        public frmAhorcado()
        {
            InitializeComponent();
            crearBotones();
            obj = new clsAhorcado("HolaMundo");
        }

        private void crearBotones()
        {
            char letra = 'A';

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

        private void Letra_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int res = obj.probarLetra(btn.Text.ElementAt(0));

            switch (res)
            {
                case 0:
                    MessageBox.Show("Ganaste la palabra es: " + obj.PalabrAux);
                    break;

                case -1:
                    MessageBox.Show("Perdiste una vida, restantes: " + obj.getVidas().ToString());

                    break;

                case -2:
                    MessageBox.Show("Perdiste la palabra es: " + obj.PalabrAux);
                    break;

                default:
                    MessageBox.Show("Letra correcta, restantes: " + obj.getLetras().ToString());
                    break;
            }

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


        private void pbHelp_Click(object sender, EventArgs e)
        {

        }

        private void pbHome_Click(object sender, EventArgs e)
        {

        }

    }
}
