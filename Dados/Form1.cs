using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dados
{
    public partial class Form1 : Form
    {
        JuegoLanzar empezarJuego;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            
            empezarJuego = new JuegoLanzar(2);
            btnJugar.Enabled = false;
            btnLanzar.Enabled = true;
        }

        private void btnLanzar_Click(object sender, EventArgs e)
        {
            empezarJuego.Jugar();
            lblPuntuacion.Text = empezarJuego.GetTotalDePuntos();
            pBox1.BackgroundImage = imageList1.Images[empezarJuego.GetDadoA()-1];
            pBox2.BackgroundImage = imageList1.Images[empezarJuego.GetDadoB()-1];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
