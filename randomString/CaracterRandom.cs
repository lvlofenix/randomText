using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace randomString
{
    public class CaracterRandom
    {
        public string erro = null;
        Random rd = new Random();
        public String randomName(int opcao, int tamanho)
        {
            try
            {
                string nome = null;
                char[] chars;
                chars = new char[62];
                int declarechars = 0;
                if (opcao == 1) { chars = "abcdefghijklmnopqrstuvxywz".ToCharArray(); declarechars = 26; }
                else if (opcao == 2) { chars = "ABCDEFGHIJKLMNOPQRSTUVXYWZ".ToCharArray(); declarechars = 26; }
                else if (opcao == 3) { chars = "abcdefghijklmnopqrstuvxywzABCDEFGHIJKLMNOPQRSTUVXYWZ".ToCharArray(); declarechars = 52; }
                else if (opcao == 4) { chars = "0123456789".ToCharArray(); declarechars = 10; }
                else if (opcao == 5) { chars = "0123456789abcdefghijklmnopqrstuvxywz".ToCharArray(); declarechars = 36; }
                else if (opcao == 5) { chars = "0123456789abcdefghijklmnopqrstuvxywzABCDEFGHIJKLMNOPQRSTUVXYWZ".ToCharArray(); declarechars = 62; }
                else if (opcao == 6) { chars = "!@#$%¨&*()_+-=´[`{ª^~}]º/°?;:.>,<|¹²³£¢¬§".ToCharArray(); declarechars = 41; }

                for (int i = 0; i < tamanho; i++)
                {
                    nome = nome + chars[rd.Next(0, declarechars)];
                }
                return nome;
            }
            catch (Exception err)
            {
                erro = err.Message;
                return null;
            }
        }
    }
}
