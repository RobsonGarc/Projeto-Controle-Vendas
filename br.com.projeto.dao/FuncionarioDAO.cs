using MySql.Data.MySqlClient;
using Projeto_Controle_Vendas.br.com.projeto.conexao;
using Projeto_Controle_Vendas.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Controle_Vendas.br.com.projeto.dao
{
    public class FuncionarioDAO
    {
        private MySqlConnection conexao;

        public FuncionarioDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region Cadastrar Funcionario

        public void CadastrarFuncionario(Funcionario obj)
        {
            try
            {
                //1 passo - Criar o comando sql
                string sql = @"insert into bdvendas.tb_funcionarios (nome, rg, cpf, email, senha, cargo, nivel_acesso, telefone, celular, cep, endereco, numero, complemento, bairro, cidade, estado)
                                value (@nome, @rg, @cpf, @email, @senha, @cargo, @nivel_acesso, @telefone, @celular, @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado);";
                
                //2 passo - Organizar e executar o comando sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@senha", obj.senha);
                executacmd.Parameters.AddWithValue("@cargo", obj.cargo);
                executacmd.Parameters.AddWithValue("@nivel_acesso", obj.nivel_acesso);
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

                MessageBox.Show("Funcionário cadastrado com sucesso!");
                //Fecha a conexao
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu o erro" + erro);
            }
        }

        #endregion

        #region Método ListarFuncionarios

        public DataTable listarFuncionario()
        {
            try
            {
                //1 passo - Criar o DataTable e o comando sql
                DataTable tabelafuncionarios = new DataTable();

                string sql = "select * from tb_funcionarios";

                //2 passo - Organizar o comando sql e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //3 passo - Criar o MySQLDataApter para preencher os dados no DataTable;
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelafuncionarios);

                conexao.Close();

                return tabelafuncionarios;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }
        }

        #endregion

        #region Alterar Funcionario

        public void alterarFuncionario(Funcionario obj)
        {
            try
            {
                //1 passo - Criar o comando sql
                string sql = @"update bdvendas.tb_funcionarios set nome=@nome, rg=@rg, cpf=@cpf, email=@email, senha=@senha, cargo=@cargo, nivel_acesso=@nivel_acesso, 
                               telefone=@telefone, celular=@celular, cep=@cep, endereco=@endereco, numero=@numero, complemento=@complemento, bairro=@bairro, cidade=@cidade, estado=@estado 
                               where id = @codigo" ;

                //2 passo - Organizar e executar o comando sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@senha", obj.senha);
                executacmd.Parameters.AddWithValue("@cargo", obj.cargo);
                executacmd.Parameters.AddWithValue("@nivel_acesso", obj.nivel_acesso);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);

                executacmd.Parameters.AddWithValue("@codigo", obj.codigo);

                //3 passo - Abrir a conexao e executar o cmd sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Funcionário cadastrado com sucesso!");
                //Fecha a conexao
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }


        #endregion

        #region Excluir Funcionario

        public void deletarFuncionario(Funcionario obj)
        {
            try
            {
                //1 passo - Criar o comando sql
                string sql = "delete from  bdvendas.tb_funcionarios where id = @codigo"; 

                //2 passo - Organizar e executar o comando sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@codigo", obj.codigo);

                //3 passo - Abrir a conexao e executar o cmd sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Funcionário excluído com sucesso!");
                //Fecha a conexao
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu o erro" + erro);
            }
        }
        #endregion
    }
}
