using System;
using System.Windows.Forms;

namespace BotaoMensagem
{
    public class FormPrincipal : Form
    {
        private Button botaoMensagem;

        public FormPrincipal()
        {
            // Criar botão
            botaoMensagem = new Button();
            botaoMensagem.Text = "Clique Aqui";
            botaoMensagem.Width = 150;
            botaoMensagem.Height = 50;
            botaoMensagem.Top = 100;
            botaoMensagem.Left = 100;

            // Evento de clique
            botaoMensagem.Click += BotaoMensagem_Click;

            // Adicionar botão ao formulário
            Controls.Add(botaoMensagem);
        }

        private void BotaoMensagem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Obrigado por participar, as informações não serão salvas pois é um ambiente simulado!", "Aviso");
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new FormPrincipal());
        }
    }
}
