using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsCRTC
{
    public class ValidarCart
    {
        public static Boolean ValidaTamanho(string Ncartao)
        {
            #region TamanhoCartao
            if (Ncartao.Length != 16)
                return false;
            #endregion
            #region Variaveis
            int Soma = 0;
            int SomaGeral = 0;
            int Divisao = 0;
            #endregion

            #region Sequencia
            for (int i = 0; i < 16; i++)
            {

                if (i % 2 == 0)
                {
                    Soma = int.Parse(Ncartao.Substring(i, 1)) * 2;

                    if (Soma > 9)
                    {
                        Soma -= 9;
                        SomaGeral += Soma;
                    }
                    else
                    {
                        SomaGeral += Soma;
                    }

                }
                if (i % 2 == 1)
                {
                    Soma = int.Parse(Ncartao.Substring(i, 1));
                    SomaGeral += Soma;
                }
            }
            #endregion

            Divisao = SomaGeral % 10;

            if (Divisao == 0)
            {
              return true;
            }
                else
                {
                    return false;
                }
        }
    }
}
