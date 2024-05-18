using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Implementacion_DSI_Grupo10
{
    public partial class Registro : Form
    {
        ReservaVisita reg = new ReservaVisita();
        public Registro()
        {
            InitializeComponent();
        }

        private void dg_registros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Cargar_Grilla_Registro();
        }

        public void Cargar_Grilla_Reservas(DataTable tabla)
        {
            dg_registros.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                dg_registros.Rows.Add();
                dg_registros.Rows[i].Cells[0].Value = tabla.Rows[i]["id_escuela"].ToString();
                dg_registros.Rows[i].Cells[1].Value = tabla.Rows[i]["id_Exposicion"].ToString();
                dg_registros.Rows[i].Cells[2].Value = tabla.Rows[i]["numeroReserva"].ToString();
                dg_registros.Rows[i].Cells[3].Value = tabla.Rows[i]["fechaHoraReserva"].ToString();
                dg_registros.Rows[i].Cells[4].Value = tabla.Rows[i]["id_cambioEstado"].ToString();
                dg_registros.Rows[i].Cells[5].Value = tabla.Rows[i]["cantidadAlumnosConfirmado"].ToString();
                //dg_exposiciones.Rows[i].Cells[6].Value = tabla.Rows[i]["id_cargo"].ToString();
                //dg_exposiciones.Rows[i].Cells[7].Value = tabla.Rows[i]["id_Sede"].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cargar_Grilla_Reservas(reg.ConocerRegistro());
        }
    }
}
