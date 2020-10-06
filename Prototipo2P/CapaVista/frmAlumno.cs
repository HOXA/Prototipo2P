using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;

namespace CapaVista
{
    public partial class frmAlumno : Form
    {

        clsControlador cn = new clsControlador();
        
        public frmAlumno()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            cn.ing_datAlum(txtCarnet.Text, txtNombre.Text, txtDir.Text, txtTel.Text, txtEmail.Text);

        }
    }
}
