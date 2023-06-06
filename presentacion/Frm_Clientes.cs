using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class Frm_Clientes : Form
    {
        public Frm_Clientes()
        {
            InitializeComponent();
        }
        #region "Variables"
        int nCodigo_cl =0;
        int nEstadoguarda =0;
        #endregion
        #region "Mis Metodos"
        private void limpia_texto()
        {
            Txt_Nombre_cl.Text = "";
            Txt_Ndocumento_cl.Text = "";
            Txt_Direccion_cl.Text = "";
            Txt_Telefono_cl.Text = "";
            cmbrol_us.Text = "";
        }
        private void estado_texto(bool lEstado)
        {
            Txt_Nombre_cl.Enabled = lEstado;
            Txt_Ndocumento_cl.Enabled = lEstado;
            Txt_Direccion_cl.Enabled = lEstado;
            Txt_Telefono_cl.Enabled = lEstado;
            cmbrol_us.Enabled = lEstado;

            Txt_Buscar.Enabled = !lEstado;
            dgvlistado.Enabled = !lEstado;
            Btn_Buscar.Enabled = !lEstado;
        }
        private void Estado_botones_procesos(bool lEstado)
        {
            Btn_cancelar.Visible = lEstado;
            Btn_guardar.Visible = lEstado;
        }
        private void Estado_botones_principales(bool lEstado)
        {
            Btn_Nuevo.Enabled = lEstado;
            Btn_Actualizar.Enabled = lEstado;
            Btn_Estado.Enabled = lEstado;
            Btn_Retornar.Enabled = lEstado;
        }
        private void formato()
        {
            dgvlistado.Columns[0].Width = 100;
            dgvlistado.Columns[0].HeaderText = "Codigo_Cl";
            dgvlistado.Columns[1].Width = 180;
            dgvlistado.Columns[1].HeaderText = "Nombre Cliente";
            dgvlistado.Columns[2].Width = 180;
            dgvlistado.Columns[2].HeaderText = "Numero Documento";
            dgvlistado.Columns[3].Visible = false;
            dgvlistado.Columns[4].Visible = false;
            dgvlistado.Columns[5].Width = 100;
            dgvlistado.Columns[5].HeaderText = "Codigo_Us";
            dgvlistado.Columns[6].Width = 100;
            dgvlistado.Columns[6].HeaderText = "Activo";
        }
        private void Listado_cl(string cTexto)
        {
            D_Clientes Datos = new D_Clientes();
            dgvlistado.DataSource = Datos.Listado_cl(cTexto);
            this.formato();
        }
        private void Listado_us()
        {
            try
            {
                D_Clientes Datos = new D_Clientes();
                cmbrol_us.DataSource = Datos.Listado_us();
                cmbrol_us.ValueMember = "codigo_us";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Seleccionaitem()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dgvlistado.CurrentRow.Cells["codigo_cl"].Value)))
            {
                MessageBox.Show("Seleccione un registro valido","Aviso de sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                nCodigo_cl=Convert.ToInt32(dgvlistado.CurrentRow.Cells["codigo_cl"].Value);
                Txt_Nombre_cl.Text = dgvlistado.CurrentRow.Cells["nombre_cl"].Value.ToString();
                Txt_Ndocumento_cl.Text = dgvlistado.CurrentRow.Cells["documento_cl"].Value.ToString();
                Txt_Direccion_cl.Text = dgvlistado.CurrentRow.Cells["direccion_cl"].Value.ToString();
                Txt_Telefono_cl.Text = dgvlistado.CurrentRow.Cells["telefono_cl"].Value.ToString();
                cmbrol_us.Text = dgvlistado.CurrentRow.Cells["codigo_us"].Value.ToString();
            }
        }
        #endregion

        private void Btn_Retornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            nEstadoguarda = 1; //Nuevo Registro
            this.limpia_texto();
            this.estado_texto(true);
            this.Estado_botones_procesos(true);
            this.Estado_botones_principales(false);
            this.Txt_Nombre_cl.Focus();
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            nEstadoguarda = 0;
            this.limpia_texto();
            this.estado_texto(false);
            this.Estado_botones_procesos(false);
            this.Estado_botones_principales(true);
        }

        private void Frm_Clientes_Load(object sender, EventArgs e)
        {
            this.Listado_us();
            this.Listado_cl("%");
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            this.Listado_cl(Txt_Buscar.Text);
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (Txt_Nombre_cl.Text==string.Empty|| Txt_Ndocumento_cl.Text==string.Empty|| Txt_Direccion_cl.Text==string.Empty|| Txt_Telefono_cl.Text==string.Empty || cmbrol_us.Text == string.Empty)
            {
                MessageBox.Show("Ingrese dato requerido ( * )", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else //procedemos a guardar la informacion
            {
                string Rpta;
                E_Clientes oCl = new E_Clientes();
                oCl.Codigo_cl = nCodigo_cl;
                oCl.Nombre_cl = Txt_Nombre_cl.Text;
                oCl.Documento_cl = Txt_Ndocumento_cl.Text;
                oCl.Direccion_cl = Txt_Direccion_cl.Text;
                oCl.Telefono_cl = Txt_Telefono_cl.Text;
                oCl.Codigo_us = Convert.ToInt32(cmbrol_us.SelectedValue);
                D_Clientes Datos = new D_Clientes();
                Rpta = Datos.Guardar_cl(nEstadoguarda, oCl);
                bool esNumero = int.TryParse(Rpta, out int xCodigo);
                if (esNumero == true)
                {
                    nEstadoguarda = 0;
                    nCodigo_cl = 0;
                    this.limpia_texto();
                    this.estado_texto(false);
                    this.Estado_botones_procesos(false);
                    this.Estado_botones_principales(true);
                    this.Listado_cl("%");
                    MessageBox.Show("Los datos han sido guardados correctamente en el codigo #" + Rpta.Trim(), "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            nEstadoguarda = 2; //Actualizar Registro
            this.estado_texto(true);
            this.Estado_botones_procesos(true);
            this.Estado_botones_principales(false);
            this.Txt_Nombre_cl.Focus();
        }

        private void dgvlistado_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.Seleccionaitem();
        }

        private void Btn_Estado_Click(object sender, EventArgs e)
        {
            if (dgvlistado.Rows.Count>0)
            {
                string Rpta = "";
                D_Clientes Datos = new D_Clientes();
                Rpta = Datos.Activo_cl(Convert.ToInt32(dgvlistado.CurrentRow.Cells["codigo_cl"].Value));
                if (Rpta.Equals ("OK"))
                {
                    this.Listado_cl("%");
                    MessageBox.Show("Proceso de estado actualizado", "Aviso del sistema", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show(Rpta, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
