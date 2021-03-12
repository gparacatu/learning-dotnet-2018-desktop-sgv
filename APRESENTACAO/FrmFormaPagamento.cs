#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using TRANSFERENCIA;
using NEGOCIOS;

namespace APRESENTACAO
{
    public partial class FrmFormaPagamento : Syncfusion.Windows.Forms.Tools.RibbonForm
    {
        public FrmFormaPagamento()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text == "")
            {
                MessageBox.Show("Não é possível cadastrar uma forma de pagamento sem uma descrição!");
                txtDescricao.Focus();
                return;
            }
            DialogResult resultado = MessageBox.Show("Deseja realmente cadastrar a forma de pagamento " + txtDescricao.Text + "? Após salvar essa forma de pagamento não será mais possível alterar a sua descrição. Apenas será possível DESATIVAR.", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.No)
            {
                return;
            }

            try
            {
                FormaPagamento pagamento = new FormaPagamento();
                pagamento.Descricao = txtDescricao.Text;
                pagamento.IDFilial = ControleSistema.getFilialLogada().IDFilial;

                FormaPagamentoNegocio pagamentoNegocio = new FormaPagamentoNegocio();

                string retorno = pagamentoNegocio.Inserir(pagamento);

                int IDFormaPagamento;
                if (int.TryParse(retorno, out IDFormaPagamento))
                {
                    MessageBox.Show("Forma de pagamento cadastrada com sucesso. ID: " + IDFormaPagamento);
                    DialogResult = DialogResult.Yes;
                    Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao cadastrar forma de pagamento. Detalhes: "+ex.Message);
                DialogResult = DialogResult.No;
                Close();
            }
        }

        private void FrmFormaPagamento_Load(object sender, EventArgs e)
        {
            txtDescricao.Clear();
        }
    }
}
