using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        #region "Mis Variables"
        internal int nCodigo_us { get; set; }
        internal string cLogin_us { get; set; }
        internal string cNombre_us { get; set; }
        internal string cDescripcion_ru { get; set; }
        internal int nCodigo_ru { get; set; }
        #endregion
        #region "Estilo para el control de titulo"
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr Hwnd, int wMsg, int wParam, int lParam);
        #endregion
        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            lbl_nombre_us.Text = "Usuario: " + cNombre_us;
            lbl_descripcion_ru.Text = "Rol Usuario: "+ cDescripcion_ru;
        }

        private void Pnl_titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lbl_titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Btn_Cerrarsesion_Click(object sender, EventArgs e)
        {
            DialogResult Opcion;
            Opcion = MessageBox.Show("¿Desea cerrar sesion del sistema?", "Aviso del sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(Opcion == DialogResult.OK )
            {
                this.Close();
            }
        }

        private void Btn_Usuarios_Click(object sender, EventArgs e)
        {
            if (nCodigo_ru == 1) // Solos los administradores del sitema
            {
                Frm_Usuarios oFrm_Usuarios = new Frm_Usuarios();
                oFrm_Usuarios.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tienes permiso para esta opcion", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Btn_Empresa_Click(object sender, EventArgs e)
        {
            if (nCodigo_ru == 1) // Solos los administradores del sitema
            {
                Frm_Empresas oFrm_Empresas = new Frm_Empresas();
                oFrm_Empresas.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tienes permiso para esta opcion", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Btn_Productos_Click(object sender, EventArgs e)
        {
            Frm_Productos oFrm_Productos = new Frm_Productos();
            oFrm_Productos.ShowDialog();
        }

        private void Btn_Clientes_Click(object sender, EventArgs e)
        {
            Frm_Clientes oFrm_Clientes = new Frm_Clientes();
            oFrm_Clientes.ShowDialog();
        }

        private void B_Proveedores_Click(object sender, EventArgs e)
        {
            Frm_Proveedores oFrm_Proveedores = new Frm_Proveedores();
            oFrm_Proveedores.ShowDialog();
        }

        private void Btn_Compras_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta parte esta en proceso", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void Btn_Ventas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta parte esta en proceso", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void Btn_Reportes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta parte esta en proceso", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
