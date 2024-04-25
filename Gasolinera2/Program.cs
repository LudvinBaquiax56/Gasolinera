using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Gasolinera2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (SerialPort puerto = new SerialPort("COM6", 9600))
                {
                    Console.WriteLine("Hola mundo");
                    puerto.Open();
                    
                    bool salir = false;

                    while (!salir)
                    {
                        Console.WriteLine("Menu:");
                        Console.WriteLine("1. Encender dispositivo");
                        Console.WriteLine("2. Apagar dispositivo");
                        Console.WriteLine("3. Salir");

                        // Leer la opción del usuario
                        Console.Write("Seleccione una opción: ");
                        string opcion = Console.ReadLine();

                        // Procesar la opción del usuario
                        switch (opcion)
                        {
                            case "1":
                                Bomba persona1 = new Bomba("1", 30);
                                string json = JsonSerializer.Serialize(persona1);
                                Console.WriteLine(json);
                                puerto.WriteLine(json);
                                string textoRecibido = puerto.ReadLine();
                                Console.WriteLine(textoRecibido + "Recibido 1");
                                break;
                            case "2":
                                Bomba persona2 = new Bomba("0", 30);
                                string json2 = JsonSerializer.Serialize(persona2);
                                Console.WriteLine(json2);
                                puerto.WriteLine("0");
                                puerto.WriteLine(json2);
                                string textoRecibido2 = puerto.ReadLine();
                                Console.WriteLine(textoRecibido2 + "Recibido 2");
                                break;
                            case "3":
                                salir = true;
                                break;
                            default:
                                Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                                break;
                        }

                        Console.WriteLine(); // Agregar una línea en blanco para mejor legibilidad
                    }
                }
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
        }
    }
}
