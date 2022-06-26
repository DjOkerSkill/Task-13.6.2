using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collection_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {

             string text = File.ReadAllText("C:\\Users\\Роман\\Desktop\\cdev_Text.txt");

            var noPunctuationText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());

            //Приведем текст в массив слов
            string[] ArString = noPunctuationText.Split(new char[] {' '});

            Dictionary<string, int> dr = new Dictionary<string, int>();

            //Размещаем слова в словаре и подсчитываем частотность
            foreach (string s in ArString)
                if (dr.Keys.Contains(s))
                { 
                    dr[s]++; 
                }

                else dr.Add(s, 1);

            string S = "";
            int k = 0;


            //Отбираем 10 наиболее частотных слов и в нашем случае отображем их в сообщении
            foreach (KeyValuePair<string, int> kk in dr.OrderByDescending(x => x.Value))
            {
               S += kk.Key + " " + kk.Value.ToString() + "\n";
               if (k == 10) break;
            }
            Console.WriteLine(S);






        }
    }
}
