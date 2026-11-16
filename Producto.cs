using System;

namespace TecnoPunto
{
    // Representa un producto del inventario de TecnoPunto
    public class Producto
    {
        // Campos privados: guardan el valor real de cada propiedad
        private string _nombre;
        private decimal _precio;
        private int _cantidad;

        // Código del producto (sin validación especial)
        public string Codigo { get; set; }

        // El nombre no puede estar vacío
        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El nombre del producto no puede estar vacío.");
                }
                _nombre = value;
            }
        }

        // El precio debe ser mayor que 0
        public decimal Precio
        {
            get { return _precio; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("El precio debe ser mayor que 0.");
                }
                _precio = value;
            }
        }

        // La cantidad no puede ser negativa (0 sí es válido)
        public int Cantidad
        {
            get { return _cantidad; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("La cantidad no puede ser negativa.");
                }
                _cantidad = value;
            }
        }

        // Propiedad de solo lectura: Precio x Cantidad
        public decimal ValorTotal
        {
            get { return Precio * Cantidad; }
        }

        // Constructor: usa las propiedades para que se apliquen las validaciones
        public Producto(string codigo, string nombre, decimal precio, int cantidad)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
        }

        // Imprime los datos del producto
        public void MostrarInfo()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Código:      " + Codigo);
            Console.WriteLine("Nombre:      " + Nombre);
            Console.WriteLine("Precio:      " + Precio.ToString("N2"));
            Console.WriteLine("Cantidad:    " + Cantidad);
            Console.WriteLine("Valor total: " + ValorTotal.ToString("N2"));
            Console.WriteLine("--------------------------------");
        }
    }
}
