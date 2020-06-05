namespace ComisionesDU
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DgvComisiones = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textCasa = new System.Windows.Forms.TextBox();
            this.textPorcCobroDentroPeriodo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textDiasCobroDentroPeriodo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textPorcCobroFueraPeriodo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textDiasCobroFueraPeriodo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvComisiones)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvComisiones
            // 
            this.DgvComisiones.AllowUserToAddRows = false;
            this.DgvComisiones.AllowUserToDeleteRows = false;
            this.DgvComisiones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvComisiones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvComisiones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvComisiones.ColumnHeadersHeight = 50;
            this.DgvComisiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvComisiones.EnableHeadersVisualStyles = false;
            this.DgvComisiones.Location = new System.Drawing.Point(301, 63);
            this.DgvComisiones.Name = "DgvComisiones";
            this.DgvComisiones.ReadOnly = true;
            this.DgvComisiones.RowHeadersVisible = false;
            this.DgvComisiones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvComisiones.Size = new System.Drawing.Size(868, 469);
            this.DgvComisiones.TabIndex = 0;
            this.DgvComisiones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvComisiones_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Casa :";
            // 
            // textCasa
            // 
            this.textCasa.Location = new System.Drawing.Point(70, 78);
            this.textCasa.Name = "textCasa";
            this.textCasa.ReadOnly = true;
            this.textCasa.Size = new System.Drawing.Size(153, 20);
            this.textCasa.TabIndex = 2;
            // 
            // textPorcCobroDentroPeriodo
            // 
            this.textPorcCobroDentroPeriodo.Location = new System.Drawing.Point(211, 126);
            this.textPorcCobroDentroPeriodo.Name = "textPorcCobroDentroPeriodo";
            this.textPorcCobroDentroPeriodo.Size = new System.Drawing.Size(44, 20);
            this.textPorcCobroDentroPeriodo.TabIndex = 4;
            this.textPorcCobroDentroPeriodo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPorcCobroDentroPeriodo_KeyPress);
            this.textPorcCobroDentroPeriodo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textPorcCobroDentroPeriodo_KeyUp);
            this.textPorcCobroDentroPeriodo.Validating += new System.ComponentModel.CancelEventHandler(this.textPorcCobroDentroPeriodo_Validating);
            this.textPorcCobroDentroPeriodo.Validated += new System.EventHandler(this.textPorcCobroDentroPeriodo_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Porc_Cobro_Dentro_Periodo :";
            // 
            // textDiasCobroDentroPeriodo
            // 
            this.textDiasCobroDentroPeriodo.Location = new System.Drawing.Point(211, 172);
            this.textDiasCobroDentroPeriodo.Name = "textDiasCobroDentroPeriodo";
            this.textDiasCobroDentroPeriodo.Size = new System.Drawing.Size(44, 20);
            this.textDiasCobroDentroPeriodo.TabIndex = 6;
            this.textDiasCobroDentroPeriodo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDiasCobroDentroPeriodo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dias_Cobro_Dentro_Periodo :";
            // 
            // textPorcCobroFueraPeriodo
            // 
            this.textPorcCobroFueraPeriodo.Location = new System.Drawing.Point(211, 220);
            this.textPorcCobroFueraPeriodo.Name = "textPorcCobroFueraPeriodo";
            this.textPorcCobroFueraPeriodo.Size = new System.Drawing.Size(44, 20);
            this.textPorcCobroFueraPeriodo.TabIndex = 8;
            this.textPorcCobroFueraPeriodo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPorcCobroFueraPeriodo_KeyPress);
            this.textPorcCobroFueraPeriodo.Validating += new System.ComponentModel.CancelEventHandler(this.textPorcCobroFueraPeriodo_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Porc_Cobro_Fuera_Periodo :";
            // 
            // textDiasCobroFueraPeriodo
            // 
            this.textDiasCobroFueraPeriodo.Location = new System.Drawing.Point(211, 270);
            this.textDiasCobroFueraPeriodo.Name = "textDiasCobroFueraPeriodo";
            this.textDiasCobroFueraPeriodo.Size = new System.Drawing.Size(44, 20);
            this.textDiasCobroFueraPeriodo.TabIndex = 10;
            this.textDiasCobroFueraPeriodo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDiasCobroFueraPeriodo_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Dias_Cobro_Fuera_Periodo :";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.Location = new System.Drawing.Point(30, 352);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(85, 34);
            this.buttonGuardar.TabIndex = 11;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.Location = new System.Drawing.Point(131, 352);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 34);
            this.buttonSalir.TabIndex = 12;
            this.buttonSalir.TabStop = false;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(261, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Dias";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(262, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Dias";
            // 
            // textid
            // 
            this.textid.Location = new System.Drawing.Point(229, 75);
            this.textid.Name = "textid";
            this.textid.ReadOnly = true;
            this.textid.Size = new System.Drawing.Size(29, 20);
            this.textid.TabIndex = 17;
            this.textid.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 6F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(68, 454);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 12);
            this.label10.TabIndex = 18;
            this.label10.Text = "Developer Carlos Velasquez ®";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 429);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(258, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "Todos los Derechos Drogueria Universal ® 2020";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 537);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.textDiasCobroFueraPeriodo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textPorcCobroFueraPeriodo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textDiasCobroDentroPeriodo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textPorcCobroDentroPeriodo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textCasa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvComisiones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimineto de Comisiones";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvComisiones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvComisiones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCasa;
        private System.Windows.Forms.TextBox textPorcCobroDentroPeriodo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textDiasCobroDentroPeriodo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPorcCobroFueraPeriodo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textDiasCobroFueraPeriodo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

