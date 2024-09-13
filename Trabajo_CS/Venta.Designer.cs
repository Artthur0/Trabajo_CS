namespace Trabajo_CS
{
    partial class Venta
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxcliente = new System.Windows.Forms.ComboBox();
            this.cbxvehiculo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_dinero = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(309, 149);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione al Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione el Vehiculo";
            // 
            // cbxcliente
            // 
            this.cbxcliente.FormattingEnabled = true;
            this.cbxcliente.Location = new System.Drawing.Point(37, 65);
            this.cbxcliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxcliente.Name = "cbxcliente";
            this.cbxcliente.Size = new System.Drawing.Size(160, 24);
            this.cbxcliente.TabIndex = 3;
            // 
            // cbxvehiculo
            // 
            this.cbxvehiculo.FormattingEnabled = true;
            this.cbxvehiculo.Location = new System.Drawing.Point(279, 65);
            this.cbxvehiculo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxvehiculo.Name = "cbxvehiculo";
            this.cbxvehiculo.Size = new System.Drawing.Size(167, 24);
            this.cbxvehiculo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ingrese Precio";
            // 
            // tb_dinero
            // 
            this.tb_dinero.Location = new System.Drawing.Point(37, 160);
            this.tb_dinero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_dinero.Name = "tb_dinero";
            this.tb_dinero.Size = new System.Drawing.Size(169, 22);
            this.tb_dinero.TabIndex = 7;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(37, 240);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(415, 164);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.tb_dinero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxvehiculo);
            this.Controls.Add(this.cbxcliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Venta";
            this.Text = "Venta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxcliente;
        private System.Windows.Forms.ComboBox cbxvehiculo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_dinero;
        private System.Windows.Forms.ListView listView1;
    }
}