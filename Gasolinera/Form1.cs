
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gasolinera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SerialPort puerto = new SerialPort("COM3", 9600); // Reemplaza "COM3" por el puerto serial correcto
            puerto.Open();
            Bomba persona1 = new Bomba("A", 30);
            string json = JsonSerializer.Serialize(persona1);
            puerto.WriteLine(json);
            puerto.Close();
        }
    }
}
