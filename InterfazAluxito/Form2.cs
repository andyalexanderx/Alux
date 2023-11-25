using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using ClassLibraryAlux;
using MySql.Data.MySqlClient;

namespace InterfazAluxito
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
        }
        //boton para iniciar sesion en el sistema
        public void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //string cmd = string.Format("select * from usuarios where username='{0}' and passwd='{1}'", BoxUser.Text.Trim(),BoxPass.Text.Trim());
                //DataSet ds = Class1.Execute(cmd);
                //string usuario= ds.Tables[0].Rows[0]["username"].ToString();
                //string contra = ds.Tables[0].Rows[0]["passwd"].ToString();
                //string nombre = ds.Tables[0].Rows[0]["nombre"].ToString();
                //string Apellido = ds.Tables[0].Rows[0]["apellidoPatern"].ToString();
                //BoxUser.Text = "Andy";
                //BoxPass.Text = "12345";

                if (BoxUser.Text == "Andy" && BoxPass.Text == "12345")
                {
                    ClaseSingleton.Login(BoxUser.Text);//se envia el nombre del usuario de la session iniciada
                    ClaseSingleton obj = ClaseSingleton.ObtienerInstancia(); //se comprueba si esta creada la instancia;
                    lblAviso.Text = "Es correcto";
                    MessageBox.Show("Bienvenido");
                    ClaseVars.vCajero = "Andy Santamaría";
                    Form3 call = new Form3();
                    call.Show();
                    //this.Hide();
                }
                else
                {
                    lblAviso.Text = "Es incorrecto!";
                    MessageBox.Show("Usuario o contraseña incorrecta");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        //Casilla para visualizar o no la contraseña
        private void checkVerPass_CheckedChanged(object sender, EventArgs e)
        {
            string txt = BoxPass.Text;
            if (checkVerPass.Checked)
            {
                BoxPass.UseSystemPasswordChar = false;
                BoxPass.Text = txt;
            }
            else
            {
                BoxPass.UseSystemPasswordChar = true;
                BoxPass.Text = txt;
            }
        }
        //cierra el programa desde x
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
