using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.PatronFabrica
{
	public abstract class CreadorDialogo
	{
		public abstract IBoton FabrircarMetodo();

		public string Render()
		{
			var producto = FabrircarMetodo();
			string cResultado = $"Creación desde fabrica:  {producto.Render()}";

			return cResultado;
		}

		public string CreateButton()
		{
			var producto = FabrircarMetodo();

			string cResultado = $"Acción Create Button: {producto.Render()}";

			return cResultado;
		}
	}
}
