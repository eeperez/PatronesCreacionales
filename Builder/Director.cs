using Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
	public class Director
	{
		public void MakeSport(IBuilder _IBuilder)
		{
			_IBuilder.Reset();
			_IBuilder.AgregarAsientos(2);
			_IBuilder.AgregarMotor(new MotorDeportivo());
			_IBuilder.AgregarComputadoraViaje();
			_IBuilder.AgregarGPS();
		}

		public void MakeSUV(IBuilder _IBuilder)
		{
			_IBuilder.Reset();
			_IBuilder.AgregarAsientos(2);
			_IBuilder.AgregarMotor(new MotorNormal());
			_IBuilder.AgregarComputadoraViaje();
			_IBuilder.AgregarGPS();
		}
	}
}
