﻿using ERP.SessaoUsuario;
using System;
using System.Windows.Forms;
using SysVendas.frm;

namespace ERP.frm
{
    public partial class Frm_principal : Form
    {
        Frm_inicializa Login;
        public Frm_principal(Frm_inicializa login)
        {
            InitializeComponent();

            toolStripStatusLabel2.Text = DateTime.Now.ToString("dd/mm/yyyy");
            toolStripStatusLabel3.Text = "Seu sistema expira emm ";
            Login = login;
        }
        
        private void Frm_principal_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Escape:
                        Login.Dispose();
                        break;

                    case Keys.F2:
                        AbreFormCadastrarClientes();
                        break;

                    case Keys.F3:
                        AbreFormCadastrarProdutos();
                        break;

                    case Keys.F4:
                        AbreFormCadastrarFuncionarios();
                        break;

                    case Keys.F5:
                        AbreFormEntradaEstoque();
                        break;

                    case Keys.F12:
                        AbreFormPdv();
                        break;

                }
            }
            catch (Exception i)
            {
                MessageBox.Show("Houve um problema na ação realizada \n" + i.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbreFormCadastrarClientes();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Login.Dispose();
        }
        

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbreFormCadastrarProdutos();
        }

        public void AbreFormCadastrarProdutos()
        {
            try
            {
                var CadastrarProdutos = new Frm_cadastrar_produto();
                CadastrarProdutos.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve  um problema ao construir tela \n" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AbreFormCadastrarClientes()
        {
            try
            { 
                var CadastrarClientes = new Frm_cadastrar_cliente();
                CadastrarClientes.Show();          
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve  um problema ao construir tela \n" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AbreFormCadastrarFuncionarios()
        {
            try
            {
                var CadastrarFuncionarios = new Frm_cadastro_funcionarios();
                CadastrarFuncionarios.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve  um problema ao construir tela \n" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AbreFormPdv()
        {
            try
            {
                var pdv = new Frm_pdv();
                pdv.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve  um problema ao construir tela \n" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbreFormCadastrarFuncionarios();
        }

        private void pDVToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbreFormPdv();
        }

        private void Pdv_Click(object sender, EventArgs e)
        {
            AbreFormPdv();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbreFormListaClientes();
        }

        public void AbreFormListaClientes()
        {
            try
            {
                var ListaClientes = new Frm_lista_clientes();
                ListaClientes.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Houve uma falha ao construir a tela" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void AbreFormListaProdutos()
        {
            try
            {
                var Listar_todos_produtos = new Frm_listar_todos_produtos();
                Listar_todos_produtos.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao construir a tela" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AbreFormListaVendas()
        {
            try
            {
                var Listar_vendas = new Frm_listar_vendas();
                Listar_vendas.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao construir a tela" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AbreFormEntradaEstoque()
        {
            try
            {
                var Entrada_estoque = new Frm_entrada_estoque();
                Entrada_estoque.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao construir a tela" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void AbreFormEstoqueBaixo()
        {
            try
            {
                var Estoque_baixo = new Frm_estoque_baixo();
                Estoque_baixo.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao construir a tela \n" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AbreFormClientes_inadimplenteso()
        {
            try
            {
                var Clientes_inadimplentes = new Frm_clientes_inadimplentes();
                Clientes_inadimplentes.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha ao construir a tela \n" + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbreFormListaProdutos();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbreFormListaVendas();
        }

        private void entradaEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbreFormEntradaEstoque();
        }

        private void estoqueBaixoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbreFormEstoqueBaixo();
        }

        private void clientesInadimplentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbreFormClientes_inadimplenteso();
        }
    }
}
