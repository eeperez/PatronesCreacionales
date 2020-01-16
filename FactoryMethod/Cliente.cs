using FactoryMethod.PatronFabrica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
	public class Cliente
	{
		public void Main()
		{
			Console.WriteLine("Invoca Creador de dialogo windows");
			ClientCode(new DialogoWindows());

			Console.WriteLine("");

			Console.WriteLine("Invoca Creador de Web");
			ClientCode(new DialogoWeb());
		}

		private void ClientCode(CreadorDialogo _creador)
		{
			Console.WriteLine("Client: I'm not aware of the creator's class," +
				"but it still works.\n" + _creador.Render());
		}
	}
}
