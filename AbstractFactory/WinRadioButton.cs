using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
	public class WinRadioButton : IRadioButton
	{
		public string CrearRadioButton()
		{
			return "Crear radio bóton WIN";
		}
	}
}
