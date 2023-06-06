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
    public partial class Frm_Proveedores : Form
    {
        public Frm_Proveedores()
        {
            InitializeComponent();
        }
        #region "Variables"
        int nCodigo_po = 0;
        int nEstadoguarda = 0;
        #endregion
        #region "Mis Metodos"
        private void limpia_texto()
        {
            Txt_Nombre_po.Text = "";
            Txt_Ndocumento_po.Text = "";
            Txt_Direccion_po.Text = "";
            Txt_Correo_po.Text = "";
            Txt_Telefono_po.Text = "";
            Txt_Banco_po.Text = "";
            Txt_Ncuenta_po.Text = "";
            Txt_Contacto_po.Text = "";
            cmbrol_us.Text = "";
        }
        private void estado_texto(bool lEstado)
        {
            Txt_Nombre_po.Enabled = lEstado;
            Txt_Ndocumento_po.Enabled = lEstado;
            Txt_Direccion_po.Enabled = lEstado;
            Txt_Correo_po.Enabled = lEstado;
            Txt_Telefono_po.Enabled = lEstado;
            Txt_Banco_po.Enabled = lEstado;
            Txt_Ncuenta_po.Enabled = lEstado;
            Txt_Contacto_po.Enabled = lEstado;
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
            Btn_Eliminar.Enabled = lEstado;
            Btn_Retornar.Enabled = lEstado;
        }
        private void formato()
        {
            dgvlistado.Columns[0].Width = 100;
            dgvlistado.Columns[0].HeaderText = "Codigo_Po";
            dgvlistado.Columns[1].Width = 180;
            dgvlistado.Columns[1].HeaderText = "Nombre";
            dgvlistado.Columns[2].Visible = false;
            dgvlistado.Columns[3].Visible = false;
            dgvlistado.Columns[4].Visible = false;
            dgvlistado.Columns[5].Visible = false;
            dgvlistado.Columns[6].Width = 180;
            dgvlistado.Columns[6].HeaderText = "Numero Conacto de proveedor";
            dgvlistado.Columns[7].Visible = false;
            dgvlistado.Columns[8].Visible = false;
            dgvlistado.Columns[9].Width = 100;
            dgvlistado.Columns[9].HeaderText = "Codigo_Us";
            dgvlistado.Columns[10].Width = 100;
            dgvlistado.Columns[10].HeaderText = "Activo";
        }
        private void Listado_us()
        {
            try
            {
                D_Proveedores Datos = new D_Proveedores();
                cmbrol_us.DataSource = Datos.Listado_us();
                cmbrol_us.ValueMember = "codigo_us";
                cmbrol_us.DisplayMember = "nombre_us";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Listado_po(string cTexto)
        {
            D_Proveedores Datos = new D_Proveedores();
            dgvlistado.DataSource = Datos.Listado_po(cTexto);
            this.formato();
        }

        private void Seleccionaitem()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dgvlistado.CurrentRow.Cells["codigo_po"].Value)))
            {
                MessageBox.Show("Seleccione un registro valido", "Aviso de sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                nCodigo_po = Convert.ToInt32(dgvlistado.CurrentRow.Cells["codigo_po"].Value);
                Txt_Nombre_po.Text = dgvlistado.CurrentRow.Cells["nombre_po"].Value.ToString();
                Txt_Ndocumento_po.Text = dgvlistado.CurrentRow.Cells["ndocumento_po"].Value.ToString();
                Txt_Direccion_po.Text = dgvlistado.CurrentRow.Cells["direccion_po"].Value.ToString();
                Txt_Telefono_po.Text = dgvlistado.CurrentRow.Cells["telefono_po"].Value.ToString();
                Txt_Correo_po.Text = dgvlistado.CurrentRow.Cells["correo_po"].Value.ToString();
                Txt_Ncuenta_po.Text = dgvlistado.CurrentRow.Cells["ncuenta_po"].Value.ToString();
                Txt_Banco_po.Text = dgvlistado.CurrentRow.Cells["banco_po"].Value.ToString();
                Txt_Ncuenta_po.Text = dgvlistado.CurrentRow.Cells["ncuenta_po"].Value.ToString();
                Txt_Contacto_po.Text = dgvlistado.CurrentRow.Cells["contacto_po"].Value.ToString();
                cmbrol_us.Text = dgvlistado.CurrentRow.Cells["nombre_us"].Value.ToString();
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
            this.Txt_Nombre_po.Focus();
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            nEstadoguarda = 0;
            this.limpia_texto();
            this.estado_texto(false);
            this.Estado_botones_procesos(false);
            this.Estado_botones_principales(true);
        }

        private void Frm_Proveedores_Load(object sender, EventArgs e)
        {
            this.Listado_us();
            this.Listado_po("%");
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            this.Listado_po(Txt_Buscar.Text);
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (Txt_Nombre_po.Text == string.Empty || Txt_Ndocumento_po.Text == string.Empty || Txt_Direccion_po.Text == string.Empty || Txt_Correo_po.Text == string.Empty ||
                Txt_Telefono_po.Text == string.Empty || Txt_Contacto_po.Text == string.Empty || Txt_Banco_po.Text == string.Empty || Txt_Ncuenta_po.Text == string.Empty || cmbrol_us.Text == string.Empty)
            {
                MessageBox.Show("Ingrese dato requerido ( * )", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else //procedemos a guardar la informacion
            {
                string Rpta;
                E_Proveedores oPo = new E_Proveedores();
                oPo.Codigo_po = nCodigo_po;
                oPo.Nombre_po = Txt_Nombre_po.Text;
                oPo.Ndocumento_po = Txt_Ndocumento_po.Text;
                oPo.Direccion_po = Txt_Direccion_po.Text;
                oPo.Telefono_po = Txt_Telefono_po.Text;
                oPo.Correo_po = Txt_Correo_po.Text;
                oPo.Contacto_po = Txt_Contacto_po.Text;
                oPo.Correo_po = Txt_Correo_po.Text;
                oPo.Banco_po = Txt_Banco_po.Text;
                oPo.Ncuenta_po = Txt_Ncuenta_po.Text;
                oPo.Codigo_us = Convert.ToInt32(cmbrol_us.SelectedValue);
                D_Proveedores Datos = new D_Proveedores();
                Rpta = Datos.Guardar_po(nEstadoguarda, oPo);
                bool esNumero = int.TryParse(Rpta, out int xCodigo);
                if (esNumero == true)
                {
                    nEstadoguarda = 0;
                    nCodigo_po = 0;
                    this.limpia_texto();
                    this.estado_texto(false);
                    this.Estado_botones_procesos(false);
                    this.Estado_botones_principales(true);
                    this.Listado_po("%");
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
            this.Txt_Nombre_po.Focus();
        }

        private void dgvlistado_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.Seleccionaitem();
        }

        private void Btn_Retornar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Nuevo_Click_1(object sender, EventArgs e)
        {
            nEstadoguarda = 1; //Nuevo Registro
            this.limpia_texto();
            this.estado_texto(true);
            this.Estado_botones_procesos(true);
            this.Estado_botones_principales(false);
            this.Txt_Nombre_po.Focus();
        }

        private void Btn_Actualizar_Click_1(object sender, EventArgs e)
        {
            nEstadoguarda = 2; //Actualizar Registro
            this.estado_texto(true);
            this.Estado_botones_procesos(true);
            this.Estado_botones_principales(false);
            this.Txt_Nombre_po.Focus();
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dgvlistado.Rows.Count > 0)
            {
                string Rpta = "";
                D_Proveedores Datos = new D_Proveedores();
                Rpta = Datos.Eliminar_po(Convert.ToInt32(dgvlistado.CurrentRow.Cells["codigo_po"].Value));
                if (Rpta.Equals("OK"))
                {
                    this.Listado_po("%");
                    MessageBox.Show("Proceso de Eliminado se realizo", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show(Rpta, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
