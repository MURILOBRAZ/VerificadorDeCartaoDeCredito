using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP11_202873
{
    public partial class FrmCRC : Form
    {
        public FrmCRC()
        {
            InitializeComponent();
            txtNcartao.Focus();
        }
        #region Botão Limpar
        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza?", "Limpar os dados",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information,
                                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                txtNcartao.Clear();
                lblResposta.Text = "";
                txtNcartao.Focus();
            }
        }
        #endregion
        #region Ícone Fechar
        private void FrmCRC_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja Sair", "Encerando o Aplicativo",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button2) == DialogResult.No)
                e.Cancel = true;
        }
        #endregion
        #region Verificar
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (clsCRTC.ValidarCart.ValidaTamanho(txtNcartao.Text) == true)
            {
                lblResposta.Text = "VÁLIDO";
                lblResposta.ForeColor = Color.Green;
            }
            else
            {
                lblResposta.Text = "INVÁLIDO";
                lblResposta.ForeColor = Color.Red;
            }
        }
        #endregion
        #region CARACTERES
        private void KeyPressF(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || (e.KeyChar <= 57 && e.KeyChar >= 48))
            {
                e.KeyChar = e.KeyChar;
            }
            else
            {
                e.KeyChar = Convert.ToChar(0);
            }
        }

        #endregion
        #region LIXO
        private void txtNcartao_TextChanged(object sender, EventArgs e)
        {

        }
        private void TxtBx1_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
