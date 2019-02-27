using System;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = 0;
            string str1 = ""; //一行に表示する数値文字列
            string str2 = ""; //一行に表示するキャラクタ文字列
            string fileName = "";

            Console.WriteLine(@"ファイル名をパスから入力してください。例）C:\hoge.txt");
            fileName = Console.ReadLine();
            byte[] data = File.ReadAllBytes(fileName); //表示したいファイル名
            foreach (int n in data) {

                str1 += n.ToString("X2");

                if (n >= 33 && n <= 126)
                {
                    str2 += (char)n;

                }
                else
                {
                    str2 += ".";
                }

                if (b == 15)
                {

                    Console.WriteLine(str1 + " : " + str2);
                    str1 = "";
                    str2 = "";

                    b = 0;
                }
                else
                {
                    str1 += " ";

                    b++;
                }

            }

            Console.WriteLine(str1 + " : " + str2);

            Console.WriteLine("");
            Console.WriteLine("ファイルサイズ:" + data.Length.ToString() + "バイト");
            Console.WriteLine("完了しました。リターンを押すと終了します。");
            Console.ReadLine();
        }
    }
}
