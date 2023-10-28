namespace CapaVistaNomina
{
    partial class frm_mantenimiento_empleado
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
            this.txt_empleado_dept = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_telefono_empleado = new System.Windows.Forms.TextBox();
            this.txt_correo_empleado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_emp_sueldo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_cargo_empleado = new System.Windows.Forms.TextBox();
            this.txt_apellido_empleado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nombre_empleado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id_empleado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.navegador1 = new CapaVista.Navegador();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.dataDepa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDepa)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_empleado_dept
            // 
            this.txt_empleado_dept.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_empleado_dept.Location = new System.Drawing.Point(419, 526);
            this.txt_empleado_dept.Name = "txt_empleado_dept";
            this.txt_empleado_dept.Size = new System.Drawing.Size(366, 32);
            this.txt_empleado_dept.TabIndex = 117;
            this.txt_empleado_dept.Tag = "tbl_departamento_Pk_id_departamento";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(419, 484);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(366, 30);
            this.dateTimePicker1.TabIndex = 116;
            this.dateTimePicker1.Tag = "emp_fecha_contratacion";
            // 
            // txt_telefono_empleado
            // 
            this.txt_telefono_empleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono_empleado.Location = new System.Drawing.Point(419, 446);
            this.txt_telefono_empleado.Name = "txt_telefono_empleado";
            this.txt_telefono_empleado.Size = new System.Drawing.Size(366, 32);
            this.txt_telefono_empleado.TabIndex = 115;
            this.txt_telefono_empleado.Tag = "emp_telefono";
            // 
            // txt_correo_empleado
            // 
            this.txt_correo_empleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_correo_empleado.Location = new System.Drawing.Point(419, 394);
            this.txt_correo_empleado.Name = "txt_correo_empleado";
            this.txt_correo_empleado.Size = new System.Drawing.Size(366, 32);
            this.txt_correo_empleado.TabIndex = 114;
            this.txt_correo_empleado.Tag = "emp_correo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(105, 525);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(221, 30);
            this.label9.TabIndex = 113;
            this.label9.Text = "Id_departamento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(105, 481);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(255, 30);
            this.label8.TabIndex = 112;
            this.label8.Text = "Fecha_contratacion";
            // 
            // txt_emp_sueldo
            // 
            this.txt_emp_sueldo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_emp_sueldo.Location = new System.Drawing.Point(419, 290);
            this.txt_emp_sueldo.Name = "txt_emp_sueldo";
            this.txt_emp_sueldo.Size = new System.Drawing.Size(366, 32);
            this.txt_emp_sueldo.TabIndex = 106;
            this.txt_emp_sueldo.Tag = "emp_sueldo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(105, 440);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 30);
            this.label7.TabIndex = 111;
            this.label7.Text = "Telefono";
            // 
            // txt_cargo_empleado
            // 
            this.txt_cargo_empleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cargo_empleado.Location = new System.Drawing.Point(419, 344);
            this.txt_cargo_empleado.Name = "txt_cargo_empleado";
            this.txt_cargo_empleado.Size = new System.Drawing.Size(366, 32);
            this.txt_cargo_empleado.TabIndex = 107;
            this.txt_cargo_empleado.Tag = "emp_cargo";
            // 
            // txt_apellido_empleado
            // 
            this.txt_apellido_empleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido_empleado.Location = new System.Drawing.Point(419, 239);
            this.txt_apellido_empleado.Name = "txt_apellido_empleado";
            this.txt_apellido_empleado.Size = new System.Drawing.Size(366, 32);
            this.txt_apellido_empleado.TabIndex = 104;
            this.txt_apellido_empleado.Tag = "emp_apellido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(104, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 30);
            this.label6.TabIndex = 110;
            this.label6.Text = "Correo";
            // 
            // txt_nombre_empleado
            // 
            this.txt_nombre_empleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_empleado.Location = new System.Drawing.Point(419, 190);
            this.txt_nombre_empleado.Name = "txt_nombre_empleado";
            this.txt_nombre_empleado.Size = new System.Drawing.Size(366, 32);
            this.txt_nombre_empleado.TabIndex = 100;
            this.txt_nombre_empleado.Tag = "emp_nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 30);
            this.label1.TabIndex = 101;
            this.label1.Text = "ID_Empleado";
            // 
            // txt_id_empleado
            // 
            this.txt_id_empleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_empleado.Location = new System.Drawing.Point(419, 142);
            this.txt_id_empleado.Name = "txt_id_empleado";
            this.txt_id_empleado.Size = new System.Drawing.Size(366, 32);
            this.txt_id_empleado.TabIndex = 99;
            this.txt_id_empleado.Tag = "Pk_id_empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 30);
            this.label2.TabIndex = 102;
            this.label2.Text = "Nombre_Empleado";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(125, 582);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(660, 153);
            this.dataGridView1.TabIndex = 108;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(105, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 30);
            this.label5.TabIndex = 109;
            this.label5.Text = "Sueldo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(105, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 30);
            this.label4.TabIndex = 105;
            this.label4.Text = "Apellido_Empleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 30);
            this.label3.TabIndex = 103;
            this.label3.Text = "Cargo";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(74, 18);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1121, 91);
            this.navegador1.TabIndex = 118;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.Controls.Add(this.dataDepa);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(819, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 268);
            this.panel1.TabIndex = 119;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(54, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(199, 30);
            this.label10.TabIndex = 120;
            this.label10.Text = "Departamentos";
            // 
            // dataDepa
            // 
            this.dataDepa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDepa.Location = new System.Drawing.Point(22, 85);
            this.dataDepa.Name = "dataDepa";
            this.dataDepa.RowHeadersVisible = false;
            this.dataDepa.RowHeadersWidth = 51;
            this.dataDepa.RowTemplate.Height = 24;
            this.dataDepa.Size = new System.Drawing.Size(270, 151);
            this.dataDepa.TabIndex = 120;
            // 
            // frm_mantenimiento_empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1247, 782);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.txt_empleado_dept);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txt_telefono_empleado);
            this.Controls.Add(this.txt_correo_empleado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_emp_sueldo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_cargo_empleado);
            this.Controls.Add(this.txt_apellido_empleado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_nombre_empleado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_id_empleado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "frm_mantenimiento_empleado";
            this.Text = "frm_mantenimiento_empleado";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDepa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_empleado_dept;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txt_telefono_empleado;
        private System.Windows.Forms.TextBox txt_correo_empleado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_emp_sueldo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_cargo_empleado;
        private System.Windows.Forms.TextBox txt_apellido_empleado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_nombre_empleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id_empleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private CapaVista.Navegador navegador1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataDepa;
    }
}