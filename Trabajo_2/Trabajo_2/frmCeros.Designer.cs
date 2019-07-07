namespace Trabajo_2
{
    partial class frmCeros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCeros));
            this.textNumero = new System.Windows.Forms.TextBox();
            this.btnConvBinario = new System.Windows.Forms.Button();
            this.lblNumBinario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCantCeros = new System.Windows.Forms.Label();
            this.btnContarCeros = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBorrarCeros = new System.Windows.Forms.Button();
            this.btnSalirCeros = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblR = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblM = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textNumero
            // 
            this.textNumero.Location = new System.Drawing.Point(25, 41);
            this.textNumero.Name = "textNumero";
            this.textNumero.Size = new System.Drawing.Size(100, 20);
            this.textNumero.TabIndex = 0;
            // 
            // btnConvBinario
            // 
            this.btnConvBinario.Location = new System.Drawing.Point(179, 15);
            this.btnConvBinario.Name = "btnConvBinario";
            this.btnConvBinario.Size = new System.Drawing.Size(84, 49);
            this.btnConvBinario.TabIndex = 1;
            this.btnConvBinario.Text = "CONVERTIR EN BINARIO";
            this.btnConvBinario.UseVisualStyleBackColor = true;
            this.btnConvBinario.Click += new System.EventHandler(this.btnConvBinario_Click);
            // 
            // lblNumBinario
            // 
            this.lblNumBinario.BackColor = System.Drawing.SystemColors.Control;
            this.lblNumBinario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumBinario.Location = new System.Drawing.Point(314, 38);
            this.lblNumBinario.Name = "lblNumBinario";
            this.lblNumBinario.Size = new System.Drawing.Size(128, 23);
            this.lblNumBinario.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(22, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "INGRESE NUMERO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(322, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "NUMERO EN BINARIO";
            // 
            // lblCantCeros
            // 
            this.lblCantCeros.BackColor = System.Drawing.SystemColors.Control;
            this.lblCantCeros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantCeros.Location = new System.Drawing.Point(314, 86);
            this.lblCantCeros.Name = "lblCantCeros";
            this.lblCantCeros.Size = new System.Drawing.Size(128, 23);
            this.lblCantCeros.TabIndex = 5;
            // 
            // btnContarCeros
            // 
            this.btnContarCeros.Location = new System.Drawing.Point(179, 89);
            this.btnContarCeros.Name = "btnContarCeros";
            this.btnContarCeros.Size = new System.Drawing.Size(84, 46);
            this.btnContarCeros.TabIndex = 6;
            this.btnContarCeros.Text = "CONTAR CEROS";
            this.btnContarCeros.UseVisualStyleBackColor = true;
            this.btnContarCeros.Click += new System.EventHandler(this.btnContarCeros_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(322, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "CANTIDAD DE CEROS";
            // 
            // btnBorrarCeros
            // 
            this.btnBorrarCeros.Location = new System.Drawing.Point(22, 104);
            this.btnBorrarCeros.Name = "btnBorrarCeros";
            this.btnBorrarCeros.Size = new System.Drawing.Size(100, 31);
            this.btnBorrarCeros.TabIndex = 8;
            this.btnBorrarCeros.Text = "BORRAR";
            this.btnBorrarCeros.UseVisualStyleBackColor = true;
            this.btnBorrarCeros.Click += new System.EventHandler(this.btnBorrarCeros_Click);
            // 
            // btnSalirCeros
            // 
            this.btnSalirCeros.Location = new System.Drawing.Point(22, 166);
            this.btnSalirCeros.Name = "btnSalirCeros";
            this.btnSalirCeros.Size = new System.Drawing.Size(100, 29);
            this.btnSalirCeros.TabIndex = 9;
            this.btnSalirCeros.Text = "SALIR";
            this.btnSalirCeros.UseVisualStyleBackColor = true;
            this.btnSalirCeros.Click += new System.EventHandler(this.btnSalirCeros_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 46);
            this.button1.TabIndex = 10;
            this.button1.Text = "COMPROBAR CON...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(311, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "CANTIDAD DE REGISTROS";
            // 
            // lblR
            // 
            this.lblR.BackColor = System.Drawing.SystemColors.Control;
            this.lblR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblR.Location = new System.Drawing.Point(314, 138);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(128, 23);
            this.lblR.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(311, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "CANTIDAD DE MEMORIA";
            // 
            // lblM
            // 
            this.lblM.BackColor = System.Drawing.SystemColors.Control;
            this.lblM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblM.Location = new System.Drawing.Point(314, 190);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(128, 23);
            this.lblM.TabIndex = 13;
            // 
            // frmCeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(471, 229);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSalirCeros);
            this.Controls.Add(this.btnBorrarCeros);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnContarCeros);
            this.Controls.Add(this.lblCantCeros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNumBinario);
            this.Controls.Add(this.btnConvBinario);
            this.Controls.Add(this.textNumero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCeros";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cantidad De Ceros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNumero;
        private System.Windows.Forms.Button btnConvBinario;
        private System.Windows.Forms.Label lblNumBinario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCantCeros;
        private System.Windows.Forms.Button btnContarCeros;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBorrarCeros;
        private System.Windows.Forms.Button btnSalirCeros;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblM;
    }
}