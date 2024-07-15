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
	/// Description of Tecnico.
	/// </summary>
	public class Tecnico:Operario
	{
		protected string especialdad;
		
		public Tecnico():base()
		{
			especialdad="z";
		}
		protected void leer(){
			base.leer();
			Console.Write("ingrese especialidad;  ");
			especialdad=Console.ReadLine();
			
		}
		protected void mostrar(){
			base.mostrar();
		    Console.WriteLine("especialidad: "+especialdad);
         
           }
		public string getEspeci(){
			return especialdad;
		}
		public void setEspeci(string especialidad){
			this.especialdad=especialidad;
		}
		
	}
}
