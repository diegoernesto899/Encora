using System;
using System.Collections.Generic;
using System.Linq;

namespace TestEncora
{
    public class Program
    {
        /// <summary>
        /// This method sort strings from more caracteres to fewer caracteres  
        /// </summary>
        /// <param name="wordToFormatByQTY"></param>
        /// <returns>string array with string format </returns>
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
                        string letterSubstring = NewWord.Substring(0, countLetter);
                        listOrderMoreCaracteres.Add(new Tuple<int, int, string>(countLetter, System.Convert.ToInt32(NewWord[0]), letterSubstring));
                        NewWord = NewWord.Replace(NewWord[0].ToString(), string.Empty);
                        positionList++;
                    }
                    var ListOrdened = listOrderMoreCaracteres.OrderByDescending(x => x.Item1).ToList();                  

                    foreach (var mapResponse in ListOrdened)
                    {
                        result += mapResponse.Item3;
                    }

                    newWordSorted[countWordsToSort] = result;
                    Console.WriteLine(result);
                    countWordsToSort++;
                    result = string.Empty;
                }
            }            
            return newWordSorted;
        }
        /// <summary>
        /// This method organize strings by alphabetical order.
        /// </summary>
        /// <param name="wordToFormat"></param>
        /// <returns>String array with strigs alphabetical order.</returns>
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

        /// <summary>
        /// this method call the method sortAlphabetic and sortByMoreCaracteres
        /// </summary>
        /// <param name="wordToFormat"></param>
        /// <returns>response with data order by alphavetical and size caracteres</returns>
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
        /// <summary>
        /// this is Main method,this call sortingOperations
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string[] wordsArray = new string[10];
            wordsArray[0] = "dulgvgzwqg";
            wordsArray[1] = "gxtjtmtywr";
            wordsArray[2] = "hnlnxiupgt";
            wordsArray[3] = "gzjotckivp";
            wordsArray[4] = "dpwwsdptae";
            wordsArray[5] = "pcscpilknb";
            wordsArray[6] = "btvyhhmflf";
            wordsArray[7] = "artrtnqxcr";
            wordsArray[8] = "nrtcmcoadn";
            wordsArray[9] = "fkdsgnekft";


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
