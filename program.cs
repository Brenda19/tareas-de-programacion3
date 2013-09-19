/*
 * Created by SharpDevelop.
 * User: hp
 * Date: 18/09/2013
 * Time: 05:24 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica2
{
	class tarea
	{
		public static void Main(string[] args)
		{
			
			
			 Persona p =new Persona();
			 
			 Console.WriteLine("Introduzca su nombre");
			 p.nombre=Console.ReadLine();
             Console.WriteLine("Nombre: "+p.nombre);
			 
			 Console.WriteLine("Introduzca su edad");
			 p.edad=Console.ReadLine();
			 Console.WriteLine("Edad: "+p.edad);
			 
			 Console.WriteLine("Introduzca su correo");
			 p.correo=Console.ReadLine();
			 Console.WriteLine("Correo: "+p.correo);
			 Console.Write("Press any key to continue . . . ");
			 Console.ReadKey(true);
		}
	}
}