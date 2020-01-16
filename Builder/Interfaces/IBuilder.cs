using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Interfaces
{
	public interface IBuilder
	{
		void Reset();
		void AgregarAsientos(int _iNumeroAsientos);
		void AgregarMotor(IEngine _IMotor);
		void AgregarComputadoraViaje();
		void AgregarGPS();
	}
}
