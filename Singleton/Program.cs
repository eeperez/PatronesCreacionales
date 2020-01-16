using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
	class Program
	{
		static void Main(string[] args)
		{
			string cRespuesta = string.Empty;
			Conexion conUno = Conexion.ObtenerInstancia();
			Conexion conDos = Conexion.ObtenerInstancia();

			if (conUno == conDos)
				cRespuesta = "Singleton funcionó: ambas variables contienen la misma instancia";
			else
				cRespuesta = "Singleton falló: las variables contienen diferentes instancias";

			Console.WriteLine(cRespuesta);
			Console.ReadLine();
		}
	}
}
