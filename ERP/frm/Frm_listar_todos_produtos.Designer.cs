﻿namespace ERP.frm
{
    partial class Frm_listar_todos_produtos
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_listar_todos_produtos));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_total_produtos_estocado = new System.Windows.Forms.Label();
            this.lb_capital_estocado = new System.Windows.Forms.Label();
            this.lb_qdt_produtos_cadastrados = new System.Windows.Forms.Label();
            this.labelEstoqueAtual = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_produtos = new System.Windows.Forms.DataGridView();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codigoProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoPagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produtos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Listagem - > Produtos";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lb_total_produtos_estocado);
            this.panel1.Controls.Add(this.lb_capital_estocado);
            this.panel1.Controls.Add(this.lb_qdt_produtos_cadastrados);
            this.panel1.Controls.Add(this.labelEstoqueAtual);
            this.panel1.Location = new System.Drawing.Point(14, 261);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 171);
            this.panel1.TabIndex = 34;
            // 
            // lb_total_produtos_estocado
            // 
            this.lb_total_produtos_estocado.AutoSize = true;
            this.lb_total_produtos_estocado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total_produtos_estocado.Location = new System.Drawing.Point(21, 115);
            this.lb_total_produtos_estocado.Name = "lb_total_produtos_estocado";
            this.lb_total_produtos_estocado.Size = new System.Drawing.Size(223, 20);
            this.lb_total_produtos_estocado.TabIndex = 35;
            this.lb_total_produtos_estocado.Text = "Total produtos estocados: ";
            // 
            // lb_capital_estocado
            // 
            this.lb_capital_estocado.AutoSize = true;
            this.lb_capital_estocado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_capital_estocado.Location = new System.Drawing.Point(21, 74);
            this.lb_capital_estocado.Name = "lb_capital_estocado";
            this.lb_capital_estocado.Size = new System.Drawing.Size(151, 20);
            this.lb_capital_estocado.TabIndex = 34;
            this.lb_capital_estocado.Text = "Capital Estocado:";
            // 
            // lb_qdt_produtos_cadastrados
            // 
            this.lb_qdt_produtos_cadastrados.AutoSize = true;
            this.lb_qdt_produtos_cadastrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_qdt_produtos_cadastrados.Location = new System.Drawing.Point(21, 33);
            this.lb_qdt_produtos_cadastrados.Name = "lb_qdt_produtos_cadastrados";
            this.lb_qdt_produtos_cadastrados.Size = new System.Drawing.Size(198, 20);
            this.lb_qdt_produtos_cadastrados.TabIndex = 33;
            this.lb_qdt_produtos_cadastrados.Text = "Produtos Cadastrados: ";
            // 
            // labelEstoqueAtual
            // 
            this.labelEstoqueAtual.AutoSize = true;
            this.labelEstoqueAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstoqueAtual.Location = new System.Drawing.Point(12, 92);
            this.labelEstoqueAtual.Name = "labelEstoqueAtual";
            this.labelEstoqueAtual.Size = new System.Drawing.Size(0, 20);
            this.labelEstoqueAtual.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(667, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "[ Esc ] - Sair";
            // 
            // dgv_produtos
            // 
            this.dgv_produtos.AllowUserToAddRows = false;
            this.dgv_produtos.AllowUserToDeleteRows = false;
            this.dgv_produtos.AutoGenerateColumns = false;
            this.dgv_produtos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_produtos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_produtos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoProdutoDataGridViewTextBoxColumn,
            this.nomeProdutoDataGridViewTextBoxColumn,
            this.precoPagoDataGridViewTextBoxColumn,
            this.precoVendaDataGridViewTextBoxColumn,
            this.estoqueDataGridViewTextBoxColumn});
            this.dgv_produtos.DataSource = this.produtoBindingSource;
            this.dgv_produtos.Location = new System.Drawing.Point(14, 49);
            this.dgv_produtos.Name = "dgv_produtos";
            this.dgv_produtos.ReadOnly = true;
            this.dgv_produtos.Size = new System.Drawing.Size(760, 180);
            this.dgv_produtos.TabIndex = 35;
            this.dgv_produtos.TabStop = false;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(ERP.Produtos.Produto);
            // 
            // codigoProdutoDataGridViewTextBoxColumn
            // 
            this.codigoProdutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.codigoProdutoDataGridViewTextBoxColumn.DataPropertyName = "CodigoProduto";
            this.codigoProdutoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codigoProdutoDataGridViewTextBoxColumn.Name = "codigoProdutoDataGridViewTextBoxColumn";
            this.codigoProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoProdutoDataGridViewTextBoxColumn.Width = 150;
            // 
            // nomeProdutoDataGridViewTextBoxColumn
            // 
            this.nomeProdutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nomeProdutoDataGridViewTextBoxColumn.DataPropertyName = "NomeProduto";
            this.nomeProdutoDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeProdutoDataGridViewTextBoxColumn.Name = "nomeProdutoDataGridViewTextBoxColumn";
            this.nomeProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeProdutoDataGridViewTextBoxColumn.Width = 180;
            // 
            // precoPagoDataGridViewTextBoxColumn
            // 
            this.precoPagoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.precoPagoDataGridViewTextBoxColumn.DataPropertyName = "PrecoPago";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.precoPagoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.precoPagoDataGridViewTextBoxColumn.HeaderText = "Preco Pago";
            this.precoPagoDataGridViewTextBoxColumn.Name = "precoPagoDataGridViewTextBoxColumn";
            this.precoPagoDataGridViewTextBoxColumn.ReadOnly = true;
            this.precoPagoDataGridViewTextBoxColumn.Width = 120;
            // 
            // precoVendaDataGridViewTextBoxColumn
            // 
            this.precoVendaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.precoVendaDataGridViewTextBoxColumn.DataPropertyName = "PrecoVenda";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.precoVendaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.precoVendaDataGridViewTextBoxColumn.HeaderText = "Preco Venda";
            this.precoVendaDataGridViewTextBoxColumn.Name = "precoVendaDataGridViewTextBoxColumn";
            this.precoVendaDataGridViewTextBoxColumn.ReadOnly = true;
            this.precoVendaDataGridViewTextBoxColumn.Width = 120;
            // 
            // estoqueDataGridViewTextBoxColumn
            // 
            this.estoqueDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.estoqueDataGridViewTextBoxColumn.DataPropertyName = "Estoque";
            this.estoqueDataGridViewTextBoxColumn.HeaderText = "Estoque";
            this.estoqueDataGridViewTextBoxColumn.Name = "estoqueDataGridViewTextBoxColumn";
            this.estoqueDataGridViewTextBoxColumn.ReadOnly = true;
            this.estoqueDataGridViewTextBoxColumn.Width = 150;
            // 
            // Frm_listar_todos_produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 442);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv_produtos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Frm_listar_todos_produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_listar_todos_produtos";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_listar_todos_produtos_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produtos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_total_produtos_estocado;
        private System.Windows.Forms.Label lb_capital_estocado;
        private System.Windows.Forms.Label lb_qdt_produtos_cadastrados;
        private System.Windows.Forms.Label labelEstoqueAtual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_produtos;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoPagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource produtoBindingSource;
    }
}