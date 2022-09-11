
namespace PracticaInteresSimple
{
    partial class CalculoInteres
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblCapital = new System.Windows.Forms.Label();
            this.lblInteresGanado = new System.Windows.Forms.Label();
            this.txtCapitalInicial = new System.Windows.Forms.TextBox();
            this.txtInteresGanado = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblAnios = new System.Windows.Forms.Label();
            this.txtYears = new System.Windows.Forms.TextBox();
            this.lblPeriodoDeTiempo = new System.Windows.Forms.Label();
            this.cbcPeriodosDeTiempo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // lblCapital
            // 
            this.lblCapital.AutoSize = true;
            this.lblCapital.Location = new System.Drawing.Point(13, 9);
            this.lblCapital.Name = "lblCapital";
            this.lblCapital.Size = new System.Drawing.Size(90, 17);
            this.lblCapital.TabIndex = 1;
            this.lblCapital.Text = "Capital inicial";
            // 
            // lblInteresGanado
            // 
            this.lblInteresGanado.AutoSize = true;
            this.lblInteresGanado.Location = new System.Drawing.Point(172, 9);
            this.lblInteresGanado.Name = "lblInteresGanado";
            this.lblInteresGanado.Size = new System.Drawing.Size(106, 17);
            this.lblInteresGanado.TabIndex = 2;
            this.lblInteresGanado.Text = "Interes Ganado";
            // 
            // txtCapitalInicial
            // 
            this.txtCapitalInicial.Location = new System.Drawing.Point(12, 29);
            this.txtCapitalInicial.Name = "txtCapitalInicial";
            this.txtCapitalInicial.Size = new System.Drawing.Size(157, 22);
            this.txtCapitalInicial.TabIndex = 4;
            // 
            // txtInteresGanado
            // 
            this.txtInteresGanado.Location = new System.Drawing.Point(175, 30);
            this.txtInteresGanado.Name = "txtInteresGanado";
            this.txtInteresGanado.Size = new System.Drawing.Size(150, 22);
            this.txtInteresGanado.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(203, 160);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblAnios
            // 
            this.lblAnios.AutoSize = true;
            this.lblAnios.Location = new System.Drawing.Point(345, 9);
            this.lblAnios.Name = "lblAnios";
            this.lblAnios.Size = new System.Drawing.Size(50, 17);
            this.lblAnios.TabIndex = 3;
            this.lblAnios.Text = "tiempo";
            // 
            // txtYears
            // 
            this.txtYears.Location = new System.Drawing.Point(348, 30);
            this.txtYears.Name = "txtYears";
            this.txtYears.Size = new System.Drawing.Size(100, 22);
            this.txtYears.TabIndex = 10;
            // 
            // lblPeriodoDeTiempo
            // 
            this.lblPeriodoDeTiempo.AutoSize = true;
            this.lblPeriodoDeTiempo.Location = new System.Drawing.Point(12, 58);
            this.lblPeriodoDeTiempo.Name = "lblPeriodoDeTiempo";
            this.lblPeriodoDeTiempo.Size = new System.Drawing.Size(123, 17);
            this.lblPeriodoDeTiempo.TabIndex = 8;
            this.lblPeriodoDeTiempo.Text = "Periodo de tiempo";
            // 
            // cbcPeriodosDeTiempo
            // 
            this.cbcPeriodosDeTiempo.FormattingEnabled = true;
            this.cbcPeriodosDeTiempo.Items.AddRange(new object[] {
            "Años",
            "Meses",
            "Dias"});
            this.cbcPeriodosDeTiempo.Location = new System.Drawing.Point(16, 79);
            this.cbcPeriodosDeTiempo.Name = "cbcPeriodosDeTiempo";
            this.cbcPeriodosDeTiempo.Size = new System.Drawing.Size(121, 24);
            this.cbcPeriodosDeTiempo.TabIndex = 9;
            // 
            // CalculoInteres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 195);
            this.Controls.Add(this.cbcPeriodosDeTiempo);
            this.Controls.Add(this.lblPeriodoDeTiempo);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtYears);
            this.Controls.Add(this.txtInteresGanado);
            this.Controls.Add(this.txtCapitalInicial);
            this.Controls.Add(this.lblAnios);
            this.Controls.Add(this.lblInteresGanado);
            this.Controls.Add(this.lblCapital);
            this.Controls.Add(this.label1);
            this.Name = "CalculoInteres";
            this.Text = "Calcular el interes simple";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCapital;
        private System.Windows.Forms.Label lblInteresGanado;
        private System.Windows.Forms.TextBox txtCapitalInicial;
        private System.Windows.Forms.TextBox txtInteresGanado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblAnios;
        private System.Windows.Forms.TextBox txtYears;
        private System.Windows.Forms.Label lblPeriodoDeTiempo;
        private System.Windows.Forms.ComboBox cbcPeriodosDeTiempo;
    }
}

