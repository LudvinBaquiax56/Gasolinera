
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
        List<Abastecimientos> abastecimientos = new List<Abastecimientos>();

        public void MostrarReporte()
        {
            dataGridViewReporte.DataSource = null;
            dataGridViewReporte.DataSource = abastecimientos;
            dataGridViewReporte.Refresh();
        }
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

        private void llenarTanque(Bomba bomba)
        {
            bomba.LLenarTanque = true;
            string jsonString = JsonSerializer.Serialize(bomba);

            // Enviar el JSON a Arduino
            puerto.WriteLine(jsonString);

            // Esperar y leer la respuesta de Arduino
            string response = puerto.ReadLine();

            if (!string.IsNullOrEmpty(response))
            {
                var jsonData2 = JsonSerializer.Deserialize<JsonDocument>(response);
                //bool ledState = jsonData2.RootElement.GetProperty("Codigo").GetBoolean();
                int buttonState = jsonData2.RootElement.GetProperty("Tiempo").GetInt32();
                int litrosAdespchar = Convert.ToInt32((buttonState - 2000)/1000);
                    //Convert.ToInt32(textBoxLitros.Text);


                UpdateUI(litrosAdespchar);
                int tiempo= Convert.ToInt32(textBoxLitrosDespachados.Text);
                int precio = Convert.ToInt32(textBoxPrecio.Text);
                string nombre = textBoxNombreCliente.Text;
                string tipoCombustible = comboBoxTipoGasolina.SelectedItem.ToString();



                Abastecimientos abastecimiento = new Abastecimientos();
                abastecimiento.Nombre = nombre;
                abastecimiento.LitrosVendidos = litrosAdespchar;
                abastecimiento.Precio = precio;
                abastecimiento.Tipo = tipoCombustible;
                abastecimiento.CalcularTotal();
                abastecimientos.Add(abastecimiento);

            }
        }
        private void UpdateUI(int litros)
        {
            textBoxLitrosDespachados.Text = litros.ToString();
            //buttonStatusLabel.Text = buttonState == 1 ? "Presionado" : "No presionado";
        }


        private void DespacharBomba(Bomba bomba)
        {
            int litrosAdespchar= Convert.ToInt32(textBoxLitros.Text);
            bomba.LLenarTanque = false;
            string json = JsonSerializer.Serialize(bomba);
            Console.WriteLine(json);
            puerto.WriteLine(json);

            int precio = Convert.ToInt32(textBoxPrecio.Text);
            string nombre= textBoxNombreCliente.Text;
            string tipoCombustible = comboBoxTipoGasolina.SelectedItem.ToString();

            

            Abastecimientos abastecimiento = new Abastecimientos();
            abastecimiento.Nombre = nombre;
            abastecimiento.LitrosVendidos = litrosAdespchar; 
            abastecimiento.Precio = precio;
            abastecimiento.Tipo=tipoCombustible;
            abastecimiento.CalcularTotal();
            abastecimientos.Add(abastecimiento);

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

        
        private void buttonVerReporte_Click(object sender, EventArgs e)
        {
            MostrarReporte();
        }

        private void buttonLlenarTanque1_Click(object sender, EventArgs e)
        {
            llenarTanque(bomba1);
        }

        private void buttonLlenarTanque2_Click(object sender, EventArgs e)
        {
            llenarTanque(bomba1);
        }
    }
}
