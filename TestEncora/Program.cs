using System;
using System.Collections.Generic;
using System.Linq;

namespace TestEncora
{
    public class Program
    {

        private static string[] sortByMoreCaracteres(string[] wordToFormatByQTY)
        {
            string[] newWordSorted = new string[wordToFormatByQTY.Length];
            string result = string.Empty;

            int countWordsToSort = 0;
            foreach (string word in wordToFormatByQTY)
            {
                string NewWord = word;
                if (!string.IsNullOrEmpty(NewWord) && NewWord != "")
                {
                    char[] charArrLetter = NewWord.ToCharArray();

                    List<Tuple<int, int, string>> listOrderMoreCaracteres = new List<Tuple<int, int,string>>();

                    int positionList = 0;
                    while (NewWord.Length > 0)
                    {
                        var countLetter = NewWord.Split(NewWord[0]).Length - 1;
                        string letters = NewWord.Substring(0, countLetter);
                        listOrderMoreCaracteres.Add(new Tuple<int, int, string>(countLetter, System.Convert.ToInt32(NewWord[0]), letters));
                        NewWord = NewWord.Replace(NewWord[0].ToString(), string.Empty);
                        positionList++;
                    }
                    var ListOrdened = listOrderMoreCaracteres.OrderByDescending(x => x.Item1).ToList();                  

                    foreach (var x in ListOrdened)
                    {
                        result += x.Item3;
                    }
                    newWordSorted[countWordsToSort] = result;
                    Console.WriteLine(result);
                    countWordsToSort++;
                    result = string.Empty;
                }
            }            
            return newWordSorted;
        }
        
        private static string[] sortAlphabetic(string[] wordToFormat)
        {
            string[] newWordSorted = new string[wordToFormat.Length];
            int loopWords = 0;
            foreach (string wordToSort in wordToFormat)
            {
                if (!string.IsNullOrEmpty(wordToSort))
                {
                    wordToSort.ToUpper();
                    
                    char[] charArrLetter = wordToSort.ToCharArray();

                    Array.Sort(charArrLetter, StringComparer.InvariantCulture);
                   
                    string chartoString = new string(charArrLetter);
                    newWordSorted[loopWords] = chartoString;
                    loopWords++;
                }
            }
            return newWordSorted;
        }


        public static string[] sortingOperations(string[] wordToFormat)
        {
            if (wordToFormat != null && wordToFormat.Length > 0)
            {
                string[] orderbyAlphabetich = sortAlphabetic(wordToFormat);

                string[] orderByMoreCaracteres = sortByMoreCaracteres(orderbyAlphabetich);
                return orderByMoreCaracteres;
            }            
            return wordToFormat;

        }
        static void Main(string[] args)
        {
            string[] wordsArray = new string[5];
            wordsArray[0] = "abaccadcc";
            wordsArray[1] = "xyzxy";
            if (wordsArray != null && wordsArray.Length > 0)
            {
                sortingOperations(wordsArray);
            }
            else
            {
                Console.WriteLine("The array must have at least 1 entry.");
            }
        }
    }
}
