using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
	public class Conexion
	{
		private static Conexion conexion;

		private Conexion()
		{
		}

		public static Conexion ObtenerInstancia()
		{
			if (conexion == null)
			{
				conexion = new Conexion();
			}

			return conexion;
		}
	}
}
