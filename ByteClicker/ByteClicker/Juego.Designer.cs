namespace ByteClicker
{
    partial class Juego
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbPuntaje = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbNivelTeclado = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbPrecioTeclado = new System.Windows.Forms.Label();
            this.btnTeclado = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbNivelCursor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPrecioCursor = new System.Windows.Forms.Label();
            this.btnClicks = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMultiplicador = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ByteClicker.Properties.Resources.Cursor;
            this.pictureBox1.Location = new System.Drawing.Point(133, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::ByteClicker.Properties.Resources.BitCoinCantidadJuego;
            this.pictureBox2.Location = new System.Drawing.Point(45, 327);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(346, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lbPuntaje
            // 
            this.lbPuntaje.BackColor = System.Drawing.Color.White;
            this.lbPuntaje.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPuntaje.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbPuntaje.Location = new System.Drawing.Point(94, 340);
            this.lbPuntaje.Name = "lbPuntaje";
            this.lbPuntaje.Size = new System.Drawing.Size(286, 23);
            this.lbPuntaje.TabIndex = 2;
            this.lbPuntaje.Text = "0";
            this.lbPuntaje.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(467, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 442);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbNivelTeclado);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnTeclado);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lbPrecioTeclado);
            this.groupBox3.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(6, 108);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 83);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TECLADO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "LEVEL";
            // 
            // lbNivelTeclado
            // 
            this.lbNivelTeclado.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNivelTeclado.Location = new System.Drawing.Point(13, 35);
            this.lbNivelTeclado.Name = "lbNivelTeclado";
            this.lbNivelTeclado.Size = new System.Drawing.Size(52, 35);
            this.lbNivelTeclado.TabIndex = 1;
            this.lbNivelTeclado.Text = "0";
            this.lbNivelTeclado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "$ PRECIO:";
            // 
            // lbPrecioTeclado
            // 
            this.lbPrecioTeclado.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecioTeclado.Location = new System.Drawing.Point(163, 51);
            this.lbPrecioTeclado.Name = "lbPrecioTeclado";
            this.lbPrecioTeclado.Size = new System.Drawing.Size(153, 24);
            this.lbPrecioTeclado.TabIndex = 2;
            this.lbPrecioTeclado.Text = "100";
            this.lbPrecioTeclado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnTeclado
            // 
            this.btnTeclado.BackColor = System.Drawing.Color.Silver;
            this.btnTeclado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTeclado.Location = new System.Drawing.Point(84, 11);
            this.btnTeclado.Name = "btnTeclado";
            this.btnTeclado.Size = new System.Drawing.Size(228, 41);
            this.btnTeclado.TabIndex = 0;
            this.btnTeclado.Text = "Mejorar";
            this.btnTeclado.UseVisualStyleBackColor = false;
            this.btnTeclado.Click += new System.EventHandler(this.btnTeclado_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lbNivelCursor);
            this.groupBox2.Controls.Add(this.lbPrecioCursor);
            this.groupBox2.Controls.Add(this.btnClicks);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 83);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CURSOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "LEVEL";
            // 
            // lbNivelCursor
            // 
            this.lbNivelCursor.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNivelCursor.Location = new System.Drawing.Point(13, 36);
            this.lbNivelCursor.Name = "lbNivelCursor";
            this.lbNivelCursor.Size = new System.Drawing.Size(52, 35);
            this.lbNivelCursor.TabIndex = 1;
            this.lbNivelCursor.Text = "0";
            this.lbNivelCursor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "$ PRECIO:";
            // 
            // lbPrecioCursor
            // 
            this.lbPrecioCursor.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecioCursor.Location = new System.Drawing.Point(163, 51);
            this.lbPrecioCursor.Name = "lbPrecioCursor";
            this.lbPrecioCursor.Size = new System.Drawing.Size(153, 26);
            this.lbPrecioCursor.TabIndex = 2;
            this.lbPrecioCursor.Text = "10";
            this.lbPrecioCursor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClicks
            // 
            this.btnClicks.BackColor = System.Drawing.Color.Silver;
            this.btnClicks.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClicks.Location = new System.Drawing.Point(84, 11);
            this.btnClicks.Name = "btnClicks";
            this.btnClicks.Size = new System.Drawing.Size(228, 41);
            this.btnClicks.TabIndex = 0;
            this.btnClicks.Text = "Mejorar";
            this.btnClicks.UseVisualStyleBackColor = false;
            this.btnClicks.Click += new System.EventHandler(this.btnClicks_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(96, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Por segundo: ";
            // 
            // lbMultiplicador
            // 
            this.lbMultiplicador.BackColor = System.Drawing.Color.Transparent;
            this.lbMultiplicador.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMultiplicador.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbMultiplicador.Location = new System.Drawing.Point(225, 380);
            this.lbMultiplicador.Name = "lbMultiplicador";
            this.lbMultiplicador.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbMultiplicador.Size = new System.Drawing.Size(155, 18);
            this.lbMultiplicador.TabIndex = 5;
            this.lbMultiplicador.Text = "0";
            this.lbMultiplicador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbMultiplicador.UseMnemonic = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(174, 254);
            this.maskedTextBox1.Mask = "000.000.000.000.000.000.000.000.000.000.000.000.000.000.000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 5;
            // 
            // Juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ByteClicker.Properties.Resources.Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(813, 466);
            this.Controls.Add(this.lbMultiplicador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbPuntaje);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Juego";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ByteClicker";
            this.Load += new System.EventHandler(this.Juego_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbPuntaje;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbNivelCursor;
        private System.Windows.Forms.Button btnClicks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbPrecioCursor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMultiplicador;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbNivelTeclado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbPrecioTeclado;
        private System.Windows.Forms.Button btnTeclado;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}

