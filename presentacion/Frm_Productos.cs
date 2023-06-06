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
    public partial class Frm_Productos : Form
    {
        public Frm_Productos()
        {
            InitializeComponent();
        }
        #region "Variables"
        int nCodigo_pr = 0;
        int nEstadoguarda = 0;
        #endregion
        #region "Mis Metodos"
        private void limpia_texto()
        {
            Txt_Nombre_pr.Text = "";
            Txt_Descripcion_pr.Text = "";
            Txt_Abreviatura_me.Text = "";
            Txt_Descripcion_me.Text = "";
            Txt_PrecioUni_pr.Text = "";
            Txt_Stock_pr.Text = "";
            Txt_Codigo_me.Text = "";
            cmbrol_po.Text = "";
        }
        private void estado_texto(bool lEstado)
        {
            Txt_Nombre_pr.Enabled = lEstado;
            Txt_Descripcion_pr.Enabled = lEstado;
            Txt_Abreviatura_me.Enabled = lEstado;
            Txt_Descripcion_me.Enabled = lEstado;
            Txt_PrecioUni_pr.Enabled = lEstado;
            Txt_Stock_pr.Enabled = lEstado;
            Txt_Codigo_me.Enabled = lEstado;
            cmbrol_po.Enabled = lEstado;


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
            dgvlistado.Columns[0].HeaderText = "Codigo_Pr";
            dgvlistado.Columns[1].Width = 180;
            dgvlistado.Columns[1].HeaderText = "Nombre ";
            dgvlistado.Columns[2].Visible = false;
            dgvlistado.Columns[3].Visible = false;
            dgvlistado.Columns[4].Visible = false;
            dgvlistado.Columns[5].Visible = false;
            dgvlistado.Columns[6].Visible = false;
            dgvlistado.Columns[7].Width = 100;
            dgvlistado.Columns[7].HeaderText = "Precio Unitario";
            dgvlistado.Columns[8].Width = 100;
            dgvlistado.Columns[8].HeaderText = "Stock";
            dgvlistado.Columns[9].Width = 100;
            dgvlistado.Columns[9].HeaderText = "Activo";
            dgvlistado.Columns[10].Visible = false;
            dgvlistado.Columns[11].Visible = false;
        }
        private void Listado_po()
        {
            try
            {
                D_Productos Datos = new D_Productos();
                cmbrol_po.DataSource = Datos.Listado_popr();
                cmbrol_po.ValueMember = "codigo_po";
                cmbrol_po.DisplayMember = "nombre_po";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Listado_pr(string cTexto)
        {
            D_Productos Datos = new D_Productos();
            dgvlistado.DataSource = Datos.Listado_pr(cTexto);
            this.formato();
        }

        private void Seleccionaitem()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dgvlistado.CurrentRow.Cells["codigo_pr"].Value)))
            {
                MessageBox.Show("Seleccione un registro valido", "Aviso de sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                nCodigo_pr = Convert.ToInt32(dgvlistado.CurrentRow.Cells["codigo_pr"].Value);
                Txt_Nombre_pr.Text = dgvlistado.CurrentRow.Cells["nombre_pr"].Value.ToString();
                Txt_Descripcion_pr.Text = dgvlistado.CurrentRow.Cells["descripcion_pr"].Value.ToString();
                Txt_Abreviatura_me.Text = dgvlistado.CurrentRow.Cells["abreviatura_me"].Value.ToString();
                Txt_PrecioUni_pr.Text = dgvlistado.CurrentRow.Cells["preciounitario_pr"].Value.ToString();
                Txt_Descripcion_me.Text = dgvlistado.CurrentRow.Cells["descripcion_me"].Value.ToString();
                Txt_Codigo_me.Text = dgvlistado.CurrentRow.Cells["codigo_me"].Value.ToString();
                Txt_Stock_pr.Text = dgvlistado.CurrentRow.Cells["stock"].Value.ToString();
                cmbrol_po.Text = dgvlistado.CurrentRow.Cells["nombre_po"].Value.ToString();
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
            this.Txt_Nombre_pr.Focus();
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            nEstadoguarda = 0;
            this.limpia_texto();
            this.estado_texto(false);
            this.Estado_botones_procesos(false);
            this.Estado_botones_principales(true);
        }

        private void Frm_Productos_Load(object sender, EventArgs e)
        {
            this.Listado_po();
            this.Listado_pr("%");
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            this.Listado_pr(Txt_Buscar.Text);
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (Txt_Nombre_pr.Text == string.Empty || Txt_Descripcion_pr.Text == string.Empty || Txt_Abreviatura_me.Text == string.Empty || Txt_Descripcion_me.Text == string.Empty ||
                Txt_PrecioUni_pr.Text == string.Empty  || Txt_Stock_pr.Text == string.Empty || Txt_Codigo_me.Text == string.Empty || cmbrol_po.Text == string.Empty)
            {
                MessageBox.Show("Ingrese dato requerido ( * )", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else //procedemos a guardar la informacion
            {
                string Rpta;
                E_Productos oPr = new E_Productos();
                oPr.Codigo_pr = nCodigo_pr;
                oPr.Nombre_pr = Txt_Nombre_pr.Text;
                oPr.Descripcion_pr = Txt_Descripcion_pr.Text;
                oPr.Abreviatura_me = Txt_Abreviatura_me.Text;
                oPr.PrecioUnitario_pr = Convert.ToDecimal(Txt_PrecioUni_pr.Text);
                oPr.Descripcion_me = Txt_Descripcion_me.Text;
                oPr.Stock = Convert.ToDecimal(Txt_Stock_pr.Text);
                oPr.Codigo_me = Convert.ToInt32(Txt_Codigo_me.Text);
                oPr.Codigo_po = Convert.ToInt32(cmbrol_po.SelectedValue);
                D_Productos Datos = new D_Productos();
                Rpta = Datos.Guardar_pr(nEstadoguarda, oPr);
                bool esNumero = int.TryParse(Rpta, out int xCodigo);
                if (esNumero == true)
                {
                    nEstadoguarda = 0;
                    nCodigo_pr = 0;
                    this.limpia_texto();
                    this.estado_texto(false);
                    this.Estado_botones_procesos(false);
                    this.Estado_botones_principales(true);
                    this.Listado_pr("%");
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
            this.Txt_Nombre_pr.Focus();
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
            this.Txt_Nombre_pr.Focus();
        }

        private void Btn_Actualizar_Click_1(object sender, EventArgs e)
        {
            nEstadoguarda = 2; //Actualizar Registro
            this.estado_texto(true);
            this.Estado_botones_procesos(true);
            this.Estado_botones_principales(false);
            this.Txt_Nombre_pr.Focus();
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dgvlistado.Rows.Count > 0)
            {
                string Rpta = "";
                D_Productos Datos = new D_Productos();
                Rpta = Datos.Eliminar_pr(Convert.ToInt32(dgvlistado.CurrentRow.Cells["codigo_pr"].Value));
                if (Rpta.Equals("OK"))
                {
                    this.Listado_pr("%");
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
