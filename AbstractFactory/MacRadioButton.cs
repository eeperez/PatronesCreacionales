using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
	public class MacRadioButton : IRadioButton
	{
		public string CrearRadioButton()
		{
			return "Crear radio bóton MAC";
		}
	}
}
