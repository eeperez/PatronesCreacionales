using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.PatronFabrica
{
	public class DialogoWindows : CreadorDialogo
	{
		public override IBoton FabrircarMetodo()
		{
			return new BotonWindows();
		}
	}
}
