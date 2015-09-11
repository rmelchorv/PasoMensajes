using System;
using System.Threading;
using System.Windows.Forms;

namespace PasoMensajes.FilosofosComensales
{
	class Program
	{
		static void Main(string[] args)
		{
			Thread t = new Thread(new ThreadStart(LanzarConsola));
			t.Start();
		}

		[STAThread]
		private static void LanzarConsola()
		{
			Application.Run(new FilosofosComensales.Main());
		}
	}
}
