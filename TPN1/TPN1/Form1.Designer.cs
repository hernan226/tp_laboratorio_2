
namespace TPN1
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
            this.textBoxNum1 = new System.Windows.Forms.TextBox();
            this.comboBoxOperador = new System.Windows.Forms.ComboBox();
            this.textBoxNum2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOperar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnConvertirBinario = new System.Windows.Forms.Button();
            this.BtnConvertirDecimal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNum1
            // 
            this.textBoxNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNum1.Location = new System.Drawing.Point(12, 55);
            this.textBoxNum1.Name = "textBoxNum1";
            this.textBoxNum1.Size = new System.Drawing.Size(200, 38);
            this.textBoxNum1.TabIndex = 0;
            this.textBoxNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBoxOperador
            // 
            this.comboBoxOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOperador.FormattingEnabled = true;
            this.comboBoxOperador.Location = new System.Drawing.Point(218, 54);
            this.comboBoxOperador.Name = "comboBoxOperador";
            this.comboBoxOperador.Size = new System.Drawing.Size(71, 39);
            this.comboBoxOperador.TabIndex = 1;
            // 
            // textBoxNum2
            // 
            this.textBoxNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNum2.Location = new System.Drawing.Point(295, 55);
            this.textBoxNum2.Name = "textBoxNum2";
            this.textBoxNum2.Size = new System.Drawing.Size(200, 38);
            this.textBoxNum2.TabIndex = 2;
            this.textBoxNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(483, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "hola";
            // 
            // btnOperar
            // 
            this.btnOperar.Location = new System.Drawing.Point(12, 99);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(155, 40);
            this.btnOperar.TabIndex = 4;
            this.btnOperar.Text = "OPERAR";
            this.btnOperar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(176, 99);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(155, 40);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(340, 99);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(155, 40);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // btnConvertirBinario
            // 
            this.btnConvertirBinario.Location = new System.Drawing.Point(12, 145);
            this.btnConvertirBinario.Name = "btnConvertirBinario";
            this.btnConvertirBinario.Size = new System.Drawing.Size(235, 40);
            this.btnConvertirBinario.TabIndex = 7;
            this.btnConvertirBinario.Text = "CONVERTIR A BINARIO";
            this.btnConvertirBinario.UseVisualStyleBackColor = true;
            // 
            // BtnConvertirDecimal
            // 
            this.BtnConvertirDecimal.Location = new System.Drawing.Point(260, 145);
            this.BtnConvertirDecimal.Name = "BtnConvertirDecimal";
            this.BtnConvertirDecimal.Size = new System.Drawing.Size(235, 40);
            this.BtnConvertirDecimal.TabIndex = 8;
            this.BtnConvertirDecimal.Text = "CONVERTIR A DECIMAL";
            this.BtnConvertirDecimal.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 198);
            this.Controls.Add(this.BtnConvertirDecimal);
            this.Controls.Add(this.btnConvertirBinario);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnOperar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNum2);
            this.Controls.Add(this.comboBoxOperador);
            this.Controls.Add(this.textBoxNum1);
            this.Name = "Form1";
            this.Text = "CALCULADORA DE HERNAN CORONEL 2ºA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNum1;
        private System.Windows.Forms.ComboBox comboBoxOperador;
        private System.Windows.Forms.TextBox textBoxNum2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnConvertirBinario;
        private System.Windows.Forms.Button BtnConvertirDecimal;
    }
}

