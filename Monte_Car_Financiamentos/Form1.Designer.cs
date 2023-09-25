namespace Monte_Car_Financiamentos
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_vlr_veiculo = new System.Windows.Forms.TextBox();
            this.tb_entrada = new System.Windows.Forms.TextBox();
            this.tb_tac = new System.Windows.Forms.TextBox();
            this.lb_vlr_tot_financ = new System.Windows.Forms.Label();
            this.tb_taxa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_coeficiente = new System.Windows.Forms.Label();
            this.lb_parcela = new System.Windows.Forms.Label();
            this.bt_calcular = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_sair = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cb_prazos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simulador de financiamento de veículos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor do veiculo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Entrada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "TAC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total financiado";
            // 
            // tb_vlr_veiculo
            // 
            this.tb_vlr_veiculo.Location = new System.Drawing.Point(181, 138);
            this.tb_vlr_veiculo.Name = "tb_vlr_veiculo";
            this.tb_vlr_veiculo.Size = new System.Drawing.Size(112, 24);
            this.tb_vlr_veiculo.TabIndex = 5;
            // 
            // tb_entrada
            // 
            this.tb_entrada.Location = new System.Drawing.Point(181, 223);
            this.tb_entrada.Name = "tb_entrada";
            this.tb_entrada.Size = new System.Drawing.Size(112, 24);
            this.tb_entrada.TabIndex = 6;
            // 
            // tb_tac
            // 
            this.tb_tac.Location = new System.Drawing.Point(181, 305);
            this.tb_tac.Name = "tb_tac";
            this.tb_tac.Size = new System.Drawing.Size(112, 24);
            this.tb_tac.TabIndex = 7;
            // 
            // lb_vlr_tot_financ
            // 
            this.lb_vlr_tot_financ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_vlr_tot_financ.Location = new System.Drawing.Point(181, 395);
            this.lb_vlr_tot_financ.Name = "lb_vlr_tot_financ";
            this.lb_vlr_tot_financ.Size = new System.Drawing.Size(154, 27);
            this.lb_vlr_tot_financ.TabIndex = 8;
            this.lb_vlr_tot_financ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_taxa
            // 
            this.tb_taxa.Location = new System.Drawing.Point(456, 220);
            this.tb_taxa.Name = "tb_taxa";
            this.tb_taxa.Size = new System.Drawing.Size(121, 24);
            this.tb_taxa.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(374, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Prazo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(382, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Taxa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(358, 308);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 18);
            this.label9.TabIndex = 13;
            this.label9.Text = "Coeficiente";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(382, 395);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 18);
            this.label10.TabIndex = 14;
            this.label10.Text = "Parcela";
            // 
            // lb_coeficiente
            // 
            this.lb_coeficiente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_coeficiente.Location = new System.Drawing.Point(456, 305);
            this.lb_coeficiente.Name = "lb_coeficiente";
            this.lb_coeficiente.Size = new System.Drawing.Size(153, 27);
            this.lb_coeficiente.TabIndex = 15;
            this.lb_coeficiente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_parcela
            // 
            this.lb_parcela.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_parcela.Location = new System.Drawing.Point(462, 390);
            this.lb_parcela.Name = "lb_parcela";
            this.lb_parcela.Size = new System.Drawing.Size(147, 27);
            this.lb_parcela.TabIndex = 16;
            this.lb_parcela.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_calcular
            // 
            this.bt_calcular.BackColor = System.Drawing.Color.SteelBlue;
            this.bt_calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_calcular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_calcular.Location = new System.Drawing.Point(662, 138);
            this.bt_calcular.Name = "bt_calcular";
            this.bt_calcular.Size = new System.Drawing.Size(97, 44);
            this.bt_calcular.TabIndex = 17;
            this.bt_calcular.Text = "Calcular";
            this.bt_calcular.UseVisualStyleBackColor = false;
            this.bt_calcular.Click += new System.EventHandler(this.bt_calcular_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(662, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 43);
            this.button2.TabIndex = 18;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_sair
            // 
            this.bt_sair.BackColor = System.Drawing.Color.SteelBlue;
            this.bt_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_sair.Location = new System.Drawing.Point(662, 318);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(97, 45);
            this.bt_sair.TabIndex = 19;
            this.bt_sair.Text = "Sair";
            this.bt_sair.UseVisualStyleBackColor = false;
            this.bt_sair.Click += new System.EventHandler(this.bt_sair_Click);
            // 
            // label14
            // 
            this.label14.Image = global::Monte_Car_Financiamentos.Properties.Resources.Monte_Car_Financiamentos;
            this.label14.Location = new System.Drawing.Point(28, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(141, 88);
            this.label14.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.Image = global::Monte_Car_Financiamentos.Properties.Resources.logo_car1;
            this.label13.Location = new System.Drawing.Point(647, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 88);
            this.label13.TabIndex = 20;
            // 
            // cb_prazos
            // 
            this.cb_prazos.FormattingEnabled = true;
            this.cb_prazos.Items.AddRange(new object[] {
            "6",
            "9",
            "12",
            "18",
            "24",
            "30",
            "36",
            "42",
            "48",
            "54",
            "60",
            "72"});
            this.cb_prazos.Location = new System.Drawing.Point(456, 137);
            this.cb_prazos.Name = "cb_prazos";
            this.cb_prazos.Size = new System.Drawing.Size(121, 26);
            this.cb_prazos.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(834, 484);
            this.Controls.Add(this.cb_prazos);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.bt_sair);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bt_calcular);
            this.Controls.Add(this.lb_parcela);
            this.Controls.Add(this.lb_coeficiente);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_taxa);
            this.Controls.Add(this.lb_vlr_tot_financ);
            this.Controls.Add(this.tb_tac);
            this.Controls.Add(this.tb_entrada);
            this.Controls.Add(this.tb_vlr_veiculo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_vlr_veiculo;
        private System.Windows.Forms.TextBox tb_entrada;
        private System.Windows.Forms.TextBox tb_tac;
        private System.Windows.Forms.Label lb_vlr_tot_financ;
        private System.Windows.Forms.TextBox tb_taxa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lb_coeficiente;
        private System.Windows.Forms.Label lb_parcela;
        private System.Windows.Forms.Button bt_calcular;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cb_prazos;
    }
}

