namespace PanaderiaRepo
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ClientDataView = new System.Windows.Forms.DataGridView();
            this.IdClientLabel = new System.Windows.Forms.Label();
            this.NameClientLabel = new System.Windows.Forms.Label();
            this.NameClientTextBox = new System.Windows.Forms.TextBox();
            this.AddClientButton = new System.Windows.Forms.Button();
            this.UpdateClientButton = new System.Windows.Forms.Button();
            this.DeleteClientButton = new System.Windows.Forms.Button();
            this.LastNameClientLabel = new System.Windows.Forms.Label();
            this.PhoneClientLabel = new System.Windows.Forms.Label();
            this.PhoneClientTextBox = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.LastNameClientTextBox = new System.Windows.Forms.TextBox();
            this.IdClientTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(65, 302);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(755, 136);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Producto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 457);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 486);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 515);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Recepcionista";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(109, 483);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(840, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(840, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(840, 374);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(840, 404);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Buscar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // ClientDataView
            // 
            this.ClientDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientDataView.Location = new System.Drawing.Point(65, 12);
            this.ClientDataView.Name = "ClientDataView";
            this.ClientDataView.Size = new System.Drawing.Size(755, 150);
            this.ClientDataView.TabIndex = 11;
            // 
            // IdClientLabel
            // 
            this.IdClientLabel.AutoSize = true;
            this.IdClientLabel.Location = new System.Drawing.Point(16, 181);
            this.IdClientLabel.Name = "IdClientLabel";
            this.IdClientLabel.Size = new System.Drawing.Size(16, 13);
            this.IdClientLabel.TabIndex = 12;
            this.IdClientLabel.Text = "Id";
            // 
            // NameClientLabel
            // 
            this.NameClientLabel.AutoSize = true;
            this.NameClientLabel.Location = new System.Drawing.Point(16, 212);
            this.NameClientLabel.Name = "NameClientLabel";
            this.NameClientLabel.Size = new System.Drawing.Size(44, 13);
            this.NameClientLabel.TabIndex = 15;
            this.NameClientLabel.Text = "Nombre";
            // 
            // NameClientTextBox
            // 
            this.NameClientTextBox.Location = new System.Drawing.Point(80, 207);
            this.NameClientTextBox.Name = "NameClientTextBox";
            this.NameClientTextBox.Size = new System.Drawing.Size(129, 20);
            this.NameClientTextBox.TabIndex = 16;
            // 
            // AddClientButton
            // 
            this.AddClientButton.Location = new System.Drawing.Point(840, 24);
            this.AddClientButton.Name = "AddClientButton";
            this.AddClientButton.Size = new System.Drawing.Size(88, 23);
            this.AddClientButton.TabIndex = 17;
            this.AddClientButton.Text = "Agregar";
            this.AddClientButton.UseVisualStyleBackColor = true;
            this.AddClientButton.Click += new System.EventHandler(this.AddClientButton_Click);
            // 
            // UpdateClientButton
            // 
            this.UpdateClientButton.Location = new System.Drawing.Point(840, 53);
            this.UpdateClientButton.Name = "UpdateClientButton";
            this.UpdateClientButton.Size = new System.Drawing.Size(88, 23);
            this.UpdateClientButton.TabIndex = 18;
            this.UpdateClientButton.Text = "Editar";
            this.UpdateClientButton.UseVisualStyleBackColor = true;
            this.UpdateClientButton.Click += new System.EventHandler(this.UpdateClientButton_Click);
            // 
            // DeleteClientButton
            // 
            this.DeleteClientButton.Location = new System.Drawing.Point(840, 82);
            this.DeleteClientButton.Name = "DeleteClientButton";
            this.DeleteClientButton.Size = new System.Drawing.Size(88, 23);
            this.DeleteClientButton.TabIndex = 19;
            this.DeleteClientButton.Text = "Eliminar";
            this.DeleteClientButton.UseVisualStyleBackColor = true;
            this.DeleteClientButton.Click += new System.EventHandler(this.DeleteClientButton_Click);
            // 
            // LastNameClientLabel
            // 
            this.LastNameClientLabel.AutoSize = true;
            this.LastNameClientLabel.Location = new System.Drawing.Point(16, 238);
            this.LastNameClientLabel.Name = "LastNameClientLabel";
            this.LastNameClientLabel.Size = new System.Drawing.Size(44, 13);
            this.LastNameClientLabel.TabIndex = 20;
            this.LastNameClientLabel.Text = "Apellido";
            // 
            // PhoneClientLabel
            // 
            this.PhoneClientLabel.AutoSize = true;
            this.PhoneClientLabel.Location = new System.Drawing.Point(17, 270);
            this.PhoneClientLabel.Name = "PhoneClientLabel";
            this.PhoneClientLabel.Size = new System.Drawing.Size(49, 13);
            this.PhoneClientLabel.TabIndex = 22;
            this.PhoneClientLabel.Text = "Teléfono";
            // 
            // PhoneClientTextBox
            // 
            this.PhoneClientTextBox.Location = new System.Drawing.Point(80, 263);
            this.PhoneClientTextBox.Name = "PhoneClientTextBox";
            this.PhoneClientTextBox.Size = new System.Drawing.Size(129, 20);
            this.PhoneClientTextBox.TabIndex = 23;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(80, 593);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(372, 23);
            this.button8.TabIndex = 25;
            this.button8.Text = "STOCK DE PRODUCTOS";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(489, 593);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(293, 23);
            this.button9.TabIndex = 26;
            this.button9.Text = "CLIENTES REGISTRADOS";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(817, 593);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(302, 23);
            this.button10.TabIndex = 27;
            this.button10.Text = "VENTAS REALIZADAS";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // LastNameClientTextBox
            // 
            this.LastNameClientTextBox.Location = new System.Drawing.Point(80, 235);
            this.LastNameClientTextBox.Name = "LastNameClientTextBox";
            this.LastNameClientTextBox.Size = new System.Drawing.Size(129, 20);
            this.LastNameClientTextBox.TabIndex = 28;
            // 
            // IdClientTextBox
            // 
            this.IdClientTextBox.Location = new System.Drawing.Point(80, 179);
            this.IdClientTextBox.Name = "IdClientTextBox";
            this.IdClientTextBox.Size = new System.Drawing.Size(129, 20);
            this.IdClientTextBox.TabIndex = 29;
            this.IdClientTextBox.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mariley Suarez",
            "Clouie Gimongala"});
            this.comboBox1.Location = new System.Drawing.Point(109, 515);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 693);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.IdClientTextBox);
            this.Controls.Add(this.LastNameClientTextBox);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.PhoneClientTextBox);
            this.Controls.Add(this.PhoneClientLabel);
            this.Controls.Add(this.LastNameClientLabel);
            this.Controls.Add(this.DeleteClientButton);
            this.Controls.Add(this.UpdateClientButton);
            this.Controls.Add(this.AddClientButton);
            this.Controls.Add(this.NameClientTextBox);
            this.Controls.Add(this.NameClientLabel);
            this.Controls.Add(this.IdClientLabel);
            this.Controls.Add(this.ClientDataView);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView ClientDataView;
        private System.Windows.Forms.Label IdClientLabel;
        private System.Windows.Forms.Label NameClientLabel;
        private System.Windows.Forms.TextBox NameClientTextBox;
        private System.Windows.Forms.Button AddClientButton;
        private System.Windows.Forms.Button UpdateClientButton;
        private System.Windows.Forms.Button DeleteClientButton;
        private System.Windows.Forms.Label LastNameClientLabel;
        private System.Windows.Forms.Label PhoneClientLabel;
        private System.Windows.Forms.TextBox PhoneClientTextBox;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox LastNameClientTextBox;
        private System.Windows.Forms.TextBox IdClientTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

