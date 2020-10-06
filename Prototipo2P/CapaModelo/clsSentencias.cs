using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaModelo
{
    public class clsSentencias
    {
        clsConexion con = new clsConexion();

        public void ingreso(string carnet, string nom, string dir, string tel, string email ) {

            try
            {


                string insAlumno = "INSERT INTO alumnos (carnet_alumno, nombre_alumno, direccion_alumno, telefono_alumno, email_alumno, estatus_alumno ) VALUES('"+ carnet + "','" + nom + "','" + dir + "','" + tel + "', '" + email + "', '"+1+"')";
                OdbcCommand Query_Validacion3 = new OdbcCommand(insAlumno, con.conexion());
               
                Query_Validacion3.ExecuteNonQuery();



                Console.WriteLine("Ingreso Exitoso");

            }
            catch (Exception ex)
            {

                Console.WriteLine("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error");

            }

        }

        public string ss(string carnet) {

            try
            {
                
                string busqAlumn = "SELECT * FROM alumno where alumno.carnet_alumno= '"+ carnet + "'";

                OdbcCommand Query_Busqueda1 = new OdbcCommand(busqAlumn, con.conexion());
                OdbcDataReader Lector1 = Query_Busqueda1.ExecuteReader();

                if (Lector1.HasRows == true)
                {

                    while (Lector1.Read())
                    {
                        string[] weekDays = new string[] { "SELECT carnet_alumno FROM alumnos where alumnos.carnet_alumno= '"+ carnet + "'",
                                                            "SELECT carnet_alumno FROM alumnos"};
                        return "a";

                    }

                }
                else
                {
                    Console.WriteLine("");

                }



                return "a";
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error");
                return "a";

            }

        }
            
    }
}
