using Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
	public class CarManualBuilder : IBuilder
	{
		Manual manualAuto;

		public CarManualBuilder()
		{
			manualAuto = new Manual();
		}

		public void AgregarAsientos(int _iNumeroAsientos)
		{
			manualAuto.lstElementos.Add($"Agrega {_iNumeroAsientos} asientos");
		}

		public void AgregarComputadoraViaje()
		{
			manualAuto.lstElementos.Add($"Agrega computadora de viaje");
		}

		public void AgregarGPS()
		{
			manualAuto.lstElementos.Add($"Agrega gps");
		}

		public void AgregarMotor(IEngine _IMotor)
		{
			manualAuto.lstElementos.Add($"Agrega motor tipo: {_IMotor.cNombreTipo}");
		}

		public void Reset()
		{
			manualAuto.lstElementos.Clear();
		}

		public Manual ObtenerResultado()
		{
			return manualAuto;
		}
	}
}
