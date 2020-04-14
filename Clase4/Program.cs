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

            FrmPrimero frmPrimero;
            frmPrimero = new FrmPrimero();
            frmPrimero.Show();

            

            //Estante estante = new Estante(5);
            ////Se generó un array de 5 elemento dentro del objeto estante
            //int i;

            ////for ( i = 0; i < estante.productos.Length; i++)
            ////{
            ////    Producto producto = new Producto();
            ////    producto.Ingresar();
            ////    if (estante + producto)
            ////        Console.WriteLine("Se agregó correctamente");
            ////}
            //Producto prodVacio = new Producto();
            //prodVacio.fabricante = "Lucas";
            //prodVacio.marca = "Segunda Mano";
            //prodVacio.tipo = "Barbijo";
            //prodVacio.precio = 250.99f;
            //prodVacio.cantidad = 0;
            ////bool a = estante - prodVacio;
            ////bool b = estante - (new Producto());

            ////estante.productos[1] = prodVacio;
            //////Se generó un array de 1 elemento dentro del objeto estante
            ////Estante estanteA = prodVacio;

            ////Array.Copy(estante.productos, estanteA.productos, 5); 
            //// bool c=  estanteA - prodVacio;

            //Producto[,] productosEnEstanteria;

            //// Mis productos estan ubicados en 4 filas y 5 de profundidad
            //productosEnEstanteria = new Producto[4, 5];



            //int j;
            //for (i = 0; i < 4; i++)
            //{
            //    for (j = 0; j < 5; j++)
            //    {
            //        productosEnEstanteria[i, j] = NuevoProducto();
            //    }
            //}
            //string fila = "columna;10225;Nombre;Apellido";
            //fila.Insert("columna;10225;Nombre;Apellido".Length-1,";ProximaColumna");

            //string columan1 = fila.Substring(0, fila.IndexOf(';'));
            //fila.Replace("'", "''");


            //Producto producto1 = (Producto)"Barbijo";

            //Console.WriteLine((string)producto1);

            //StringBuilder stringBuilder = new StringBuilder();
            //stringBuilder.AppendLine("Hola");

            //stringBuilder.AppendLine("Mundo");

            //stringBuilder.AppendLine(producto1.ToString());


            //stringBuilder.ToString();




        }

        public static Producto NuevoProducto()
        {
            Producto prodVacio = new Producto();
            prodVacio.fabricante = "Lucas";
            prodVacio.marca = "Segunda Mano";
            prodVacio.tipo = "Barbijo";
            prodVacio.precio = 250.99f;
            prodVacio.cantidad = 0;

            return prodVacio;

        }
    }
}
