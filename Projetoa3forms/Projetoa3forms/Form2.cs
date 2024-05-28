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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            SetupTextBox();

        }

        private void SetupTextBox()
        {

            textBoxTitle.Text = "Titulo";
            textBoxTitle.ForeColor = Color.Gray;

            textBoxValor.Text = "Valor";
            textBoxValor.ForeColor = Color.Gray;

            textBoxCategoria.Text = "Categoria";
            textBoxCategoria.ForeColor = Color.Gray;

            // Adcionar os eventos Enter e Leave

            textBoxTitle.Enter += TextBoxTitle_Enter;
            textBoxTitle.Leave += TextBoxTitle_Leave;

            textBoxValor.Enter += TextBoxValor_Enter;
            textBoxValor.Leave += TextBoxValor_Leave;

            textBoxCategoria.Enter += TextBoxCategoria_Enter;
            textBoxCategoria.Leave += TextBoxCategoria_Leave;
        }

        private void TextBoxValor_Leave(object sender, EventArgs e)
        {
            if (textBoxTitle.Text == "")
            {
                textBoxTitle.Text = "Valor";
                textBoxTitle.ForeColor = Color.Gray;
            }
        }

        private void TextBoxValor_Enter(object sender, EventArgs e)
        {
            if (textBoxTitle.Text == "Valor")
            {
                textBoxTitle.Text = "";
                textBoxTitle.ForeColor = Color.Black;
            }
        }

        private void TextBoxCategoria_Leave(object sender, EventArgs e)
        {
            if (textBoxTitle.Text == "")
            {
                textBoxTitle.Text = "Categoria";
                textBoxTitle.ForeColor = Color.Gray;
            }
        }

        private void TextBoxCategoria_Enter(object sender, EventArgs e)
        {
            if (textBoxTitle.Text == "Categoria")
            {
                textBoxTitle.Text = "";
                textBoxTitle.ForeColor = Color.Black;
            }
        }

        private void TextBoxTitle_Enter(object sender, EventArgs e)
        {
            if (textBoxTitle.Text == "Titulo")
            {
                textBoxTitle.Text = "";
                textBoxTitle.ForeColor = Color.Black;
            }
        }

        private void TextBoxTitle_Leave(object sender, EventArgs e)
        {
            if(textBoxTitle.Text == "")
            {
                textBoxTitle.Text = "Titulo";
                textBoxTitle.ForeColor = Color.Gray;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Usa BeginInvoke para definir o foco após o formulário ser carregado
            this.BeginInvoke((Action)delegate
            {
                btnCadastrar.Focus();
            });
        }
    }
}
