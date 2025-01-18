using BenTech.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BenTech
{
    class DatabaseRepository
    {
        private readonly DatabaseConnection _databaseConnection;
        public DatabaseRepository()
        {
            _databaseConnection = new DatabaseConnection();
        }
        public (string username, bool isAdmin) Login(string username, string password)
        {
            using (var connection = _databaseConnection.ConnectToDatabase())
            {
                if (connection == null)
                {
                    return (null, false);
                }

                string query = "SELECT user_name, is_admin FROM users WHERE user_name = @username AND password = @password";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                using (var reader = command.ExecuteReader())
                {
                    return reader.Read() ? (reader["user_name"].ToString(), Convert.ToBoolean(reader["is_admin"])) : (null, false);
                }

            }

        }
        public List<Employees> GetAllEmployees()
        {
            var employees = new List<Employees>();
            using (var connection = _databaseConnection.ConnectToDatabase())
            {
                if (connection == null)
                {
                    return employees;
                }

                string query = "SELECT id, user_name, is_admin FROM users";
                var command = new MySqlCommand(query, connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Cria objetos Employee diretamente.
                    var employee = new Employees
                    {
                        ID = Convert.ToString(reader.GetInt32(reader.GetOrdinal("id"))),
                        Username = reader.GetString(reader.GetOrdinal("user_name")),
                        IsAdmin = reader.GetBoolean(reader.GetOrdinal("is_admin"))
                    };
                    employees.Add(employee);
                }
            }

            return employees;
        }

        public bool AddEmployee(string name, string password, bool isAdmin)
        {
            using (var connection = _databaseConnection.ConnectToDatabase())
            {
                if (connection == null)
                {
                    return false;
                }
                string query = "INSERT INTO users (user_name,password, is_admin) VALUES (@user_name,@password, @is_admin)";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@user_name", name);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@is_admin", isAdmin);
                try
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public bool DeleteEmployee(Int32 id)
        {
            using (var connection = _databaseConnection.ConnectToDatabase())
            {
                if (connection == null)
                {
                    return false;
                }
                string query = "DELETE FROM users WHERE id=@id";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                int result = command.ExecuteNonQuery();  // Executa a query e retorna o número de linhas afetadas
                return result > 0;  // Se result for maior que 0, significa que a exclusão foi bem-sucedida
            }
        }

        public Employees GetEmployeeById(int id)
        {
            // Lógica para obter os dados do funcionário com base no ID
            using (var connection = _databaseConnection.ConnectToDatabase())
            {
                if (connection == null)
                {
                    return null;
                }

                string query = "SELECT user_name, password, is_admin FROM users WHERE id = @id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Employees
                        {
                            Username = reader["user_name"].ToString(),
                            Password = reader["password"].ToString(),
                            IsAdmin = Convert.ToBoolean(reader["is_admin"])
                        };
                    }
                    return null;
                }
            }
        }
        public bool UpdateEmployee(int employeeId, string name, string password, bool isAdmin)
        {
            // Lógica para atualizar um funcionário no banco de dados
            using (var connection = _databaseConnection.ConnectToDatabase())
            {
                if (connection == null)
                {
                    return false;
                }

                string query = "UPDATE users SET user_name = @name, password = @password, is_admin = @isAdmin WHERE id = @id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@isAdmin", isAdmin);
                command.Parameters.AddWithValue("@id", employeeId);

                int result = command.ExecuteNonQuery(); // Retorna o número de linhas afetadas
                return result > 0; // Retorna verdadeiro se a atualização foi bem-sucedida
            }
        }


        public bool DoDatesExistInDatabase(string start, string end)
        {
            using (var connection = _databaseConnection.ConnectToDatabase())
            {
                if (connection == null)
                    return false;

                return DateExists(connection, start) && DateExists(connection, end);
            }
        }

        private bool DateExists(MySqlConnection connection, string date)
        {
            const string query = "SELECT COUNT(*) FROM valores WHERE DATE(data) = @data;";
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@data", date);
                return Convert.ToInt32(command.ExecuteScalar()) > 0;
            }
        }

        public Prices GetSumPricesInRange(string start, string end)
        {

            using (var connection = _databaseConnection.ConnectToDatabase())
            {
                if (connection == null)
                {
                    return null;
                }

                string query = @"
            SELECT 
                sum(valor_casal) AS Couple,
                sum(valor_solteiro) AS Single,
                sum(valor_triplo) AS Triple,
                sum(valor_quadruplo) AS Quadruple,
                sum(valor_quintuplo) AS Quintuple,
                sum(valor_criancaDe03A06) AS Child03To06,
                sum(valor_criancaDe07A10) AS Child07To10
            FROM valores
            WHERE data BETWEEN @start AND @end";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@start", start);
                    command.Parameters.AddWithValue("@end", end);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Prices
                            {
                                TotalCouple = reader.GetFieldValue<double>(reader.GetOrdinal("Couple")),
                                TotalSingle = reader.GetFieldValue<double>(reader.GetOrdinal("Single")),
                                TotalTriple = reader.GetFieldValue<double>(reader.GetOrdinal("Triple")),
                                TotalQuadruple = reader.GetFieldValue<double>(reader.GetOrdinal("Quadruple")),
                                TotalQuintuple = reader.GetFieldValue<double>(reader.GetOrdinal("Quintuple")),
                                TotalChild03To06 = reader.GetFieldValue<double>(reader.GetOrdinal("Child03To06")),
                                TotalChild07To10 = reader.GetFieldValue<double>(reader.GetOrdinal("Child07To10"))
                            };
                        }
                    }
                }
            }
            return null;
        }
        public List<Prices> GetPricesInRange(string start, string end)
        {
            var pricesList = new List<Prices>();
            using (var connection = _databaseConnection.ConnectToDatabase())
            {
                if (connection == null)
                {
                    return pricesList;
                }
                string query = @"
            SELECT 
data,
                valor_casal AS Couple,
                valor_solteiro AS Single,
                valor_triplo AS Triple,
                valor_quadruplo AS Quadruple,
                valor_quintuplo AS Quintuple,
                valor_criancaDe03A06 AS Child03To06,
                valor_criancaDe07A10 AS Child07To10,
                colorCode AS color
            FROM valores
            WHERE data BETWEEN @start AND @end";


                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@start", start);
                    command.Parameters.AddWithValue("@end", end);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var prices = new Prices
                            {
                                Data = reader.GetDateTime(reader.GetOrdinal("data")),
                                TotalCouple = reader.GetFieldValue<double>(reader.GetOrdinal("Couple")),
                                TotalSingle = reader.GetFieldValue<double>(reader.GetOrdinal("Single")),
                                TotalTriple = reader.GetFieldValue<double>(reader.GetOrdinal("Triple")),
                                TotalQuadruple = reader.GetFieldValue<double>(reader.GetOrdinal("Quadruple")),
                                TotalQuintuple = reader.GetFieldValue<double>(reader.GetOrdinal("Quintuple")),
                                TotalChild03To06 = reader.GetFieldValue<double>(reader.GetOrdinal("Child03To06")),
                                TotalChild07To10 = reader.GetFieldValue<double>(reader.GetOrdinal("Child07To10")),
                                ColorCode = reader.GetFieldValue<string>(reader.GetOrdinal("color"))
                            };
                            pricesList.Add(prices);
                        }
                    }
                }
            }
            return pricesList;
        }
        public void CreateOrUpdatePredefinedPriceDatabase(PredefinedPrices predefinedPrices)
        {
            using (var connection = _databaseConnection.ConnectToDatabase())
            {
                if (connection == null)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados.");
                    return;
                }

                try
                {
                    if (connection.State != System.Data.ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    using (var transaction = connection.BeginTransaction())
                    {
                        // Verificar se o predefinedPrice já existe
                        string checkIfExistsQuery = @"
                    SELECT COUNT(*) 
                    FROM predefinedPrices 
                    WHERE colorCode = @currentColorCode";

                        using (var checkCommand = new MySqlCommand(checkIfExistsQuery, connection, transaction))
                        {
                            checkCommand.Parameters.AddWithValue("@currentColorCode", predefinedPrices.OldColorCode);

                            int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                            if (count > 0)
                            {
                                // O registro existe, então vamos fazer o UPDATE
                                string updatePredefinedPricesQuery = @"
                            UPDATE predefinedPrices 
                            SET 
                                name = @name,
                                couple = @couple,
                                single = @single,
                                triple = @triple,
                                quadruple = @quadruple,
                                quintuple = @quintuple,
                                child03to06 = @child03to06,
                                child07to10 = @child07to10,
                                colorCode = @newColorCode
                            WHERE colorCode = @currentColorCode";

                                using (var updateCommand = new MySqlCommand(updatePredefinedPricesQuery, connection, transaction))
                                {
                                    // Parâmetros
                                    updateCommand.Parameters.AddWithValue("@currentColorCode", predefinedPrices.OldColorCode);
                                    updateCommand.Parameters.AddWithValue("@newColorCode", predefinedPrices.ColorCode);
                                    updateCommand.Parameters.AddWithValue("@name", predefinedPrices.Name);
                                    updateCommand.Parameters.AddWithValue("@couple", predefinedPrices.Couple);
                                    updateCommand.Parameters.AddWithValue("@single", predefinedPrices.Single);
                                    updateCommand.Parameters.AddWithValue("@triple", predefinedPrices.Triple);
                                    updateCommand.Parameters.AddWithValue("@quadruple", predefinedPrices.Quadruple);
                                    updateCommand.Parameters.AddWithValue("@quintuple", predefinedPrices.Quintuple);
                                    updateCommand.Parameters.AddWithValue("@child03to06", predefinedPrices.Child03To06);
                                    updateCommand.Parameters.AddWithValue("@child07to10", predefinedPrices.Child07To10);

                                    updateCommand.ExecuteNonQuery();
                                }

                                // Atualiza os dados na tabela valores, pois o registro foi atualizado
                                string updateValoresQuery = @"
                            UPDATE valores
                            SET 
                                valor_casal = @Couple,
                                valor_solteiro = @Single,
                                valor_triplo = @Triple,
                                valor_quadruplo = @Quadruple,
                                valor_quintuplo = @Quintuple,
                                valor_criancaDe03A06 = @Child03To06,
                                valor_criancaDe07A10 = @Child07To10
                            WHERE colorCode = @newColorCode";

                                using (var updateCommand = new MySqlCommand(updateValoresQuery, connection, transaction))
                                {
                                    // Parâmetros
                                    updateCommand.Parameters.AddWithValue("@newColorCode", predefinedPrices.ColorCode);
                                    updateCommand.Parameters.AddWithValue("@Couple", predefinedPrices.Couple);
                                    updateCommand.Parameters.AddWithValue("@Single", predefinedPrices.Single);
                                    updateCommand.Parameters.AddWithValue("@Triple", predefinedPrices.Triple);
                                    updateCommand.Parameters.AddWithValue("@Quadruple", predefinedPrices.Quadruple);
                                    updateCommand.Parameters.AddWithValue("@Quintuple", predefinedPrices.Quintuple);
                                    updateCommand.Parameters.AddWithValue("@Child03To06", predefinedPrices.Child03To06);
                                    updateCommand.Parameters.AddWithValue("@Child07To10", predefinedPrices.Child07To10);

                                    updateCommand.ExecuteNonQuery();
                                }
                            }
                            else
                            {
                                // O registro não existe, então vamos fazer o INSERT
                                string insertPredefinedPricesQuery = @"
                            INSERT INTO predefinedPrices (name, couple, single, triple, quadruple, quintuple, child03to06, child07to10, colorCode)
                            VALUES (@name, @couple, @single, @triple, @quadruple, @quintuple, @child03to06, @child07to10, @newColorCode)";

                                using (var insertCommand = new MySqlCommand(insertPredefinedPricesQuery, connection, transaction))
                                {
                                    // Parâmetros
                                    insertCommand.Parameters.AddWithValue("@name", predefinedPrices.Name);
                                    insertCommand.Parameters.AddWithValue("@couple", predefinedPrices.Couple);
                                    insertCommand.Parameters.AddWithValue("@single", predefinedPrices.Single);
                                    insertCommand.Parameters.AddWithValue("@triple", predefinedPrices.Triple);
                                    insertCommand.Parameters.AddWithValue("@quadruple", predefinedPrices.Quadruple);
                                    insertCommand.Parameters.AddWithValue("@quintuple", predefinedPrices.Quintuple);
                                    insertCommand.Parameters.AddWithValue("@child03to06", predefinedPrices.Child03To06);
                                    insertCommand.Parameters.AddWithValue("@child07to10", predefinedPrices.Child07To10);
                                    insertCommand.Parameters.AddWithValue("@newColorCode", predefinedPrices.ColorCode);

                                    insertCommand.ExecuteNonQuery();
                                }
                            }
                        }

                        transaction.Commit();
                        MessageBox.Show("Operação realizada com sucesso.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao processar o banco de dados: {ex.Message}");
                }
                finally
                {
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }


        public List<PredefinedPrices> GetPredefinedPrices()
        {
            var predefinedPrices = new List<PredefinedPrices>();
            using (var connection = _databaseConnection.ConnectToDatabase())
            {
                if (connection == null)
                {
                    return null;
                }

                string query = "SELECT * FROM predefinedPrices";

                using (var command = new MySqlCommand(query, connection))
                {

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var prices = new PredefinedPrices
                            {
                                ColorCode = reader.GetFieldValue<string>(reader.GetOrdinal("colorCode")),
                                Name = reader.GetFieldValue<string>(reader.GetOrdinal("name")),
                                Couple = reader.GetFieldValue<double>(reader.GetOrdinal("Couple")),
                                Single = reader.GetFieldValue<double>(reader.GetOrdinal("Single")),
                                Triple = reader.GetFieldValue<double>(reader.GetOrdinal("Triple")),
                                Quadruple = reader.GetFieldValue<double>(reader.GetOrdinal("Quadruple")),
                                Quintuple = reader.GetFieldValue<double>(reader.GetOrdinal("Quintuple")),
                                Child03To06 = reader.GetFieldValue<double>(reader.GetOrdinal("Child03To06")),
                                Child07To10 = reader.GetFieldValue<double>(reader.GetOrdinal("Child07To10"))
                            };
                            predefinedPrices.Add(prices);
                        }
                    }
                }
                return predefinedPrices;
            }
        }

        public void AssignPredefinedPricesToDay(string date, PredefinedPrices prices)
        {
            try
            {
                using (var connection = _databaseConnection.ConnectToDatabase())
                {
                    if (connection == null)
                    {
                        Console.WriteLine("Falha ao conectar ao banco de dados.");
                        return;
                    }

                    // Tenta atualizar o dia específico
                    string updateQuery = @"
                UPDATE valores
                SET 
                    colorCode = @colorCode,
                    valor_casal = @Couple,
                    valor_solteiro = @Single,
                    valor_triplo = @Triple,
                    valor_quadruplo = @Quadruple,
                    valor_Quintuplo = @Quintuple,
                    valor_criancaDe03A06 = @Child03To06,
                    valor_criancaDe07A10 = @Child07To10
                WHERE `data` = @Date";

                    using (var updateCommand = new MySqlCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@Date", date);
                        updateCommand.Parameters.AddWithValue("@colorCode", prices.ColorCode);
                        updateCommand.Parameters.AddWithValue("@Couple", prices.Couple);
                        updateCommand.Parameters.AddWithValue("@Single", prices.Single);
                        updateCommand.Parameters.AddWithValue("@Triple", prices.Triple);
                        updateCommand.Parameters.AddWithValue("@Quadruple", prices.Quadruple);
                        updateCommand.Parameters.AddWithValue("@Quintuple", prices.Quintuple);
                        updateCommand.Parameters.AddWithValue("@Child03To06", prices.Child03To06);
                        updateCommand.Parameters.AddWithValue("@Child07To10", prices.Child07To10);

                        int rowsAffected = updateCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Dia atualizado com sucesso.");
                        }
                        else
                        {
                            // Se nenhum registro foi atualizado, insere o novo dia
                            Console.WriteLine("Dia não encontrado. Inserindo novo registro.");
                            string insertQuery = @"
                        INSERT INTO valores (
                            `data`, colorCode, valor_casal, valor_solteiro, valor_triplo, 
                            valor_quadruplo, valor_Quintuplo, valor_criancaDe03A06, valor_criancaDe07A10
                        )
                        VALUES (
                            @Date, @colorCode, @Couple, @Single, @Triple, 
                            @Quadruple, @Quintuple, @Child03To06, @Child07To10
                        )";

                            using (var insertCommand = new MySqlCommand(insertQuery, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@Date", date);
                                insertCommand.Parameters.AddWithValue("@colorCode", prices.ColorCode);
                                insertCommand.Parameters.AddWithValue("@Couple", prices.Couple);
                                insertCommand.Parameters.AddWithValue("@Single", prices.Single);
                                insertCommand.Parameters.AddWithValue("@Triple", prices.Triple);
                                insertCommand.Parameters.AddWithValue("@Quadruple", prices.Quadruple);
                                insertCommand.Parameters.AddWithValue("@Quintuple", prices.Quintuple);
                                insertCommand.Parameters.AddWithValue("@Child03To06", prices.Child03To06);
                                insertCommand.Parameters.AddWithValue("@Child07To10", prices.Child07To10);

                                insertCommand.ExecuteNonQuery();
                                Console.WriteLine("Novo dia inserido com sucesso.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao inserir/atualizar os preços: {ex.Message}");
            }
        }
        public void DeletePredefinedPrice(string color)
        {

            using (var connection = _databaseConnection.ConnectToDatabase())
            {
                if (connection == null)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados.");
                    return;
                }


                try
                {
                    string updateQuery = @"
              DELETE  FROM predefinedPrices WHERE colorCode = @colorCode";

                    using (var deleteCommand = new MySqlCommand(updateQuery, connection))
                    {
                        deleteCommand.Parameters.AddWithValue("@colorCode", color);

                        // Executa o comando
                        int rowsAffected = deleteCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registro deletado com sucesso.");
                        }
                        else
                        {
                            MessageBox.Show("Nenhum registro encontrado para a cor especificada.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao deletar o registro: " + ex.Message);
                }

            }
        }
    }
}

