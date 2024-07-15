/*
 * Created by SharpDevelop.
 * User: CONTROL
 * Date: 06/04/2024
 * Time: 11:12 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Proyecto_practica2
{
	class Program
	{
		public static void Main(string[] args)
		{
		   //a) Realizar código del diagrama de clases 
		   //con sus atributos, constructor, métodos (Leer y Mostrar)

			Directivo D=new Directivo();
			D.mostrar();
			oficial O=new oficial();
			O.mostrar();
			Tecnico_comercial TC=new Tecnico_comercial();
			TC.mostrar();
			Tecnico_en_piso TP=new Tecnico_en_piso();
			TP.mostrar();
			
			//B)Verificar si los técnicos y el oficial 
			//se encuentran en un mismo turno
			TP.Turno(TC,O);
			
			//c) Buscar el empleado con ci=”x” 
			//mostrar todos sus datos
           O.buscarCI(D,TC,TP);
          
           //d) Si el directivo tiene el cargo de “a” 
           //subirle a un cargo “b”
          D.subirCargo();
          
           //e) Si el turno del empleado es “noche” 
           //adicionarle más el 5% de su sueldo
           O.adicionar_5por_sueldo(TC,TP);
          
            // Cambiar el área de un técnico comercial por “x”,
            //  si su especialidad es = “z”
           TC.cambiarArea();
            
            //g) Que técnico tiene más años de antigüedad
            TC.aniosAntiguedad(TP);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}