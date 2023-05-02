
namespace prySimulacroParcial2
{
    partial class frmRomanos
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
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdGenerar = new System.Windows.Forms.Button();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.lblSalida = new System.Windows.Forms.Label();
            this.lblNombreR = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ofdEntrada = new System.Windows.Forms.OpenFileDialog();
            this.sfdSalida = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // cmdGenerar
            // 
            this.cmdGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGenerar.Location = new System.Drawing.Point(172, 155);
            this.cmdGenerar.Name = "cmdGenerar";
            this.cmdGenerar.Size = new System.Drawing.Size(82, 32);
            this.cmdGenerar.TabIndex = 0;
            this.cmdGenerar.Text = "Generar";
            this.cmdGenerar.UseVisualStyleBackColor = true;
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrada.Location = new System.Drawing.Point(12, 9);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(66, 20);
            this.lblEntrada.TabIndex = 1;
            this.lblEntrada.Text = "Entrada";
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalida.Location = new System.Drawing.Point(12, 78);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(53, 20);
            this.lblSalida.TabIndex = 2;
            this.lblSalida.Text = "Salida";
            // 
            // lblNombreR
            // 
            this.lblNombreR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombreR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreR.Location = new System.Drawing.Point(16, 43);
            this.lblNombreR.Name = "lblNombreR";
            this.lblNombreR.Size = new System.Drawing.Size(151, 20);
            this.lblNombreR.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 12;
            // 
            // ofdEntrada
            // 
            this.ofdEntrada.FileName = "openFileDialog1";
            // 
            // frmRomanos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 285);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNombreR);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.lblEntrada);
            this.Controls.Add(this.cmdGenerar);
            this.Name = "frmRomanos";
            this.Text = "Romanos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdGenerar;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.Label lblNombreR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog ofdEntrada;
        private System.Windows.Forms.SaveFileDialog sfdSalida;
    }
}