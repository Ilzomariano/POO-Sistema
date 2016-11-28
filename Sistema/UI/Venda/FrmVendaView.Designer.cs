namespace InterfaceProduto
{
    partial class FrmVendaView
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rtb_description = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_add_car = new System.Windows.Forms.Button();
            this.btn_comprar = new System.Windows.Forms.Button();
            this.lbl_total = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_total_frete = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nud_quantidade = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_nome_produto_informacao = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pb_view_image = new System.Windows.Forms.PictureBox();
            this.lbl_nome_produto_titulo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_quantidade)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_view_image)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produto Selecionado:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(11, 40);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(535, 272);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rtb_description);
            this.groupBox4.Location = new System.Drawing.Point(6, 168);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(170, 96);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Descrição:";
            // 
            // rtb_description
            // 
            this.rtb_description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_description.Location = new System.Drawing.Point(2, 15);
            this.rtb_description.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtb_description.Name = "rtb_description";
            this.rtb_description.ReadOnly = true;
            this.rtb_description.Size = new System.Drawing.Size(166, 79);
            this.rtb_description.TabIndex = 0;
            this.rtb_description.Text = "Todas a descrição...";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.btn_add_car);
            this.groupBox3.Controls.Add(this.btn_comprar);
            this.groupBox3.Controls.Add(this.lbl_total);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.lbl_total_frete);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.nud_quantidade);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.lbl_nome_produto_informacao);
            this.groupBox3.Controls.Add(this.txt_codigo);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(195, 16);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(336, 248);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informações para compra";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(36, 187);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "*Finalizar a compra!";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(209, 187);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "*Continuar comprando...";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(157, 212);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "Ou";
            // 
            // btn_add_car
            // 
            this.btn_add_car.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_car.Location = new System.Drawing.Point(211, 200);
            this.btn_add_car.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_add_car.Name = "btn_add_car";
            this.btn_add_car.Size = new System.Drawing.Size(103, 35);
            this.btn_add_car.TabIndex = 18;
            this.btn_add_car.Text = "Add Carrinho";
            this.btn_add_car.UseVisualStyleBackColor = true;
            // 
            // btn_comprar
            // 
            this.btn_comprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_comprar.Location = new System.Drawing.Point(31, 200);
            this.btn_comprar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_comprar.Name = "btn_comprar";
            this.btn_comprar.Size = new System.Drawing.Size(103, 35);
            this.btn_comprar.TabIndex = 17;
            this.btn_comprar.Text = "Compar";
            this.btn_comprar.UseVisualStyleBackColor = true;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.Color.Green;
            this.lbl_total.Location = new System.Drawing.Point(195, 161);
            this.lbl_total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(80, 24);
            this.lbl_total.TabIndex = 16;
            this.lbl_total.Text = "R$ 0,00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(90, 166);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Valor total:";
            // 
            // lbl_total_frete
            // 
            this.lbl_total_frete.AutoSize = true;
            this.lbl_total_frete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_frete.ForeColor = System.Drawing.Color.Green;
            this.lbl_total_frete.Location = new System.Drawing.Point(267, 102);
            this.lbl_total_frete.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_total_frete.Name = "lbl_total_frete";
            this.lbl_total_frete.Size = new System.Drawing.Size(50, 15);
            this.lbl_total_frete.TabIndex = 14;
            this.lbl_total_frete.Text = "R$ 0,00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(205, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Total frete:";
            // 
            // nud_quantidade
            // 
            this.nud_quantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nud_quantidade.Location = new System.Drawing.Point(117, 101);
            this.nud_quantidade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nud_quantidade.Name = "nud_quantidade";
            this.nud_quantidade.Size = new System.Drawing.Size(55, 20);
            this.nud_quantidade.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Quantidade:";
            // 
            // lbl_nome_produto_informacao
            // 
            this.lbl_nome_produto_informacao.AutoSize = true;
            this.lbl_nome_produto_informacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_produto_informacao.ForeColor = System.Drawing.Color.Blue;
            this.lbl_nome_produto_informacao.Location = new System.Drawing.Point(27, 58);
            this.lbl_nome_produto_informacao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nome_produto_informacao.MaximumSize = new System.Drawing.Size(500, 0);
            this.lbl_nome_produto_informacao.Name = "lbl_nome_produto_informacao";
            this.lbl_nome_produto_informacao.Size = new System.Drawing.Size(133, 20);
            this.lbl_nome_produto_informacao.TabIndex = 10;
            this.lbl_nome_produto_informacao.Text = "Nome do Produto";
            this.lbl_nome_produto_informacao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(117, 21);
            this.txt_codigo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(56, 20);
            this.txt_codigo.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Código:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pb_view_image);
            this.groupBox2.Location = new System.Drawing.Point(4, 16);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(178, 148);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Visualização";
            // 
            // pb_view_image
            // 
            this.pb_view_image.Location = new System.Drawing.Point(2, 14);
            this.pb_view_image.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb_view_image.Name = "pb_view_image";
            this.pb_view_image.Size = new System.Drawing.Size(170, 127);
            this.pb_view_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_view_image.TabIndex = 0;
            this.pb_view_image.TabStop = false;
            // 
            // lbl_nome_produto_titulo
            // 
            this.lbl_nome_produto_titulo.AutoSize = true;
            this.lbl_nome_produto_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_produto_titulo.ForeColor = System.Drawing.Color.Blue;
            this.lbl_nome_produto_titulo.Location = new System.Drawing.Point(163, 4);
            this.lbl_nome_produto_titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nome_produto_titulo.MaximumSize = new System.Drawing.Size(500, 0);
            this.lbl_nome_produto_titulo.Name = "lbl_nome_produto_titulo";
            this.lbl_nome_produto_titulo.Size = new System.Drawing.Size(133, 20);
            this.lbl_nome_produto_titulo.TabIndex = 11;
            this.lbl_nome_produto_titulo.Text = "Nome do Produto";
            this.lbl_nome_produto_titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmVendaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 331);
            this.Controls.Add(this.lbl_nome_produto_titulo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(573, 370);
            this.Name = "FrmVendaView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Vendas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_quantidade)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_view_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pb_view_image;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox rtb_description;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.NumericUpDown nud_quantidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_nome_produto_informacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_total_frete;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_comprar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_add_car;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_nome_produto_titulo;
    }
}

