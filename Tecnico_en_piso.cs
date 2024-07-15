/*
 * Created by SharpDevelop.
 * User: CONTROL
 * Date: 06/04/2024
 * Time: 11:16 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Proyecto_practica2
{
	/// <summary>
	/// Description of Tecnico_en_piso.
	/// </summary>
	public class Tecnico_en_piso:Tecnico
	{
		protected string tipo;
		public Tecnico_en_piso():base(){
            tipo="productividad";
            turno="mañana";
            
		}
		public void leer(){
			base.leer();
			
			Console.Write("ingrese tipo;  ");
			tipo=Console.ReadLine();
			
		}
		public void mostrar(){
			
			Console.WriteLine("\ningrese datos tecnico en piso");
			base.mostrar();
		    Console.WriteLine("tipo: "+tipo);
         
           }
		public string getTipo(){
			return tipo;
		}
		public void setTipo(string tipo){
			this.tipo=tipo;
		}
		//B)Verificar si los técnicos y el oficial 
			//se encuentran en un mismo turno
			public void Turno(Tecnico_comercial te, oficial o){
				if(turno.ToLower().Equals(te.getTurno().ToLower())& turno.ToLower().Equals(o.getTurno().ToLower()) )
					Console.WriteLine("\n los tres son del mismo turno");
				else if (te.getTurno().ToLower().Equals(o.getTurno().ToLower()))
					Console.WriteLine("\n  el tecnico comercial es de otro tuno");
				else if (o.getTurno().ToLower().Equals(turno.ToLower()) )
					Console.WriteLine("\n  el oficial es de otro tuno");
				else
					Console.WriteLine("\n el tecnico de piso es de otro turno");
			
			}
	}
}
