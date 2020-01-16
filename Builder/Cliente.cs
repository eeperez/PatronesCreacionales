using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
	public class Cliente
	{
		Director director;

		public void Main()
		{
			Console.WriteLine("Creacion de auto deportivo:");
			CrearAutoDeportivo();
			Console.WriteLine("");

			Console.WriteLine("Creacion manual de auto deportivo:");
			CrearManualAutoDeportivo();
		}

		private void CrearAutoDeportivo()
		{
			director = new Director();
			CarBuilder car = new CarBuilder();

			director.MakeSport(car);
			var carCreado = car.ObtenerResultado();
			Console.WriteLine(carCreado.ObtenerPartes());
		}

		private void CrearManualAutoDeportivo()
		{
			director = new Director();
			CarManualBuilder carManual = new CarManualBuilder();

			director.MakeSport(carManual);
			var manualCreado = carManual.ObtenerResultado();
			Console.WriteLine(manualCreado.ObtenerPartes());
		}
	}
}
