namespace Matrices
{
    partial class Grafos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grafos));
            this.groupBoxMatriz1 = new System.Windows.Forms.GroupBox();
            this.btnCriarMatriz = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxMatrizResultante = new System.Windows.Forms.GroupBox();
            this.panelResultados = new System.Windows.Forms.Panel();
            this.btnBorrarR = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnCuadrado = new System.Windows.Forms.Button();
            this.btnTraspaso = new System.Windows.Forms.Button();
            this.btnOriginal = new System.Windows.Forms.Button();
            this.btnConexos = new System.Windows.Forms.Button();
            this.btnSumar = new System.Windows.Forms.Button();
            this.btnCaminos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnDijkstra = new System.Windows.Forms.Button();
            this.btnAdyacencia = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEjecutarDijkstra = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panelResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxMatriz1
            // 
            this.groupBoxMatriz1.Location = new System.Drawing.Point(12, 83);
            this.groupBoxMatriz1.Name = "groupBoxMatriz1";
            this.groupBoxMatriz1.Size = new System.Drawing.Size(286, 275);
            this.groupBoxMatriz1.TabIndex = 2;
            this.groupBoxMatriz1.TabStop = false;
            this.groupBoxMatriz1.Text = "Matriz de Adyacencia (Original)";
            this.groupBoxMatriz1.Leave += new System.EventHandler(this.groupBoxMatriz1_Leave);
            // 
            // btnCriarMatriz
            // 
            this.btnCriarMatriz.Location = new System.Drawing.Point(215, 35);
            this.btnCriarMatriz.Name = "btnCriarMatriz";
            this.btnCriarMatriz.Size = new System.Drawing.Size(75, 23);
            this.btnCriarMatriz.TabIndex = 1;
            this.btnCriarMatriz.Text = "Crear Matriz";
            this.btnCriarMatriz.UseVisualStyleBackColor = true;
            this.btnCriarMatriz.Click += new System.EventHandler(this.btnCriarMatriz_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(169, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(40, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ingrese numero de VERTICES";
            // 
            // groupBoxMatrizResultante
            // 
            this.groupBoxMatrizResultante.Location = new System.Drawing.Point(337, 83);
            this.groupBoxMatrizResultante.Name = "groupBoxMatrizResultante";
            this.groupBoxMatrizResultante.Size = new System.Drawing.Size(286, 275);
            this.groupBoxMatrizResultante.TabIndex = 1;
            this.groupBoxMatrizResultante.TabStop = false;
            this.groupBoxMatrizResultante.Text = "Matriz de Adyacencia (Resultados)";
            // 
            // panelResultados
            // 
            this.panelResultados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelResultados.Controls.Add(this.btnBorrarR);
            this.panelResultados.Controls.Add(this.btnCerrar);
            this.panelResultados.Controls.Add(this.richTextBox1);
            this.panelResultados.Location = new System.Drawing.Point(337, 83);
            this.panelResultados.Name = "panelResultados";
            this.panelResultados.Size = new System.Drawing.Size(286, 275);
            this.panelResultados.TabIndex = 22;
            this.panelResultados.Visible = false;
            // 
            // btnBorrarR
            // 
            this.btnBorrarR.Location = new System.Drawing.Point(111, 243);
            this.btnBorrarR.Name = "btnBorrarR";
            this.btnBorrarR.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarR.TabIndex = 1;
            this.btnBorrarR.Text = "Borrar";
            this.btnBorrarR.UseVisualStyleBackColor = true;
            this.btnBorrarR.Visible = false;
            this.btnBorrarR.Click += new System.EventHandler(this.btnBorrarR_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(111, 243);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(2, 1);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(280, 234);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnCuadrado
            // 
            this.btnCuadrado.Location = new System.Drawing.Point(537, 35);
            this.btnCuadrado.Name = "btnCuadrado";
            this.btnCuadrado.Size = new System.Drawing.Size(103, 23);
            this.btnCuadrado.TabIndex = 4;
            this.btnCuadrado.Text = "Elevar";
            this.btnCuadrado.UseVisualStyleBackColor = true;
            this.btnCuadrado.Click += new System.EventHandler(this.btnCuadrado_Click);
            // 
            // btnTraspaso
            // 
            this.btnTraspaso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraspaso.Location = new System.Drawing.Point(277, 364);
            this.btnTraspaso.Name = "btnTraspaso";
            this.btnTraspaso.Size = new System.Drawing.Size(75, 33);
            this.btnTraspaso.TabIndex = 8;
            this.btnTraspaso.Text = "←";
            this.btnTraspaso.UseVisualStyleBackColor = true;
            this.btnTraspaso.Click += new System.EventHandler(this.btnTraspaso_Click);
            // 
            // btnOriginal
            // 
            this.btnOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOriginal.Location = new System.Drawing.Point(7, 364);
            this.btnOriginal.Name = "btnOriginal";
            this.btnOriginal.Size = new System.Drawing.Size(75, 33);
            this.btnOriginal.TabIndex = 5;
            this.btnOriginal.Text = "Original";
            this.btnOriginal.UseVisualStyleBackColor = true;
            this.btnOriginal.Click += new System.EventHandler(this.btnOriginal_Click);
            // 
            // btnConexos
            // 
            this.btnConexos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConexos.Location = new System.Drawing.Point(169, 364);
            this.btnConexos.Name = "btnConexos";
            this.btnConexos.Size = new System.Drawing.Size(75, 33);
            this.btnConexos.TabIndex = 7;
            this.btnConexos.Text = "¿Conexos?";
            this.btnConexos.UseVisualStyleBackColor = true;
            this.btnConexos.Click += new System.EventHandler(this.btnConexos_Click);
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(88, 364);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(75, 33);
            this.btnSumar.TabIndex = 6;
            this.btnSumar.Text = "Sumar";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // btnCaminos
            // 
            this.btnCaminos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaminos.Location = new System.Drawing.Point(529, 364);
            this.btnCaminos.Name = "btnCaminos";
            this.btnCaminos.Size = new System.Drawing.Size(103, 41);
            this.btnCaminos.TabIndex = 10;
            this.btnCaminos.Text = "Cantidad de Caminos";
            this.btnCaminos.UseVisualStyleBackColor = true;
            this.btnCaminos.Click += new System.EventHandler(this.btnCaminos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ingrese numero de CAMINOS";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(430, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Borrar Resultados";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(416, 385);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(50, 20);
            this.numericUpDown1.TabIndex = 9;
            // 
            // btnDijkstra
            // 
            this.btnDijkstra.Location = new System.Drawing.Point(321, 35);
            this.btnDijkstra.Name = "btnDijkstra";
            this.btnDijkstra.Size = new System.Drawing.Size(103, 23);
            this.btnDijkstra.TabIndex = 23;
            this.btnDijkstra.Text = "Dijkstra";
            this.btnDijkstra.UseVisualStyleBackColor = true;
            this.btnDijkstra.Click += new System.EventHandler(this.btnDijkstra_Click);
            // 
            // btnAdyacencia
            // 
            this.btnAdyacencia.Location = new System.Drawing.Point(321, 35);
            this.btnAdyacencia.Name = "btnAdyacencia";
            this.btnAdyacencia.Size = new System.Drawing.Size(103, 23);
            this.btnAdyacencia.TabIndex = 24;
            this.btnAdyacencia.Text = "Adyacencia";
            this.btnAdyacencia.UseVisualStyleBackColor = true;
            this.btnAdyacencia.Visible = false;
            this.btnAdyacencia.Click += new System.EventHandler(this.btnAdyacencia_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Ingrese vertice de ORIGEN";
            this.label3.Visible = false;
            // 
            // btnEjecutarDijkstra
            // 
            this.btnEjecutarDijkstra.Location = new System.Drawing.Point(197, 364);
            this.btnEjecutarDijkstra.Name = "btnEjecutarDijkstra";
            this.btnEjecutarDijkstra.Size = new System.Drawing.Size(103, 41);
            this.btnEjecutarDijkstra.TabIndex = 26;
            this.btnEjecutarDijkstra.Text = "Ejecutar Dijkstra";
            this.btnEjecutarDijkstra.UseVisualStyleBackColor = true;
            this.btnEjecutarDijkstra.Visible = false;
            this.btnEjecutarDijkstra.Click += new System.EventHandler(this.btnEjecutarDijkstra_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(151, 372);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(40, 20);
            this.textBox2.TabIndex = 25;
            this.textBox2.Visible = false;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // Grafos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 428);
            this.Controls.Add(this.panelResultados);
            this.Controls.Add(this.btnAdyacencia);
            this.Controls.Add(this.btnDijkstra);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCaminos);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.btnConexos);
            this.Controls.Add(this.btnOriginal);
            this.Controls.Add(this.btnTraspaso);
            this.Controls.Add(this.btnCuadrado);
            this.Controls.Add(this.groupBoxMatrizResultante);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCriarMatriz);
            this.Controls.Add(this.groupBoxMatriz1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEjecutarDijkstra);
            this.Controls.Add(this.textBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Grafos";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grafos";
            this.panelResultados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMatriz1;
        private System.Windows.Forms.Button btnCriarMatriz;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxMatrizResultante;
        private System.Windows.Forms.Button btnCuadrado;
        private System.Windows.Forms.Button btnTraspaso;
        private System.Windows.Forms.Button btnOriginal;
        private System.Windows.Forms.Button btnConexos;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Button btnCaminos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelResultados;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnDijkstra;
        private System.Windows.Forms.Button btnAdyacencia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEjecutarDijkstra;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnBorrarR;
    }
}

