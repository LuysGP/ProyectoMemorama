
namespace JuegoMemorama___PracticaFinal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PanelJuego = new System.Windows.Forms.Panel();
            this.lblContador = new System.Windows.Forms.Label();
            this.lblContador2 = new System.Windows.Forms.Label();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // PanelJuego
            // 
            this.PanelJuego.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelJuego.Location = new System.Drawing.Point(31, 12);
            this.PanelJuego.Name = "PanelJuego";
            this.PanelJuego.Size = new System.Drawing.Size(561, 444);
            this.PanelJuego.TabIndex = 0;
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.Location = new System.Drawing.Point(667, 49);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(85, 24);
            this.lblContador.TabIndex = 1;
            this.lblContador.Text = "Record:";
            // 
            // lblContador2
            // 
            this.lblContador2.AutoSize = true;
            this.lblContador2.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador2.Location = new System.Drawing.Point(787, 49);
            this.lblContador2.Name = "lblContador2";
            this.lblContador2.Size = new System.Drawing.Size(22, 24);
            this.lblContador2.TabIndex = 2;
            this.lblContador2.Text = "0";
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReiniciar.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.Location = new System.Drawing.Point(671, 344);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(138, 54);
            this.btnReiniciar.TabIndex = 3;
            this.btnReiniciar.Text = "Reiniciar Juego";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(885, 470);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.lblContador2);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.PanelJuego);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelJuego;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Label lblContador2;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Timer timer1;
    }
}

