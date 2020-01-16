using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
	public class Cliente
	{
		public void Main()
		{
			Console.WriteLine("Creacion de botones de Windows:");
			ClientMethod(new WinFactory());

			Console.WriteLine("");

			Console.WriteLine("Creacion de botones de MAC:");
			ClientMethod(new MacFactory());

			Console.ReadLine();
		}

		private void ClientMethod(IAbstractFactory fabrica)
		{
			var button = fabrica.CreateButton();
			var checkbox = fabrica.CreateCheckbox();
			var radioButton = fabrica.CreateRadio();

			Console.WriteLine(button.CrearBoton());
			Console.WriteLine(checkbox.CrearCheckbox());
			Console.WriteLine(radioButton.CrearRadioButton());
		}
	}
}
