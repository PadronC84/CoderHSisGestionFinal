﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionEntities;

namespace SistemaGestionData
{
    public class ProductoData
    {
        ///               Metodos para productos 
        public static void CrearProducto(Producto producto)
        {
            string connectionString = @"Server=localhost;DataBase=SistemaGestion;
                                        Trusted_Connection=True";
            string query = "INSERT INTO Producto (Descripciones,Costo, PrecioVenta,Stock,IdUsuario)" +
                " VALUES(@Descripcion, @Costo, @PrecioVenta, @Stock, @IdUsuario); ";

            try
            {
                using SqlConnection conexion = new SqlConnection(connectionString);
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = producto.Descripciones });
                    comando.Parameters.Add(new SqlParameter("Costo", SqlDbType.Decimal) { Value = producto.Costo });
                    comando.Parameters.Add(new SqlParameter("PrecioVenta", SqlDbType.Decimal) { Value = producto.PrecioVenta });
                    comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.Decimal) { Value = producto.Stock });
                    comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.Int) { Value = producto.IdUsuario });

                    comando.ExecuteNonQuery();
                }
                conexion.Close();
            }
            catch (Exception ex)
            {

                throw;
            }


        }

        public static void ModificarProducto(Producto producto)
        {
            string connectionString = @"Server=localhost;DataBase=SistemaGestion;
                                        Trusted_Connection=True";
            string query = "UPDATE Producto " +
                "SET Descripciones = @Descripcion ,Costo = @Costo, PrecioVenta = @PrecioVenta,Stock = @Stock, IdUsuario=@IdUsuario " +
                " WHERE Id = @Id";
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.VarChar) { Value = producto.Id });

                        comando.Parameters.Add(new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = producto.Descripciones });
                        comando.Parameters.Add(new SqlParameter("Costo", SqlDbType.Decimal) { Value = producto.Costo });
                        comando.Parameters.Add(new SqlParameter("PrecioVenta", SqlDbType.Decimal) { Value = producto.PrecioVenta });
                        comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.Decimal) { Value = producto.Stock });
                        comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.BigInt) { Value = producto.IdUsuario });

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

        public static void EliminarProducto(int Id)
        {
            string connectionString = @"Server=localhost;DataBase=SistemaGestion;
                                        Trusted_Connection=True";
            string query = "DELETE FROM Producto " +
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

        public static List<Producto> ListarProductos()
        {
            List<Producto> lista = new List<Producto>();

            string connectionString = @"Server=localhost;DataBase=SistemaGestion;
                                        Trusted_Connection=True";
            string query = "SELECT Id,Descripciones,Costo,PrecioVenta,Stock,IdUsuario FROM Producto";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader dr = comando.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    var producto = new Producto();
                                    producto.Id = Convert.ToInt32(dr["Id"]);
                                    producto.Descripciones = dr["Descripciones"].ToString();
                                    producto.Costo = Convert.ToDecimal(dr["Costo"]);
                                    producto.PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"]);
                                    producto.Stock = Convert.ToInt32(dr["Stock"]);
                                    producto.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);

                                    lista.Add(producto);
                                }
                            }
                        }
                    }

                    // Opcional
                    conexion.Close();
                }
                return lista;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

       
    }
}