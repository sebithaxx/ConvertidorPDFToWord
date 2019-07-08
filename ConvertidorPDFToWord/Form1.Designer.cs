namespace ConvertidorPDFToWord
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnArchivoOrigen = new System.Windows.Forms.Button();
            this.btnCarpetaDestino = new System.Windows.Forms.Button();
            this.btnConvertirWord = new System.Windows.Forms.Button();
            this.txtArchivoOrigen = new System.Windows.Forms.TextBox();
            this.txtCarpetaDestino = new System.Windows.Forms.TextBox();
            this.ROJO = new System.Windows.Forms.Label();
            this.AZUL = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Archivo de Origen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Carpeta Destino:";
            // 
            // btnArchivoOrigen
            // 
            this.btnArchivoOrigen.Location = new System.Drawing.Point(445, 60);
            this.btnArchivoOrigen.Name = "btnArchivoOrigen";
            this.btnArchivoOrigen.Size = new System.Drawing.Size(25, 23);
            this.btnArchivoOrigen.TabIndex = 2;
            this.btnArchivoOrigen.Text = "...";
            this.btnArchivoOrigen.UseVisualStyleBackColor = true;
            this.btnArchivoOrigen.Click += new System.EventHandler(this.btnArchivoOrigen_Click);
            // 
            // btnCarpetaDestino
            // 
            this.btnCarpetaDestino.Location = new System.Drawing.Point(445, 92);
            this.btnCarpetaDestino.Name = "btnCarpetaDestino";
            this.btnCarpetaDestino.Size = new System.Drawing.Size(25, 23);
            this.btnCarpetaDestino.TabIndex = 3;
            this.btnCarpetaDestino.Text = "...";
            this.btnCarpetaDestino.UseVisualStyleBackColor = true;
            this.btnCarpetaDestino.Click += new System.EventHandler(this.btnCarpetaDestino_Click);
            // 
            // btnConvertirWord
            // 
            this.btnConvertirWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertirWord.Location = new System.Drawing.Point(220, 289);
            this.btnConvertirWord.Name = "btnConvertirWord";
            this.btnConvertirWord.Size = new System.Drawing.Size(121, 35);
            this.btnConvertirWord.TabIndex = 4;
            this.btnConvertirWord.Text = "Convertir";
            this.btnConvertirWord.UseVisualStyleBackColor = true;
            this.btnConvertirWord.Click += new System.EventHandler(this.btnConvertirWord_Click);
            // 
            // txtArchivoOrigen
            // 
            this.txtArchivoOrigen.Location = new System.Drawing.Point(122, 63);
            this.txtArchivoOrigen.Name = "txtArchivoOrigen";
            this.txtArchivoOrigen.Size = new System.Drawing.Size(317, 20);
            this.txtArchivoOrigen.TabIndex = 5;
            // 
            // txtCarpetaDestino
            // 
            this.txtCarpetaDestino.Location = new System.Drawing.Point(122, 97);
            this.txtCarpetaDestino.Name = "txtCarpetaDestino";
            this.txtCarpetaDestino.Size = new System.Drawing.Size(317, 20);
            this.txtCarpetaDestino.TabIndex = 6;
            // 
            // ROJO
            // 
            this.ROJO.AutoSize = true;
            this.ROJO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ROJO.ForeColor = System.Drawing.Color.Red;
            this.ROJO.Location = new System.Drawing.Point(476, 59);
            this.ROJO.Name = "ROJO";
            this.ROJO.Size = new System.Drawing.Size(50, 24);
            this.ROJO.TabIndex = 7;
            this.ROJO.Text = "PDF";
            // 
            // AZUL
            // 
            this.AZUL.AutoSize = true;
            this.AZUL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AZUL.ForeColor = System.Drawing.Color.Blue;
            this.AZUL.Location = new System.Drawing.Point(476, 89);
            this.AZUL.Name = "AZUL";
            this.AZUL.Size = new System.Drawing.Size(60, 24);
            this.AZUL.TabIndex = 8;
            this.AZUL.Text = "Word";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(122, 230);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(317, 41);
            this.progressBar1.TabIndex = 10;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(526, 289);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 19);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ConvertidorPDFToWord.Properties.Resources.danikdak;
            this.pictureBox2.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(583, 31);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ConvertidorPDFToWord.Properties.Resources.capturas;
            this.pictureBox1.Location = new System.Drawing.Point(122, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 90);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Image = global::ConvertidorPDFToWord.Properties.Resources.rfefer;
            this.button1.Location = new System.Drawing.Point(547, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 31);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(574, 336);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AZUL);
            this.Controls.Add(this.ROJO);
            this.Controls.Add(this.txtCarpetaDestino);
            this.Controls.Add(this.txtArchivoOrigen);
            this.Controls.Add(this.btnConvertirWord);
            this.Controls.Add(this.btnCarpetaDestino);
            this.Controls.Add(this.btnArchivoOrigen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnArchivoOrigen;
        private System.Windows.Forms.Button btnCarpetaDestino;
        private System.Windows.Forms.Button btnConvertirWord;
        private System.Windows.Forms.TextBox txtArchivoOrigen;
        private System.Windows.Forms.TextBox txtCarpetaDestino;
        private System.Windows.Forms.Label ROJO;
        private System.Windows.Forms.Label AZUL;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button1;
    }
}

