namespace EditorForms
{
    partial class Estacionamento
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.TbQtdEntrada = new System.Windows.Forms.MaskedTextBox();
            this.btnEntrar = new MaterialSkin.Controls.MaterialFlatButton();
            this.lbErroEntrada = new System.Windows.Forms.Label();
            this.lbVagasOcupadas = new System.Windows.Forms.Label();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSaida = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(21, 101);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(341, 38);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Informe a quantidade de carros para entrar. \nLembrando que há 5 entradas no estac" +
    "ionamento";
            // 
            // TbQtdEntrada
            // 
            this.TbQtdEntrada.Location = new System.Drawing.Point(378, 112);
            this.TbQtdEntrada.Mask = "0";
            this.TbQtdEntrada.Name = "TbQtdEntrada";
            this.TbQtdEntrada.Size = new System.Drawing.Size(151, 20);
            this.TbQtdEntrada.TabIndex = 1;
            // 
            // btnEntrar
            // 
            this.btnEntrar.AutoSize = true;
            this.btnEntrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEntrar.Depth = 0;
            this.btnEntrar.Location = new System.Drawing.Point(559, 103);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEntrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Primary = false;
            this.btnEntrar.Size = new System.Drawing.Size(64, 36);
            this.btnEntrar.TabIndex = 2;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lbErroEntrada
            // 
            this.lbErroEntrada.AutoSize = true;
            this.lbErroEntrada.Location = new System.Drawing.Point(375, 135);
            this.lbErroEntrada.Name = "lbErroEntrada";
            this.lbErroEntrada.Size = new System.Drawing.Size(0, 13);
            this.lbErroEntrada.TabIndex = 3;
            // 
            // lbVagasOcupadas
            // 
            this.lbVagasOcupadas.AutoSize = true;
            this.lbVagasOcupadas.Location = new System.Drawing.Point(111, 194);
            this.lbVagasOcupadas.Name = "lbVagasOcupadas";
            this.lbVagasOcupadas.Size = new System.Drawing.Size(0, 13);
            this.lbVagasOcupadas.TabIndex = 4;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(21, 322);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(258, 38);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "Informe as Vagas que deseja liberar. \n Ex. 299,1,3,5";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(378, 340);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 20);
            this.textBox1.TabIndex = 7;
            // 
            // btnSaida
            // 
            this.btnSaida.AutoSize = true;
            this.btnSaida.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaida.Depth = 0;
            this.btnSaida.Location = new System.Drawing.Point(559, 331);
            this.btnSaida.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaida.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaida.Name = "btnSaida";
            this.btnSaida.Primary = false;
            this.btnSaida.Size = new System.Drawing.Size(42, 36);
            this.btnSaida.TabIndex = 8;
            this.btnSaida.Text = "Sair";
            this.btnSaida.UseVisualStyleBackColor = true;
            this.btnSaida.Click += new System.EventHandler(this.btnSaida_Click);
            // 
            // Estacionamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaida);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.lbVagasOcupadas);
            this.Controls.Add(this.lbErroEntrada);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.TbQtdEntrada);
            this.Controls.Add(this.materialLabel1);
            this.Name = "Estacionamento";
            this.Text = "Estacionamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.MaskedTextBox TbQtdEntrada;
        private MaterialSkin.Controls.MaterialFlatButton btnEntrar;
        private System.Windows.Forms.Label lbErroEntrada;
        private System.Windows.Forms.Label lbVagasOcupadas;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.TextBox textBox1;
        private MaterialSkin.Controls.MaterialFlatButton btnSaida;
    }
}