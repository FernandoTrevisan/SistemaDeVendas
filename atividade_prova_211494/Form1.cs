using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade_prova_211494
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        int vendas = 1;

        int quantidade;

        double valor_unitario;

        double valor_total;

        double total = 0;

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            dgvProdutos.Rows.Add(txtDescricao.Text, txtQuantidade.Text, $"{double.Parse(txtValorUnitario.Text):C}");

            quantidade = int.Parse(txtQuantidade.Text);
            valor_unitario = double.Parse(txtValorUnitario.Text);
            valor_total = quantidade * valor_unitario;

            total += valor_total;

            lblTotal.Text = $"{total:C}";

            vendas++;
            lblVenda.Text = $"Venda: {vendas}";
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            dgvProdutos.Rows.RemoveAt(dgvProdutos.CurrentCell.ColumnIndex);

        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            dgvProdutos.CurrentRow.Cells[1].Value = txtQuantidadeSelecionada.Text;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaTextBox(txtDescricao, txtQuantidade, txtQuantidadeSelecionada, txtValorUnitario);
        }

        private void btnNovaVenda_Click(object sender, EventArgs e)
        {
            vendas++;
            lblVenda.Text = $"Venda: {vendas}";
            lblItensGrade.Text = $"Itens na grade: {vendas}";

            LimpaTextBox(txtDescricao, txtQuantidade, txtQuantidadeSelecionada, txtValorUnitario);
        }
        void LimpaTextBox(params TextBox[] textBoxes)
        {
            foreach (TextBox txt in textBoxes)
            {
                txt.Clear();
            }
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
