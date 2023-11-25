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
    public partial class Inventario : Form 
    {
        public Inventario()
        {
            InitializeComponent();
            LoadTabla(null);
        }
        string _nombre;
        int existens;
        string _descripcion;
        string _unidad;
        decimal _precio;
        int _id;


        private void LoadTabla(string dato)
        {
            /*List<ClassCtrlProductos> list = new List<ClassCtrlProductos>();
            ClassCtrlProductos _CtrlProductos = new ClassCtrlProductos();
            dataGridInventario.DataSource = _CtrlProductos.consulta(dato);
            dataGridInventario.Columns[0].Visible = false;*/
        }
        private void Inventario_Load(object sender, EventArgs e)
        {
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string cadena = txtSearch.Text;
            LoadTabla(cadena);
        }

        private void Inventario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.F5)
            {
                LoadTabla(null);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadTabla(null);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtNombre.Text = null;
            txtDescrip.Text = null;
            txtID.Text = "0";
            //numericUpDownPrec.Value = 0;
            txtPrec.Text = null;
            txtEx.Text = null;
            txtUnidad.Text = null;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            _id = Convert.ToInt32(txtID.Text);
            _nombre = txtNombre.Text;
            existens = Convert.ToInt32(txtEx.Text);
            _descripcion = txtDescrip.Text;
            _unidad = txtUnidad.Text;
            _precio = Convert.ToDecimal(txtPrec.Text);
            //_precio = numericUpDownPrec.Value;
             
            
            ClassCtrlProductos vObj = new ClassCtrlProductos();
            vObj.insertar(_id,_nombre,existens,_descripcion,_unidad,_precio);

            List<ClassCtrlProductos> list = new List<ClassCtrlProductos>();
            ClassCtrlProductos _CtrlProductos = new ClassCtrlProductos();
            dataGridInventario.DataSource = _CtrlProductos.consulta(null);
            dataGridInventario.Columns[0].Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _id = Convert.ToInt32(txtID.Text);
            _nombre = txtNombre.Text;
            existens = Convert.ToInt32(txtEx.Text);
            _descripcion = txtDescrip.Text;
            _unidad = txtUnidad.Text;
            _precio = Convert.ToDecimal(txtPrec.Text);
            //_precio = numericUpDownPrec.Value;


            ClassCtrlProductos vObj = new ClassCtrlProductos();
            vObj.actualizar(_id, _nombre, existens, _descripcion, _unidad, _precio);

            List<ClassCtrlProductos> list = new List<ClassCtrlProductos>();
            ClassCtrlProductos _CtrlProductos = new ClassCtrlProductos();
            dataGridInventario.DataSource = _CtrlProductos.consulta(null);
            dataGridInventario.Columns[0].Visible = false;
        }


        public void campo(DataGridView dgv, TextBox txt, int colum) 
        {
            txt.Text=dgv.Rows[dgv.CurrentRow.Index].Cells[colum].Value.ToString();
        }
       
        private void dataGridInventario_SelectionChanged(object sender, EventArgs e)
        {
            campo(dataGridInventario, txtNombre, 1);
            campo(dataGridInventario, txtEx, 2);
            campo(dataGridInventario, txtDescrip, 3);
            campo(dataGridInventario, txtUnidad, 4);
            campo(dataGridInventario, txtID, 0);
            campo(dataGridInventario, txtPrec, 5);

            //Convert.ToDouble(numericUpDownPrec.Text = dataGridInventario.Rows[dataGridInventario.CurrentRow.Index].Cells[5].Value.ToString());
        }

        private void txtEx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrec_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
