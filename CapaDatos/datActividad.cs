﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class datActividad: Conexion
    {
        public List<entActividad> LeerActividad()
        {
            List<entActividad> actividades = new List<entActividad>();

            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();

                string query = "GetActividades"; // Reemplaza con el nombre real del procedimiento almacenado de LeerActividad

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {

                    cmd.CommandType = CommandType.StoredProcedure;


                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            entActividad actividad = new entActividad
                            {
                                idActividad = Convert.ToInt32(reader["idActividad"]),
                                NombreActividad = reader["NombreActividad"].ToString(),
                                Descripcion = reader["Descripcion"].ToString(),
                            };
                            actividades.Add(actividad);
                        }
                    }
                    conexion.Close();
                }
            }
            return actividades;
        }

        public void CrearActividad(entActividad actividad)
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();

                string query = "InsertActividad"; // Reemplaza con el nombre real del procedimiento almacenado de CrearActividad

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@NombreActividad", actividad.NombreActividad);
                    cmd.Parameters.AddWithValue("@Descripcion", actividad.Descripcion);


                    cmd.ExecuteNonQuery();
                    conexion.Close();
                }
            }
        }

        public entActividad LeerActividadPorID(int idActividad)
        {
            entActividad actividad = null;
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();

                string query = "GetActividadPorID"; // Reemplaza con el nombre real del procedimiento almacenado de LeerActividadPorID
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idActividad", idActividad);


                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            actividad = new entActividad
                            {
                                idActividad = Convert.ToInt32(reader["idActividad"]),
                                NombreActividad = reader["NombreActividad"].ToString(),
                                Descripcion = reader["Descripcion"].ToString(),
                            };
                        }
                    }
                    conexion.Close();
                }
            }
            return actividad;
        }

        public void ActualizarActividad(entActividad Actividad)
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();

                string query = "UpdateActividad"; // Reemplaza con el nombre real del procedimiento almacenado de ActualizarActividad
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idActividad", Actividad.idActividad);
                    cmd.Parameters.AddWithValue("@NombreActividad", Actividad.NombreActividad);
                    cmd.Parameters.AddWithValue("@Descripcion", Actividad.Descripcion);

                    cmd.ExecuteNonQuery();
                    conexion.Close();
                }
            }
        }

        public void EliminarActividad(int idActividad)
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();

                string query = "DeleteActividad"; // Reemplaza con el nombre real del procedimiento almacenado de EliminarActividad
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idActividad", idActividad);


                    cmd.ExecuteNonQuery();
                    conexion.Close();
                }
            }
        }
    }
}
