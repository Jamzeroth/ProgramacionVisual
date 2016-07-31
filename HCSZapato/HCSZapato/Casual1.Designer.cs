namespace HCSZapato
{
    partial class Casual1
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
            this.txtEvento = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.txtTalla = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEvento
            // 
            this.txtEvento.Location = new System.Drawing.Point(87, 58);
            this.txtEvento.Name = "txtEvento";
            this.txtEvento.Size = new System.Drawing.Size(100, 20);
            this.txtEvento.TabIndex = 29;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(22, 61);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(41, 13);
            this.Label3.TabIndex = 28;
            this.Label3.Text = "Evento";
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(123, 103);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 23);
            this.Button1.TabIndex = 27;
            this.Button1.Text = "Mostrar";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(11, 103);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 26;
            this.btn.Text = "Ingresar";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // txtTalla
            // 
            this.txtTalla.Location = new System.Drawing.Point(87, 32);
            this.txtTalla.Name = "txtTalla";
            this.txtTalla.Size = new System.Drawing.Size(100, 20);
            this.txtTalla.TabIndex = 25;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(87, 6);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 24;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(22, 35);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(30, 13);
            this.Label2.TabIndex = 23;
            this.Label2.Text = "Talla";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(22, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(37, 13);
            this.Label1.TabIndex = 22;
            this.Label1.Text = "Marca";
            // 
            // Casual1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 139);
            this.Controls.Add(this.txtEvento);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.txtTalla);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "Casual1";
            this.Text = "Casual";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtEvento;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Button btn;
        internal System.Windows.Forms.TextBox txtTalla;
        internal System.Windows.Forms.TextBox txtMarca;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}