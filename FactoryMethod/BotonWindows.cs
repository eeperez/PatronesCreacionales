using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
	public class BotonWindows : IBoton
	{
		string cTitulo = "windows";
		public string OnClick()
		{
			return $"Se realiza click al bóton {cTitulo}";
		}

		public string Render()
		{
			return $"Se crea bóton {cTitulo}";
		}
	}
}
