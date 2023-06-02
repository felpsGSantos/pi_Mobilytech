using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace MobilityTech
{

    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            sublinhado();

            
        }

        public void sublinhado()
        {
            lblCadastro.Text = "Cadastre-se";
            lblCadastro.Font = new Font(lblCadastro.Font, FontStyle.Underline);

            lblEsqueceuSenha.Text = "Esqueceu a senha?";
            lblEsqueceuSenha.Font = new Font(lblEsqueceuSenha.Font, FontStyle.Underline);
           

        }
    }

   

    
}
