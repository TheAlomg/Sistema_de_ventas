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
    public partial class Frm_Empresas : Form
    {
        public Frm_Empresas()
        {
            InitializeComponent();
        }
        #region "Variables"
        int nCodigo_em =0;
        int nEstadoguarda =0;
        #endregion
        #region "Mis Metodos"
        private void limpia_texto()
        {
            Txt_Nombre_em.Text = "";
            Txt_Ndocumento_em.Text = "";
            Txt_Direccion_em.Text = "";
            Txt_Correo_em.Text = "";
            Txt_Telefono_em.Text = "";
        }
        private void estado_texto(bool lEstado)
        {
            Txt_Nombre_em.Enabled = lEstado;
            Txt_Ndocumento_em.Enabled = lEstado;
            Txt_Direccion_em.Enabled = lEstado;
            Txt_Correo_em.Enabled = lEstado;
            Txt_Telefono_em.Enabled = lEstado;

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
            dgvlistado.Columns[0].HeaderText = "Codigo_Em";
            dgvlistado.Columns[1].Width = 180;
            dgvlistado.Columns[1].HeaderText = "Nombre";
            dgvlistado.Columns[2].Width = 180;
            dgvlistado.Columns[2].HeaderText = "Numero Documento";
            dgvlistado.Columns[3].Visible = false;
            dgvlistado.Columns[4].Visible = false;
            dgvlistado.Columns[5].Visible = false;
            dgvlistado.Columns[6].Width = 100;
            dgvlistado.Columns[6].HeaderText = "Activo";
        }
        private void Listado_em(string cTexto)
        {
            D_Empresas Datos = new D_Empresas();
            dgvlistado.DataSource = Datos.Listado_em(cTexto);
            this.formato();
        }

        private void Seleccionaitem()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dgvlistado.CurrentRow.Cells["codigo_em"].Value)))
            {
                MessageBox.Show("Seleccione un registro valido","Aviso de sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                nCodigo_em=Convert.ToInt32(dgvlistado.CurrentRow.Cells["codigo_em"].Value);
                Txt_Nombre_em.Text = dgvlistado.CurrentRow.Cells["nombre_em"].Value.ToString();
                Txt_Ndocumento_em.Text = dgvlistado.CurrentRow.Cells["ndocumento_em"].Value.ToString();
                Txt_Direccion_em.Text = dgvlistado.CurrentRow.Cells["direccion_em"].Value.ToString();
                Txt_Telefono_em.Text = dgvlistado.CurrentRow.Cells["telefono_em"].Value.ToString();
                Txt_Correo_em.Text = dgvlistado.CurrentRow.Cells["correo_em"].Value.ToString();
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
            this.Txt_Nombre_em.Focus();
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            nEstadoguarda = 0;
            this.limpia_texto();
            this.estado_texto(false);
            this.Estado_botones_procesos(false);
            this.Estado_botones_principales(true);
        }

        private void Frm_Empresas_Load(object sender, EventArgs e)
        {
            this.Listado_em("%");
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            this.Listado_em(Txt_Buscar.Text);
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (Txt_Nombre_em.Text==string.Empty|| Txt_Ndocumento_em.Text==string.Empty|| Txt_Direccion_em.Text==string.Empty|| Txt_Correo_em.Text == string.Empty|| Txt_Telefono_em.Text==string.Empty)
            {
                MessageBox.Show("Ingrese dato requerido ( * )", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else //procedemos a guardar la informacion
            {
                string Rpta;
                E_Empresa oEm = new E_Empresa();
                oEm.Codigo_em = nCodigo_em;
                oEm.Nombre_em = Txt_Nombre_em.Text;
                oEm.Ndocumento_em = Txt_Ndocumento_em.Text;
                oEm.Direccion_em = Txt_Direccion_em.Text;
                oEm.Telefono_em = Txt_Telefono_em.Text;
                oEm.Correo_em = Txt_Correo_em.Text;
                D_Empresas Datos = new D_Empresas();
                Rpta = Datos.Guardar_em(nEstadoguarda, oEm);
                bool esNumero = int.TryParse(Rpta, out int xCodigo);
                if (esNumero == true)
                {
                    nEstadoguarda = 0;
                    nCodigo_em = 0;
                    this.limpia_texto();
                    this.estado_texto(false);
                    this.Estado_botones_procesos(false);
                    this.Estado_botones_principales(true);
                    this.Listado_em("%");
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
            this.Txt_Nombre_em.Focus();
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
                D_Empresas Datos = new D_Empresas();
                Rpta = Datos.Activo_em(Convert.ToInt32(dgvlistado.CurrentRow.Cells["codigo_em"].Value));
                if (Rpta.Equals ("OK"))
                {
                    this.Listado_em("%");
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
