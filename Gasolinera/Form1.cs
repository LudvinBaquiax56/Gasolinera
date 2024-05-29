
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gasolinera
{
    public partial class Form1 : Form
    {
        SerialPort puerto;
        string COM = "COM6";
        Bomba bomba1;
        Bomba bomba2;
        
        
        public Form1()
        {
            InitializeComponent();
            bomba1 = new Bomba("1", 30);
            bomba2= new Bomba("2", 30);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                puerto = new SerialPort(COM, 9600);
                puerto.Open();

            }
            catch (UnauthorizedAccessException ex)
            {
                // Manejar el error de acceso no autorizado al puerto serial
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine("Error no autorizado");
            }
            catch (IOException ex)
            {
                // Manejar otros errores de E/S
                Console.WriteLine("Error de ES");
                Console.WriteLine($"Error de E/S: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Manejar cualquier otra excepción inesperada
                Console.WriteLine("Error inesperado");
                Console.WriteLine($"Error inesperado: {ex.Message}");
            }
            //if(puerto != null )
            //{
            //puerto.Open();
            //}
        }

        

        private void ff(Bomba bomba)
        {
            int litrosAdespchar= Convert.ToInt32(textBoxLitros.Text);
            string json = JsonSerializer.Serialize(bomba);
            Console.WriteLine(json);
            puerto.WriteLine(json);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(puerto != null && puerto.IsOpen)
            {
                puerto.Close();
            }
        }

        private void buttonBomba1_Click(object sender, EventArgs e)
        {
            DespacharBomba(bomba1);
        }

        private void buttonBomba2_Click(object sender, EventArgs e)
        {
            DespacharBomba(bomba2);
        }

        private void textBoxLitros_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
