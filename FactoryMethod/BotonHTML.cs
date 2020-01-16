using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
	public class BotonHTML : IBoton
	{
		string cTitulo = "HTML";

		public string OnClick()
		{
			return $"Se realiza click al bóton {cTitulo}";
		}

		public string Render()
		{
			return $"Se crea botón {cTitulo}";
		}
	}
}
