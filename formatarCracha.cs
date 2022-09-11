using System;
using System.Collections.Generic;
using System.Text;

namespace solucao03_Cracha
{
    class formatarCracha
    {
        private static String nome;

        public static void setNome(String _nome) { nome = _nome; }
        public static String getNome() { return nome; }

        public static int getUltimoEspaco()
        {
            int i;
            for (i = nome.Length - 1; nome[i] != ' '; --i) ;
            return i;
        }

        public static String getUltimoSobrenome()
        {
            return nome.Substring(getUltimoEspaco() + 1, nome.Length - getUltimoEspaco() - 1).ToUpper();
        }

        public static String getIniciais()
        {
            String tam = nome.Substring(0, getUltimoEspaco());
            String aux = "";
            for(int l = 0; l < tam.Length; l++) {
            if(char.IsUpper(tam[l]) == true) {
                    aux += tam[l] + ". ";
                }
            };
                return aux;
        }
    }
}
