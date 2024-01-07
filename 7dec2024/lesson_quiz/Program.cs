using System;

namespace lesson_quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reversed("salam");

            string[] array = { "salam", "necesiz", "4", "5" };
            RemoveElement(ref array, 2);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            string text = "        salam";
            Console.WriteLine(FrontSpaces(text));
        }
        #region Task4
        //Verilmiş sözün tərsdən oxunuşunun özü ilə eyni olub olmadığnı tapan metod
        static void Reversed(string word)
        {
            string reverseWord = "";
            for(int i = word.Length-1; i >= 0; i--)
            {
                reverseWord += word[i];
            }

            if (reverseWord == word)
                Console.WriteLine("Eynidir");
            else Console.WriteLine("Eyni deyil");

        }
        #endregion

        #region Task5
        //Verilmiş array-dən verilmiş indexli elementi silən metod.
        static void RemoveElement(ref string[] arr, int index)
        {
            string[] newArr = new string[arr.Length-1];
            string removing = "";
            for(int i = 0; i<arr.Length; i++)
            {
                if (index == i)
                    removing = arr[index];
                    
            }
            for(int i = 0;i<arr.Length-1; i++)
            {
                if (arr[i]!= removing)
                {
                    newArr[i] = arr[i];
                }
            }

            arr = newArr;
            
        }
        #endregion


        #region Task6
        //Verilmiş yazının əvvəlindəki boşluqları silən metod
        static string FrontSpaces(string str)
        {
            string newStr = "";
            int startIndex = IlkIndex(str);

            if (startIndex == -1) return str;

            for (int i = startIndex; i < str.Length; i++)
            {
                newStr += str[i];
            }

            return newStr;
        }

        static int IlkIndex(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ') return i;
            }

            return -1;
        }

        #endregion
    }
}
