namespace Practica2
{
    partial class TSS
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
            this.CmdLeerRutaFija = new System.Windows.Forms.Button();
            this.TxtContenidoArchivo = new System.Windows.Forms.TextBox();
            this.CmdLeerArchivoConDialogo = new System.Windows.Forms.Button();
            this.cmdLlenarGrid = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DgvResultados = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdGenFile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvResultados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CmdLeerRutaFija
            // 
            this.CmdLeerRutaFija.Location = new System.Drawing.Point(38, 64);
            this.CmdLeerRutaFija.Name = "CmdLeerRutaFija";
            this.CmdLeerRutaFija.Size = new System.Drawing.Size(94, 23);
            this.CmdLeerRutaFija.TabIndex = 0;
            this.CmdLeerRutaFija.Text = "Leer Ruta";
            this.CmdLeerRutaFija.UseVisualStyleBackColor = true;
            this.CmdLeerRutaFija.Click += new System.EventHandler(this.CmdLeerRutaFija_Click);
            // 
            // TxtContenidoArchivo
            // 
            this.TxtContenidoArchivo.Location = new System.Drawing.Point(26, 112);
            this.TxtContenidoArchivo.Multiline = true;
            this.TxtContenidoArchivo.Name = "TxtContenidoArchivo";
            this.TxtContenidoArchivo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtContenidoArchivo.Size = new System.Drawing.Size(264, 200);
            this.TxtContenidoArchivo.TabIndex = 1;
            this.TxtContenidoArchivo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CmdLeerArchivoConDialogo
            // 
            this.CmdLeerArchivoConDialogo.Location = new System.Drawing.Point(156, 64);
            this.CmdLeerArchivoConDialogo.Name = "CmdLeerArchivoConDialogo";
            this.CmdLeerArchivoConDialogo.Size = new System.Drawing.Size(100, 23);
            this.CmdLeerArchivoConDialogo.TabIndex = 2;
            this.CmdLeerArchivoConDialogo.Text = "Leer Archivo";
            this.CmdLeerArchivoConDialogo.UseVisualStyleBackColor = true;
            this.CmdLeerArchivoConDialogo.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdLlenarGrid
            // 
            this.cmdLlenarGrid.Location = new System.Drawing.Point(358, 64);
            this.cmdLlenarGrid.Name = "cmdLlenarGrid";
            this.cmdLlenarGrid.Size = new System.Drawing.Size(96, 23);
            this.cmdLlenarGrid.TabIndex = 5;
            this.cmdLlenarGrid.Text = "Cargar Archivo";
            this.cmdLlenarGrid.UseVisualStyleBackColor = true;
            this.cmdLlenarGrid.Click += new System.EventHandler(this.cmdLlenarGrid_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(503, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Escribir Archivo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // DgvResultados
            // 
            this.DgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvResultados.Location = new System.Drawing.Point(319, 112);
            this.DgvResultados.Name = "DgvResultados";
            this.DgvResultados.Size = new System.Drawing.Size(331, 346);
            this.DgvResultados.TabIndex = 7;
            this.DgvResultados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmdGenFile);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpTo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpFrom);
            this.groupBox1.Location = new System.Drawing.Point(26, 326);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 132);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "LEER Y GUARDAR ";
            // 
            // cmdGenFile
            // 
            this.cmdGenFile.Location = new System.Drawing.Point(155, 35);
            this.cmdGenFile.Name = "cmdGenFile";
            this.cmdGenFile.Size = new System.Drawing.Size(75, 23);
            this.cmdGenFile.TabIndex = 9;
            this.cmdGenFile.Text = "&Generar";
            this.cmdGenFile.UseVisualStyleBackColor = true;
            this.cmdGenFile.Click += new System.EventHandler(this.cmdGenFile_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Hasta";
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(6, 103);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(224, 20);
            this.dtpTo.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Desde";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(9, 64);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(221, 20);
            this.dtpFrom.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "TESORERIA DE LA SEGURIDAD SOCIAL";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(56, 465);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 38);
            this.button2.TabIndex = 17;
            this.button2.Text = "XML";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TSS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 515);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgvResultados);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdLlenarGrid);
            this.Controls.Add(this.CmdLeerArchivoConDialogo);
            this.Controls.Add(this.TxtContenidoArchivo);
            this.Controls.Add(this.CmdLeerRutaFija);
            this.Name = "TSS";
            this.Text = "TSS";
            ((System.ComponentModel.ISupportInitialize)(this.DgvResultados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdLeerRutaFija;
        private System.Windows.Forms.TextBox TxtContenidoArchivo;
        private System.Windows.Forms.Button CmdLeerArchivoConDialogo;
        private System.Windows.Forms.Button cmdLlenarGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DgvResultados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Button cmdGenFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}

