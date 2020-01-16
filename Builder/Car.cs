using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
	public class Car
	{
		public List<string> lstElementos { get; set; }

		public Car()
		{
			lstElementos = new List<string>();
		}

		public string ObtenerPartes()
		{
			return $"Car: {string.Join(", ", lstElementos)}";
		}
	}
}
