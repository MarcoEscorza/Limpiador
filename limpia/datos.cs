using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace limpia
{
    class datos
    {

        public void detener()
        {

            ServiceController servicioWindows = new ServiceController("Spooler");
            try
            {

                if (servicioWindows != null &&
                    servicioWindows.Status == ServiceControllerStatus.Running)
                {

                    servicioWindows.Stop();
                }

                servicioWindows.WaitForStatus(ServiceControllerStatus.Stopped);
                servicioWindows.Close();
                MessageBox.Show("Servicio detenido correctamente");


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al detener el servicio: " + ex.Message);
            }


        }


        public void stop()
        {



        }



        public void limpiar()
        {

            string ruta = @"C:\WINDOWS\system32\spool\PRINTERS";

            //string ruta = @"C:\test";

            List<string> strFiles = Directory
                .GetFiles(ruta, "*", SearchOption.AllDirectories)
                .ToList();

            try
            {

                //File.Delete(ruta);

                foreach (string fichero in strFiles)
                {

                    File.Delete(fichero);

                    /*  if (File.Exists(fichero))
                      {

                          //Console.WriteLine("El archivo sigue existiendo");
                          MessageBox.Show("Los archivos siguen existiendo");
                      }
                      else
                      {

                          //Console.WriteLine("El archivo YA NO EXISTE");
                          MessageBox.Show("Los archivos ya no existen");
                      }
                      */
                }

                MessageBox.Show("Archivos eliminados");




            }
            catch (Exception e)
            {

                MessageBox.Show("Error al borrar el archivo {0}", e.ToString());
            }


        }


        public void iniciar()
        {
            ServiceController servicioWindows = new ServiceController("Spooler");
            try
            {

                if (servicioWindows != null &&
                    servicioWindows.Status != ServiceControllerStatus.Running)
                {

                    servicioWindows.Start();
                }

                servicioWindows.WaitForStatus(ServiceControllerStatus.Running);
                servicioWindows.Close();
                MessageBox.Show("Servicio iniciado correctamente");


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al iniciar el servicio: " + ex.Message);
            }



        }
    }
}
