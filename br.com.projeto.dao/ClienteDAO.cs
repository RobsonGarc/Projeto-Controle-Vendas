using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Projeto_Controle_Vendas.br.com.projeto.model;
using Projeto_Controle_Vendas.br.com.projeto.conexao;
using System.Windows.Forms;
using System.Data;

namespace Projeto_Controle_Vendas.br.com.projeto.dao
{
    public class ClienteDAO
    {
        private MySqlConnection conexao;

        public ClienteDAO() {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region CadastrarCliente
        public void CadastrarCliente(Cliente obj)
        {
            try
            {
                //1 passo - definir o cmd - insert into
                string sql = @"insert into tb_clientes (nome, rg, cpf, email, telefone, celular, cep, endereco, numero, complemento, bairro, cidade, estado)
                               values (@nome, @rg, @cpf, @email, @telefone, @celular, @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado)";

                //2 passo - Organizar o cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);

                //3 passo - Abrir a conexao e executar o cmd sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cliente cadastrado com sucesso!");
            }

            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu o erro: " + erro);
            }
        }
        #endregion

        #region AlterarCliente
        public void AlterarCliente(Cliente obj)
        {
            try
            {
                //1 passo - definir o cmd - insert into
                string sql = @"update tb_clientes set nome=@nome,rg=@rg,cpf=@cpf,email=@email,telefone=@telefone,celular=@celular,cep=@cep, 
                               endereco=@endereco,numero=@numero,complemento=@complemento,bairro=@bairro,cidade=@cidade,estado=@estado
                               where id=id";

                //2 passo - Organizar o cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);
                executacmd.Parameters.AddWithValue("@id", obj.codigo);

                //3 passo - Abrir a conexao e executar o cmd sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cliente alterado com sucesso!");
            }

            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu o erro: " + erro);
            }
        }

        #endregion

        #region ExcluirClientes

        public void ExluirCliente(Cliente obj)
        {
            try
            {
                //1 passo - definir o cmd - insert into
                string sql = @"delete from tb_clientes where id=@id";

                //2 passo - Organizar o cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@id", obj.codigo);

                //3 passo - Abrir a conexao e executar o cmd sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cliente excluido com sucesso!");
            }

            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu o erro: " + erro);
            }
        }

        #endregion

        #region ListarClientes
        public DataTable listarCliente()
        {
            try
            {
                //1 passo - Criar o DataTable e o comando sql
                DataTable tabelacliente = new DataTable();

                string sql = "select * from tb_clientes";

                //2 passo - Organizar o comando sql e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //3 passo - Criar o MySQLDataApter para preencher os dados no DataTable;
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelacliente);

                return tabelacliente;
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }
        }
        #endregion

        //Metodo excluirCliente

        //Metodo buscarClientePorCpf
    }
}
