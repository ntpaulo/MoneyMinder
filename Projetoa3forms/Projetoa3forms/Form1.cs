using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projetoa3forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Configura o DataGridView
            ConfigureDataGridView();

            //Vincula Dados de exemplo
            BindData(); 
        }

        private void ConfigureDataGridView()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Define as colunas do DataGridView

            var titleColumn = new DataGridViewTextBoxColumn
            {
                Name = "Title",
                HeaderText = "Título",
                DataPropertyName = "Title" //Vincula esta coluna à propriedade Title do objeto Transaction
            };
            dataGridView1.Columns.Add(titleColumn);

            var amountColumn = new DataGridViewTextBoxColumn
            {
                Name = "Amount",
                HeaderText = "Valor",
                DataPropertyName = "Amount" // Vincula esta coluna à propriedade amount do objeto Transaction
            };
            dataGridView1.Columns.Add(amountColumn);

            var categoryColumn = new DataGridViewTextBoxColumn
            {
                Name = "Category",
                HeaderText = "Categoria",
                DataPropertyName = "Category" // Vincula esta coluna à propriedade Category do objeto Transaction
            };
            dataGridView1.Columns.Add(categoryColumn);

            var dateColumn = new DataGridViewTextBoxColumn
            {
                Name = "Date",
                HeaderText = "Data",
                DataPropertyName = "Date" // Vincula esta coluna à propriedade Date do objeto Transaction
            };
            dataGridView1.Columns.Add(dateColumn);

        }

        private void BindData()
        {
            // Cria uma lista de transações de exemplo
            List<Transaction> transactions = new List<Transaction>
            {
                new Transaction {Title = "Compra de Café", Amount = -5.00m, Category = "Débito", Date = DateTime.Now},
                new Transaction {Title = "Salário", Amount = 1500.00m, Category = "Crédito", Date = DateTime.Now.AddDays(-1)},
                new Transaction {Title = "Conta de luz", Amount = -200.00m, Category = "Débito", Date = DateTime.Now.AddDays(-2)}
            };

            // Vincula a lista de transações ao DataGridView
            dataGridView1.DataSource = transactions;

        }

        public class Transaction
        {
            public string Title { get; set; }
            public decimal Amount { get; set; }
            public string Category { get; set; }
            public DateTime Date { get; set; }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Cria uma nova instância do formulário que você quer abrir
            Form2 form2 = new Form2();

            //Define a posição inicial do novo formulario
            form2.StartPosition = FormStartPosition.Manual;

            //Calcula a posição centralizada em relação ao form1
            int x = this.Location.X + (this.Width - form2.Width) / 2;
            int y = this.Location.Y + (this.Height - form2.Height) / 2;
            form2.Location = new Point(x, y);

            // Exibe o formulário como uma janela modal
            form2.ShowDialog();
        }
    }
}
