using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace Entidades
{

  

    public abstract class Producto
    {
        private string descripcion;


        //Delegate ProductoTerminado = new Delegate();
        //falta crear el delegado


        //event void ProductoTerminado(Object sender, EventArgs e);


        public string Descripcion
        {
            get { return this.descripcion; }

        }


        public void Elaborar() {
        
            String connectionStr = "Data Source=[Instancia Del Servidor];Initial Catalog=[Nombre de la Base de Datos];Integrated Security=True";

            SqlConnection conexion;
            conexion = new SqlConnection(connectionStr);
            SqlCommand comando;

            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;

            //abre la conexio  y dispara el insert

            comando.Connection = conexion;
            //string consulta = "INSERT INTO Productos (descripcion)  VALUES("++")";
            //comando.CommandText = consulta;

            conexion.Open();

            comando.ExecuteNonQuery();


        }

        public string Mostrar() {


            return "";
        }


        public Producto() {
        }

        public Producto(string descripcion) {

            this.descripcion = descripcion;

        }
            


    }
}
