/*
 * Created by SharpDevelop.
 * User: CONTROL
 * Date: 06/04/2024
 * Time: 11:15 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Proyecto_practica2
{
	/// <summary>
	/// Description of Directivo.
	/// </summary>
	public class Directivo:empleado
	{
		protected string cargo;
		protected int nro_oficina;
		public Directivo():base()
		{
			cargo="a";
			nro_oficina=12;
		}
		public void leer(){
			base.leer();
			Console.Write("ingrese cargo;  ");
			cargo=Console.ReadLine();
			Console.Write("ingrese numero de oficina;  ");
			nro_oficina=int.Parse(Console.ReadLine());
		}
		public void mostrar(){
			
			Console.WriteLine("\ningrese datos del dirctivo");
			base.mostrar();
			 Console.WriteLine("cargo: "+cargo);
            Console.WriteLine("numero de oficna: "+nro_oficina);
		}
		public string getCargo(){
			return cargo;
		}
		public void setCargo(string cargo){
			this.cargo=cargo;
		}
		public int getNro_oficina(){
			return nro_oficina;
		}
		public void setNro_ofcina(int nro_oficina){
			this.nro_oficina=nro_oficina;
		}
	
	   //d) Si el directivo tiene el cargo de “a” 
           //subirle a un cargo “b”
           public void subirCargo(){
           Console.Write("\tingrese el cargo = ");
           	string c=Console.ReadLine();
           	if(cargo.ToLower().Equals(c.ToLower())){
           	Console.Write("\tsubir cargo = ");
           	cargo= Console.ReadLine();
           	mostrar();
           	}
           	else{
           		Console.WriteLine("cargo no correspondido");
           	}
           }
         
     }
}
