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
    public partial class Frm_Usuarios : Form
    {
        public Frm_Usuarios()
        {
            InitializeComponent();
        }
        #region "Variables"
        int nCodigo_us =0;
        int nEstadoguarda =0;
        #endregion
        #region "Mis Metodos"
        private void limpia_texto()
        {
            Txt_login_us.Text = "";
            Txt_password_us.Text = "";
            Txt_nombre_us.Text = "";
            cmbrol_us.Text = "";
        }
        private void estado_texto(bool lEstado)
        {
            Txt_login_us.Enabled = lEstado;
            Txt_password_us.Enabled = lEstado;
            Txt_nombre_us.Enabled = lEstado;
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
            dgvlistado.Columns[0].HeaderText = "Codigo_Us";
            dgvlistado.Columns[1].Width = 120;
            dgvlistado.Columns[1].HeaderText = "Login_Us";
            dgvlistado.Columns[2].Width = 180;
            dgvlistado.Columns[2].HeaderText = "Nombre";
            dgvlistado.Columns[3].Width = 200;
            dgvlistado.Columns[3].HeaderText = "Rol Del Usuario";
            dgvlistado.Columns[4].Width = 100;
            dgvlistado.Columns[4].HeaderText = "Activo";
            dgvlistado.Columns[5].Visible = false;
        }
        private void Listado_us(string cTexto)
        {
            D_Usuarios Datos = new D_Usuarios();
            dgvlistado.DataSource = Datos.Listado_us(cTexto);
            this.formato();
        }
        private void Listado_ru()
        {
            try
            {
                D_Usuarios Datos = new D_Usuarios();
                cmbrol_us.DataSource = Datos.Listado_ru();
                cmbrol_us.ValueMember = "codigo_ru";
                cmbrol_us.DisplayMember = "descripcion_ru";

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            } 
        }

        private void Seleccionaitem()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dgvlistado.CurrentRow.Cells["codigo_us"].Value)))
            {
                MessageBox.Show("Seleccione un registro valido","Aviso de sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                nCodigo_us=Convert.ToInt32(dgvlistado.CurrentRow.Cells["codigo_us"].Value);
                Txt_login_us.Text = dgvlistado.CurrentRow.Cells["login_us"].Value.ToString();
                Txt_password_us.Text = "";
                Txt_nombre_us.Text = dgvlistado.CurrentRow.Cells["nombre_us"].Value.ToString();
                cmbrol_us.Text = dgvlistado.CurrentRow.Cells["descripcion_ru"].Value.ToString();
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
            this.Txt_login_us.Focus();
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            nEstadoguarda = 0;
            this.limpia_texto();
            this.estado_texto(false);
            this.Estado_botones_procesos(false);
            this.Estado_botones_principales(true);
        }

        private void Frm_Usuarios_Load(object sender, EventArgs e)
        {
            this.Listado_ru();
            this.Listado_us("%");
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            this.Listado_us(Txt_Buscar.Text);
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (Txt_login_us.Text==string.Empty|| Txt_password_us.Text==string.Empty|| Txt_nombre_us.Text==string.Empty || cmbrol_us.Text==string.Empty)
            {
                MessageBox.Show("Ingrese dato requerido ( * )", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else //procedemos a guardar la informacion
            {
                string Rpta;
                E_Usuarios oPro = new E_Usuarios();
                oPro.Codigo_us = nCodigo_us;
                oPro.Login_us = Txt_login_us.Text;
                oPro.Password_us = Txt_password_us.Text;
                oPro.Nombre_us = Txt_nombre_us.Text;
                oPro.Codigo_ru = Convert.ToInt32(cmbrol_us.SelectedValue);
                D_Usuarios Datos = new D_Usuarios();
                Rpta = Datos.Guardar_us(nEstadoguarda, oPro);
                bool esNumero = int.TryParse(Rpta, out int xCodigo);
                if (esNumero == true)
                {
                    nEstadoguarda = 0;
                    nCodigo_us = 0;
                    this.limpia_texto();
                    this.estado_texto(false);
                    this.Estado_botones_procesos(false);
                    this.Estado_botones_principales(true);
                    this.Listado_us("%");
                    MessageBox.Show("Los datos han sido guardados correctamente en el codigo #" + Rpta.Trim(), "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            nEstadoguarda = 2; //Actualizar Registro
            this.estado_texto(true);
            Txt_login_us.Enabled = false;
            this.Estado_botones_procesos(true);
            this.Estado_botones_principales(false);
            this.Txt_nombre_us.Focus();
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
                D_Usuarios Datos = new D_Usuarios();
                Rpta = Datos.Activo_us(Convert.ToInt32(dgvlistado.CurrentRow.Cells["codigo_us"].Value));
                if (Rpta.Equals ("OK"))
                {
                    this.Listado_us("%");
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
