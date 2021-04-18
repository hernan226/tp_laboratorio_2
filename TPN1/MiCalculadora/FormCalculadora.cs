using Entidades;
using System;
using System.Windows.Forms;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.cmbOperador.DropDownStyle = ComboBoxStyle.DropDownList;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.btnConvertirABinario.Enabled = false;
            this.btnConvertirADecimal.Enabled = false;
            this.cmbOperador.SelectedIndex = 0;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.CenterToScreen();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {            
            this.lblResultado.Text = Operar(
                this.txtNumero1.Text,
                this.txtNumero2.Text,
                this.cmbOperador.Text
                ).ToString();
            if (this.lblResultado.Text != "0")
            {
                this.btnConvertirABinario.Enabled = true;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            this.btnConvertirADecimal.Enabled = true;
            this.lblResultado.Text = Numero.DecimalBinario(this.lblResultado.Text);
            this.btnConvertirABinario.Enabled = false;
        }

        private void BtnConvertirADecimal_Click(object sender, EventArgs e)
        {
            this.btnConvertirABinario.Enabled = true;
            this.lblResultado.Text = Numero.BinarioDecimal(this.lblResultado.Text);
            this.btnConvertirADecimal.Enabled = false;
        }
        #region Metodos

        /// <summary>
        /// Opera los numeros recibidos.
        /// </summary>
        /// <param name="numero1">Numero a operar.</param>
        /// <param name="numero2">Numero a operar.</param>
        /// <param name="operador">Operador.</param>
        /// <returns>Resultado.</returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);

            return Calculadora.Operar(num1, num2, operador);
        }

        /// <summary>
        /// Reestablece todos los textbox, el combobox y el label a por defecto.
        /// Desgabilita los conversores a binario y decimal
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.lblResultado.Text = "";
            this.cmbOperador.SelectedIndex = 0;
            this.btnConvertirABinario.Enabled = false;
            this.btnConvertirADecimal.Enabled = false;
        }
        #endregion

    }
}
