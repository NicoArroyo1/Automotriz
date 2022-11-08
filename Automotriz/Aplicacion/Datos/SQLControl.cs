﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aplicacion.Datos
{
    public class SQLControl
    {
        private string conexionString;
        private SqlConnection cnn;
        private SqlCommand cmd;
        private DataTable table;

        public SQLControl()
        {
            conexionString = @"Data Source=PC-NICO\SQLEXPRESS;Initial Catalog=AutomotrizTP;Integrated Security=True";
            cnn = new SqlConnection(conexionString);
        }
        public DataTable ConsultarSQL(string query)
        {
            cnn.Open();
            cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = cnn;
            table = new DataTable();
            table.Load(cmd.ExecuteReader());
            cnn.Close();
            return table;
        }

        public DataTable ConsultarSP(string sp)
        {
            DataTable dt = new DataTable();

            cnn.Open();
            SqlCommand cmd = new SqlCommand(sp, cnn);
            dt.Load(cmd.ExecuteReader());
            cnn.Close();

            return dt;
        }

        /*   CAMBIAR PARA DOMINIO
         *   
        public bool InsertarMD(Factura oFactura)
        {
            bool aux = false;
            SqlTransaction t = null;
            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();

                //configuro cmd para insertar Maestro
                SqlCommand cmdMaestro = new SqlCommand("SP_INSERTAR_EQUIPO", cnn, t);
                cmdMaestro.CommandType = CommandType.StoredProcedure;

                //parametros de entrada
                cmdMaestro.Parameters.AddWithValue("@pais", oEquipo.Pais);
                cmdMaestro.Parameters.AddWithValue("@director_tecnico", oEquipo.DirectorTecnico);

                //configuro param de salida para recibir el id del maestro
                SqlParameter paramSalida = new SqlParameter();
                paramSalida.ParameterName = "@id";
                paramSalida.DbType = DbType.Int32;
                paramSalida.Direction = ParameterDirection.Output;

                cmdMaestro.Parameters.Add(paramSalida);

                //ejecuto cmdMaestro y guardo el identity
                cmdMaestro.ExecuteNonQuery();
                int idMaestro = (int)paramSalida.Value;

                //para ingresar cada detalle del maestro
                SqlCommand cmdDetalle = null;
                foreach (Jugador det in oEquipo.Jugadores)
                {
                    //configuro cmd para insertar el detalle
                    cmdDetalle = new SqlCommand("SP_INSERTAR_DETALLES_EQUIPO", cnn, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;

                    //parametros de entrada
                    cmdDetalle.Parameters.AddWithValue("@id_equipo", idMaestro);
                    cmdDetalle.Parameters.AddWithValue("@id_persona", det.Persona.IdPersona);
                    cmdDetalle.Parameters.AddWithValue("@camiseta", det.Camiseta);
                    cmdDetalle.Parameters.AddWithValue("@posicion", det.Posicion);
                    cmdDetalle.ExecuteNonQuery();
                }

                t.Commit();
                aux = true;
            }
            catch (Exception e)
            {
                if (t != null)//si "t" no es null es porq hubo en error
                {
                    t.Rollback();
                }
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)//si la conex existe y esta abierta
                {
                    cnn.Close();
                }
            }

            return aux;
        }

        */


        public int Login(string usario, string pass)
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("spLogin", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@usuario", usario);
                cmd.Parameters.AddWithValue("@pass", pass);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    return dr.GetInt32(0);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                cnn.Close();
            }
            return -1;
        }
    }
}