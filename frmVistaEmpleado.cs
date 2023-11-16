using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryTP_Marconi_Laboratorio
{
    public partial class frmVistaEmpleado : Form
    {
        public frmVistaEmpleado()
        {
            InitializeComponent();
        }

        private void cmbEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();

            string codigoSeleccionado = cmbEmpleado.SelectedItem.ToString();

            clsEmpleados Empleados = new clsEmpleados();
            Empleados.LlenarTreeViewConTablas(codigoSeleccionado, treeView1);
        }

        private void frmVistaEmpleado_Load(object sender, EventArgs e)
        {
            clsEmpleados Empleado = new clsEmpleados();
            Empleado.LlenarDatos(cmbEmpleado);
        }
    }
}
