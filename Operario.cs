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
	/// Description of Operario.
	/// </summary>
	public class Operario:empleado
	{
		protected int Anios;
		protected string servicio;
		protected string turno;
		
		public Operario():base()
		{
			Anios=11;
			servicio="contador";
			turno="noche";
		}
		protected void leer(){
			base.leer();
			Console.Write("ingrese años: ");
			Anios=int.Parse(Console.ReadLine());
			Console.Write("ongrese servicio ");
			servicio=Console.ReadLine();
			Console.Write("ngrese turno ");
			turno=Console.ReadLine();
			
		}
		protected void mostrar(){
			base.mostrar();
			 Console.WriteLine("año: "+Anios);
            Console.WriteLine("servicio: "+servicio);
            Console.WriteLine("turno: "+turno);
		}
		public int getAnios(){
			return Anios;
		}
		public void setAnios(int anios){
			this.Anios=anios;
		}
		public string getServico(){
			return servicio;
		}
		public void setServicio(string servicio){
			this.servicio=servicio;
		}
		public string getTurno(){
			return turno;
		}
		public void setTurno(string turno){
			this.turno=turno;
		}
		  //e) Si el turno del empleado es “noche” 
           //adicionarle más el 5% de su sueldo
           public void adicionar5porSueldo(string x){
           	if(turno.ToLower().Equals(x.ToLower())){
				sueldo = (int)(sueldo + sueldo * 0.05);
           		mostrar();
           	}
           	else{
           	    Console.WriteLine("\tel turno no coincide");
           	}
           }
	}
}
