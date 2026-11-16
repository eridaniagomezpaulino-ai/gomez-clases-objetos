using System;

namespace TecnoPunto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Control de inventario de TecnoPunto ===");

            // Se registran 3 productos usando un bucle (sin arreglos ni listas)
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Producto " + i + " de 3");

                bool registrado = false;

                // Se repite hasta que los datos sean válidos
                while (!registrado)
                {
                    try
                    {
                        Console.Write("Código: ");
                        string codigo = Console.ReadLine();

                        Console.Write("Nombre: ");
                        string nombre = Console.ReadLine();

                        Console.Write("Precio: ");
                        decimal precio = decimal.Parse(Console.ReadLine());

                        Console.Write("Cantidad: ");
                        int cantidad = int.Parse(Console.ReadLine());

                        // Si algún dato es inválido, el constructor lanza una excepción
                        Producto producto = new Producto(codigo, nombre, precio, cantidad);

                        producto.MostrarInfo();
                        registrado = true;
                    }
                    catch (ArgumentException ex)
                    {
                        // Error de validación (nombre vacío, precio negativo, etc.)
                        Console.WriteLine("Error: " + ex.Message + " Intente de nuevo.");
                        Console.WriteLine();
                    }
                    catch (FormatException)
                    {
                        // El usuario escribió letras donde iba un número
                        Console.WriteLine("Error: el precio y la cantidad deben ser números. Intente de nuevo.");
                        Console.WriteLine();
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Registro finalizado. Presione una tecla para salir.");
            Console.ReadKey();
        }
    }
}
