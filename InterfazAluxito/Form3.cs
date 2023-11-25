using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InterfazAluxito
{
    public partial class Form3 : Form
    {
        public string vCajero;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            et_caj.Text = ClaseVars.vCajero;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.ForeColor = Color.Red;
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Inventario obj = new Inventario();
            obj.Show();

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            DialogResult dialogResult = MessageBox.Show(ClaseVars.vCajero+" ¿Está seguro que desea finalizar la sesión?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                //obj.Show();
                this.Close();
                ClaseSingleton.Logout(); // finaliza la session libera la instancia
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void btnBuscarArti_Click(object sender, EventArgs e)
        {
            string cadena = BoxCode.Text;
            LoadTabla(cadena);
        }
        private void LoadTabla(string Code)
        {
            //List<ClassCtrlProductos> list = new List<ClassCtrlProductos>();
            ClassCtrlProductos _CtrlProductos = new ClassCtrlProductos();
            dataGridArti.DataSource = _CtrlProductos.consultaIDProducto(Code);
            dataGridArti.Columns[0].Visible = false;
        }
        private void AddTabla(string Code)
        {
            BoxTotal.Text = "1,200.00";
        }
        private void btnTotalizarCuenta_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string Cadena = BoxCode.Text;
            AddTabla(Cadena);
        }

        private void BoxCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
