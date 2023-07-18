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
    public partial class Frmclientes : Form
    {
        public Frmclientes()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnnovo_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            //1 passo - armazenar os dados em um objeto model
            Cliente obj = new Cliente();

            obj.nome = txtnome.Text; // obj.setName(txtnome.Text);
            obj.rg = txtrg.Text;
            obj.cpf = txtcpf.Text;
            obj.email = txtemail.Text;
            obj.telefone = txttelefone.Text;
            obj.celular = txtcelular.Text;
            obj.cep = txtcep.Text;
            obj.endereco = txtendereco.Text;
            obj.numero = int.Parse(txtnumero.Text);
            obj.complemento = txtcomplemento.Text;
            obj.bairro = txtbairro.Text;
            obj.cidade = txtcidade.Text;
            obj.estado = cbuf.Text;

            //2 passo - Criar um obj da classe ClienteDAO e chamar o metodo CadastrarCliente
            ClienteDAO dao = new ClienteDAO();
            dao.CadastrarCliente(obj);

            //recarregar o datagridview
            tabelaClientes.DataSource = dao.listarCliente();
        }

        private void tabelaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegar os dados da linha selecionada 
            txtcodigo.Text = tabelaClientes.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = tabelaClientes.CurrentRow.Cells[1].Value.ToString();
            txtrg.Text = tabelaClientes.CurrentRow.Cells[2].Value.ToString();
            txtcpf.Text = tabelaClientes.CurrentRow.Cells[3].Value.ToString();
            txtemail.Text = tabelaClientes.CurrentRow.Cells[4].Value.ToString();
            txttelefone.Text = tabelaClientes.CurrentRow.Cells[5].Value.ToString();
            txtcelular.Text = tabelaClientes.CurrentRow.Cells[6].Value.ToString();
            txtcep.Text = tabelaClientes.CurrentRow.Cells[7].Value.ToString();
            txtendereco.Text = tabelaClientes.CurrentRow.Cells[8].Value.ToString();
            txtnumero.Text = tabelaClientes.CurrentRow.Cells[9].Value.ToString();
            txtcomplemento.Text = tabelaClientes.CurrentRow.Cells[10].Value.ToString();
            txtbairro.Text = tabelaClientes.CurrentRow.Cells[11].Value.ToString();
            txtcidade.Text = tabelaClientes.CurrentRow.Cells[12].Value.ToString();
            cbuf.Text = tabelaClientes.CurrentRow.Cells[13].Value.ToString();

            //Alterar para a guia Dados Pessoais
            tabClientes.SelectedTab = tabPage1;
        }

        private void Frmclientes_Load(object sender, EventArgs e)
        {
            ClienteDAO dao = new ClienteDAO();
            tabelaClientes.DataSource = dao.listarCliente();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            //Botao excluir
            Cliente obj = new Cliente();

            //pegar o codigo
            obj.codigo = int.Parse(txtcodigo.Text);

            ClienteDAO dao = new ClienteDAO();

            dao.ExluirCliente(obj);

            //Recarregar o datagridview
            tabelaClientes.DataSource = dao.listarCliente();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            //1 passo - armazenar os dados em um objeto model
            Cliente obj = new Cliente();

            obj.nome = txtnome.Text; // obj.setName(txtnome.Text);
            obj.rg = txtrg.Text;
            obj.cpf = txtcpf.Text;
            obj.email = txtemail.Text;
            obj.telefone = txttelefone.Text;
            obj.celular = txtcelular.Text;
            obj.cep = txtcep.Text;
            obj.endereco = txtendereco.Text;
            obj.numero = int.Parse(txtnumero.Text);
            obj.complemento = txtcomplemento.Text;
            obj.bairro = txtbairro.Text;
            obj.cidade = txtcidade.Text;
            obj.estado = cbuf.Text;

            obj.codigo = int.Parse(txtcodigo.Text);

            //2 passo - Criar um obj da classe ClienteDAO e chamar o metodo CadastrarCliente
            ClienteDAO dao = new ClienteDAO();
            dao.AlterarCliente(obj);

            //recarregar o datagridview
            tabelaClientes.DataSource = dao.listarCliente();

        }
    }
}
