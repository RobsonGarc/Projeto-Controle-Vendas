using Projeto_Controle_Vendas.br.com.projeto.dao;
using Projeto_Controle_Vendas.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Controle_Vendas.br.com.projeto.view
{
    public partial class FrmFuncionarios : Form
    {
        public FrmFuncionarios()
        {
            InitializeComponent();
        }

        private void FrmFuncionarios_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            //Botao salvar
            Funcionario obj = new Funcionario();

            //Receber os dados dos campos
            obj.nome = txtnome.Text;
            obj.rg = txtrg.Text;
            obj.cpf = txtcpf.Text;
            obj.email = txtemail.Text;
            obj.senha = txtsenha.Text;
            obj.nivel_acesso = cbnivel.SelectedItem.ToString();
            obj.telefone = txttelefone.Text;
            obj.celular = txtcelular.Text;
            obj.cep = txtcep.Text;
            obj.endereco = txtendereco.Text;
            obj.numero = int.Parse(txtnumero.Text);
            obj.complemento = txtcomplemento.Text;
            obj.bairro = txtbairro.Text;
            obj.cidade = txtcidade.Text;
            obj.estado = cbuf.SelectedItem.ToString();
            obj.cargo = cbcargo.SelectedItem.ToString();

            //Criar o objeto FuncionarioDAO
            FuncionarioDAO dao = new FuncionarioDAO();
            dao.CadastrarFuncionario(obj);

        }

        private void btnpesquisa_Click(object sender, EventArgs e)
        {

        }

        private void txtcpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
