namespace CaixaCartorio
{
    partial class frmCaixa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaixa));
            gbDados = new GroupBox();
            dtLancamento = new DateTimePicker();
            btGravar = new Button();
            chDeposito = new CheckBox();
            label5 = new Label();
            cbForma = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            txSaida = new TextBox();
            txEntrada = new TextBox();
            label2 = new Label();
            txHistorico = new TextBox();
            label1 = new Label();
            gbFiltros = new GroupBox();
            chTodos = new CheckBox();
            dtFinal = new DateTimePicker();
            dtInicial = new DateTimePicker();
            btImprimir = new Button();
            chFiltroDeposito = new CheckBox();
            label7 = new Label();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            historicoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewCheckBoxColumn1 = new DataGridViewCheckBoxColumn();
            dTOCaixaBindingSource = new BindingSource(components);
            gbGeral = new GroupBox();
            gbTotais = new GroupBox();
            lbTotalGeral = new Label();
            lbTotalDeposito = new Label();
            label14 = new Label();
            label15 = new Label();
            lbTotalSaida = new Label();
            lbTotalEntrada = new Label();
            label9 = new Label();
            label8 = new Label();
            menuStrip1 = new MenuStrip();
            principalToolStripMenuItem = new ToolStripMenuItem();
            conferirLançamentosToolStripMenuItem = new ToolStripMenuItem();
            gbDados.SuspendLayout();
            gbFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dTOCaixaBindingSource).BeginInit();
            gbGeral.SuspendLayout();
            gbTotais.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // gbDados
            // 
            gbDados.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            gbDados.Controls.Add(dtLancamento);
            gbDados.Controls.Add(btGravar);
            gbDados.Controls.Add(chDeposito);
            gbDados.Controls.Add(label5);
            gbDados.Controls.Add(cbForma);
            gbDados.Controls.Add(label4);
            gbDados.Controls.Add(label3);
            gbDados.Controls.Add(txSaida);
            gbDados.Controls.Add(txEntrada);
            gbDados.Controls.Add(label2);
            gbDados.Controls.Add(txHistorico);
            gbDados.Controls.Add(label1);
            gbDados.Location = new Point(1014, 16);
            gbDados.Name = "gbDados";
            gbDados.Size = new Size(570, 331);
            gbDados.TabIndex = 0;
            gbDados.TabStop = false;
            // 
            // dtLancamento
            // 
            dtLancamento.Format = DateTimePickerFormat.Short;
            dtLancamento.Location = new Point(7, 56);
            dtLancamento.Margin = new Padding(3, 4, 3, 4);
            dtLancamento.Name = "dtLancamento";
            dtLancamento.Size = new Size(118, 27);
            dtLancamento.TabIndex = 0;
            // 
            // btGravar
            // 
            btGravar.Location = new Point(250, 277);
            btGravar.Margin = new Padding(3, 4, 3, 4);
            btGravar.Name = "btGravar";
            btGravar.Size = new Size(137, 41);
            btGravar.TabIndex = 11;
            btGravar.Text = "Gravar";
            btGravar.UseVisualStyleBackColor = true;
            btGravar.Click += btGravar_Click;
            // 
            // chDeposito
            // 
            chDeposito.AutoSize = true;
            chDeposito.Location = new Point(249, 245);
            chDeposito.Margin = new Padding(3, 4, 3, 4);
            chDeposito.Name = "chDeposito";
            chDeposito.Size = new Size(138, 24);
            chDeposito.TabIndex = 10;
            chDeposito.Text = "Depósito Futuro";
            chDeposito.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 217);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 9;
            label5.Text = "Forma";
            // 
            // cbForma
            // 
            cbForma.FormattingEnabled = true;
            cbForma.Items.AddRange(new object[] { "Dinheiro", "Pix", "Cartão" });
            cbForma.Location = new Point(7, 243);
            cbForma.Margin = new Padding(3, 4, 3, 4);
            cbForma.Name = "cbForma";
            cbForma.Size = new Size(235, 28);
            cbForma.TabIndex = 8;
            // 
            // label4
            // 
            label4.Location = new Point(133, 152);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 7;
            label4.Text = "Saída";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Location = new Point(7, 152);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 6;
            label3.Text = "Entrada";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txSaida
            // 
            txSaida.Location = new Point(128, 179);
            txSaida.Margin = new Padding(3, 4, 3, 4);
            txSaida.Name = "txSaida";
            txSaida.Size = new Size(114, 27);
            txSaida.TabIndex = 5;
            txSaida.Text = "0,00";
            txSaida.TextAlign = HorizontalAlignment.Right;
            txSaida.Enter += txSaida_Enter;
            txSaida.Validated += txSaida_Validated;
            // 
            // txEntrada
            // 
            txEntrada.Location = new Point(7, 179);
            txEntrada.Margin = new Padding(3, 4, 3, 4);
            txEntrada.Name = "txEntrada";
            txEntrada.Size = new Size(114, 27);
            txEntrada.TabIndex = 4;
            txEntrada.Text = "0,00";
            txEntrada.TextAlign = HorizontalAlignment.Right;
            txEntrada.Enter += txEntrada_Enter;
            txEntrada.Validated += txEntrada_Validated;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 91);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 3;
            label2.Text = "Histórico";
            // 
            // txHistorico
            // 
            txHistorico.CharacterCasing = CharacterCasing.Upper;
            txHistorico.Location = new Point(7, 115);
            txHistorico.Margin = new Padding(3, 4, 3, 4);
            txHistorico.Name = "txHistorico";
            txHistorico.Size = new Size(559, 27);
            txHistorico.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 32);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 1;
            label1.Text = "Data";
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
            gbFiltros.Location = new Point(1014, 352);
            gbFiltros.Name = "gbFiltros";
            gbFiltros.Size = new Size(570, 184);
            gbFiltros.TabIndex = 1;
            gbFiltros.TabStop = false;
            gbFiltros.Text = "Filtros";
            // 
            // chTodos
            // 
            chTodos.AutoSize = true;
            chTodos.Location = new Point(186, 91);
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
            dtFinal.Location = new Point(133, 52);
            dtFinal.Margin = new Padding(3, 4, 3, 4);
            dtFinal.Name = "dtFinal";
            dtFinal.Size = new Size(118, 27);
            dtFinal.TabIndex = 4;
            // 
            // dtInicial
            // 
            dtInicial.Format = DateTimePickerFormat.Short;
            dtInicial.Location = new Point(7, 52);
            dtInicial.Margin = new Padding(3, 4, 3, 4);
            dtInicial.Name = "dtInicial";
            dtInicial.Size = new Size(118, 27);
            dtInicial.TabIndex = 2;
            // 
            // btImprimir
            // 
            btImprimir.Location = new Point(114, 133);
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
            chFiltroDeposito.Location = new Point(7, 91);
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
            label7.Location = new Point(133, 28);
            label7.Name = "label7";
            label7.Size = new Size(76, 20);
            label7.TabIndex = 5;
            label7.Text = "Data Final";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 28);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 3;
            label6.Text = "Data Inicial";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, historicoDataGridViewTextBoxColumn, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewCheckBoxColumn1 });
            dataGridView1.DataSource = dTOCaixaBindingSource;
            dataGridView1.Location = new Point(6, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1002, 739);
            dataGridView1.TabIndex = 2;
            dataGridView1.MouseDoubleClick += dataGridView1_MouseDoubleClick;
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
            // dTOCaixaBindingSource
            // 
            dTOCaixaBindingSource.DataSource = typeof(DTOCaixa);
            // 
            // gbGeral
            // 
            gbGeral.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbGeral.Controls.Add(gbTotais);
            gbGeral.Controls.Add(dataGridView1);
            gbGeral.Controls.Add(gbFiltros);
            gbGeral.Controls.Add(gbDados);
            gbGeral.Location = new Point(11, 31);
            gbGeral.Name = "gbGeral";
            gbGeral.Size = new Size(1590, 770);
            gbGeral.TabIndex = 3;
            gbGeral.TabStop = false;
            // 
            // gbTotais
            // 
            gbTotais.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            gbTotais.Controls.Add(lbTotalGeral);
            gbTotais.Controls.Add(lbTotalDeposito);
            gbTotais.Controls.Add(label14);
            gbTotais.Controls.Add(label15);
            gbTotais.Controls.Add(lbTotalSaida);
            gbTotais.Controls.Add(lbTotalEntrada);
            gbTotais.Controls.Add(label9);
            gbTotais.Controls.Add(label8);
            gbTotais.Location = new Point(1014, 541);
            gbTotais.Name = "gbTotais";
            gbTotais.Size = new Size(569, 224);
            gbTotais.TabIndex = 3;
            gbTotais.TabStop = false;
            gbTotais.Text = "Totais";
            // 
            // lbTotalGeral
            // 
            lbTotalGeral.BorderStyle = BorderStyle.Fixed3D;
            lbTotalGeral.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbTotalGeral.Location = new Point(307, 159);
            lbTotalGeral.Name = "lbTotalGeral";
            lbTotalGeral.Size = new Size(190, 39);
            lbTotalGeral.TabIndex = 7;
            lbTotalGeral.Text = "0,00";
            lbTotalGeral.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbTotalDeposito
            // 
            lbTotalDeposito.BorderStyle = BorderStyle.Fixed3D;
            lbTotalDeposito.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbTotalDeposito.Location = new Point(110, 159);
            lbTotalDeposito.Name = "lbTotalDeposito";
            lbTotalDeposito.Size = new Size(191, 39);
            lbTotalDeposito.TabIndex = 6;
            lbTotalDeposito.Text = "0,00";
            lbTotalDeposito.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            label14.Location = new Point(327, 129);
            label14.Name = "label14";
            label14.Size = new Size(170, 21);
            label14.TabIndex = 5;
            label14.Text = "Total Geral";
            label14.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            label15.Location = new Point(102, 129);
            label15.Name = "label15";
            label15.Size = new Size(199, 21);
            label15.TabIndex = 4;
            label15.Text = "Total Depósitos";
            label15.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbTotalSaida
            // 
            lbTotalSaida.BorderStyle = BorderStyle.Fixed3D;
            lbTotalSaida.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbTotalSaida.Location = new Point(307, 81);
            lbTotalSaida.Name = "lbTotalSaida";
            lbTotalSaida.Size = new Size(190, 39);
            lbTotalSaida.TabIndex = 3;
            lbTotalSaida.Text = "0,00";
            lbTotalSaida.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbTotalEntrada
            // 
            lbTotalEntrada.BorderStyle = BorderStyle.Fixed3D;
            lbTotalEntrada.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbTotalEntrada.Location = new Point(110, 81);
            lbTotalEntrada.Name = "lbTotalEntrada";
            lbTotalEntrada.Size = new Size(191, 39);
            lbTotalEntrada.TabIndex = 2;
            lbTotalEntrada.Text = "0,00";
            lbTotalEntrada.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.Location = new Point(320, 45);
            label9.Name = "label9";
            label9.Size = new Size(177, 29);
            label9.TabIndex = 1;
            label9.Text = "Total Saídas";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.Location = new Point(110, 45);
            label8.Name = "label8";
            label8.Size = new Size(191, 29);
            label8.TabIndex = 0;
            label8.Text = "Total Entradas";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { principalToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1614, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // principalToolStripMenuItem
            // 
            principalToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { conferirLançamentosToolStripMenuItem });
            principalToolStripMenuItem.Name = "principalToolStripMenuItem";
            principalToolStripMenuItem.Size = new Size(104, 24);
            principalToolStripMenuItem.Text = "Ferramentas";
            // 
            // conferirLançamentosToolStripMenuItem
            // 
            conferirLançamentosToolStripMenuItem.Name = "conferirLançamentosToolStripMenuItem";
            conferirLançamentosToolStripMenuItem.Size = new Size(233, 26);
            conferirLançamentosToolStripMenuItem.Text = "Conferir lançamentos";
            conferirLançamentosToolStripMenuItem.Click += conferirLançamentosToolStripMenuItem_Click;
            // 
            // frmCaixa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1614, 813);
            Controls.Add(gbGeral);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Name = "frmCaixa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Caixa";
            WindowState = FormWindowState.Maximized;
            FormClosed += frmCaixa_FormClosed;
            Load += frmCaixa_Load;
            KeyPress += frmCaixa_KeyPress;
            gbDados.ResumeLayout(false);
            gbDados.PerformLayout();
            gbFiltros.ResumeLayout(false);
            gbFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dTOCaixaBindingSource).EndInit();
            gbGeral.ResumeLayout(false);
            gbTotais.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbDados;
        private GroupBox gbFiltros;
        private DataGridView dataGridView1;
        private GroupBox gbGeral;
        private Label label5;
        private ComboBox cbForma;
        private Label label4;
        private Label label3;
        private TextBox txSaida;
        private TextBox txEntrada;
        private Label label2;
        private TextBox txHistorico;
        private Label label1;
        private DateTimePicker dtLancamento;
        private CheckBox chDeposito;
        private Button btGravar;
        private GroupBox gbTotais;
        private Label label7;
        private DateTimePicker dtFinal;
        private Label label6;
        private DateTimePicker dtInicial;
        private CheckBox chFiltroDeposito;
        private Button btImprimir;
        private Label lbTotalSaida;
        private Label lbTotalEntrada;
        private Label label9;
        private Label label8;
        private Label lbTotalGeral;
        private Label lbTotalDeposito;
        private Label label14;
        private Label label15;
        private DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn entradaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn saidaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn formaDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn depositoFuturoDataGridViewCheckBoxColumn;
        private CheckBox chTodos;
        private BindingSource dTOCaixaBindingSource;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn historicoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem principalToolStripMenuItem;
        private ToolStripMenuItem conferirLançamentosToolStripMenuItem;
    }
}