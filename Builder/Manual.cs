using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
	public class Manual
	{
		public List<string> lstElementos { get; set; }

		public Manual()
		{
			lstElementos = new List<string>();
		}

		public string ObtenerPartes()
		{
			return $"Manual: {string.Join(", ", lstElementos)}";
		}
	}
}
