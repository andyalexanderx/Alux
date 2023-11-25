
namespace InterfazAluxito
{
    partial class Form3
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
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BoxCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridArti = new System.Windows.Forms.DataGridView();
            this.btnTotalizarCuenta = new System.Windows.Forms.Button();
            this.btnBuscarArti = new System.Windows.Forms.Button();
            this.BoxCant = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.BoxCambio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BoxPagoCon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BoxTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.et_caj = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArti)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(352, 583);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 66);
            this.button3.TabIndex = 2;
            this.button3.Text = "Inventarios";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(1613, 15);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 66);
            this.button5.TabIndex = 4;
            this.button5.Text = "Cerrar sesión";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ventas";
            // 
            // BoxCode
            // 
            this.BoxCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxCode.Location = new System.Drawing.Point(61, 46);
            this.BoxCode.Margin = new System.Windows.Forms.Padding(4);
            this.BoxCode.Name = "BoxCode";
            this.BoxCode.Size = new System.Drawing.Size(224, 34);
            this.BoxCode.TabIndex = 3;
            this.BoxCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BoxCode_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Código:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.dataGridArti);
            this.groupBox2.Controls.Add(this.btnTotalizarCuenta);
            this.groupBox2.Controls.Add(this.btnBuscarArti);
            this.groupBox2.Controls.Add(this.BoxCant);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.BoxCode);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(21, 69);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1115, 523);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Artículos";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(669, 37);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 41);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Añadir a la venta";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridArti
            // 
            this.dataGridArti.AllowUserToDeleteRows = false;
            this.dataGridArti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridArti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridArti.Location = new System.Drawing.Point(12, 85);
            this.dataGridArti.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridArti.Name = "dataGridArti";
            this.dataGridArti.ReadOnly = true;
            this.dataGridArti.RowHeadersWidth = 51;
            this.dataGridArti.Size = new System.Drawing.Size(905, 431);
            this.dataGridArti.TabIndex = 11;
            // 
            // btnTotalizarCuenta
            // 
            this.btnTotalizarCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalizarCuenta.Location = new System.Drawing.Point(949, 155);
            this.btnTotalizarCuenta.Margin = new System.Windows.Forms.Padding(4);
            this.btnTotalizarCuenta.Name = "btnTotalizarCuenta";
            this.btnTotalizarCuenta.Size = new System.Drawing.Size(140, 58);
            this.btnTotalizarCuenta.TabIndex = 9;
            this.btnTotalizarCuenta.Text = "Totalizar Cuenta";
            this.btnTotalizarCuenta.UseVisualStyleBackColor = true;
            this.btnTotalizarCuenta.Click += new System.EventHandler(this.btnTotalizarCuenta_Click);
            // 
            // btnBuscarArti
            // 
            this.btnBuscarArti.Location = new System.Drawing.Point(949, 41);
            this.btnBuscarArti.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarArti.Name = "btnBuscarArti";
            this.btnBuscarArti.Size = new System.Drawing.Size(140, 41);
            this.btnBuscarArti.TabIndex = 8;
            this.btnBuscarArti.Text = "Buscar Artículo";
            this.btnBuscarArti.UseVisualStyleBackColor = true;
            this.btnBuscarArti.Click += new System.EventHandler(this.btnBuscarArti_Click);
            // 
            // BoxCant
            // 
            this.BoxCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxCant.Location = new System.Drawing.Point(379, 46);
            this.BoxCant.Margin = new System.Windows.Forms.Padding(4);
            this.BoxCant.Name = "BoxCant";
            this.BoxCant.Size = new System.Drawing.Size(252, 34);
            this.BoxCant.TabIndex = 5;
            this.BoxCant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cantidad:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Controls.Add(this.BoxCambio);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.BoxPagoCon);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.BoxTotal);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Location = new System.Drawing.Point(21, 618);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1115, 186);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pago";
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(925, 50);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(140, 65);
            this.button9.TabIndex = 11;
            this.button9.Text = "Finalizar Venta";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // BoxCambio
            // 
            this.BoxCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxCambio.Location = new System.Drawing.Point(551, 139);
            this.BoxCambio.Margin = new System.Windows.Forms.Padding(4);
            this.BoxCambio.Name = "BoxCambio";
            this.BoxCambio.ReadOnly = true;
            this.BoxCambio.Size = new System.Drawing.Size(220, 34);
            this.BoxCambio.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(477, 137);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Cambio $";
            // 
            // BoxPagoCon
            // 
            this.BoxPagoCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxPagoCon.Location = new System.Drawing.Point(551, 94);
            this.BoxPagoCon.Margin = new System.Windows.Forms.Padding(4);
            this.BoxPagoCon.Name = "BoxPagoCon";
            this.BoxPagoCon.Size = new System.Drawing.Size(220, 34);
            this.BoxPagoCon.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(461, 92);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Pago Con $";
            // 
            // BoxTotal
            // 
            this.BoxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxTotal.Location = new System.Drawing.Point(551, 50);
            this.BoxTotal.Margin = new System.Windows.Forms.Padding(4);
            this.BoxTotal.Name = "BoxTotal";
            this.BoxTotal.ReadOnly = true;
            this.BoxTotal.Size = new System.Drawing.Size(220, 34);
            this.BoxTotal.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(492, 48);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Total $";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(31, 94);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(116, 20);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Imprimir Ticket";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(31, 43);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(90, 20);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Facturada";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 821);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Hora:";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.ForeColor = System.Drawing.Color.Red;
            this.lblHora.Location = new System.Drawing.Point(69, 821);
            this.lblHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(21, 16);
            this.lblHora.TabIndex = 10;
            this.lblHora.Text = "lbl";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(457, 821);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "Cajero:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Yu Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1144, 11);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(412, 103);
            this.label13.TabIndex = 13;
            this.label13.Text = "El Aluxito";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox4.Controls.Add(this.button13);
            this.groupBox4.Controls.Add(this.button12);
            this.groupBox4.Controls.Add(this.button11);
            this.groupBox4.Controls.Add(this.button10);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Location = new System.Drawing.Point(1180, 128);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(552, 722);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Menú de Ventas";
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(352, 142);
            this.button13.Margin = new System.Windows.Forms.Padding(4);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(120, 57);
            this.button13.TabIndex = 3;
            this.button13.Text = "Cambio de Precio";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(99, 134);
            this.button12.Margin = new System.Windows.Forms.Padding(4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(120, 64);
            this.button12.TabIndex = 2;
            this.button12.Text = "Retiros de Fondos y Entradas ";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(352, 46);
            this.button11.Margin = new System.Windows.Forms.Padding(4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(120, 46);
            this.button11.TabIndex = 1;
            this.button11.Text = "Reimprimir Ticket";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(99, 46);
            this.button10.Margin = new System.Windows.Forms.Padding(4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(120, 46);
            this.button10.TabIndex = 0;
            this.button10.Text = "Cancelar Venta";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(100, 583);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ventas y Pago";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // et_caj
            // 
            this.et_caj.AutoSize = true;
            this.et_caj.Location = new System.Drawing.Point(519, 821);
            this.et_caj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.et_caj.Name = "et_caj";
            this.et_caj.Size = new System.Drawing.Size(21, 16);
            this.et_caj.TabIndex = 15;
            this.et_caj.Text = "lbl";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 821);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fecha:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(233, 821);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(21, 16);
            this.lblFecha.TabIndex = 16;
            this.lblFecha.Text = "lbl";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1745, 860);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.et_caj);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SPV EL ALUXITO(Prototipo)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArti)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BoxCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTotalizarCuenta;
        private System.Windows.Forms.Button btnBuscarArti;
        private System.Windows.Forms.TextBox BoxCant;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox BoxPagoCon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox BoxTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox BoxCambio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.DataGridView dataGridArti;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label et_caj;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFecha;
    }
}