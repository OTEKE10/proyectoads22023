﻿
namespace CapaVistaNomina
{
    partial class frm_mantenimiento_departamento
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id_departamento = new System.Windows.Forms.TextBox();
            this.txt_nombre_empleado = new System.Windows.Forms.TextBox();
            this.navegador1 = new CapaVista.Navegador();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(57, 303);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(674, 229);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 30);
            this.label1.TabIndex = 80;
            this.label1.Tag = "Pk_id_departamento";
            this.label1.Text = "ID_Departamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(370, 38);
            this.label2.TabIndex = 81;
            this.label2.Tag = "";
            this.label2.Text = "Nombre_departamento";
            // 
            // txt_id_departamento
            // 
            this.txt_id_departamento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_departamento.Location = new System.Drawing.Point(365, 153);
            this.txt_id_departamento.Name = "txt_id_departamento";
            this.txt_id_departamento.Size = new System.Drawing.Size(366, 32);
            this.txt_id_departamento.TabIndex = 82;
            this.txt_id_departamento.Tag = "Pk_id_departamento";
            // 
            // txt_nombre_empleado
            // 
            this.txt_nombre_empleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_empleado.Location = new System.Drawing.Point(365, 212);
            this.txt_nombre_empleado.Name = "txt_nombre_empleado";
            this.txt_nombre_empleado.Size = new System.Drawing.Size(366, 32);
            this.txt_nombre_empleado.TabIndex = 83;
            this.txt_nombre_empleado.Tag = "dpt_nombre";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(20, 12);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1004, 119);
            this.navegador1.TabIndex = 84;
            // 
            // frm_mantenimiento_departamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 614);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.txt_nombre_empleado);
            this.Controls.Add(this.txt_id_departamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frm_mantenimiento_departamento";
            this.Text = "frm_mantenimiento_departamento";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id_departamento;
        private System.Windows.Forms.TextBox txt_nombre_empleado;
        private CapaVista.Navegador navegador1;
    }
}