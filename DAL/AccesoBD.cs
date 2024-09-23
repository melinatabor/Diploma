using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AccesoBD
    {
        private static SqlConnection _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["BDConnection"].ConnectionString);
        private static SqlCommand _command;
        private static SqlTransaction _transaction;

        public static DataTable ExecuteDataTable(string query, Hashtable queryParams, bool isStoredProcedure = false)
        {
            DataTable table = new DataTable();

            try
            {
                _command = new SqlCommand(query, _connection);
                _command.CommandType = isStoredProcedure ? CommandType.StoredProcedure : CommandType.Text;

                if (queryParams != null)
                {
                    foreach (DictionaryEntry param in queryParams)
                    {
                        _command.Parameters.AddWithValue(param.Key.ToString(), param.Value);
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(_command);

                adapter.Fill(table);
            }
            catch (Exception ex) when (ex is SqlException)
            {
                throw;
            }
            finally
            {
                if (_connection?.State != ConnectionState.Closed) _connection.Close();
            }

            return table;
        }

        public static bool ExecuteNonQuery(string query, Hashtable queryParams, bool isStoredProcedure = false)
        {
            try
            {
                _connection.Open();

                _transaction = _connection.BeginTransaction();
                _command = new SqlCommand(query, _connection);
                _command.CommandType = isStoredProcedure ? CommandType.StoredProcedure : CommandType.Text;
                if (queryParams != null)
                {
                    foreach (DictionaryEntry param in queryParams)
                    {
                        _command.Parameters.AddWithValue(param.Key.ToString(), param.Value);
                    }
                }
                _command.ExecuteNonQuery();
                _transaction.Commit();
                return true;

            }
            catch (Exception ex)
            {
                _transaction.Rollback();

                if (ex is SqlException sqlEx)
                {
                    switch (sqlEx.Number)
                    {
                        case 547:
                            throw new Exception("No se puede eliminar el registro porque tiene registros relacionados.");
                        case 2627:
                        case 2601:
                            throw new Exception("Ya existe un registro con los datos proporcionados. Restricción UNIQUE.");
                        default:
                            throw;
                    }
                }
                throw;
            }
            finally
            {
                if (_connection?.State != ConnectionState.Closed) _connection.Close();
            }
        }

        public static int ExecuteScalar(string query, Hashtable queryParams, bool isStoredProcedure = false)
        {
            try
            {
                _connection.Open();
                _transaction = _connection.BeginTransaction();
                _command = new SqlCommand(query, _connection);
                _command.CommandType = isStoredProcedure ? CommandType.StoredProcedure : CommandType.Text;
                if (queryParams != null)
                {
                    foreach (DictionaryEntry param in queryParams)
                    {
                        _command.Parameters.AddWithValue(param.Key.ToString(), param.Value);
                    }
                }
                int result = Convert.ToInt32(_command.ExecuteScalar());
                _transaction.Commit();
                return result;
            }
            catch (Exception ex)
            {
                _transaction.Rollback();
                if (ex is SqlException sqlEx)
                {
                    switch (sqlEx.Number)
                    {
                        case 547:
                            throw new Exception("No se puede eliminar el registro porque tiene registros relacionados.");
                        case 2627:
                        case 2601:
                            throw new Exception("Ya existe un registro con los datos proporcionados. Restricción UNIQUE.");
                        default:
                            throw;
                    }
                }
                throw;
            }
            finally
            {
                if (_connection?.State != ConnectionState.Closed) _connection.Close();
            }
        }
    }
}