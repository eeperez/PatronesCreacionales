using FactoryMethod.PatronFabrica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
	public class Program
	{
		static void Main(string[] args)
		{
			Cliente cliente = new Cliente();
			cliente.Main();

			Console.ReadLine();
		}
	}
}
