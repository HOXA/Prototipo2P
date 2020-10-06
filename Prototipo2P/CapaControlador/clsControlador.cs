using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo;
namespace CapaControlador
{
    public class clsControlador
    {

        clsSentencias sen = new clsSentencias();
        public void ing_datAlum(string carnet, string nom, string dir, string tel, string email) {
            
            
            sen.ingreso(carnet, nom, dir, tel, email);


        }

    }
}
