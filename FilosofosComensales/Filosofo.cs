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

		public Filosofo(int id, Tenedores tenedores)
		{
			int numFilosofos = int.Parse(ConfigurationManager.AppSettings["NumFilosofos"]);

			this.tenedores = tenedores;
			this.id = id;
			izquierda = id == 0 ? numFilosofos - 1 : id - 1;
			derecha = id;
			
			//Inicia la ejecucion del proceso
			Thread proceso = new Thread(new ThreadStart(Iniciar));

			proceso.Start();
		}

		public void Iniciar()
		{
			Random aleatorio = new Random();
			int tiempoMaxPensar = int.Parse(ConfigurationManager.AppSettings["TiempoMaxSegPensar"]) * 1000;
			int tiempoMaxComer = int.Parse(ConfigurationManager.AppSettings["TiempoMaxSegComer"]) * 1000;
			int tiempo = 0;

			while (true)
			{
				try
				{
					Console.WriteLine("Filósofo " + id + " pensando...");
					tiempo = aleatorio.Next(1000, tiempoMaxPensar);
					Thread.Sleep(tiempo);
					Console.WriteLine("Filósofo " + id + " tiene hambre. Esperando...");
					tenedores.Obtener(izquierda, derecha);
					Console.WriteLine("Filósofo " + id + " comiendo...");
					tiempo = aleatorio.Next(1000, tiempoMaxComer);
					Thread.Sleep(tiempo);
					tenedores.Liberar(izquierda, derecha);
					Console.WriteLine("Filósofo " + id + " terminó de comer.");
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
