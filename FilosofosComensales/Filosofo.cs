using System;
using System.Configuration;
using System.Threading;

namespace PasoMensajes.FilosofosComensales
{
	class Filosofo
	{
		int derecha;
		int izquierda;
		int id;
		Tenedores tenedores;
		internal event EventHandler ManejadorEstado;
		internal enum Estado { Pensando, Esperando, Comiendo };

		public Filosofo(int id, Tenedores tenedores, EventHandler manejadorEstado)
		{
			int numFilosofos = int.Parse(ConfigurationManager.AppSettings["NumFilosofos"]);

			this.tenedores = tenedores;
			this.id = id;
			ManejadorEstado = manejadorEstado;
			izquierda = id == 0 ? numFilosofos - 1 : id - 1;
			derecha = id;
			
			//Inicia la ejecucion del proceso
			Thread proceso = new Thread(new ThreadStart(Iniciar));

			proceso.Start();
		}

		public void Iniciar()
		{
			EventHandler handler = ManejadorEstado;
			Random aleatorio = new Random();
			int tiempoMaxPensar = int.Parse(ConfigurationManager.AppSettings["TiempoMaxSegPensar"]) * 1000;
			int tiempoMaxComer = int.Parse(ConfigurationManager.AppSettings["TiempoMaxSegComer"]) * 1000;
			int tiempo = 0;

			while (true)
			{
				try
				{
					
					if (handler != null)
						handler(new Argumentos() { Estado = Estado.Pensando, IdProceso = id }, new EventArgs());

					tiempo = aleatorio.Next(1000, tiempoMaxPensar);
					Thread.Sleep(tiempo);

					if (handler != null)
						handler(new Argumentos() { Estado = Estado.Esperando, IdProceso = id }, new EventArgs());

					tenedores.Obtener(izquierda, derecha);
					
					if (handler != null)
						handler(new Argumentos() { Estado = Estado.Comiendo, IdProceso = id }, new EventArgs());

					tiempo = aleatorio.Next(1000, tiempoMaxComer);
					Thread.Sleep(tiempo);
					tenedores.Liberar(izquierda, derecha);
				}
				catch(Exception e)
				{
					Console.WriteLine("Filósofo " + id + " error!");
					Console.WriteLine("Mensaje: " + e.Message);
				}
			}
		}
	}
}
