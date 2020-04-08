using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clase4
{
    class Program
    {
        static void Main(string[] args)
        {
            Estante estante = new Estante(5);

            for (int i = 0; i < estante.productos.Length; i++)
            {
                Producto producto = new Producto();
                producto.Ingresar();
                if (estante + producto)
                    Console.WriteLine("Se agregó correctamente");
            }
            Producto prodVacio = new Producto();
            prodVacio.fabricante = "Lucas";
            prodVacio.marca = "Segunda Mano";
            prodVacio.tipo = "Barbijo";
            prodVacio.precio = 250.99f;
            prodVacio.cantidad = 0;
            bool a = estante - prodVacio;
            bool b = estante - (new Producto());
            Estante estanteA = prodVacio;


            Producto producto1 =(Producto)"Barbijo";

            Console.WriteLine((string)producto1);



        }
    }
}
