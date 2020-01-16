using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
	public class MacFactory : IAbstractFactory
	{
		public IButton CreateButton()
		{
			return new MacButton();
		}

		public ICheckbox CreateCheckbox()
		{
			return new MacCheckbox();
		}

		public IRadioButton CreateRadio()
		{
			return new MacRadioButton();
		}
	}
}
