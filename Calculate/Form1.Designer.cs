namespace Calculate
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.tabForm = new System.Windows.Forms.TabControl();
            this.tbpCalculos = new System.Windows.Forms.TabPage();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.txtCCNum2 = new System.Windows.Forms.TextBox();
            this.lblOperacion = new System.Windows.Forms.Label();
            this.cmbOperacion = new System.Windows.Forms.ComboBox();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.txtCCNum1 = new System.Windows.Forms.TextBox();
            this.tbpConversion = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbConvertir = new System.Windows.Forms.ComboBox();
            this.txtVConvertir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbpCreador = new System.Windows.Forms.TabPage();
            this.btnCalConvertir = new System.Windows.Forms.Button();
            this.tabForm.SuspendLayout();
            this.tbpCalculos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbpConversion.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabForm
            // 
            this.tabForm.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tabForm.Controls.Add(this.tbpCalculos);
            this.tabForm.Controls.Add(this.tbpConversion);
            this.tabForm.Controls.Add(this.tbpCreador);
            this.tabForm.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabForm.Location = new System.Drawing.Point(12, 12);
            this.tabForm.Multiline = true;
            this.tabForm.Name = "tabForm";
            this.tabForm.SelectedIndex = 0;
            this.tabForm.Size = new System.Drawing.Size(374, 373);
            this.tabForm.TabIndex = 0;
            // 
            // tbpCalculos
            // 
            this.tbpCalculos.BackColor = System.Drawing.Color.White;
            this.tbpCalculos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbpCalculos.Controls.Add(this.btnCalcular);
            this.tbpCalculos.Controls.Add(this.groupBox1);
            this.tbpCalculos.Controls.Add(this.lblNum2);
            this.tbpCalculos.Controls.Add(this.txtCCNum2);
            this.tbpCalculos.Controls.Add(this.lblOperacion);
            this.tbpCalculos.Controls.Add(this.cmbOperacion);
            this.tbpCalculos.Controls.Add(this.lblNum1);
            this.tbpCalculos.Controls.Add(this.txtCCNum1);
            this.tbpCalculos.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpCalculos.Location = new System.Drawing.Point(4, 4);
            this.tbpCalculos.Name = "tbpCalculos";
            this.tbpCalculos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCalculos.Size = new System.Drawing.Size(366, 341);
            this.tbpCalculos.TabIndex = 0;
            this.tbpCalculos.Text = "Calculos";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(26, 180);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(307, 37);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtResultado);
            this.groupBox1.Location = new System.Drawing.Point(26, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultado";
            // 
            // txtResultado
            // 
            this.txtResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResultado.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.ForeColor = System.Drawing.Color.Green;
            this.txtResultado.Location = new System.Drawing.Point(7, 40);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(294, 37);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(24, 130);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(89, 23);
            this.lblNum2.TabIndex = 5;
            this.lblNum2.Text = "Numero 2:";
            // 
            // txtCCNum2
            // 
            this.txtCCNum2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCCNum2.Location = new System.Drawing.Point(125, 128);
            this.txtCCNum2.MaxLength = 10;
            this.txtCCNum2.Name = "txtCCNum2";
            this.txtCCNum2.Size = new System.Drawing.Size(208, 31);
            this.txtCCNum2.TabIndex = 4;
            this.txtCCNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCCNum2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCCNum2_KeyPress);
            // 
            // lblOperacion
            // 
            this.lblOperacion.AutoSize = true;
            this.lblOperacion.Location = new System.Drawing.Point(24, 77);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(95, 23);
            this.lblOperacion.TabIndex = 3;
            this.lblOperacion.Text = "Operación:";
            // 
            // cmbOperacion
            // 
            this.cmbOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperacion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbOperacion.FormattingEnabled = true;
            this.cmbOperacion.Items.AddRange(new object[] {
            "SUMA",
            "RESTA",
            "MULTIPLICACION",
            "DIVISION",
            "POTENCIA"});
            this.cmbOperacion.Location = new System.Drawing.Point(125, 74);
            this.cmbOperacion.Name = "cmbOperacion";
            this.cmbOperacion.Size = new System.Drawing.Size(208, 31);
            this.cmbOperacion.TabIndex = 2;
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(22, 22);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(86, 23);
            this.lblNum1.TabIndex = 1;
            this.lblNum1.Text = "Numero 1:";
            // 
            // txtCCNum1
            // 
            this.txtCCNum1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCCNum1.Location = new System.Drawing.Point(125, 20);
            this.txtCCNum1.MaxLength = 10;
            this.txtCCNum1.Name = "txtCCNum1";
            this.txtCCNum1.Size = new System.Drawing.Size(208, 31);
            this.txtCCNum1.TabIndex = 0;
            this.txtCCNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCCNum1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCCNum1_KeyPress);
            // 
            // tbpConversion
            // 
            this.tbpConversion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbpConversion.Controls.Add(this.btnCalConvertir);
            this.tbpConversion.Controls.Add(this.groupBox2);
            this.tbpConversion.Controls.Add(this.label2);
            this.tbpConversion.Controls.Add(this.cmbConvertir);
            this.tbpConversion.Controls.Add(this.txtVConvertir);
            this.tbpConversion.Controls.Add(this.label1);
            this.tbpConversion.Location = new System.Drawing.Point(4, 4);
            this.tbpConversion.Name = "tbpConversion";
            this.tbpConversion.Padding = new System.Windows.Forms.Padding(3);
            this.tbpConversion.Size = new System.Drawing.Size(366, 341);
            this.tbpConversion.TabIndex = 1;
            this.tbpConversion.Text = "Conversión";
            this.tbpConversion.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtResult);
            this.groupBox2.Location = new System.Drawing.Point(13, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 114);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado";
            // 
            // txtResult
            // 
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResult.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(6, 48);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(327, 30);
            this.txtResult.TabIndex = 0;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Convertir a:";
            // 
            // cmbConvertir
            // 
            this.cmbConvertir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConvertir.FormattingEnabled = true;
            this.cmbConvertir.Items.AddRange(new object[] {
            "DECIMAL - BINARIO",
            "BINARIO - DECIMAL",
            "BINARIO - HEXADECIMAL",
            "HEXADECIMAL - BINARIO",
            "HEXADECIMAL - DECIMAL",
            "DECIMAL - HEXADECIMAL"});
            this.cmbConvertir.Location = new System.Drawing.Point(13, 119);
            this.cmbConvertir.Name = "cmbConvertir";
            this.cmbConvertir.Size = new System.Drawing.Size(339, 27);
            this.cmbConvertir.TabIndex = 2;
            // 
            // txtVConvertir
            // 
            this.txtVConvertir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVConvertir.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVConvertir.Location = new System.Drawing.Point(13, 47);
            this.txtVConvertir.Name = "txtVConvertir";
            this.txtVConvertir.Size = new System.Drawing.Size(338, 31);
            this.txtVConvertir.TabIndex = 1;
            this.txtVConvertir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor a Convertir:";
            // 
            // tbpCreador
            // 
            this.tbpCreador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbpCreador.Location = new System.Drawing.Point(4, 4);
            this.tbpCreador.Name = "tbpCreador";
            this.tbpCreador.Size = new System.Drawing.Size(366, 341);
            this.tbpCreador.TabIndex = 2;
            this.tbpCreador.Text = "Creador";
            this.tbpCreador.UseVisualStyleBackColor = true;
            // 
            // btnCalConvertir
            // 
            this.btnCalConvertir.Location = new System.Drawing.Point(195, 161);
            this.btnCalConvertir.Name = "btnCalConvertir";
            this.btnCalConvertir.Size = new System.Drawing.Size(156, 35);
            this.btnCalConvertir.TabIndex = 5;
            this.btnCalConvertir.Text = "Calcular";
            this.btnCalConvertir.UseVisualStyleBackColor = true;
            this.btnCalConvertir.Click += new System.EventHandler(this.btnCalConvertir_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(398, 397);
            this.Controls.Add(this.tabForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.tabForm.ResumeLayout(false);
            this.tbpCalculos.ResumeLayout(false);
            this.tbpCalculos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbpConversion.ResumeLayout(false);
            this.tbpConversion.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabForm;
        private System.Windows.Forms.TabPage tbpCalculos;
        private System.Windows.Forms.TabPage tbpConversion;
        private System.Windows.Forms.TabPage tbpCreador;
        private System.Windows.Forms.TextBox txtCCNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.TextBox txtCCNum2;
        private System.Windows.Forms.Label lblOperacion;
        private System.Windows.Forms.ComboBox cmbOperacion;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtVConvertir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbConvertir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnCalConvertir;
    }
}

