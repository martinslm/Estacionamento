namespace EditorForms
{
    partial class Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEntrada1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.labelResultado = new MaterialSkin.Controls.MaterialLabel();
            this.resultado = new MaterialSkin.Controls.MaterialLabel();
            this.labelVagas = new System.Windows.Forms.Label();
            this.TbQtdEntrada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEntrada1
            // 
            this.btnEntrada1.AutoSize = true;
            this.btnEntrada1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEntrada1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEntrada1.Depth = 0;
            this.btnEntrada1.Location = new System.Drawing.Point(330, 148);
            this.btnEntrada1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEntrada1.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEntrada1.Name = "btnEntrada1";
            this.btnEntrada1.Primary = false;
            this.btnEntrada1.Size = new System.Drawing.Size(64, 36);
            this.btnEntrada1.TabIndex = 0;
            this.btnEntrada1.Text = "Entrar";
            this.btnEntrada1.UseVisualStyleBackColor = false;
            this.btnEntrada1.Click += new System.EventHandler(this.btnEntrada1_Click);
            // 
            // btnEntrada2
            // 
            this.btnEntrada2.AutoSize = true;
            this.btnEntrada2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEntrada2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEntrada2.Depth = 0;
            this.btnEntrada2.Location = new System.Drawing.Point(144, 83);
            this.btnEntrada2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEntrada2.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEntrada2.Name = "btnEntrada2";
            this.btnEntrada2.Primary = false;
            this.btnEntrada2.Size = new System.Drawing.Size(85, 36);
            this.btnEntrada2.TabIndex = 1;
            this.btnEntrada2.Text = "Entrada 2";
            this.btnEntrada2.UseVisualStyleBackColor = false;
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Depth = 0;
            this.labelResultado.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelResultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelResultado.Location = new System.Drawing.Point(0, 213);
            this.labelResultado.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(0, 19);
            this.labelResultado.TabIndex = 7;
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.BackColor = System.Drawing.Color.Transparent;
            this.resultado.Depth = 0;
            this.resultado.Font = new System.Drawing.Font("Roboto", 11F);
            this.resultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.resultado.Location = new System.Drawing.Point(20, 219);
            this.resultado.MouseState = MaterialSkin.MouseState.HOVER;
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(0, 19);
            this.resultado.TabIndex = 8;
            // 
            // btnSaida1
            // 
            this.btnSaida1.Depth = 0;
            this.btnSaida1.Location = new System.Drawing.Point(42, 219);
            this.btnSaida1.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaida1.Name = "btnSaida1";
            this.btnSaida1.Primary = true;
            this.btnSaida1.Size = new System.Drawing.Size(85, 35);
            this.btnSaida1.TabIndex = 10;
            this.btnSaida1.Text = "Saída 1";
            this.btnSaida1.UseVisualStyleBackColor = true;
            // 
            // labelVagas
            // 
            this.labelVagas.AutoSize = true;
            this.labelVagas.Location = new System.Drawing.Point(184, 376);
            this.labelVagas.Name = "labelVagas";
            this.labelVagas.Size = new System.Drawing.Size(0, 13);
            this.labelVagas.TabIndex = 28;
            // 
            // TbQtdEntrada
            // 
            this.TbQtdEntrada.Location = new System.Drawing.Point(100, 157);
            this.TbQtdEntrada.Name = "TbQtdEntrada";
            this.TbQtdEntrada.Size = new System.Drawing.Size(213, 20);
            this.TbQtdEntrada.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 26);
            this.label1.TabIndex = 30;
            this.label1.Text = "Informe a quantidade de carros para entrar. \nLembrando que há 5 entradas no estac" +
    "ionamento.  ";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(543, 398);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbQtdEntrada);
            this.Controls.Add(this.labelVagas);
            this.Controls.Add(this.lbSaida5);
            this.Controls.Add(this.lbSaida4);
            this.Controls.Add(this.lbSaida3);
            this.Controls.Add(this.lbSaida2);
            this.Controls.Add(this.lbSaida1);
            this.Controls.Add(this.lbEntrada5);
            this.Controls.Add(this.lbEntrada4);
            this.Controls.Add(this.lbEntrada3);
            this.Controls.Add(this.lbEntrada2);
            this.Controls.Add(this.lbEntrada1);
            this.Controls.Add(this.btnSaida5);
            this.Controls.Add(this.btnSaida4);
            this.Controls.Add(this.btnSaida3);
            this.Controls.Add(this.btnSaida2);
            this.Controls.Add(this.btnEntrada5);
            this.Controls.Add(this.btnEntrada4);
            this.Controls.Add(this.btnEntrada3);
            this.Controls.Add(this.btnSaida1);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.btnEntrada2);
            this.Controls.Add(this.btnEntrada1);
            this.Name = "Menu";
            this.Text = "Estacionamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton btnEntrada1;
        private MaterialSkin.Controls.MaterialFlatButton btnEntrada2;
        private MaterialSkin.Controls.MaterialLabel labelResultado;
        private MaterialSkin.Controls.MaterialLabel resultado;
        private MaterialSkin.Controls.MaterialRaisedButton btnSaida1;
        private MaterialSkin.Controls.MaterialFlatButton btnEntrada3;
        private MaterialSkin.Controls.MaterialFlatButton btnEntrada4;
        private MaterialSkin.Controls.MaterialFlatButton btnEntrada5;
        private MaterialSkin.Controls.MaterialRaisedButton btnSaida2;
        private MaterialSkin.Controls.MaterialRaisedButton btnSaida3;
        private MaterialSkin.Controls.MaterialRaisedButton btnSaida4;
        private MaterialSkin.Controls.MaterialRaisedButton btnSaida5;
        private System.Windows.Forms.Label lbEntrada1;
        private System.Windows.Forms.Label lbEntrada2;
        private System.Windows.Forms.Label lbEntrada3;
        private System.Windows.Forms.Label lbEntrada4;
        private System.Windows.Forms.Label lbEntrada5;
        private System.Windows.Forms.Label lbSaida5;
        private System.Windows.Forms.Label lbSaida4;
        private System.Windows.Forms.Label lbSaida3;
        private System.Windows.Forms.Label lbSaida2;
        private System.Windows.Forms.Label lbSaida1;
        private System.Windows.Forms.Label labelVagas;
        private System.Windows.Forms.TextBox TbQtdEntrada;
        private System.Windows.Forms.Label label1;
    }
}

