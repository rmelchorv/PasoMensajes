using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasoMensajes.FilosofosComensales
{
	class Program
	{
		static void Main(string[] args)
		{
			//Se crea la instancia del recurso compartido
			Tenedores tenedores = new Tenedores();

			//Se crean las instancia de los filósofos
			Filosofo filosofo0 = new Filosofo(0, tenedores);
			Filosofo filosofo1 = new Filosofo(1, tenedores);
			Filosofo filosofo2 = new Filosofo(2, tenedores);
			Filosofo filosofo3 = new Filosofo(3, tenedores);
			Filosofo filosofo4 = new Filosofo(4, tenedores);
		}
	}
}
