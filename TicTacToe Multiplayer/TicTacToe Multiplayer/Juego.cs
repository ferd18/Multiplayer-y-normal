using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace TicTacToe_Multiplayer
{
    public partial class Juego : Form
    {
        public Juego(bool EsAnfitrion, string ip = null) //para conectarse o ser el afitrion 
        {
            InitializeComponent();
            MessegeReceiver.DoWork += MessegeReceiver_DoWork;
            CheckForIllegalCrossThreadCalls = false;

            if (EsAnfitrion)
            {
                JugadorChar = 'X';
                OponenteChar = 'O';
                server = new TcpListener(System.Net.IPAddress.Any, 5732);
                server.Start();
                sock = server.AcceptSocket();
            }
            else
            {
                JugadorChar = 'O';
                OponenteChar = 'X';
                try 
                {
                    client = new TcpClient(ip, 5732);
                    sock = client.Client;
                    MessegeReceiver.RunWorkerAsync();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Close(); 
                }
            }    
        }

        private void MessegeReceiver_DoWork(object sender, DoWorkEventArgs e) // recibe el mensaje del oponente
        {
            if (ComprobarEstado())
                return;
            Congelar();
            label1.Text = "Turno del Oponente!";
            RecibirMovimiento();
            label1.Text = "Tu Turno!";
            if (!ComprobarEstado())
                Descongelar();
        }

        

        private char JugadorChar;
        private char OponenteChar;
        private Socket sock;
        private BackgroundWorker MessegeReceiver = new BackgroundWorker();
        private TcpListener server = null;
        private TcpClient client; 

        private bool ComprobarEstado()
        {
            //Horizontales
            if(button1.Text == button2.Text && button2.Text == button3.Text && button3.Text != "")
            {
                if(button1.Text[0] == JugadorChar)
                {
                    label1.Text = "Ganaste!";
                    MessageBox.Show("Ganaste!");
                }
                else
                {
                    label1.Text = "Perdiste!";
                    MessageBox.Show("Perdiste!");
                }
                return true; 
            }

            else if (button4.Text == button5.Text && button5.Text == button6.Text && button6.Text != "")
            {
                if (button4.Text[0] == JugadorChar)
                {
                    label1.Text = "Ganaste!";
                    MessageBox.Show("Ganaste!");
                }
                else
                {
                    label1.Text = "Perdiste!";
                    MessageBox.Show("Perdiste!");
                }
                return true;
            }

            else if (button7.Text == button8.Text && button8.Text == button9.Text && button9.Text != "")
            {
                if (button7.Text[0] == JugadorChar)
                {
                    label1.Text = "Ganaste!";
                    MessageBox.Show("Ganaste!");
                }
                else
                {
                    label1.Text = "Perdiste!";
                    MessageBox.Show("Perdiste!");
                }
                return true;
            }
            //Verticales

            else if (button1.Text == button4.Text && button4.Text == button7.Text && button7.Text != "")
            {
                if (button1.Text[0] == JugadorChar)
                {
                    label1.Text = "Ganaste!";
                    MessageBox.Show("Ganaste!");
                }
                else
                {
                    label1.Text = "Perdiste!";
                    MessageBox.Show("Perdiste!");
                }
                return true;
            }

            else if (button2.Text == button5.Text && button5.Text == button8.Text && button8.Text != "")
            {
                if (button2.Text[0] == JugadorChar)
                {
                    label1.Text = "Ganaste!";
                    MessageBox.Show("Ganaste!");
                }
                else
                {
                    label1.Text = "Perdiste!";
                    MessageBox.Show("Perdiste!");
                }
                return true;
            }

            else if (button3.Text == button6.Text && button6.Text == button9.Text && button9.Text != "")
            {
                if (button3.Text[0] == JugadorChar)
                {
                    label1.Text = "Ganaste!";
                    MessageBox.Show("Ganaste!");
                }
                else
                {
                    label1.Text = "Perdiste!";
                    MessageBox.Show("Perdiste!");
                }
                return true;
            }

            
            else if (button1.Text == button5.Text && button5.Text == button9.Text && button9.Text != "")
            {
                if (button1.Text[0] == JugadorChar)
                {
                    label1.Text = "Ganaste!";
                    MessageBox.Show("Ganaste!");
                }
                else
                {
                    label1.Text = "Perdiste!";
                    MessageBox.Show("Perdiste!");
                }
                return true;
            }

            
            else if (button3.Text == button5.Text && button5.Text == button7.Text && button7.Text != "")
            {
                if (button3.Text[0] == JugadorChar)
                {
                    label1.Text = "Ganaste!";
                    MessageBox.Show("Ganaste!");
                }
                else
                {
                    label1.Text = "Perdiste!";
                    MessageBox.Show("Perdiste!");
                }
                return true;
            }
            
            //empate
            else if (button1.Text !="" && button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" &&button8.Text != "" && button9.Text != "")
            {
                label1.Text = "Es un empate!";
                MessageBox.Show("Es un empate!");
                return true;
            }
 
            return false;
        } 
        
        private void Congelar()
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

        private void Descongelar()
        {
            if (button1.Text == "")
                button1.Enabled = true;
            if (button2.Text == "")
                button2.Enabled = true;
            if (button3.Text == "")
                button3.Enabled = true;
            if (button4.Text == "")
                button4.Enabled = true;
            if (button5.Text == "")
                button5.Enabled = true;
            if (button6.Text == "")
                button6.Enabled = true;
            if (button7.Text == "")
                button7.Enabled = true;
            if (button8.Text == "")
                button8.Enabled = true;
            if (button9.Text == "")
                button9.Enabled = true;
        }

        //espera a que el oponente juegue en la posicion que desee
        private void RecibirMovimiento()
        {
            byte[] amortiguador = new byte[1];
            sock.Receive(amortiguador);
            if (amortiguador[0] == 1)
                button1.Text = OponenteChar.ToString();
            if (amortiguador[0] == 2)
                button2.Text = OponenteChar.ToString();
            if (amortiguador[0] == 3)
                button3.Text = OponenteChar.ToString();
            if (amortiguador[0] == 4)
                button4.Text = OponenteChar.ToString();
            if (amortiguador[0] == 5)
                button5.Text = OponenteChar.ToString();
            if (amortiguador[0] == 6)
                button6.Text = OponenteChar.ToString();
            if (amortiguador[0] == 7)
                button7.Text = OponenteChar.ToString();
            if (amortiguador[0] == 8)
                button8.Text = OponenteChar.ToString();
            if (amortiguador[0] == 9)
                button9.Text = OponenteChar.ToString();

        }

        //movimientos enviados
        private void button1_Click(object sender, EventArgs e)
        {
            byte[] num = { 1 };
            sock.Send(num);
            button1.Text = JugadorChar.ToString();
            MessegeReceiver.RunWorkerAsync();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] num = { 2 };
            sock.Send(num);
            button2.Text = JugadorChar.ToString();
            MessegeReceiver.RunWorkerAsync();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            byte[] num = { 3 };
            sock.Send(num);
            button3.Text = JugadorChar.ToString();
            MessegeReceiver.RunWorkerAsync();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            byte[] num = { 4 };
            sock.Send(num);
            button4.Text = JugadorChar.ToString();
            MessegeReceiver.RunWorkerAsync();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            byte[] num = { 5 };
            sock.Send(num);
            button5.Text = JugadorChar.ToString();
            MessegeReceiver.RunWorkerAsync();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            byte[] num = { 6 };
            sock.Send(num);
            button6.Text = JugadorChar.ToString();
            MessegeReceiver.RunWorkerAsync();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            byte[] num = { 7 };
            sock.Send(num);
            button7.Text = JugadorChar.ToString();
            MessegeReceiver.RunWorkerAsync();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            byte[] num = { 8 };
            sock.Send(num);
            button8.Text = JugadorChar.ToString();
            MessegeReceiver.RunWorkerAsync();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            byte[] num = { 9 };
            sock.Send(num);
            button9.Text = JugadorChar.ToString();
            MessegeReceiver.RunWorkerAsync();
        }

        //para cerrarlo
        private void Juego_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessegeReceiver.WorkerSupportsCancellation = true;
            MessegeReceiver.CancelAsync();
            if (server != null)
                server.Stop();
        }
    }
}


