using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MissionPlanner.Utilities;

namespace MissionPlanner
{
    public partial class setPassword : Form
    {
        string senha = "", confirmacao = "1";//"a3r14l5";
        private bool senhasIguais = false;
        configPassword configurar = configPassword.Instance;
        

        public static setPassword instance;

        public static setPassword Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new setPassword();
                }
                return instance;
            }
        }



        public setPassword()
        {
            InitializeComponent();
            Utilities.ThemeManager.ApplyThemeTo(this);
            txtSenha.PasswordChar = '*';
            txtSenha.TextAlign = HorizontalAlignment.Center;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //setSenhasIguais(false);
            //if (configurar.getSenhaConfigurada() == false)
            //{
                senha = txtSenha.Text;
                //confirmacao = txtConfirmacao.Text;
                //txtConfirmacao.Visible = true;
                //mylblRedigitar.Visible = true;
                if (senha == confirmacao)
                {
                    //configurar.setSenha(senha);
                    configurar.setSenhaConfigurada(true);
                    mylblErroSenha.Visible = false;
                    txtSenha.Text = "";
                    setSenhasIguais(true);
                    this.Close();
                }
                else
                {
                    //configurar.setSenhaConfigurada(false);
                    mylblErroSenha.Visible = true;
                    txtSenha.Text = "";
                    setSenhasIguais(false);
                }
            }
        /*else
        {
            string senhaComparar = txtSenha.Text;
            if (senhaComparar == confirmacao)
            {
                setSenhasIguais(true);
                mylblErroSenha.Visible = false;
                txtSenha.Text = "";
                this.Close();
            }else
                if (senhaComparar == redefinir)
                {
                    configurar.setSenhaConfigurada(false);
                    this.btnOK_Click(sender,e);
                }
                

            else
            {
                setSenhasIguais(false);
                mylblErroSenha.Text = "Senha errada!";
                mylblErroSenha.Visible = true;
                txtSenha.Text = "";
            }
        }
    }*/

        public bool getSenhasIguais()
        {
            return this.senhasIguais;
        }
        public void setSenhasIguais(bool senhasIguais)
        {
            this.senhasIguais = senhasIguais;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            setSenhasIguais(false);
            this.Close();
        }
    }
}
