using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            cmbOperador.SelectedIndex = -1;
            lblResultado.Text = "";
            lstOperaciones.ClearSelected();
        }

        private double Operar(string numero1, string numero2, string operador)
        {
            double res = 0;
            return res;
        }


        #region Eventos

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            cmbOperador.Items.Add('+');
            cmbOperador.Items.Add('-');
            cmbOperador.Items.Add('*');
            cmbOperador.Items.Add('/');
            Limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro de querer salir?","Salir", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (resultado==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            Operando numero1 = new Operando(txtNumero1.Text);
            Operando numero2 = new Operando(txtNumero2.Text);
            double resultado = Calculadora.Operar(numero1, numero2,((char)cmbOperador.SelectedItem));
            lblResultado.Text = resultado.ToString();
            lstOperaciones.Items.Add($"{txtNumero1.Text} {cmbOperador.SelectedItem} {txtNumero2.Text} = {resultado.ToString()}");
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Operando numero1 = new Operando(txtNumero1.Text);
            double resultadoBinarioADecimal = numero1.BinarioADecimal(txtNumero1.ToString());           
            lblResultado.Text = resultadoBinarioADecimal.ToString();           
            lstOperaciones.Items.Add(resultadoBinarioADecimal.ToString());
           
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Operando numero1 = new Operando(txtNumero1.Text);
            string resultadoDecimalABinario = numero1.DecimalABinario(txtNumero1.ToString());
            lblResultado.Text = resultadoDecimalABinario.ToString();
            lstOperaciones.Items.Add(resultadoDecimalABinario.ToString());

        }

        private void cmbOperador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
