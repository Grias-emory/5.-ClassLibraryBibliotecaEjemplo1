using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBibliotecaEjemplo
{
    // Esta clase representa un producto cualquiera, como podría ser parte de una tienda o inventario
    public class Producto
    {
        // Campos privados donde se guardan internamente los datos del producto
        private string nombre;   // Aquí se guarda el nombre del producto
        private decimal precio;  // Aquí se guarda el precio del producto (decimal porque permite valores con centavos)

        // Propiedad pública para acceder o modificar el nombre del producto desde fuera de la clase
        public string Nombre
        {
            get { return nombre; }    // Devuelve el nombre actual del producto
            set { nombre = value; }   // Permite asignar un nuevo nombre
        }

        // Propiedad pública para acceder o modificar el precio del producto
        public decimal Precio
        {
            get { return precio; }    // Devuelve el precio actual del producto
            set { precio = value; }   // Permite asignar un nuevo precio
        }

        // Método que devuelve una descripción amigable del producto
        public string ObtenerDescripcion()
        {
            // Retorna una cadena con el nombre y el precio del producto, el ":C" lo muestra con símbolo de moneda
            return $"Producto: {Nombre}, Precio: {Precio:C}";
        }
    }
}
