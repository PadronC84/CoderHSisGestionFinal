﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionEntities;
using Microsoft.VisualBasic;
using System.Security.Cryptography.X509Certificates;

namespace SistemaGestionData
{
    public class UsuarioData
    {
        public static object MessageBox { get; private set; }

        public static List<Usuario> DevolverUsuarios()
        {
            var listaUsuarios = new List<Usuario>();
            string connectionString = @"Server=localhost;Database=SistemaGestion;Trusted_Connection=True;";
            var query = "SELECT Id,Nombre,Apellido,NombreUsuario,Contraseña,Mail FROM usuario";
            using (SqlConnection conect = new SqlConnection(connectionString))
            {


                using (SqlCommand comando = new SqlCommand(query, conect))
                {
                    conect.Open();
                    using (SqlDataReader dr = comando.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                var usuario = new Usuario();
                                usuario.Id = Convert.ToInt32(dr["Id"]);
                                usuario.Nombre = dr["Nombre"].ToString();
                                usuario.Apellido = dr["Apellido"].ToString();
                                usuario.NombreUsuario = dr["NombreUsuario"].ToString();
                                usuario.Mail = dr["Mail"].ToString();
                                usuario.Contraseña = dr["Contraseña"].ToString();

                                //Agrego a la lista
                                listaUsuarios.Add(usuario);
                            }
                        }
                    }
                }
            }
            return listaUsuarios;
        }  
        public static void CrearUsuario(Usuario usuario)
        {
            string connectionString = @"Server=localhost;DataBase=SistemaGestion;
                                        Trusted_Connection=True";
            string query = "INSERT INTO Usuario (Nombre,Apellido,NombreUsuario,Contraseña,Mail)" +
                " VALUES(@Nombre, @Apellido, @NombreUsuario, @Contraseña, @Mail); ";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        //comando.Parameters.Add(new SqlParameter("Id", SqlDbType.BigInt) { Value = null });
                        comando.Parameters.Add(new SqlParameter("Nombre", SqlDbType.VarChar) { Value = usuario.Nombre });
                        comando.Parameters.Add(new SqlParameter("Apellido", SqlDbType.VarChar) { Value = usuario.Apellido });
                        comando.Parameters.Add(new SqlParameter("NombreUsuario", SqlDbType.VarChar) { Value = usuario.NombreUsuario });
                        comando.Parameters.Add(new SqlParameter("Contraseña", SqlDbType.VarChar) { Value = usuario.Contraseña });
                        comando.Parameters.Add(new SqlParameter("Mail", SqlDbType.VarChar) { Value = usuario.Mail });
                        comando.ExecuteNonQuery();
                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {

                throw;
            }


        }

        public static void ModificarUsuario(Usuario usuario)
        {
            string connectionString = @"Server=localhost;DataBase=SistemaGestion;
                                        Trusted_Connection=True";
            string query = "UPDATE Usuario " +
                "SET Nombre = @Nombre, Apellido = @Apellido,NombreUsuario = @NombreUsuario, Contraseña=@Contraseña, Mail=@Mail " +
                " WHERE Id = @Id";
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.VarChar) { Value = usuario.Id });
                        comando.Parameters.Add(new SqlParameter("Nombre", SqlDbType.VarChar) { Value = usuario.Nombre });
                        comando.Parameters.Add(new SqlParameter("Apellido", SqlDbType.VarChar) { Value = usuario.Apellido });
                        comando.Parameters.Add(new SqlParameter("NombreUsuario", SqlDbType.VarChar) { Value = usuario.NombreUsuario });
                        comando.Parameters.Add(new SqlParameter("Contraseña", SqlDbType.VarChar) { Value = usuario.Contraseña });
                        comando.Parameters.Add(new SqlParameter("Mail", SqlDbType.VarChar) { Value = usuario.Mail });

                        comando.ExecuteNonQuery();
                    }
                    conexion.Close();
                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static void EliminarUsuario(int Id)
        {
            string connectionString = @"Server=localhost;DataBase=SistemaGestion;
                                        Trusted_Connection=True";
            string query = "DELETE FROM Usuario " +
                " WHERE Id = @Id";
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.VarChar) { Value = Id });

                        comando.ExecuteNonQuery();
                    }
                    conexion.Close();
                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }
     
        
        public static bool Login(string NombreUsuario, string Contraseña){
            bool logueado = false;
            string connection = @"Server=localhost;DataBase=SistemaGestion;
                                          Trusted_Connection=True";
            SqlConnection con = new SqlConnection(connection);
            con.Open();

            using (SqlCommand StrQuer = new SqlCommand("SELECT * FROM Usuario WHERE Contraseña=@Contraseña AND NombreUsuario=@NombreUsuario", con))
            {
                StrQuer.Parameters.AddWithValue("@Contraseña", Contraseña);
                StrQuer.Parameters.AddWithValue("@NombreUsuario", NombreUsuario);
                SqlDataReader dr = StrQuer.ExecuteReader();
                if
                (dr.HasRows)
                {
                    return logueado=true;
                    
                }
                return logueado;
               
            }
        }

    }
}

 
