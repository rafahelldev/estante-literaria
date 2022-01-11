using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Estante_Literária
{
    class BancoDeDados
    {


        //  Variáveis
        MySqlConnection DataConnection;
        bool sucesso = true;
        MySqlCommand cmd;
        ValidarLogin validarlogin;
        Cliente cliente;
        MySqlDataReader reader;
        Funcionario funcionario;
        Autor autor;
        Livro livro;
        AutorLivro autorlivro;
        Venda venda;
        ItemVenda itemvenda;


        //  Conectando ao banco de dados
        public bool Conecta()
        {


            DataConnection = new MySqlConnection("server=localhost;database='estante_literaria';uid=root;pwd=''");


            try
            {


                DataConnection.Open();


            }

            catch
            {


                sucesso = false;


            }


            return sucesso;


        }

        //  Desconectando do banco de dados
        public void Desconecta()
        {


            DataConnection.Close();


        }


        //  Validar login
        public ValidarLogin ValidarLogin(int validar_cod_funcionario, string validar_chave_acesso)
        {


            validarlogin = null;


            cmd = new MySqlCommand("SELECT cod_funcionario, cargo, chave_acesso FROM funcionario WHERE " +
                "cod_funcionario = @cod_funcionario AND chave_acesso = @chave_acesso", DataConnection);

            cmd.Parameters.AddWithValue("@cod_funcionario", validar_cod_funcionario);
            cmd.Parameters.AddWithValue("@chave_acesso", validar_chave_acesso);


            reader = cmd.ExecuteReader();

            while (reader.Read())
            {


                int cod_funcionario = validar_cod_funcionario;
                string cargo = reader["cargo"].ToString();
                string chave_acesso = validar_chave_acesso;

                
                validarlogin = new ValidarLogin(cod_funcionario, cargo, chave_acesso);


            }


            return validarlogin;


        }
        

        //  Cadastrar novo cliente
        public bool CadastrarCliente(Cliente cliente)
        {


            try
            {


                cmd = new MySqlCommand("INSERT INTO cliente(nome, cpf, dt_cadastro, dt_nascimento, tel_principal, " +
                    "tel_reserva, email, cod_cliente) VALUES (@nome, @cpf, @dt_cadastro, @dt_nascimento, " +
                    "@tel_principal, @tel_reserva, @email, @cod_cliente)", DataConnection);


                cmd.Parameters.AddWithValue("@nome", cliente.nome);
                cmd.Parameters.AddWithValue("@cpf", cliente.cpf);
                cmd.Parameters.AddWithValue("@dt_cadastro", cliente.dt_cadastro);
                cmd.Parameters.AddWithValue("@dt_nascimento", cliente.dt_nascimento);
                cmd.Parameters.AddWithValue("@tel_principal", cliente.tel_principal);
                cmd.Parameters.AddWithValue("@tel_reserva", cliente.tel_reserva);
                cmd.Parameters.AddWithValue("@email", cliente.email);
                cmd.Parameters.AddWithValue("@cod_cliente", cliente.cod_cliente);

                cmd.ExecuteNonQuery();


            }

            catch
            {


                sucesso = false;


            }


            return sucesso;


        }

        //  Consultar dados de cliente
        public Cliente ConsultarCliente_Codigo(int search_cod_cliente)
        {


            cliente = null;


            cmd = new MySqlCommand("SELECT nome, cpf, dt_cadastro, dt_nascimento, tel_principal, tel_reserva, " +
                "email, cod_cliente FROM cliente WHERE cod_cliente = @cod_cliente", DataConnection);

            cmd.Parameters.AddWithValue("@cod_cliente", search_cod_cliente);


            reader = cmd.ExecuteReader();

            while (reader.Read())
            {


                int cod_cliente = search_cod_cliente;
                string nome = reader["nome"].ToString();
                string cpf = reader["cpf"].ToString();
                DateTime dt_cadastro = Convert.ToDateTime(reader["dt_cadastro"]);
                DateTime dt_nascimento = Convert.ToDateTime(reader["dt_nascimento"]);
                string tel_principal = reader["tel_principal"].ToString();
                string tel_reserva = reader["tel_reserva"].ToString();
                string email = reader["email"].ToString();


                cliente = new Cliente(nome, cpf, dt_cadastro, dt_nascimento, tel_principal,
                    tel_reserva, email, cod_cliente);


            }


            return cliente;


        }

        public List<Cliente> ConsultarCliente_Nome(string partenome)
        {


            List<Cliente> results = new List<Cliente>();

            cliente = null;


            cmd = new MySqlCommand("SELECT nome, cpf, dt_cadastro, dt_nascimento, tel_principal, tel_reserva, " +
                "email, cod_cliente FROM cliente WHERE nome LIKE @nome", DataConnection);

            cmd.Parameters.AddWithValue("@nome", partenome + "%");


            reader = cmd.ExecuteReader();

            while (reader.Read())
            {


                int cod_cliente = Convert.ToInt32(reader["cod_cliente"]);
                string nome = reader["nome"].ToString();
                string cpf = reader["cpf"].ToString();
                DateTime dt_cadastro = Convert.ToDateTime(reader["dt_cadastro"]);
                DateTime dt_nascimento = Convert.ToDateTime(reader["dt_nascimento"]);
                string tel_principal = reader["tel_principal"].ToString();
                string tel_reserva = reader["tel_reserva"].ToString();
                string email = reader["email"].ToString();


                cliente = new Cliente(nome, cpf, dt_cadastro, dt_nascimento, tel_principal,
                    tel_reserva, email, cod_cliente);

                results.Add(cliente);


            }


            return results;


        }

        //  Atualizar dados de cadastro de cliente
        public bool AtualizarDados_Cliente(Cliente cliente)
        {


            try
            {


                cmd = new MySqlCommand("UPDATE cliente SET nome = @nome, cpf = @cpf, dt_nascimento = @dt_nascimento, " +
                    "tel_principal = @tel_principal, tel_reserva = @tel_reserva, email = @email " +
                    "WHERE cod_cliente = @cod_cliente", DataConnection);

                cmd.Parameters.AddWithValue("@nome", cliente.nome);
                cmd.Parameters.AddWithValue("@cpf", cliente.cpf);
                cmd.Parameters.AddWithValue("@dt_nascimento", cliente.dt_nascimento);
                cmd.Parameters.AddWithValue("@tel_principal", cliente.tel_principal);
                cmd.Parameters.AddWithValue("@tel_reserva", cliente.tel_reserva);
                cmd.Parameters.AddWithValue("@email", cliente.email);
                cmd.Parameters.AddWithValue("@cod_cliente", cliente.cod_cliente);

                cmd.ExecuteNonQuery();


            }

            catch
            {


                sucesso = false;


            }


            return sucesso;


        }

        //  Deletar cadastro de cliente
        public bool DeletarCadastro_Cliente(Cliente cliente)
        {


            try
            {


                cmd = new MySqlCommand("DELETE FROM cliente WHERE cod_cliente = @cod_cliente", DataConnection);
                cmd.Parameters.AddWithValue("@cod_cliente", cliente.cod_cliente);

                cmd.ExecuteNonQuery();


            }

            catch
            {


                sucesso = false;


            }


            return sucesso;


        }


        //  Cadastrar novo funcionário
        public bool CadastrarFuncionario(Funcionario funcionario)
        {


            try
            {


                cmd = new MySqlCommand("INSERT INTO funcionario(nome, cpf, dt_cadastro, dt_nascimento, tel_principal, " +
                    "tel_reserva, email, cod_funcionario, status, cargo, turno, salario, cidade, bairro, cep, rua, " +
                    "numero, complemento, chave_acesso, dt_admissao, dt_desligamento) VALUES (@nome, @cpf, @dt_cadastro, @dt_nascimento, " +
                    "@tel_principal, @tel_reserva, @email, @cod_funcionario, @status, @cargo, @turno, @salario, @cidade, " +
                    "@bairro, @cep, @rua, @numero, @complemento, @chave_acesso, @dt_admissao, @dt_desligamento)", DataConnection);

                cmd.Parameters.AddWithValue("@nome", funcionario.nome);
                cmd.Parameters.AddWithValue("@cpf", funcionario.cpf);
                cmd.Parameters.AddWithValue("@dt_cadastro", funcionario.dt_cadastro);
                cmd.Parameters.AddWithValue("@dt_nascimento", funcionario.dt_nascimento);
                cmd.Parameters.AddWithValue("@tel_principal", funcionario.tel_principal);
                cmd.Parameters.AddWithValue("@tel_reserva", funcionario.tel_reserva);
                cmd.Parameters.AddWithValue("@email", funcionario.email);
                cmd.Parameters.AddWithValue("@cod_funcionario", funcionario.cod_funcionario);
                cmd.Parameters.AddWithValue("@status", funcionario.status);
                cmd.Parameters.AddWithValue("@cargo", funcionario.cargo);
                cmd.Parameters.AddWithValue("@turno", funcionario.turno);
                cmd.Parameters.AddWithValue("@salario", funcionario.salario);
                cmd.Parameters.AddWithValue("@cidade", funcionario.cidade);
                cmd.Parameters.AddWithValue("@bairro", funcionario.bairro);
                cmd.Parameters.AddWithValue("@cep", funcionario.cep);
                cmd.Parameters.AddWithValue("@rua", funcionario.rua);
                cmd.Parameters.AddWithValue("@numero", funcionario.numero);
                cmd.Parameters.AddWithValue("@complemento", funcionario.complemento);
                cmd.Parameters.AddWithValue("@chave_acesso", funcionario.chave_acesso);
                cmd.Parameters.AddWithValue("@dt_admissao", funcionario.dt_admissao);
                cmd.Parameters.AddWithValue("@dt_desligamento", funcionario.dt_desligamento);

                cmd.ExecuteNonQuery();


            }

            catch
            {


                sucesso = false;


            }


            return sucesso;


        }

        //  Consultar dados de funcionário
        public Funcionario ConsultarFuncionario_Codigo(int search_cod_funcionario)
        {


            funcionario = null;


            cmd = new MySqlCommand("SELECT nome, cpf, dt_cadastro, dt_nascimento, tel_principal, " +
                "tel_reserva, email, cod_funcionario, status, cargo, turno, salario, cidade, bairro, cep, rua, " +
                "numero, complemento, chave_acesso, dt_admissao, dt_desligamento FROM funcionario " +
                "WHERE cod_funcionario = @cod_funcionario", DataConnection);

            cmd.Parameters.AddWithValue("@cod_funcionario", search_cod_funcionario);


            reader = cmd.ExecuteReader();

            while (reader.Read())
            {


                string nome = reader["nome"].ToString();
                string cpf = reader["cpf"].ToString();
                DateTime dt_cadastro = Convert.ToDateTime(reader["dt_cadastro"]);
                DateTime dt_nascimento = Convert.ToDateTime(reader["dt_nascimento"]);
                string tel_principal = reader["tel_principal"].ToString();
                string tel_reserva = reader["tel_reserva"].ToString();
                string email = reader["email"].ToString();
                int cod_funcionario = search_cod_funcionario;
                string status = reader["status"].ToString();
                string cargo = reader["cargo"].ToString();
                string turno = reader["turno"].ToString();
                decimal salario = Convert.ToDecimal(reader["salario"]);
                string cidade = reader["cidade"].ToString();
                string bairro = reader["bairro"].ToString();
                string cep = reader["cep"].ToString();
                string rua = reader["rua"].ToString();
                int numero = Convert.ToInt32(reader["numero"]);
                string complemento = reader["complemento"].ToString();
                string chave_acesso = reader["chave_acesso"].ToString();
                DateTime dt_admissao = Convert.ToDateTime(reader["dt_admissao"]);
                DateTime dt_desligamento = Convert.ToDateTime(reader["dt_desligamento"]);


                funcionario = new Funcionario(nome, cpf, dt_cadastro, dt_nascimento, tel_principal, tel_reserva,
                    email, cod_funcionario, status, cargo, turno, salario, cidade, bairro, cep, rua, numero, complemento, chave_acesso,
                    dt_admissao, dt_desligamento);


            }


            return funcionario;


        }

        public List<Funcionario> ConsultarFuncionario_Nome(string partenome)
        {


            List<Funcionario> results = new List<Funcionario>();

            funcionario = null;


            cmd = new MySqlCommand("SELECT nome, cpf, dt_cadastro, dt_nascimento, tel_principal, " +
                "tel_reserva, email, cod_funcionario, status, cargo, turno, salario, cidade, bairro, cep, rua, " +
                "numero, complemento, chave_acesso, dt_admissao, dt_desligamento FROM funcionario " +
                "WHERE nome LIKE @nome", DataConnection);

            cmd.Parameters.AddWithValue("@nome", partenome + "%");


            reader = cmd.ExecuteReader();

            while (reader.Read())
            {


                string nome = reader["nome"].ToString();
                string cpf = reader["cpf"].ToString();
                DateTime dt_cadastro = Convert.ToDateTime(reader["dt_cadastro"]);
                DateTime dt_nascimento = Convert.ToDateTime(reader["dt_nascimento"]);
                string tel_principal = reader["tel_principal"].ToString();
                string tel_reserva = reader["tel_reserva"].ToString();
                string email = reader["email"].ToString();
                int cod_funcionario = Convert.ToInt32(reader["cod_funcionario"]); ;
                string status = Convert.ToString(reader["status"]);
                string cargo = reader["cargo"].ToString();
                string turno = reader["turno"].ToString();
                decimal salario = Convert.ToDecimal(reader["salario"]);
                string cidade = reader["cidade"].ToString();
                string bairro = reader["bairro"].ToString();
                string cep = Convert.ToString(reader["cep"]);
                string rua = reader["rua"].ToString();
                int numero = Convert.ToInt32(reader["numero"]);
                string complemento = reader["complemento"].ToString();
                string chave_acesso = reader["chave_acesso"].ToString();
                DateTime dt_admissao = Convert.ToDateTime(reader["dt_admissao"]);
                DateTime dt_desligamento = Convert.ToDateTime(reader["dt_desligamento"]);


                funcionario = new Funcionario(nome, cpf, dt_cadastro, dt_nascimento, tel_principal, tel_reserva,
                    email, cod_funcionario, status, cargo, turno, salario, cidade, bairro, cep, rua, numero, complemento, chave_acesso,
                    dt_admissao, dt_desligamento);

                results.Add(funcionario);


            }

            return results;


        }

        //  Atualizar dados de cadastro de funcionário
        public bool AtualizarDados_Funcionario(Funcionario funcionario)
        {


            try
            {


                cmd = new MySqlCommand("UPDATE funcionario SET nome = @nome, cpf = @cpf, dt_nascimento = @dt_nascimento, " +
                    "tel_principal = @tel_principal, tel_reserva = @tel_reserva, email = @email, status = @status, " +
                    "cargo = @cargo, turno = @turno, salario = @salario, cidade = @cidade, bairro = @bairro, " +
                    "cep = @cep, rua = @rua, numero = @numero, complemento = @complemento, chave_acesso = @chave_acesso, " +
                    "dt_admissao = @dt_admissao, dt_desligamento = @dt_desligamento WHERE cod_funcionario = @cod_funcionario", 
                    DataConnection);

                cmd.Parameters.AddWithValue("@nome", funcionario.nome);
                cmd.Parameters.AddWithValue("@cpf", funcionario.cpf);
                cmd.Parameters.AddWithValue("@dt_cadastro", funcionario.dt_cadastro);
                cmd.Parameters.AddWithValue("@dt_nascimento", funcionario.dt_nascimento);
                cmd.Parameters.AddWithValue("@tel_principal", funcionario.tel_principal);
                cmd.Parameters.AddWithValue("@tel_reserva", funcionario.tel_reserva);
                cmd.Parameters.AddWithValue("@email", funcionario.email);
                cmd.Parameters.AddWithValue("@cod_funcionario", funcionario.cod_funcionario);
                cmd.Parameters.AddWithValue("@status", funcionario.status);
                cmd.Parameters.AddWithValue("@cargo", funcionario.cargo);
                cmd.Parameters.AddWithValue("@turno", funcionario.turno);
                cmd.Parameters.AddWithValue("@salario", funcionario.salario);
                cmd.Parameters.AddWithValue("@cidade", funcionario.cidade);
                cmd.Parameters.AddWithValue("@bairro", funcionario.bairro);
                cmd.Parameters.AddWithValue("@cep", funcionario.cep);
                cmd.Parameters.AddWithValue("@rua", funcionario.rua);
                cmd.Parameters.AddWithValue("@numero", funcionario.numero);
                cmd.Parameters.AddWithValue("@complemento", funcionario.complemento);
                cmd.Parameters.AddWithValue("@chave_acesso", funcionario.chave_acesso);
                cmd.Parameters.AddWithValue("@dt_admissao", funcionario.dt_admissao);
                cmd.Parameters.AddWithValue("@dt_desligamento", funcionario.dt_desligamento);

                cmd.ExecuteNonQuery();


            }

            catch
            {


                sucesso = false;


            }

            return sucesso;


        }

        //  Deletar cadastro de funcionário
        public bool DeletarCadastro_Funcionario(Funcionario funcionario)
        {


            try
            {


                cmd = new MySqlCommand("DELETE FROM funcionario WHERE cod_funcionario = @cod_funcionario", DataConnection);
                cmd.Parameters.AddWithValue("@cod_funcionario", funcionario.cod_funcionario);

                cmd.ExecuteNonQuery();


            }

            catch
            {


                sucesso = false;


            }

            return sucesso;


        }


        //  Cadastrar novo autor
        public bool CadastrarAutor(Autor autor)
        {


            try
            {


                cmd = new MySqlCommand("INSERT INTO autor(cod_autor, nome, dt_nascimento, descricao, dt_cadastro) VALUES " +
                    "(@cod_autor, @nome, @dt_nascimento, @descricao, @dt_cadastro)", DataConnection);

                cmd.Parameters.AddWithValue("@cod_autor", autor.cod_autor);
                cmd.Parameters.AddWithValue("@nome", autor.nome);
                cmd.Parameters.AddWithValue("@dt_nascimento", autor.dt_nascimento);
                cmd.Parameters.AddWithValue("@descricao", autor.descricao);
                cmd.Parameters.AddWithValue("@dt_cadastro", autor.dt_cadastro);

                cmd.ExecuteNonQuery();


            }

            catch
            {


                sucesso = false;


            }

            return sucesso;


        }

        //  Consultar dados de autor
        public Autor ConsultarAutor_Codigo(int search_cod_autor)
        {


            autor = null;


            cmd = new MySqlCommand("SELECT cod_autor, nome, dt_nascimento, descricao, dt_cadastro FROM autor " +
                "WHERE cod_autor = @cod_autor", DataConnection);

            cmd.Parameters.AddWithValue("@cod_autor", search_cod_autor);


            reader = cmd.ExecuteReader();

            while (reader.Read())
            {


                int cod_autor = Convert.ToInt32(reader["cod_autor"]);
                string nome = reader["nome"].ToString();
                DateTime dt_nascimento = Convert.ToDateTime(reader["dt_nascimento"]);
                string descricao = Convert.ToString(reader["descricao"]);
                DateTime dt_cadastro = Convert.ToDateTime(reader["dt_cadastro"]);


                autor = new Autor(cod_autor, nome, dt_nascimento, descricao, dt_cadastro);


            }

            return autor;


        }

        public List<Autor> ConsultarAutor_Nome(string partenome)
        {


            List<Autor> results = new List<Autor>();

            autor = null;


            cmd = new MySqlCommand("SELECT cod_autor, nome, dt_nascimento, descricao, dt_cadastro " +
                "FROM autor WHERE nome LIKE @nome", DataConnection);

            cmd.Parameters.AddWithValue("@nome", partenome + "%");


            reader = cmd.ExecuteReader();

            while (reader.Read())
            {


                int cod_autor = Convert.ToInt32(reader["cod_autor"]);
                string nome = reader["nome"].ToString();
                DateTime dt_nascimento = Convert.ToDateTime(reader["dt_nascimento"]);
                string descricao = Convert.ToString(reader["descricao"]);
                DateTime dt_cadastro = Convert.ToDateTime(reader["dt_cadastro"]);


                autor = new Autor(cod_autor, nome, dt_nascimento, descricao, dt_cadastro);
                results.Add(autor);


            }

            return results;


        }

        //  Atualizar dados de cadastro de autor
        public bool AtualizarDados_Autor(Autor autor)
        {


            try
            {


                cmd = new MySqlCommand("UPDATE autor SET nome = @nome, dt_nascimento = @dt_nascimento, descricao = @descricao " +
                    "WHERE cod_autor = @cod_autor", DataConnection);

                cmd.Parameters.AddWithValue("@nome", autor.nome);
                cmd.Parameters.AddWithValue("@dt_nascimento", autor.dt_nascimento);
                cmd.Parameters.AddWithValue("@descricao", autor.descricao);
                cmd.Parameters.AddWithValue("@cod_autor", autor.cod_autor);

                cmd.ExecuteNonQuery();


            }

            catch
            {


                sucesso = false;


            }

            return sucesso;
        }

        //  Deletar cadastro de autor
        public bool DeletarCadastro_Autor(Autor autor)
        {


            try
            {


                cmd = new MySqlCommand("DELETE FROM autor WHERE cod_autor = @cod_autor", DataConnection);
                cmd.Parameters.AddWithValue("@cod_autor", autor.cod_autor);

                cmd.ExecuteNonQuery();


            }

            catch
            {


                sucesso = false;


            }

            return sucesso;


        }


        //  Cadastrar livro
        public bool CadastrarLivro(Livro livro)
        {


            try
            {


                cmd = new MySqlCommand("INSERT INTO livro(cod_livro, titulo, ano_publicacao, editora, descricao, dt_cadastro, " +
                    "valor_livro) VALUES (@cod_livro, @titulo, @ano_publicacao, @editora, @descricao, @dt_cadastro, " +
                    "@valor_livro)", DataConnection);

                cmd.Parameters.AddWithValue("@cod_livro", livro.cod_livro);
                cmd.Parameters.AddWithValue("@titulo", livro.titulo);
                cmd.Parameters.AddWithValue("@ano_publicacao", livro.ano_publicacao);
                cmd.Parameters.AddWithValue("@editora", livro.editora);
                cmd.Parameters.AddWithValue("@descricao", livro.descricao);
                cmd.Parameters.AddWithValue("@dt_cadastro", livro.dt_cadastro);
                cmd.Parameters.AddWithValue("@valor_livro", livro.valor_livro);

                cmd.ExecuteNonQuery();


            }

            catch
            {


                sucesso = false;


            }

            return sucesso;


        }

        public bool CadastrarAutorLivro(AutorLivro autorlivro)
        {


            try
            {


                cmd = new MySqlCommand("INSERT INTO autorlivro(cod_autorlivro, cod_autor, cod_livro) VALUES (@cod_autorlivro, " +
                    "@cod_autor, @cod_livro)", DataConnection);


                cmd.Parameters.AddWithValue("@cod_autorlivro", autorlivro.cod_autorlivro);
                cmd.Parameters.AddWithValue("@cod_autor", autorlivro.cod_autor);
                cmd.Parameters.AddWithValue("@cod_livro", autorlivro.cod_livro);


                cmd.ExecuteNonQuery();


            }

            catch
            {


                sucesso = false;


            }

            return sucesso;


        }

        //  Consultar dados de livro
        public Livro ConsultarLivro_Codigo(int search_cod_livro)
        {


            livro = null;

            cmd = new MySqlCommand("SELECT cod_livro, titulo, ano_publicacao, editora, descricao, dt_cadastro, " +
                "valor_livro FROM livro WHERE cod_livro = @cod_livro", DataConnection);

            cmd.Parameters.AddWithValue("@cod_livro", search_cod_livro);


            reader = cmd.ExecuteReader();

            while (reader.Read())
            {


                int cod_livro = Convert.ToInt32(reader["cod_livro"]);
                string titulo = reader["titulo"].ToString();
                int ano_publicacao = Convert.ToInt32(reader["ano_publicacao"]);
                string editora = Convert.ToString(reader["editora"]);
                string descricao = Convert.ToString(reader["descricao"]);
                DateTime dt_cadastro = Convert.ToDateTime(reader["dt_cadastro"]);
                decimal valor_livro = Convert.ToDecimal(reader["valor_livro"]);


                livro = new Livro(cod_livro, titulo, ano_publicacao, editora, descricao, dt_cadastro, valor_livro);


            }

            return livro;


        }

        public List<Livro> ConsultarLivro_Titulo(string parteTitulo)
        {


            List<Livro> results = new List<Livro>();

            livro = null;


            cmd = new MySqlCommand("SELECT cod_livro, titulo, ano_publicacao, editora, descricao, dt_cadastro, " +
                "valor_livro FROM livro WHERE titulo LIKE @titulo", DataConnection);

            cmd.Parameters.AddWithValue("@titulo", parteTitulo + "%");


            reader = cmd.ExecuteReader();

            while (reader.Read())
            {


                int cod_livro = Convert.ToInt32(reader["cod_livro"]);
                string titulo = reader["titulo"].ToString();
                int ano_publicacao = Convert.ToInt32(reader["ano_publicacao"]);
                string editora = Convert.ToString(reader["editora"]);
                string descricao = Convert.ToString(reader["descricao"]);
                DateTime dt_cadastro = Convert.ToDateTime(reader["dt_cadastro"]);
                decimal valor_livro = Convert.ToDecimal(reader["valor_livro"]);


                livro = new Livro(cod_livro, titulo, ano_publicacao, editora, descricao, dt_cadastro, valor_livro);
                results.Add(livro);


            }

            return results;


        }

        //  Atualizar dados de livro
        public bool AtualizarDados_Livro(Livro livro)
        {


            try
            {


                cmd = new MySqlCommand("UPDATE livro SET titulo = @titulo, ano_publicacao = @ano_publicacao, editora = @editora, " +
                    "descricao = @descricao, valor_livro = @valor_livro WHERE cod_livro = @cod_livro", DataConnection);

                cmd.Parameters.AddWithValue("@titulo", livro.titulo);
                cmd.Parameters.AddWithValue("@ano_publicacao", livro.ano_publicacao);
                cmd.Parameters.AddWithValue("@editora", livro.editora);
                cmd.Parameters.AddWithValue("@descricao", livro.descricao);
                cmd.Parameters.AddWithValue("@valor_livro", livro.valor_livro);
                cmd.Parameters.AddWithValue("@cod_livro", livro.cod_livro);

                cmd.ExecuteNonQuery();


            }
            catch
            {


                sucesso = false;


            }

            return sucesso;


        }

        //  Deletar cadastro de livro
        public bool DeletarCadastro_Livro(Livro livro)
        {


            try
            {


                cmd = new MySqlCommand("DELETE FROM livro WHERE cod_livro = @cod_livro", DataConnection);

                cmd.Parameters.AddWithValue("@cod_livro", livro.cod_livro);

                cmd.ExecuteNonQuery();


            }

            catch
            {


                sucesso = false;


            }

            return sucesso;


        }

        public bool DeletarAutorLivro(AutorLivro autorlivro)
        {


            try
            {


                cmd = new MySqlCommand("DELETE FROM autorlivro WHERE cod_autorlivro = @cod_autorlivro", DataConnection);

                cmd.Parameters.AddWithValue("@cod_autorlivro", autorlivro.cod_autorlivro);

                cmd.ExecuteNonQuery();


            }

            catch
            {


                sucesso = false;


            }

            return sucesso;


        }


        //      MÉTODOS-CHAVE: servem tanto para o FormLivro quanto para o FormVenda
        public List<AutorLivro> ProcurarAutoresLivro_Codigo(int search_cod_livro)
        {


            List<AutorLivro> results = new List<AutorLivro>();

            autorlivro = null;


            cmd = new MySqlCommand("SELECT cod_autorlivro, cod_autor, cod_livro FROM autorlivro " +
                "WHERE cod_livro = @cod_livro", DataConnection);

            cmd.Parameters.AddWithValue("@cod_livro", search_cod_livro);


            reader = cmd.ExecuteReader();

            while (reader.Read())
            {


                int cod_autorlivro = Convert.ToInt32(reader["cod_autorlivro"]);
                int cod_autor = Convert.ToInt32(reader["cod_autor"]);
                int cod_livro = Convert.ToInt32(reader["cod_livro"]);


                autorlivro = new AutorLivro(cod_autorlivro, cod_autor, cod_livro);

                results.Add(autorlivro);


            }

            return results;


        }

        public Autor ProcurarAutores_Nome(int search_cod_autor)
        {


            autor = null;


            cmd = new MySqlCommand("SELECT cod_autor, nome, dt_nascimento, descricao, dt_cadastro FROM autor " +
                "WHERE cod_autor = @cod_autor", DataConnection);

            cmd.Parameters.AddWithValue("@cod_autor", search_cod_autor);


            reader = cmd.ExecuteReader();

            while (reader.Read())
            {


                int cod_autor = Convert.ToInt32(reader["cod_autor"]);
                string nome = reader["nome"].ToString();
                DateTime dt_nascimento = Convert.ToDateTime(reader["dt_nascimento"]);
                string descricao = Convert.ToString(reader["descricao"]);
                DateTime dt_cadastro = Convert.ToDateTime(reader["dt_cadastro"]);


                autor = new Autor(cod_autor, nome, dt_nascimento, descricao, dt_cadastro);


            }

            return autor;


        }


        //  Iniciar sessão
        public ValidarLogin IniciarSessao(int validar_cod_funcionario)
        {


            validarlogin = null;


            cmd = new MySqlCommand("SELECT cod_funcionario FROM funcionario WHERE " +
                "cod_funcionario = @cod_funcionario", DataConnection);

            cmd.Parameters.AddWithValue("@cod_funcionario", validar_cod_funcionario);


            reader = cmd.ExecuteReader();

            while (reader.Read())
            {


                int cod_funcionario = validar_cod_funcionario;
                validarlogin = new ValidarLogin(cod_funcionario);


            }

            return validarlogin;


        }

        //  Registrar venda
        public bool RegistrarVenda(Venda venda)
        {


            try
            {


                cmd = new MySqlCommand("INSERT INTO venda(cod_venda, cod_cliente, cod_funcionario, dt_registro, " +
                    "valor_totalvenda) VALUES (@cod_venda, @cod_cliente, @cod_funcionario, @dt_registro, @valor_totalvenda)", 
                    DataConnection);

                cmd.Parameters.AddWithValue("@cod_venda", venda.cod_venda);
                cmd.Parameters.AddWithValue("@cod_cliente", venda.cod_cliente);
                cmd.Parameters.AddWithValue("@cod_funcionario", venda.cod_funcionario);
                cmd.Parameters.AddWithValue("@dt_registro", venda.dt_registro);
                cmd.Parameters.AddWithValue("@valor_totalvenda", venda.valor_totalvenda);

                cmd.ExecuteNonQuery();


            }

            catch
            {


                sucesso = false;


            }

            return sucesso;


        }

        public bool RegistrarListaProdutos(ItemVenda itemvenda)
        {


            try
            {


                cmd = new MySqlCommand("INSERT INTO itemvenda(cod_itemvenda, cod_venda, dt_registro, cod_livro, " +
                    "valor_livro, unidades, valor_itemvenda) VALUES (@cod_itemvenda, @cod_venda, @dt_registro, " +
                    "@cod_livro, @valor_livro, @unidades, @valor_itemvenda)", DataConnection);


                cmd.Parameters.AddWithValue("@cod_itemvenda", itemvenda.cod_itemvenda);
                cmd.Parameters.AddWithValue("@cod_venda", itemvenda.cod_venda);
                cmd.Parameters.AddWithValue("@dt_registro", itemvenda.dt_registro);
                cmd.Parameters.AddWithValue("@cod_livro", itemvenda.cod_livro);
                cmd.Parameters.AddWithValue("@valor_livro", itemvenda.valor_livro);
                cmd.Parameters.AddWithValue("@unidades", itemvenda.unidades);
                cmd.Parameters.AddWithValue("@valor_itemvenda", itemvenda.valor_itemvenda);

                cmd.ExecuteNonQuery();


            }
            catch
            {


                sucesso = false;


            }

            return sucesso;


        }

        //  Consultar venda
        public Venda ConsultarVenda_CodigoVenda(int search_cod_venda)
        {


            venda = null;


            cmd = new MySqlCommand("SELECT cod_venda, cod_cliente, cod_funcionario, dt_registro, valor_totalvenda " +
                "FROM venda WHERE cod_venda = @cod_venda", DataConnection);

            cmd.Parameters.AddWithValue("@cod_venda", search_cod_venda);


            reader = cmd.ExecuteReader();

            while (reader.Read())
            {


                int cod_venda = Convert.ToInt32(reader["cod_venda"]);
                int cod_cliente = Convert.ToInt32(reader["cod_cliente"]);
                int cod_funcionario = Convert.ToInt32(reader["cod_funcionario"]);
                DateTime dt_registro = Convert.ToDateTime(reader["dt_registro"]);
                decimal valor_totalvenda = Convert.ToDecimal(reader["valor_totalvenda"]);


                venda = new Venda(cod_venda, cod_cliente, cod_funcionario, dt_registro, valor_totalvenda);


            }

            return venda;


        }

        public List<Venda> ConsultarVenda_CodigoCliente(int search_cod_cliente)
        {


            List<Venda> results = new List<Venda>();

            venda = null;


            cmd = new MySqlCommand("SELECT cod_venda, cod_cliente, cod_funcionario, dt_registro, valor_totalvenda " +
                "FROM venda WHERE cod_cliente = @cod_cliente", DataConnection);

            cmd.Parameters.AddWithValue("@cod_cliente", search_cod_cliente);


            reader = cmd.ExecuteReader();

            while (reader.Read())
            {


                int cod_venda = Convert.ToInt32(reader["cod_venda"]);
                int cod_cliente = Convert.ToInt32(reader["cod_cliente"]);
                int cod_funcionario = Convert.ToInt32(reader["cod_funcionario"]);
                DateTime dt_registro = Convert.ToDateTime(reader["dt_registro"]);
                decimal valor_totalvenda = Convert.ToDecimal(reader["valor_totalvenda"]);


                venda = new Venda(cod_venda, cod_cliente, cod_funcionario, dt_registro, valor_totalvenda);
                results.Add(venda);


            }


            return results;


        }

        public List<Venda> ConsultarVenda_CodigoFuncionario(int search_cod_funcionario)
        {


            List<Venda> results = new List<Venda>();

            venda = null;


            cmd = new MySqlCommand("SELECT cod_venda, cod_cliente, cod_funcionario, dt_registro, valor_totalvenda " +
                "FROM venda WHERE cod_funcionario = @cod_funcionario", DataConnection);

            cmd.Parameters.AddWithValue("@cod_funcionario", search_cod_funcionario);


            reader = cmd.ExecuteReader();

            while (reader.Read())
            {


                int cod_venda = Convert.ToInt32(reader["cod_venda"]);
                int cod_cliente = Convert.ToInt32(reader["cod_cliente"]);
                int cod_funcionario = Convert.ToInt32(reader["cod_funcionario"]);
                DateTime dt_registro = Convert.ToDateTime(reader["dt_registro"]);
                decimal valor_totalvenda = Convert.ToDecimal(reader["valor_totalvenda"]);


                venda = new Venda(cod_venda, cod_cliente, cod_funcionario, dt_registro, valor_totalvenda);
                results.Add(venda);


            }


            return results;


        }

        public List<ItemVenda> ConsultarItemVenda(int search_cod_venda)
        {


            List<ItemVenda> results = new List<ItemVenda>();

            itemvenda = null;


            cmd = new MySqlCommand("SELECT cod_itemvenda, cod_venda, dt_registro, cod_livro, valor_livro, " +
                "unidades, valor_itemvenda FROM itemvenda WHERE cod_venda = @cod_venda", DataConnection);

            cmd.Parameters.AddWithValue("@cod_venda", search_cod_venda);


            reader = cmd.ExecuteReader();

            while (reader.Read())
            {


                int cod_itemvenda = Convert.ToInt32(reader["cod_itemvenda"]);
                int cod_venda = Convert.ToInt32(reader["cod_venda"]);
                DateTime dt_registro = Convert.ToDateTime(reader["dt_registro"]);
                int cod_livro = Convert.ToInt32(reader["cod_livro"]);
                decimal valor_livro = Convert.ToDecimal(reader["valor_livro"]);
                int unidades = Convert.ToInt32(reader["unidades"]);
                decimal valor_itemvenda = Convert.ToDecimal(reader["valor_itemvenda"]);


                itemvenda = new ItemVenda(cod_itemvenda, cod_venda, dt_registro, cod_livro, valor_livro, unidades, valor_itemvenda);
                results.Add(itemvenda);


            }


            return results;


        }




    }
}
