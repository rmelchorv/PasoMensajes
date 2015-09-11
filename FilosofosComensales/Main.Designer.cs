namespace PasoMensajes.FilosofosComensales
{
	partial class Main
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lbConsola = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// lbConsola
			// 
			this.lbConsola.FormattingEnabled = true;
			this.lbConsola.Location = new System.Drawing.Point(3, 239);
			this.lbConsola.Name = "lbConsola";
			this.lbConsola.Size = new System.Drawing.Size(466, 160);
			this.lbConsola.TabIndex = 0;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(471, 401);
			this.Controls.Add(this.lbConsola);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Main";
			this.Text = "Main";
			this.Load += new System.EventHandler(this.Main_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox lbConsola;
	}
}