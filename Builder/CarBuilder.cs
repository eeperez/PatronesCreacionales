using Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
	public class CarBuilder : IBuilder
	{
		Car car;

		public CarBuilder()
		{
			car = new Car();
		}

		public void AgregarAsientos(int _iNumeroAsientos)
		{
			car.lstElementos.Add($"Agrega {_iNumeroAsientos} asientos");
		}

		public void AgregarComputadoraViaje()
		{
			car.lstElementos.Add("Agregar computadora viaje");
		}

		public void AgregarGPS()
		{
			car.lstElementos.Add("Agrega GPS");
		}

		public void AgregarMotor(IEngine _IMotor)
		{
			car.lstElementos.Add($"Agrega motor tipo: {_IMotor.cNombreTipo}");
		}

		public void Reset()
		{
			car.lstElementos.Clear();
		}

		public Car ObtenerResultado()
		{
			return car;
		}
	}
}
