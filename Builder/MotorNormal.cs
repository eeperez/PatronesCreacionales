using Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
	public class MotorNormal : IEngine
	{
		public string cNombreTipo { get; set; }

		public MotorNormal()
		{
			cNombreTipo = "Motor normal";
		}

		
	}
}
