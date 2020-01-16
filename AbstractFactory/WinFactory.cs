using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
	public class WinFactory : IAbstractFactory
	{
		public IButton CreateButton()
		{
			return new WinButton();
		}

		public ICheckbox CreateCheckbox()
		{
			return new WinCheckbox();
		}

		public IRadioButton CreateRadio()
		{
			return new WinRadioButton();
		}
	}
}
