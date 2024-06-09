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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.LastNameClientTextBox = new System.Windows.Forms.TextBox();
            this.IdClientTextBox = new System.Windows.Forms.TextBox();
            this.StockDataView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(13, 386);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(936, 139);
            this.dataGridView2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1061, 470);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CleanConsulta);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1061, 414);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 28);
            this.button2.TabIndex = 8;
            this.button2.Text = "Consultar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ConsultarCliente);
            // 
            // ClientDataView
            // 
            this.ClientDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientDataView.Location = new System.Drawing.Point(13, 43);
            this.ClientDataView.Margin = new System.Windows.Forms.Padding(4);
            this.ClientDataView.Name = "ClientDataView";
            this.ClientDataView.RowHeadersWidth = 51;
            this.ClientDataView.Size = new System.Drawing.Size(936, 289);
            this.ClientDataView.TabIndex = 11;
            // 
            // IdClientLabel
            // 
            this.IdClientLabel.AutoSize = true;
            this.IdClientLabel.Location = new System.Drawing.Point(971, 80);
            this.IdClientLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IdClientLabel.Name = "IdClientLabel";
            this.IdClientLabel.Size = new System.Drawing.Size(20, 16);
            this.IdClientLabel.TabIndex = 12;
            this.IdClientLabel.Text = "ID";
            // 
            // NameClientLabel
            // 
            this.NameClientLabel.AutoSize = true;
            this.NameClientLabel.Location = new System.Drawing.Point(971, 118);
            this.NameClientLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameClientLabel.Name = "NameClientLabel";
            this.NameClientLabel.Size = new System.Drawing.Size(56, 16);
            this.NameClientLabel.TabIndex = 15;
            this.NameClientLabel.Text = "Nombre";
            // 
            // NameClientTextBox
            // 
            this.NameClientTextBox.Location = new System.Drawing.Point(1057, 112);
            this.NameClientTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameClientTextBox.Name = "NameClientTextBox";
            this.NameClientTextBox.Size = new System.Drawing.Size(171, 22);
            this.NameClientTextBox.TabIndex = 16;
            // 
            // AddClientButton
            // 
            this.AddClientButton.Location = new System.Drawing.Point(1260, 92);
            this.AddClientButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddClientButton.Name = "AddClientButton";
            this.AddClientButton.Size = new System.Drawing.Size(117, 26);
            this.AddClientButton.TabIndex = 17;
            this.AddClientButton.Text = "Agregar";
            this.AddClientButton.UseVisualStyleBackColor = true;
            this.AddClientButton.Click += new System.EventHandler(this.AddClientButton_Click);
            // 
            // UpdateClientButton
            // 
            this.UpdateClientButton.Location = new System.Drawing.Point(1260, 127);
            this.UpdateClientButton.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateClientButton.Name = "UpdateClientButton";
            this.UpdateClientButton.Size = new System.Drawing.Size(117, 26);
            this.UpdateClientButton.TabIndex = 18;
            this.UpdateClientButton.Text = "Editar";
            this.UpdateClientButton.UseVisualStyleBackColor = true;
            this.UpdateClientButton.Click += new System.EventHandler(this.UpdateClientButton_Click);
            // 
            // DeleteClientButton
            // 
            this.DeleteClientButton.Location = new System.Drawing.Point(1260, 163);
            this.DeleteClientButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteClientButton.Name = "DeleteClientButton";
            this.DeleteClientButton.Size = new System.Drawing.Size(117, 26);
            this.DeleteClientButton.TabIndex = 19;
            this.DeleteClientButton.Text = "Eliminar";
            this.DeleteClientButton.UseVisualStyleBackColor = true;
            this.DeleteClientButton.Click += new System.EventHandler(this.DeleteClientButton_Click);
            // 
            // LastNameClientLabel
            // 
            this.LastNameClientLabel.AutoSize = true;
            this.LastNameClientLabel.Location = new System.Drawing.Point(971, 150);
            this.LastNameClientLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LastNameClientLabel.Name = "LastNameClientLabel";
            this.LastNameClientLabel.Size = new System.Drawing.Size(57, 16);
            this.LastNameClientLabel.TabIndex = 20;
            this.LastNameClientLabel.Text = "Apellido";
            // 
            // PhoneClientLabel
            // 
            this.PhoneClientLabel.AutoSize = true;
            this.PhoneClientLabel.Location = new System.Drawing.Point(973, 189);
            this.PhoneClientLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhoneClientLabel.Name = "PhoneClientLabel";
            this.PhoneClientLabel.Size = new System.Drawing.Size(61, 16);
            this.PhoneClientLabel.TabIndex = 22;
            this.PhoneClientLabel.Text = "Teléfono";
            // 
            // PhoneClientTextBox
            // 
            this.PhoneClientTextBox.Location = new System.Drawing.Point(1057, 181);
            this.PhoneClientTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PhoneClientTextBox.Name = "PhoneClientTextBox";
            this.PhoneClientTextBox.Size = new System.Drawing.Size(171, 22);
            this.PhoneClientTextBox.TabIndex = 23;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(678, 617);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(231, 28);
            this.button8.TabIndex = 25;
            this.button8.Text = "Consulta Stock";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // LastNameClientTextBox
            // 
            this.LastNameClientTextBox.Location = new System.Drawing.Point(1057, 146);
            this.LastNameClientTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.LastNameClientTextBox.Name = "LastNameClientTextBox";
            this.LastNameClientTextBox.Size = new System.Drawing.Size(171, 22);
            this.LastNameClientTextBox.TabIndex = 28;
            // 
            // IdClientTextBox
            // 
            this.IdClientTextBox.Location = new System.Drawing.Point(1057, 77);
            this.IdClientTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.IdClientTextBox.Name = "IdClientTextBox";
            this.IdClientTextBox.Size = new System.Drawing.Size(171, 22);
            this.IdClientTextBox.TabIndex = 29;
            // 
            // StockDataView
            // 
            this.StockDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StockDataView.Location = new System.Drawing.Point(65, 564);
            this.StockDataView.Margin = new System.Windows.Forms.Padding(4);
            this.StockDataView.Name = "StockDataView";
            this.StockDataView.RowHeadersWidth = 51;
            this.StockDataView.Size = new System.Drawing.Size(578, 185);
            this.StockDataView.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Verificar registro";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Registrar Cliente";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 774);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StockDataView);
            this.Controls.Add(this.IdClientTextBox);
            this.Controls.Add(this.LastNameClientTextBox);
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
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
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
        private System.Windows.Forms.TextBox LastNameClientTextBox;
        private System.Windows.Forms.TextBox IdClientTextBox;
        private System.Windows.Forms.DataGridView StockDataView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

