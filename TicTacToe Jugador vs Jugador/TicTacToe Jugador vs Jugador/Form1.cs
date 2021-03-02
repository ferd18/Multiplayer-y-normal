using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_Jugador_vs_Jugador
{
  
    public partial class Form1 : Form
    {
        //dialogo
        string Jugador1 = "";
        string Jugador2 = "";
        string Variable1 = "";
        string Variable2 = "";


        //controles
        bool pl1 = true;
        bool pl2 = false;
        bool Empate = false;
        bool WinX = false;
        bool WinO = false;



        public Form1()
        {
            InitializeComponent();
        }

        //Botones
        private void button11_Click(object sender, EventArgs e) //para cerrar
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pl1 == true)
            {
                button1.Text = Variable1;
                pl1 = false;
                pl2 = true;
                button1.Enabled = false;
            }

            else
            {
                button1.Text = Variable2;
                pl2 = false;
                pl1 = true;
                button1.Enabled = false;
            }

            if (pl1 == true)
            {
                label3.Text = "Turno del JUGADOR 1" + Environment.NewLine + Jugador1;
            }

            if (pl2 == true)
            {
                label3.Text = "Turno del JUGADOR 2" + Environment.NewLine + Jugador2;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pl1 == true)
            {
                button2.Text = Variable1;
                pl1 = false;
                pl2 = true;
                button2.Enabled = false;
            }

            else
            {
                button2.Text = Variable2;
                pl2 = false;
                pl1 = true;
                button2.Enabled = false;
            }

            if (pl1 == true)
            {
                label3.Text = "Turno del JUGADOR 1" + Environment.NewLine + Jugador1;
            }

            if (pl2 == true)
            {
                label3.Text = "Turno del JUGADOR 2" + Environment.NewLine + Jugador2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pl1 == true)
            {
                button3.Text = Variable1;
                pl1 = false;
                pl2 = true;
                button3.Enabled = false;
            }

            else
            {
                button3.Text = Variable2;
                pl2 = false;
                pl1 = true;
                button3.Enabled = false;
            }

            if (pl1 == true)
            {
                label3.Text = "Turno del JUGADOR 1" + Environment.NewLine + Jugador1;
            }

            if (pl2 == true)
            {
                label3.Text = "Turno del JUGADOR 2" + Environment.NewLine + Jugador2;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pl1 == true)
            {
                button4.Text = Variable1;
                pl1 = false;
                pl2 = true;
                button4.Enabled = false;
            }

            else
            {
                button4.Text = Variable2;
                pl2 = false;
                pl1 = true;
                button4.Enabled = false;
            }

            if (pl1 == true)
            {
                label3.Text = "Turno del JUGADOR 1" + Environment.NewLine + Jugador1;
            }

            if (pl2 == true)
            {
                label3.Text = "Turno del JUGADOR 2" + Environment.NewLine + Jugador2;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (pl1 == true)
            {
                button5.Text = Variable1;
                pl1 = false;
                pl2 = true;
                button5.Enabled = false;
            }

            else
            {
                button5.Text = Variable2;
                pl2 = false;
                pl1 = true;
                button5.Enabled = false;
            }

            if (pl1 == true)
            {
                label3.Text = "Turno del JUGADOR 1" + Environment.NewLine + Jugador1;
            }

            if (pl2 == true)
            {
                label3.Text = "Turno del JUGADOR 2" + Environment.NewLine + Jugador2;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (pl1 == true)
            {
                button6.Text = Variable1;
                pl1 = false;
                pl2 = true;
                button6.Enabled = false;
            }

            else
            {
                button6.Text = Variable2;
                pl2 = false;
                pl1 = true;
                button6.Enabled = false;
            }

            if (pl1 == true)
            {
                label3.Text = "Turno del JUGADOR 1" + Environment.NewLine + Jugador1;
            }

            if (pl2 == true)
            {
                label3.Text = "Turno del JUGADOR 2" + Environment.NewLine + Jugador2;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (pl1 == true)
            {
                button7.Text = Variable1;
                pl1 = false;
                pl2 = true;
                button7.Enabled = false;
            }

            else
            {
                button7.Text = Variable2;
                pl2 = false;
                pl1 = true;
                button7.Enabled = false;
            }

            if (pl1 == true)
            {
                label3.Text = "Turno del JUGADOR 1" + Environment.NewLine + Jugador1;
            }

            if (pl2 == true)
            {
                label3.Text = "Turno del JUGADOR 2" + Environment.NewLine + Jugador2;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (pl1 == true)
            {
                button8.Text = Variable1;
                pl1 = false;
                pl2 = true;
                button8.Enabled = false;
            }

            else
            {
                button8.Text = Variable2;
                pl2 = false;
                pl1 = true;
                button8.Enabled = false;
            }

            if (pl1 == true)
            {
                label3.Text = "Turno del JUGADOR 1" + Environment.NewLine + Jugador1;
            }

            if (pl2 == true)
            {
                label3.Text = "Turno del JUGADOR 2" + Environment.NewLine + Jugador2;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (pl1 == true)
            {
                button9.Text = Variable1;
                pl1 = false;
                pl2 = true;
                button9.Enabled = false;
            }

            else
            {
                button9.Text = Variable2;
                pl2 = false;
                pl1 = true;
                button9.Enabled = false;
            }

            if (pl1 == true)
            {
                label3.Text = "Turno del JUGADOR 1" + Environment.NewLine + Jugador1;
            }

            if (pl2 == true)
            {
                label3.Text = "Turno del JUGADOR 2" + Environment.NewLine + Jugador2;
            }
        }


        //Form
        private void Form1_Load(object sender, EventArgs e)
        {
            Jugador1 = Microsoft.VisualBasic.Interaction.InputBox("Escriba su nombre JUGADOR 1 ", "JUGADOR 1");        //Referencia de VisualBasic
            Variable1 = Jugador1 = Microsoft.VisualBasic.Interaction.InputBox("Escriba su símbolo JUGADOR 1 ", "SÍMBOLO DE JUGADOR 1");
            Jugador2 = Microsoft.VisualBasic.Interaction.InputBox("Escriba su nombre JUGADOR 2 ", "JUGADOR 2");
            Variable2 = Jugador2 = Microsoft.VisualBasic.Interaction.InputBox("Escriba su símbolo JUGADOR 2 ", "SÍMBOLO DE JUGADOR 2");

            if (Variable1 == Variable2)
            {
                MessageBox.Show("Vuelva a abrir el programa y llene de manera correcta. " + Environment.NewLine + "Los Símbolos no pueden ser iguales. ");
                this.Close();
            }
            if (Jugador1 == "" || Jugador2 == "" || Variable1 == "" || Variable2 == "")
            {
                MessageBox.Show("Vuelva a abrir el programa y llene el espacio vacío. " + Environment.NewLine + "Ningun dato puede quedar en blanco. ");
                this.Close();
            }

            Nuevo();
        }

        private void timer1_Tick(object sender, EventArgs e)    //Resultados
        {
            // haciendo las condiciones 
            if (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false && button4.Enabled == false && button5.Enabled == false
              && button6.Enabled == false && button7.Enabled == false && button8.Enabled == false && button9.Enabled == false && WinO == WinX == false)
            {
                Empate = false;
            }

            //condiciones para X
            if (button1.Text == Variable1 && button2.Text == Variable1 && button3.Text == Variable1)
            {
                WinX = true;
            }

            if (button2.Text == Variable1 && button3.Text == Variable1 && button4.Text == Variable1)
            {
                WinX = true;
            }

            if (button4.Text == Variable1 && button5.Text == Variable1 && button6.Text == Variable1)
            {
                WinX = true;
            }

            if (button7.Text == Variable1 && button8.Text == Variable1 && button9.Text == Variable1)
            {
                WinX = true;
            }

            if (button1.Text == Variable1 && button4.Text == Variable1 && button7.Text == Variable1)
            {
                WinX = true;
            }

            if (button2.Text == Variable1 && button5.Text == Variable1 && button8.Text == Variable1)
            {
                WinX = true;
            }

            if (button3.Text == Variable1 && button6.Text == Variable1 && button9.Text == Variable1)
            {
                WinX = true;
            }

            if (button1.Text == Variable1 && button5.Text == Variable1 && button9.Text == Variable1)
            {
                WinX = true;
            }

            if (button3.Text == Variable1 && button5.Text == Variable1 && button7.Text == Variable1)
            {
                WinX = true;
            }

            //condiciones para O
            if (button1.Text == Variable2 && button2.Text == Variable2 && button3.Text == Variable2)
            {
                WinO = true;
            }

            if (button2.Text == Variable2 && button3.Text == Variable2 && button4.Text == Variable2)
            {
                WinO = true;
            }

            if (button4.Text == Variable2 && button5.Text == Variable2 && button6.Text == Variable2)
            {
                WinO = true;
            }

            if (button7.Text == Variable2 && button8.Text == Variable2 && button9.Text == Variable2)
            {
                WinO = true;
            }

            if (button1.Text == Variable2 && button4.Text == Variable2 && button7.Text == Variable2)
            {
                WinO = true;
            }

            if (button2.Text == Variable2 && button5.Text == Variable2 && button8.Text == Variable2)
            {
                WinO = true;
            }

            if (button3.Text == Variable2 && button6.Text == Variable2 && button9.Text == Variable2)
            {
                WinO = true;
            }

            if (button1.Text == Variable2 && button5.Text == Variable2 && button9.Text == Variable2)
            {
                WinO = true;
            }

            if (button3.Text == Variable2 && button5.Text == Variable2 && button7.Text == Variable2)
            {
                WinO = true;
            }

            //primero
            textBox1.Hide();   //empate
            if (Empate == false)
            {
                textBox1.Show();
                textBox1.Text = "Empatado";
                Empate = true;
                Bloquear();
            }

            if (WinX == true) //ganadaro jugador 1
            {
                textBox1.Show();
                textBox1.Text = "Felicidades " + Jugador1 + Environment.NewLine + "Ganaste ";
                WinX = false;
                Bloquear();
            }

            if (WinO == true) //ganador jugador 2
            {
                textBox1.Show();
                textBox1.Text = "Felicidades " + Jugador2 + Environment.NewLine + "Ganaste ";
                WinO = false;
                Bloquear();
            }
        }

        void Bloquear() //bloquear botones despues de ganar
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        void Nuevo() //activar botones
        {
            button1.Enabled = true;
            button1.Text = "";
            button2.Enabled = true;
            button2.Text = "";
            button3.Enabled = true;
            button3.Text = "";
            button4.Enabled = true;
            button4.Text = "";
            button5.Enabled = true;
            button5.Text = "";
            button6.Enabled = true;
            button6.Text = "";
            button7.Enabled = true;
            button7.Text = "";
            button8.Enabled = true;
            button8.Text = "";
            button9.Enabled = true;
            button9.Text = "";
            label3.Text = "Turno del JUGADOR 1" + Environment.NewLine+ Jugador1;
            pl1 = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Nuevo();
        }
    }
}


