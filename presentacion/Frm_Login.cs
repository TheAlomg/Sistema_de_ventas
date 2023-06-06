using Datos;
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
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
            this.toolTip1.SetToolTip(this.Btn_Iniciar,"Iniciar sesion ahora");
            this.toolTip1.SetToolTip(this.Btn_Salir, "Salir del sistema");

            this.Text=string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        #region "Estilo para el control de titulo"
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr Hwnd, int wMsg, int wParam, int lParam);
        #endregion
        #region "Mis Metodos"
        private void logout(object sender, FormClosedEventArgs e)
        {
            this.Txtlogin_us.Text = "";
            this.Txtpassword_us.Text = "";
            this.Show();
            this.Txtlogin_us.Select();
        }
        #endregion
        private void Pnl_titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Iniciar_Click(object sender, EventArgs e)
        {
            DataTable Tablalogin = new DataTable();
            D_Usuarios Datos = new D_Usuarios();
            Tablalogin = Datos.Login_us(Txtlogin_us.Text,Txtpassword_us.Text);
            if (Tablalogin.Rows.Count > 0)
            {
                Frm_Principal oFrm_Principal = new Frm_Principal();
                oFrm_Principal.nCodigo_us = Convert.ToInt32(Tablalogin.Rows[0][0]);
                oFrm_Principal.cLogin_us = Convert.ToString(Tablalogin.Rows[0][1]);
                oFrm_Principal.cNombre_us = Convert.ToString(Tablalogin.Rows[0][2]);
                oFrm_Principal.cDescripcion_ru = Convert.ToString(Tablalogin.Rows[0][3]);
                oFrm_Principal.nCodigo_ru = Convert.ToInt32(Tablalogin.Rows[0][4]);
                oFrm_Principal.Show();
                oFrm_Principal.FormClosed += logout;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Accesso Denegado........ Verifique si el usuario o la contraseña son correctas", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
