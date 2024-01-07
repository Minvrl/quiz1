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
            FrontSpaces(ref text);
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

        static void FrontSpaces(ref string text)
        {
            string newText = "";
            int startIndex = 0;

            for(int i = 0; i< text.Length; i++)
            {
                if (text[i] != ' ')
                    startIndex = i;
                break;
            }

            for(int i = startIndex; i < text.Length; i++)
            {
                newText += text[i];
            }
            text = newText;

            Console.WriteLine(newText);
            
        }

        #endregion
    }
}
