using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MissionPlanner
{
    class configPassword
    {
        private string senha;
        bool senhaConfigurada = false;
        bool senhasIguais = false;

        public static configPassword instance;
        public configPassword() { }

        public static configPassword Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new configPassword();
                }
                return instance;
            }
        }


        public void setSenha(string senha)
        {
            this.senha = senha;
        }

        public bool getSenhaConfigurada()
        {
            return senhaConfigurada;
        }
        public void setSenhaConfigurada(bool senhaConfigurada)
        {
            this.senhaConfigurada = senhaConfigurada;
        }
    }
}
