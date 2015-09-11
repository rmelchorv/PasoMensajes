using System;
using System.Windows.Forms;

namespace PasoMensajes.FilosofosComensales
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
			Form.CheckForIllegalCrossThreadCalls = false;
		}

		private void Main_Load(object sender, EventArgs e)
		{
			//Se crea la instancia del recurso compartido
			Tenedores tenedores = new Tenedores();

			//Se crean las instancia de los filósofos
			Filosofo filosofo0 = new Filosofo(0, tenedores, evento_CambioEstado);
			Filosofo filosofo1 = new Filosofo(1, tenedores, evento_CambioEstado);
			Filosofo filosofo2 = new Filosofo(2, tenedores, evento_CambioEstado);
			Filosofo filosofo3 = new Filosofo(3, tenedores, evento_CambioEstado);
			Filosofo filosofo4 = new Filosofo(4, tenedores, evento_CambioEstado);
		}

		private void evento_CambioEstado(object sender, EventArgs e)
		{
			Argumentos proceso = (Argumentos)sender;

			lbConsola.Items.Add("Filosofo " +  proceso.IdProceso + ": " + proceso.Estado);

			switch (proceso.Estado)
			{
				case Filosofo.Estado.Pensando:
					//Cambiar imagen a color amarillo
					break;
				case Filosofo.Estado.Esperando:
					//Cambiar imagen a color rojo
					break;
				case Filosofo.Estado.Comiendo:
					//Cambiar imagen a color verde
					break;
			}
		}
	}
}
