
namespace InterfazAluxito
{
    partial class Inventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridInventario = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existenciasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classProductosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupInventario = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUnidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescrip = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPrec = new System.Windows.Forms.TextBox();
            this.txtEx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.numericUpDownPrec = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.classProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classProductosBindingSource1)).BeginInit();
            this.groupInventario.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classProductosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridInventario
            // 
            this.dataGridInventario.AllowUserToDeleteRows = false;
            this.dataGridInventario.AutoGenerateColumns = false;
            this.dataGridInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridInventario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.existenciasDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.unidadDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn});
            this.dataGridInventario.DataSource = this.classProductosBindingSource1;
            this.dataGridInventario.Location = new System.Drawing.Point(8, 23);
            this.dataGridInventario.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridInventario.Name = "dataGridInventario";
            this.dataGridInventario.ReadOnly = true;
            this.dataGridInventario.RowHeadersWidth = 51;
            this.dataGridInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridInventario.Size = new System.Drawing.Size(888, 517);
            this.dataGridInventario.TabIndex = 0;
            this.dataGridInventario.SelectionChanged += new System.EventHandler(this.dataGridInventario_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // existenciasDataGridViewTextBoxColumn
            // 
            this.existenciasDataGridViewTextBoxColumn.DataPropertyName = "Existencias";
            this.existenciasDataGridViewTextBoxColumn.HeaderText = "Existencias";
            this.existenciasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.existenciasDataGridViewTextBoxColumn.Name = "existenciasDataGridViewTextBoxColumn";
            this.existenciasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unidadDataGridViewTextBoxColumn
            // 
            this.unidadDataGridViewTextBoxColumn.DataPropertyName = "Unidad";
            this.unidadDataGridViewTextBoxColumn.HeaderText = "Unidad";
            this.unidadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unidadDataGridViewTextBoxColumn.Name = "unidadDataGridViewTextBoxColumn";
            this.unidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classProductosBindingSource1
            // 
            this.classProductosBindingSource1.DataSource = typeof(InterfazAluxito.ClassProductos);
            // 
            // groupInventario
            // 
            this.groupInventario.Controls.Add(this.dataGridInventario);
            this.groupInventario.Location = new System.Drawing.Point(16, 178);
            this.groupInventario.Margin = new System.Windows.Forms.Padding(4);
            this.groupInventario.Name = "groupInventario";
            this.groupInventario.Padding = new System.Windows.Forms.Padding(4);
            this.groupInventario.Size = new System.Drawing.Size(904, 548);
            this.groupInventario.TabIndex = 1;
            this.groupInventario.TabStop = false;
            this.groupInventario.Text = "Inventario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Unidad de medida: ";
            // 
            // txtUnidad
            // 
            this.txtUnidad.Location = new System.Drawing.Point(140, 263);
            this.txtUnidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Size = new System.Drawing.Size(119, 22);
            this.txtUnidad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descripción:";
            // 
            // txtDescrip
            // 
            this.txtDescrip.Location = new System.Drawing.Point(101, 118);
            this.txtDescrip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescrip.Multiline = true;
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.Size = new System.Drawing.Size(181, 130);
            this.txtDescrip.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(223, 34);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 54);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(24, 34);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(105, 54);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "Insertar";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Precio: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPrec);
            this.groupBox1.Controls.Add(this.txtEx);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.txtUnidad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDescrip);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(916, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(307, 402);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del producto";
            // 
            // txtPrec
            // 
            this.txtPrec.Location = new System.Drawing.Point(69, 303);
            this.txtPrec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrec.Name = "txtPrec";
            this.txtPrec.Size = new System.Drawing.Size(119, 22);
            this.txtPrec.TabIndex = 14;
            this.txtPrec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrec_KeyPress);
            // 
            // txtEx
            // 
            this.txtEx.Location = new System.Drawing.Point(100, 78);
            this.txtEx.Margin = new System.Windows.Forms.Padding(4);
            this.txtEx.Name = "txtEx";
            this.txtEx.Size = new System.Drawing.Size(132, 22);
            this.txtEx.TabIndex = 13;
            this.txtEx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEx_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Existencias:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(71, 43);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(156, 22);
            this.txtNombre.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nombre:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(12, 353);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(119, 22);
            this.txtID.TabIndex = 6;
            // 
            // numericUpDownPrec
            // 
            this.numericUpDownPrec.Location = new System.Drawing.Point(936, 627);
            this.numericUpDownPrec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownPrec.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownPrec.Name = "numericUpDownPrec";
            this.numericUpDownPrec.Size = new System.Drawing.Size(119, 22);
            this.numericUpDownPrec.TabIndex = 12;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(928, 438);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(127, 65);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Limpiar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Buscar:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(76, 130);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(452, 22);
            this.txtSearch.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(535, 111);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 54);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(648, 111);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(105, 54);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Recargar [F5]";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1087, 438);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 65);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(423, 34);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 54);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            // 
            // classProductosBindingSource
            // 
            this.classProductosBindingSource.DataSource = typeof(InterfazAluxito.ClassProductos);
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1245, 738);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.numericUpDownPrec);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupInventario);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Inventario_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Inventario_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classProductosBindingSource1)).EndInit();
            this.groupInventario.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classProductosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridInventario;
        private System.Windows.Forms.GroupBox groupInventario;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUnidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescrip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource classProductosBindingSource;
        private System.Windows.Forms.BindingSource classProductosBindingSource1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn existenciasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownPrec;
        private System.Windows.Forms.TextBox txtEx;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtPrec;
    }
}