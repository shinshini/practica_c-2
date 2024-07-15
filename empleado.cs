/*
 * Created by SharpDevelop.
 * User: CONTROL
 * Date: 06/04/2024
 * Time: 11:14 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Proyecto_practica2
{
	/// <summary>
	/// Description of empleado.
	/// </summary>
	public class empleado
	{
		protected string Nombre;
		protected string Apellidos;
		protected int ci;
		protected int sueldo;
		public empleado()
		{
			Nombre= "juan";
			Apellidos="loza aduviri";
			ci=12345566;
			sueldo=1400;
		}
		protected void leer(){
			Console.Write("ingrese nombre;  ");
			Nombre=Console.ReadLine();
			Console.Write("ingrese apellidos;  ");
			Apellidos=Console.ReadLine();
			Console.Write("ingrese ci;  ");
			ci=int.Parse(Console.ReadLine());
			Console.Write("ingrese sueldo;  ");
			sueldo=int.Parse(Console.ReadLine());
		}
		protected void mostrar(){
		    Console.WriteLine("Nmobre: "+Nombre);
            Console.WriteLine("Apellidos: "+Apellidos);
            Console.WriteLine("Ci: "+ci);
            Console.WriteLine("sueldo: "+sueldo);
       }
		public string getNombre(){
			return Nombre;
		}
		public void setNombre(string nombre){
			this.Nombre=nombre;
		}
		public string getApellido(){
			return Apellidos;
		}
		public void setApellido(string apellidos){
			this.Apellidos=apellidos;
		}
		public int getCI(){
			return ci;
		}
		public void setCI(int ci){
			this.ci=ci;
		}
		public int getSueldo(){
			return sueldo;
		}
		public void setSueldo(int sueldo){
			this.sueldo=sueldo;
		}
		
           
	}
}