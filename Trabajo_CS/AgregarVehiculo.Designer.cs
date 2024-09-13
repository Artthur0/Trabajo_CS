namespace Trabajo_CS
{
    partial class AgregarVehiculo
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("f");
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tx_pre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tx_kil = new System.Windows.Forms.TextBox();
            this.tx_year = new System.Windows.Forms.TextBox();
            this.tx_mod = new System.Windows.Forms.TextBox();
            this.tx_mar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tx_pre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tx_kil);
            this.groupBox1.Controls.Add(this.tx_year);
            this.groupBox1.Controls.Add(this.tx_mod);
            this.groupBox1.Controls.Add(this.tx_mar);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 284);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vehiculo";
            // 
            // tx_pre
            // 
            this.tx_pre.Location = new System.Drawing.Point(111, 191);
            this.tx_pre.Margin = new System.Windows.Forms.Padding(2);
            this.tx_pre.Name = "tx_pre";
            this.tx_pre.Size = new System.Drawing.Size(99, 22);
            this.tx_pre.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 197);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Precio:";
            // 
            // tx_kil
            // 
            this.tx_kil.Location = new System.Drawing.Point(111, 154);
            this.tx_kil.Margin = new System.Windows.Forms.Padding(2);
            this.tx_kil.Name = "tx_kil";
            this.tx_kil.Size = new System.Drawing.Size(99, 22);
            this.tx_kil.TabIndex = 9;
            // 
            // tx_year
            // 
            this.tx_year.Location = new System.Drawing.Point(111, 115);
            this.tx_year.Margin = new System.Windows.Forms.Padding(2);
            this.tx_year.Name = "tx_year";
            this.tx_year.Size = new System.Drawing.Size(99, 22);
            this.tx_year.TabIndex = 8;
            // 
            // tx_mod
            // 
            this.tx_mod.Location = new System.Drawing.Point(111, 76);
            this.tx_mod.Margin = new System.Windows.Forms.Padding(2);
            this.tx_mod.Name = "tx_mod";
            this.tx_mod.Size = new System.Drawing.Size(99, 22);
            this.tx_mod.TabIndex = 7;
            // 
            // tx_mar
            // 
            this.tx_mar.Location = new System.Drawing.Point(111, 39);
            this.tx_mar.Margin = new System.Windows.Forms.Padding(2);
            this.tx_mar.Name = "tx_mar";
            this.tx_mar.Size = new System.Drawing.Size(99, 22);
            this.tx_mar.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kilometraje:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Año:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca: ";
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.HoverSelection = true;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(17, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(257, 249);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(321, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 284);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listado";
            // 
            // AgregarVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 348);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AgregarVehiculo";
            this.Text = "AgregarVehiculo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tx_kil;
        private System.Windows.Forms.TextBox tx_year;
        private System.Windows.Forms.TextBox tx_mod;
        private System.Windows.Forms.TextBox tx_mar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tx_pre;
        private System.Windows.Forms.Label label5;
    }
}