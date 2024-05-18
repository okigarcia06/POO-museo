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

    public partial class Form1 : Form

    {
        Exposicion expo = new Exposicion();
        Empleado empleado = new Empleado();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void guiaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


        private void btn_buscarExpo_Click(object sender, EventArgs e)
        {
            Cargar_Grilla_Expo(expo.ConocerExpo());
        }




        private void btn_registrar_Click(object sender, EventArgs e)
        {
            Form Registro = new Registro();
            Registro.Show();

        }

        private void cmb_escuela_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_escuela.Text == "")
            {
                MessageBox.Show("Debe seleccionar una escuela para registrar la visita");
            }

        }

        private void num_visitantes_ValueChanged(object sender, EventArgs e)
        {
            if (num_visitantes.Value == 0)
            {
                MessageBox.Show("Debe asignar una cantidad de visitantes");
                return;

            }
        }

        private void btn_validarVisitante_Click(object sender, EventArgs e)
        {
            if (num_visitantes.Value >= 100)
                MessageBox.Show("Supera al maximo de visitante");
            else
                MessageBox.Show("Se encuentra en los parametros");
        }

        private void cmb_expo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_expo.Text == "")
            {
                MessageBox.Show("Debe seleccionar una exposicion para registrarse a la visita");
            }
        }

        private void cmb_tipoVisita_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_tipoVisita.Text == "")
            {
                MessageBox.Show("Debe seleccionar un tipo de Visita para registrarse");
            }
        }

        private void dg_cantidadVisitantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<int> lista = new List<int>();
            
        }

        private void btn_buscarGuias_Click(object sender, EventArgs e)
        {
            Cargar_Grilla_Empl(empleado.ConocerEmpleado());

        }

        private void dg_exposiciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btn_buscarExpo_MouseClick(object sender, MouseEventArgs e)
        {
            Cargar_Grilla_Expo(expo.ConocerExpo());

        }
        
 
 
        public void Cargar_Grilla_Expo(DataTable tabla)
        {
            dg_exposiciones.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                dg_exposiciones.Rows.Add();
                dg_exposiciones.Rows[i].Cells[0].Value = tabla.Rows[i]["id_Exposicion"].ToString();
                dg_exposiciones.Rows[i].Cells[1].Value = tabla.Rows[i]["nombre"].ToString();
                dg_exposiciones.Rows[i].Cells[2].Value = tabla.Rows[i]["fechaFin"].ToString();
                dg_exposiciones.Rows[i].Cells[3].Value = tabla.Rows[i]["fechaInicio"].ToString();
                dg_exposiciones.Rows[i].Cells[4].Value = tabla.Rows[i]["horaApertura"].ToString();
                dg_exposiciones.Rows[i].Cells[5].Value = tabla.Rows[i]["horaCierre"].ToString();
                //dg_exposiciones.Rows[i].Cells[6].Value = tabla.Rows[i]["id_cargo"].ToString();
                //dg_exposiciones.Rows[i].Cells[7].Value = tabla.Rows[i]["id_Sede"].ToString();
            }
        }

        public void Cargar_Grilla_Empl(DataTable tabla)
        {
            dg_guiasDisponibles.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                dg_guiasDisponibles.Rows.Add();
                dg_guiasDisponibles.Rows[i].Cells[0].Value = tabla.Rows[i]["id_empleado"].ToString();
                dg_guiasDisponibles.Rows[i].Cells[1].Value = tabla.Rows[i]["apellido"].ToString();
                dg_guiasDisponibles.Rows[i].Cells[2].Value = tabla.Rows[i]["nombre"].ToString();
                dg_guiasDisponibles.Rows[i].Cells[3].Value = tabla.Rows[i]["cuit"].ToString();
                dg_guiasDisponibles.Rows[i].Cells[4].Value = tabla.Rows[i]["dni"].ToString();
                dg_guiasDisponibles.Rows[i].Cells[5].Value = tabla.Rows[i]["domicilo"].ToString();
                dg_guiasDisponibles.Rows[i].Cells[6].Value = tabla.Rows[i]["telefono"].ToString();
                dg_guiasDisponibles.Rows[i].Cells[7].Value = tabla.Rows[i]["id_cargo"].ToString();
                dg_guiasDisponibles.Rows[i].Cells[8].Value = tabla.Rows[i]["id_Sede"].ToString();
            }
        }

        private void list_guias_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    BaseDatos empleado = new BaseDatos();

        //    empleado.insertar_reserva(this.cmbTipoDoc.SelectedValue.ToString(), this.txtNroDoc.Text, this.txtNombre.Text, this.txtApellido.Text
        //                    , this.txtCalle.Text, this.txtNroCalle.Text, this.cmbBarrio.SelectedValue.ToString()
        //                    , this.txtEmail.Text, this.mskTelefono.Text);
       // }
    }
}


