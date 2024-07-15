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
	/// Description of oficial.
	/// </summary>
	public class oficial:Operario
	{
		protected int grado;
		public oficial():base()
		{
			grado=12;
			ci=444445555;
		}
			public void leer(){
			base.leer();
			Console.Write("ingrese grado;  ");
			grado=int.Parse(Console.ReadLine());
			
		}
		public void mostrar(){
			
			Console.WriteLine("\ningrese datos del oficial");
		    base.mostrar();
			Console.WriteLine("grado: "+grado);
         
           }
		//c) Buscar el empleado con ci=”x” 
			//mostrar todos sus datos
			public void buscarCI(Directivo d, Tecnico_comercial te,Tecnico_en_piso tp){
			Console.Write("\ningrese ci del empleado a buscar: ");
				int x=int.Parse(Console.ReadLine());
				if (getCI()==x){
					Console.WriteLine("----oficial---");
					mostrar();
			  }
				if (d.getCI()==x){
					Console.WriteLine("----directvo---");
					d.mostrar();
			  }
				if (te.getCI()==x){
					Console.WriteLine("----tecnico comercial---");
					te.mostrar();
			  }
				if (tp.getCI()==x){
					Console.WriteLine("----tecnco de piso---");
					tp.mostrar();
			  }
			}
			  //e) Si el turno del empleado es “noche” 
           //adicionarle más el 5% de su sueldo
           public void adicionar_5por_sueldo( Tecnico_comercial tc, Tecnico_en_piso tp){
           	Console.Write("ingrese turno=  ");
           	string x=Console.ReadLine();
           
           	Console.WriteLine("****OFICAL****");
           	adicionar5porSueldo(x);
           	Console.WriteLine("****TECNICO COMECIAL****");
           	tc.adicionar5porSueldo(x);
           	Console.WriteLine("****TECNICO DE PISO****");
           	tp.adicionar5porSueldo(x);
           
           	
           	
           }
	}
}
