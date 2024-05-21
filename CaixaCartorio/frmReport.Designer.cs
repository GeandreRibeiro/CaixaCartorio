namespace CaixaCartorio
{
    partial class frmReport
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport));
            groupBox1 = new GroupBox();
            label8 = new Label();
            txSaldoAtual = new TextBox();
            label5 = new Label();
            txDepositos = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txEntrada = new TextBox();
            txSaldoAnterior = new TextBox();
            txSaida = new TextBox();
            txTotalGeral = new TextBox();
            dTOCaixaBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            historicoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewCheckBoxColumn1 = new DataGridViewCheckBoxColumn();
            gbFiltros = new GroupBox();
            chTodos = new CheckBox();
            dtFinal = new DateTimePicker();
            dtInicial = new DateTimePicker();
            btImprimir = new Button();
            chFiltroDeposito = new CheckBox();
            label7 = new Label();
            label6 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dTOCaixaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            gbFiltros.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txSaldoAtual);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txDepositos);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txEntrada);
            groupBox1.Controls.Add(txSaldoAnterior);
            groupBox1.Controls.Add(txSaida);
            groupBox1.Controls.Add(txTotalGeral);
            groupBox1.Location = new Point(12, 738);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1739, 116);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Totais";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(401, 80);
            label8.Name = "label8";
            label8.Size = new Size(86, 20);
            label8.TabIndex = 11;
            label8.Text = "Saldo Atual";
            // 
            // txSaldoAtual
            // 
            txSaldoAtual.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txSaldoAtual.Location = new Point(493, 75);
            txSaldoAtual.Name = "txSaldoAtual";
            txSaldoAtual.ReadOnly = true;
            txSaldoAtual.Size = new Size(183, 34);
            txSaldoAtual.TabIndex = 10;
            txSaldoAtual.Text = "0,00";
            txSaldoAtual.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1015, 36);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 9;
            label5.Text = "Depósitos";
            // 
            // txDepositos
            // 
            txDepositos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txDepositos.Location = new Point(1099, 31);
            txDepositos.Name = "txDepositos";
            txDepositos.ReadOnly = true;
            txDepositos.Size = new Size(183, 34);
            txDepositos.TabIndex = 8;
            txDepositos.Text = "0,00";
            txDepositos.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1013, 85);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 7;
            label4.Text = "Total Geral";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(733, 31);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 6;
            label3.Text = "Saidas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(421, 36);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 5;
            label2.Text = "Entradas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(682, 85);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 4;
            label1.Text = "Saldo Anterior";
            // 
            // txEntrada
            // 
            txEntrada.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txEntrada.Location = new Point(493, 31);
            txEntrada.Name = "txEntrada";
            txEntrada.ReadOnly = true;
            txEntrada.Size = new Size(183, 34);
            txEntrada.TabIndex = 3;
            txEntrada.Text = "0,00";
            txEntrada.TextAlign = HorizontalAlignment.Right;
            // 
            // txSaldoAnterior
            // 
            txSaldoAnterior.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txSaldoAnterior.Location = new Point(791, 80);
            txSaldoAnterior.Name = "txSaldoAnterior";
            txSaldoAnterior.ReadOnly = true;
            txSaldoAnterior.Size = new Size(183, 34);
            txSaldoAnterior.TabIndex = 2;
            txSaldoAnterior.Text = "0,00";
            txSaldoAnterior.TextAlign = HorizontalAlignment.Right;
            // 
            // txSaida
            // 
            txSaida.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txSaida.Location = new Point(791, 26);
            txSaida.Name = "txSaida";
            txSaida.ReadOnly = true;
            txSaida.Size = new Size(183, 34);
            txSaida.TabIndex = 1;
            txSaida.Text = "0,00";
            txSaida.TextAlign = HorizontalAlignment.Right;
            // 
            // txTotalGeral
            // 
            txTotalGeral.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txTotalGeral.Location = new Point(1099, 80);
            txTotalGeral.Name = "txTotalGeral";
            txTotalGeral.ReadOnly = true;
            txTotalGeral.Size = new Size(183, 34);
            txTotalGeral.TabIndex = 0;
            txTotalGeral.Text = "0,00";
            txTotalGeral.TextAlign = HorizontalAlignment.Right;
            // 
            // dTOCaixaBindingSource
            // 
            dTOCaixaBindingSource.DataSource = typeof(DTOCaixa);
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, historicoDataGridViewTextBoxColumn, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewCheckBoxColumn1 });
            dataGridView1.DataSource = dTOCaixaBindingSource;
            dataGridView1.Location = new Point(12, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1466, 732);
            dataGridView1.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Codigo";
            dataGridViewTextBoxColumn1.FillWeight = 467.914429F;
            dataGridViewTextBoxColumn1.HeaderText = "Código";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.DataPropertyName = "Data";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewTextBoxColumn2.FillWeight = 38.68093F;
            dataGridViewTextBoxColumn2.HeaderText = "Data";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // historicoDataGridViewTextBoxColumn
            // 
            historicoDataGridViewTextBoxColumn.DataPropertyName = "Historico";
            historicoDataGridViewTextBoxColumn.FillWeight = 38.68093F;
            historicoDataGridViewTextBoxColumn.HeaderText = "Histórico";
            historicoDataGridViewTextBoxColumn.MinimumWidth = 6;
            historicoDataGridViewTextBoxColumn.Name = "historicoDataGridViewTextBoxColumn";
            historicoDataGridViewTextBoxColumn.ReadOnly = true;
            historicoDataGridViewTextBoxColumn.Width = 400;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.DataPropertyName = "Entrada";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewTextBoxColumn3.FillWeight = 38.68093F;
            dataGridViewTextBoxColumn3.HeaderText = "Entrada";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn4.DataPropertyName = "Saida";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewTextBoxColumn4.FillWeight = 38.68093F;
            dataGridViewTextBoxColumn4.HeaderText = "Saida";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn5.DataPropertyName = "Forma";
            dataGridViewTextBoxColumn5.FillWeight = 38.68093F;
            dataGridViewTextBoxColumn5.HeaderText = "Forma";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            dataGridViewCheckBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCheckBoxColumn1.DataPropertyName = "DepositoFuturo";
            dataGridViewCheckBoxColumn1.FillWeight = 38.68093F;
            dataGridViewCheckBoxColumn1.HeaderText = "Depósito Futuro";
            dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // gbFiltros
            // 
            gbFiltros.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            gbFiltros.Controls.Add(chTodos);
            gbFiltros.Controls.Add(dtFinal);
            gbFiltros.Controls.Add(dtInicial);
            gbFiltros.Controls.Add(btImprimir);
            gbFiltros.Controls.Add(chFiltroDeposito);
            gbFiltros.Controls.Add(label7);
            gbFiltros.Controls.Add(label6);
            gbFiltros.Location = new Point(1484, -1);
            gbFiltros.Name = "gbFiltros";
            gbFiltros.Size = new Size(273, 184);
            gbFiltros.TabIndex = 4;
            gbFiltros.TabStop = false;
            gbFiltros.Text = "Filtros";
            // 
            // chTodos
            // 
            chTodos.AutoSize = true;
            chTodos.Location = new Point(197, 91);
            chTodos.Margin = new Padding(3, 4, 3, 4);
            chTodos.Name = "chTodos";
            chTodos.Size = new Size(71, 24);
            chTodos.TabIndex = 13;
            chTodos.Text = "Todos";
            chTodos.UseVisualStyleBackColor = true;
            // 
            // dtFinal
            // 
            dtFinal.Format = DateTimePickerFormat.Short;
            dtFinal.Location = new Point(144, 52);
            dtFinal.Margin = new Padding(3, 4, 3, 4);
            dtFinal.Name = "dtFinal";
            dtFinal.Size = new Size(118, 27);
            dtFinal.TabIndex = 4;
            // 
            // dtInicial
            // 
            dtInicial.Format = DateTimePickerFormat.Short;
            dtInicial.Location = new Point(18, 52);
            dtInicial.Margin = new Padding(3, 4, 3, 4);
            dtInicial.Name = "dtInicial";
            dtInicial.Size = new Size(118, 27);
            dtInicial.TabIndex = 2;
            // 
            // btImprimir
            // 
            btImprimir.Location = new Point(131, 123);
            btImprimir.Margin = new Padding(3, 4, 3, 4);
            btImprimir.Name = "btImprimir";
            btImprimir.Size = new Size(137, 44);
            btImprimir.TabIndex = 12;
            btImprimir.Text = "Listar";
            btImprimir.UseVisualStyleBackColor = true;
            btImprimir.Click += btImprimir_Click;
            // 
            // chFiltroDeposito
            // 
            chFiltroDeposito.AutoSize = true;
            chFiltroDeposito.Location = new Point(18, 91);
            chFiltroDeposito.Margin = new Padding(3, 4, 3, 4);
            chFiltroDeposito.Name = "chFiltroDeposito";
            chFiltroDeposito.Size = new Size(138, 24);
            chFiltroDeposito.TabIndex = 11;
            chFiltroDeposito.Text = "Depósito Futuro";
            chFiltroDeposito.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(144, 28);
            label7.Name = "label7";
            label7.Size = new Size(76, 20);
            label7.TabIndex = 5;
            label7.Text = "Data Final";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 28);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 3;
            label6.Text = "Data Inicial";
            // 
            // frmReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1769, 866);
            Controls.Add(gbFiltros);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Conferir Caixa";
            WindowState = FormWindowState.Maximized;
            Load += frmReport_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dTOCaixaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            gbFiltros.ResumeLayout(false);
            gbFiltros.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private BindingSource dTOCaixaBindingSource;
        private DataGridView dataGridView1;
        private TextBox txTotalGeral;
        private Label label1;
        private TextBox txEntrada;
        private TextBox txSaldoAnterior;
        private TextBox txSaida;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox gbFiltros;
        private CheckBox chTodos;
        private DateTimePicker dtFinal;
        private DateTimePicker dtInicial;
        private Button btImprimir;
        private CheckBox chFiltroDeposito;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txDepositos;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn historicoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private Label label8;
        private TextBox txSaldoAtual;
    }
}