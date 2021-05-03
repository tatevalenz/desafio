
namespace desafio
{
    partial class ApocalipsisZombie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApocalipsisZombie));
            this.label1 = new System.Windows.Forms.Label();
            this.btnKatana = new System.Windows.Forms.Button();
            this.btnComida = new System.Windows.Forms.Button();
            this.btnVendaje = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 108);
            this.label1.TabIndex = 0;
            this.label1.Text = "Encuentras en un callejon tres objetos pero solo te puedes llevar uno...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKatana
            // 
            this.btnKatana.BackColor = System.Drawing.Color.Gray;
            this.btnKatana.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnKatana.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnKatana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKatana.Location = new System.Drawing.Point(295, 156);
            this.btnKatana.Name = "btnKatana";
            this.btnKatana.Size = new System.Drawing.Size(171, 35);
            this.btnKatana.TabIndex = 1;
            this.btnKatana.Text = "Una katana";
            this.btnKatana.UseVisualStyleBackColor = false;
            this.btnKatana.Click += new System.EventHandler(this.btnKatana_Click);
            // 
            // btnComida
            // 
            this.btnComida.BackColor = System.Drawing.Color.Gray;
            this.btnComida.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnComida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnComida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComida.Location = new System.Drawing.Point(295, 207);
            this.btnComida.Name = "btnComida";
            this.btnComida.Size = new System.Drawing.Size(171, 37);
            this.btnComida.TabIndex = 2;
            this.btnComida.Text = "Tres latas de comida";
            this.btnComida.UseVisualStyleBackColor = false;
            this.btnComida.Click += new System.EventHandler(this.btnComida_Click);
            // 
            // btnVendaje
            // 
            this.btnVendaje.BackColor = System.Drawing.Color.Gray;
            this.btnVendaje.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnVendaje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnVendaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendaje.Location = new System.Drawing.Point(295, 261);
            this.btnVendaje.Name = "btnVendaje";
            this.btnVendaje.Size = new System.Drawing.Size(171, 32);
            this.btnVendaje.TabIndex = 3;
            this.btnVendaje.Text = "Vendaje";
            this.btnVendaje.UseVisualStyleBackColor = false;
            this.btnVendaje.Click += new System.EventHandler(this.btnVendaje_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Gray;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(21, 398);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(114, 40);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Podes salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ApocalipsisZombie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVendaje);
            this.Controls.Add(this.btnComida);
            this.Controls.Add(this.btnKatana);
            this.Controls.Add(this.label1);
            this.Name = "ApocalipsisZombie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ApocalipsisZombie";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKatana;
        private System.Windows.Forms.Button btnComida;
        private System.Windows.Forms.Button btnVendaje;
        private System.Windows.Forms.Button btnSalir;
    }
}