using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAPU1_ACT_FINAL_EXAMEN_YOHELCENICEROSCABRERA
{
    public partial class MenuOpciones : Form
    {
        private string UsuarioConectado;
        ImagenComida comidaH = new ImagenComida();
        ImagenTacos comidaT = new ImagenTacos();
        ImagenBownless comidaB = new ImagenBownless();
        ImagenPapas comidaP = new ImagenPapas();
        
        public int progress, progressH, progressT, progressP, progressB,total;
       

        private void btnTacos_Click(object sender, EventArgs e)
        {
            if (progressT >= 0 && progressT <= 90)
            {
               total += 45;
               progressT += 10;
                PbTacos.Value = progressT;
                LbPrecio.Text = total.ToString();
            }
        }

        private void btnPapas_Click(object sender, EventArgs e)
        {
            if (progressP>=0&&progressB<=99)
            {
                total += 90;
                progressP += 10;
                PbPapas.Value = progressP;
                LbPrecio.Text = total.ToString();

            }
        }
        // Aqui se muestra la imagen en otro form
        // Se hace un proceso muy similar con todos los eventos mouse hover y mouse leaver
        // Para que la imagen se muestre y se quite
        private void btnHamburguesa_MouseHover(object sender, EventArgs e)
        {

            if (true)
            {
                comidaH.Show();
            }

        }

        private void btnHamburguesa_MouseLeave(object sender, EventArgs e)
        {
            comidaH.Hide();

        }

        private void btnTacos_MouseHover(object sender, EventArgs e)
        {
            if (true)
            {
                comidaT.Show();
            }
        }

        private void btnTacos_MouseLeave(object sender, EventArgs e)
        {
            comidaT.Hide();
        }

        private void btnBownless_MouseHover(object sender, EventArgs e)
        {
            if (true)
            {
                comidaB.Show();
            }
        }

        private void btnBownless_MouseLeave(object sender, EventArgs e)
        {
            comidaB.Hide();
        }

        private void btnPapas_MouseHover(object sender, EventArgs e)
        {
            if (true)
            {
                comidaP.Show();
            }
        }

        private void btnPapas_MouseLeave(object sender, EventArgs e)
        {
            comidaP.Hide();
        }
        // Aqui terminaria la programacion de los forms para que se muestren y se quiten

        private void btnBownless_Click(object sender, EventArgs e)
        {

            if (progressB >= 0 && progressB <= 90)
            {
                total += 60;
                progressB += 10;
                PbBownless.Value = progressB;
                LbPrecio.Text = total.ToString();
            }
        }

        // En esta parte se programa la progress bar que vaya aumentando conforme se le den clicks
        // Ademas de ello nos muestre la cantidad que se usa
        private void btnHamburguesa_Click(object sender, EventArgs e)
        {
            if (progress >= 0 && progress <= 90)
            {
                total += 50;
                progressH += 10;
                PbHamburguesa.Value = progressH;
                LbPrecio.Text = total.ToString();
            }
        }

        public MenuOpciones(string usuario)
        {
            InitializeComponent();
            this.UsuarioConectado = UsuarioConectado;
            progress = 0;
        }
        // En esta seccion se programa un boton para cerrar sesion 
        private void ToolStripButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        // En esta parte se programa un label que indique el usuario que se conecto a PIDETEC
        private void MenuOpciones_Load(object sender, EventArgs e)
        {
            TspUsuario.Text = FrmLogin.usuarioConectadoFinal;
            
            

        }

    }

}
