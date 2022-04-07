using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
namespace TAPU1_ACT_FINAL_EXAMEN_YOHELCENICEROSCABRERA
{
    public partial class FrmLogin : Form
    {
        // Aqui se acomoda la estructura para utilizar de una forma correcta el diccionario
        Dictionary<string, string> Alumnos = new Dictionary<string, string>();
        Dictionary<string, string> Empleados = new Dictionary<string, string>();
        FrmLogin Menu;
        public static string Invitado;
        public static string usuarioConectadoFinal;
        public FrmLogin()
        {
            InitializeComponent();
        }
        // En esta parte se programa el evento click el cual nos llevara a nuestro segundo form
        // Mostrandonos un message box que indique quien entro al sistema
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string msg = string.Empty;
            string usuario = string.Empty;
            if (Alumnos.ContainsKey(txtAcceso.Text) || Empleados.ContainsKey(txtAcceso.Text)|| chInvitado.Checked==true)
            {

                if (Alumnos.ContainsKey(txtAcceso.Text))
                {
                    msg = string.Format("Bienvenido a PIDETEC estimado alumno: {0}, espero tu visita sea placentera.", Alumnos[txtAcceso.Text].ToString());
                    usuarioConectadoFinal = Alumnos[txtAcceso.Text].ToString();
                }
                if (Empleados.ContainsKey(txtAcceso.Text))
                {
                    msg = string.Format("Bienvenido a PIDETEC {0}", Empleados[txtAcceso.Text].ToString());
                    usuarioConectadoFinal = Empleados[txtAcceso.Text].ToString();
                }
                // Aqui se cambiaria a nuestro segundo form donde se lleva al menu de la comida disponible
                MessageBox.Show(msg);
                MenuOpciones opciones = new MenuOpciones(usuario);
                this.Hide();
                DialogResult dialogResult = opciones.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    this.Show();
                }
                if (chInvitado.Checked==true)
                {
                    msg = string.Format("Sea bienvenido {0}", (txtAcceso.Text).ToString());
                    usuarioConectadoFinal = (txtAcceso.Text);
                }
                MessageBox.Show(msg);
                MenuOpciones menuOpciones = new MenuOpciones(usuario);
                this.Hide();
                DialogResult dialogResult1 = menuOpciones.ShowDialog();
                if (dialogResult==DialogResult.OK)
                {
                    this.Show();
                }
            }

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            //Se llena el diccionario a usar
            Alumnos.Add("201000188", "OCHOA ESPARZA SANJUANA MELISSA");
            Alumnos.Add("201000152", "SCOTT CARREON PAOLA ALEJANDRA");
            Alumnos.Add("201000114", "VELASQUEZ VAZQUEZ DIANA KAREN");
            Alumnos.Add("201000079", "ALVAREZ LOZA JOB ALBERTO");
            Alumnos.Add("201000180", "AVITIA MUÑIZ ELIENAI AZUCENA");
            Alumnos.Add("201000175", "CARRIZALES CARRILLO LUIS GAEL");
            Alumnos.Add("201000068", "CENICEROS CABRERA YOHEL");
            Alumnos.Add("201000078", "HERNANDEZ AGUILAR NAYDELIN GUADALUPE");
            Alumnos.Add("201000130", "JIMENEZ IBARRA HECTOR ADAIR");
            Alumnos.Add("201000133", "LOZA MILAN LEONARDO");
            Empleados.Add("1138", "MTI. Ulises Martínez Rodríguez");
            Empleados.Add("1367", "ME. Idalia Ruiz Arroyo");
            Empleados.Add("1023", "Ing. Américo Martínez Ovalle");
            Empleados.Add("117", "Lord Darth Vader");


        }
        // En esta seccion se programa acerca de si el usuario decide entrar como invitado
        // Ademas de darle a escoger el hacerlo o si se equivoco 
        // Pueda entrar como alumno o empleado
        private void chInvitado_CheckedChanged(object sender, EventArgs e)
        {

            if (chInvitado.Checked == true)
            {
                DialogResult result = MessageBox.Show("¿Estas seguro que deseas ingresar como invitado?", "PIDETEC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    txtAcceso.Focus();
                    txtAcceso.Text = "Ingresa tu nombre de usuario";
                }
                if (result == DialogResult.No)
                {
                    chInvitado.Checked = false;
                    txtAcceso.Text = "Ingresa tu matricula o número de empleado";
                }
            }
            if (chInvitado.Checked == false)
            {
                chInvitado.Checked = false;
                txtAcceso.Text = "Ingresa tu matricula o número de empleado";
            }


        }
        // En esta parte validaremos las teclas que solo se pueden presionar al entrar como un invitado
        private void txtAcceso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (chInvitado.Checked==true)
            {
                if (e.KeyChar >= 00 && e.KeyChar != 8 && e.KeyChar <= 64 || e.KeyChar != 8 && e.KeyChar >= 91 && e.KeyChar <= 96 //Se crea una condición donde solo se pueden escribir
                    || e.KeyChar != 8 && e.KeyChar >= 123 && e.KeyChar <= 126 || e.KeyChar != 8 && e.KeyChar >= 128)
                {
                    e.Handled = true;
                    MessageBox.Show("Solo puedes ingresar letras");
                }
            }
            else
            {
                if (e.KeyChar >= 00 && e.KeyChar != 8 && e.KeyChar <= 47 && e.KeyChar != 127 || e.KeyChar != 8 && e.KeyChar >= 58 && e.KeyChar != 127
)
                {
                    e.Handled = true;
                    MessageBox.Show("Solo puedes ingresar números");
                }
            }




        
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
