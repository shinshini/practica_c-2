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
	/// Description of Tecnico_comercial.
	/// </summary>
	public class Tecnico_comercial:Tecnico
	{
		protected string area;
		protected int sucuesal_a_cargo;
		public Tecnico_comercial():base()
		{
			area="productvo";
			sucuesal_a_cargo=3;
			
			
		}
		public void leer(){
			base.leer();
			Console.Write("ingrese area;  ");
			area=Console.ReadLine();
			Console.Write("ingrese surcusal;  ");
			sucuesal_a_cargo=int.Parse(Console.ReadLine());
			
		}
		public void mostrar(){
			
			Console.WriteLine("\ningrese datos tecnico comercial");
			base.mostrar();
		    Console.WriteLine("area: "+area);
		    Console.WriteLine("sucursal a cargo: "+sucuesal_a_cargo);
         
           }
		public string getArea(){
			return area;
		}
		public void setArea(string area){
			this.area=area;
		}
		public int getSucursal(){
			return sucuesal_a_cargo;
		}
		public void setSucursal(int sucursal_a_cargo){
			this.sucuesal_a_cargo=sucursal_a_cargo;
		}
		// Cambiar el área de un técnico comercial por “x”,
            //  si su especialidad es = “z”
            public void cambiarArea(){
            	Console.Write("ingrese especialiadad= ");
            	string esp= Console.ReadLine();
            	if(especialdad.ToLower().Equals(esp.ToLower())){
            		Console.Write("\tcambiar area= ");
            		string x=Console.ReadLine();
            		setArea(x);
            		mostrar();
            		
            	}
            	else{
            		Console.WriteLine(" otra especialidad");
            	}
            }
            //g) Que técnico tiene más años de antigüedad
		public void aniosAntiguedad(Tecnico_en_piso tp){
            	if (Anios == tp.getAnios()){
				Console.WriteLine("\nambos tienen el mismo año de antiguedad");
			}
			else{
            		if(Anios>tp.getAnios()){
				Console.WriteLine("\nel tecnico de comercio lleva mas años de antiguedad");
				}
				else{
				Console.WriteLine("\nel tecnico de piso lleva mas años de antiguedad");
				}
			}
		}
	}
}
