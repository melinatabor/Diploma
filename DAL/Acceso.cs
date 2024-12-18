﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Acceso
    {
        private static SqlConnection _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DistribuidoraDelHaras"].ConnectionString);
        private static SqlCommand _command;
        private static SqlTransaction _transaction;

        public static bool Backup(string rutaBackup)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DistribuidoraDelHaras"].ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand backupCmd = new SqlCommand("BACKUP DATABASE [DistribuidoraDelHaras] TO DISK = @RutaBackup WITH FORMAT, INIT, NAME = 'Backup de Distribuidora del Haras';", connection))
                    {
                        backupCmd.Parameters.AddWithValue("@RutaBackup", rutaBackup);
                        backupCmd.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al realizar backup de la base de datos: {ex.Message}", ex);
            }
            finally
            {
                if (_connection.State != ConnectionState.Closed) _connection.Close();
            }
        }

        public static bool Restore(string backupPath)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DistribuidoraDelHaras"].ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand singleUserCmd = new SqlCommand("USE master; ALTER DATABASE [DistribuidoraDelHaras] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;", connection))
                    {
                        singleUserCmd.ExecuteNonQuery();
                    }

                    using (SqlCommand restoreCmd = new SqlCommand("USE master; RESTORE DATABASE [DistribuidoraDelHaras] FROM DISK = @RutaBackup WITH REPLACE;", connection))
                    {
                        restoreCmd.Parameters.AddWithValue("@RutaBackup", backupPath);
                        restoreCmd.ExecuteNonQuery();
                    }

                    using (SqlCommand multiUserCmd = new SqlCommand("USE master; ALTER DATABASE [DistribuidoraDelHaras] SET MULTI_USER;", connection))
                    {
                        multiUserCmd.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al restaurar la base de datos: {ex.Message}", ex);
            }
            finally
            {
                if (_connection.State != ConnectionState.Closed) _connection.Close();
            }
        }

        public static DataTable ExecuteDataTable(string query, Hashtable parametros, bool isStoredProcedure = false)
        {
            DataTable table = new DataTable();

            try
            {
                _command = new SqlCommand(query, _connection);

                if (isStoredProcedure)
                    _command.CommandType = CommandType.StoredProcedure;

                if (parametros != null)
                {
                    foreach (string param in parametros.Keys)
                    {
                        _command.Parameters.AddWithValue(param, parametros[param]);
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(_command);
                adapter.Fill(table);
            }

            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (_connection.State != ConnectionState.Closed) _connection.Close();
            }

            return table;
        }

        public static bool ExecuteNonQuery(string query, Hashtable parametros, bool isStoredProcedure = false)
        {
            try
            {
                _connection.Open();

                _transaction = _connection.BeginTransaction();

                _command = new SqlCommand(query, _connection);
                _command.CommandType = isStoredProcedure ? CommandType.StoredProcedure : CommandType.Text;
                _command.Transaction = _transaction;

                if (parametros != null)
                {
                    foreach (string param in parametros.Keys)
                    {
                        _command.Parameters.AddWithValue(param, parametros[param]);
                    }
                }

                _command.ExecuteNonQuery();

                _transaction.Commit();

                return true;
            }
            catch (SqlException ex)
            {
                _transaction.Rollback();

                /* Error 2627: Se produce al intentar insertar una clave duplicada en una columna 
                 * con índice único o restricción UNIQUE.
                 *   
                 * Error 2601: Ocurre cuando se intenta insertar un valor duplicado en un índice 
                 * que no sea la clave principal (primary key) pero que aún es único.
                 */
                if (ex.Number == 2627 || ex.Number == 2601)
                    throw new Exception("Violación de restricción UNIQUE: el valor ya existe.");
             
                throw ex;
            }
            catch (Exception ex)
            {
                _transaction.Rollback();
                throw ex;
            }
            finally
            {
                if (_connection.State != ConnectionState.Closed) _connection.Close();
            }
        }

        public static int ExecuteScalar(string query, Hashtable parametros, bool isStoredProcedure = false)
        {
            try
            {
                _connection.Open();
                _command = new SqlCommand(query, _connection);
                _command.CommandType = isStoredProcedure ? CommandType.StoredProcedure : CommandType.Text;

                if (parametros != null)
                {
                    foreach (string param in parametros.Keys)
                    {
                        _command.Parameters.AddWithValue(param, parametros[param]);
                    }
                }

                int result = Convert.ToInt32(_command.ExecuteScalar());
                return result;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (_connection.State != ConnectionState.Closed) _connection.Close();
            }
        }

      
    }
}
