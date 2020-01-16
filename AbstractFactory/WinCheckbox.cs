using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
	public class WinCheckbox : ICheckbox
	{
		public string CrearCheckbox()
		{
			return "Crea un checkbox de WIN";
		}
	}
}
