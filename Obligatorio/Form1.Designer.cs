namespace Obligatorio
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
            this.lblOperacion = new System.Windows.Forms.Label();
            this.linkVenta = new System.Windows.Forms.LinkLabel();
            this.linkAlquiler = new System.Windows.Forms.LinkLabel();
            this.linkCasa = new System.Windows.Forms.LinkLabel();
            this.linkApartamento = new System.Windows.Forms.LinkLabel();
            this.lblInmueble = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOperacion
            // 
            this.lblOperacion.AutoSize = true;
            this.lblOperacion.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperacion.Location = new System.Drawing.Point(39, 59);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(92, 23);
            this.lblOperacion.TabIndex = 0;
            this.lblOperacion.Text = "Operación";
            this.lblOperacion.Click += new System.EventHandler(this.lblOperacion_Click);
            // 
            // linkVenta
            // 
            this.linkVenta.ActiveLinkColor = System.Drawing.Color.DarkTurquoise;
            this.linkVenta.AutoSize = true;
            this.linkVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkVenta.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkVenta.LinkColor = System.Drawing.Color.Black;
            this.linkVenta.Location = new System.Drawing.Point(39, 94);
            this.linkVenta.Name = "linkVenta";
            this.linkVenta.Size = new System.Drawing.Size(52, 20);
            this.linkVenta.TabIndex = 1;
            this.linkVenta.TabStop = true;
            this.linkVenta.Text = "Venta";
            this.linkVenta.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // linkAlquiler
            // 
            this.linkAlquiler.ActiveLinkColor = System.Drawing.Color.DarkTurquoise;
            this.linkAlquiler.AutoSize = true;
            this.linkAlquiler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkAlquiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkAlquiler.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkAlquiler.LinkColor = System.Drawing.Color.Black;
            this.linkAlquiler.Location = new System.Drawing.Point(39, 123);
            this.linkAlquiler.Name = "linkAlquiler";
            this.linkAlquiler.Size = new System.Drawing.Size(61, 20);
            this.linkAlquiler.TabIndex = 2;
            this.linkAlquiler.TabStop = true;
            this.linkAlquiler.Text = "Alquiler";
            this.linkAlquiler.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // linkCasa
            // 
            this.linkCasa.ActiveLinkColor = System.Drawing.Color.DarkTurquoise;
            this.linkCasa.AutoSize = true;
            this.linkCasa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkCasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkCasa.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkCasa.LinkColor = System.Drawing.Color.Black;
            this.linkCasa.Location = new System.Drawing.Point(39, 248);
            this.linkCasa.Name = "linkCasa";
            this.linkCasa.Size = new System.Drawing.Size(54, 20);
            this.linkCasa.TabIndex = 5;
            this.linkCasa.TabStop = true;
            this.linkCasa.Text = "Casas";
            this.linkCasa.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // linkApartamento
            // 
            this.linkApartamento.ActiveLinkColor = System.Drawing.Color.DarkTurquoise;
            this.linkApartamento.AutoSize = true;
            this.linkApartamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkApartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkApartamento.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkApartamento.LinkColor = System.Drawing.Color.Black;
            this.linkApartamento.Location = new System.Drawing.Point(39, 219);
            this.linkApartamento.Name = "linkApartamento";
            this.linkApartamento.Size = new System.Drawing.Size(110, 20);
            this.linkApartamento.TabIndex = 4;
            this.linkApartamento.TabStop = true;
            this.linkApartamento.Text = "Apartamentos";
            this.linkApartamento.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // lblInmueble
            // 
            this.lblInmueble.AutoSize = true;
            this.lblInmueble.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInmueble.Location = new System.Drawing.Point(39, 184);
            this.lblInmueble.Name = "lblInmueble";
            this.lblInmueble.Size = new System.Drawing.Size(85, 23);
            this.lblInmueble.TabIndex = 3;
            this.lblInmueble.Text = "Inmueble";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 506);
            this.Controls.Add(this.linkCasa);
            this.Controls.Add(this.linkApartamento);
            this.Controls.Add(this.lblInmueble);
            this.Controls.Add(this.linkAlquiler);
            this.Controls.Add(this.linkVenta);
            this.Controls.Add(this.lblOperacion);
            this.Name = "Form1";
            this.Text = "POP3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOperacion;
        private System.Windows.Forms.LinkLabel linkVenta;
        private System.Windows.Forms.LinkLabel linkAlquiler;
        private System.Windows.Forms.LinkLabel linkCasa;
        private System.Windows.Forms.LinkLabel linkApartamento;
        private System.Windows.Forms.Label lblInmueble;
    }
}

