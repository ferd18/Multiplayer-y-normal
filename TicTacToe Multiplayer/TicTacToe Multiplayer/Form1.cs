using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_Multiplayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Juego NuevoJuego = new Juego(false, textBox1.Text);
            Visible = false;
            if (!NuevoJuego.IsDisposed)
                NuevoJuego.ShowDialog();
            Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Juego NuevoJuego = new Juego(true);
            Visible = false;
            if (!NuevoJuego.IsDisposed)
                NuevoJuego.ShowDialog();
            Visible = true;
        }
    }
}
