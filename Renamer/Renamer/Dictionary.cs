using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Renamer
{
    public partial class Dictionary
    {
        //---FIELDS---
        /// <summary>
        /// Contains words loaded from a dictionary file
        /// </summary>
        /// <remarks>
        /// This list array starts off empty. Filling this list array will require the use of the 'LoadDictionary()' method.
        /// </remarks>
        public static List<String> LoadedDictionary = new List<String>();
        //---CONSTRUCTORS---

        //---METHODS---
        /// <summary>
        /// Loads each word from a dictionary file into their own element that exists in the 'LoadedDictionary' list array.
        /// </summary>
        /// <remarks>
        /// After puting words in the same order from the dictionary to the 'LoadedDictionary' list array, elements are reversed to -hopefully- order from biggest words to smallest words. Even after loading a dictionary, this method may be reused to load a diffrent dictionary(other dictionarys are for deffrent languages). BUG: Dictionary is not loaded in alphabetical order.
        /// </remarks>
        /// <param name="DictionaryName"></param>
        public static void LoadDictionary(string DictionaryName)
        {
            FileInfo DictionaryFile = new FileInfo("~/Dictionarys/" + DictionaryName);//TODO: Test if resulting file path is expected path
            LoadedDictionary.Clear();
            try
            {
                int InsertionPoint = 0;//Index of array where stuff will be inserted.
                string Word = "";//Contains a word from the dictionary file.
                string PrevWord = "";//Contains the previous value of 'Word'.
                bool NotAtFileEnd =  DictionaryFile.OpenText().Peek() != -1;//A flag for when the files end is reached. flag is given a value early in case should(and I don't know yet) a completly empty array will result in -1.

                //***Reverse Alphabetic SubOrder***
                while(NotAtFileEnd)//TODO: Clean up and clarify documentation within this while loop
                {
                    Word = DictionaryFile.OpenText().ReadLine();//Get next word
                    if(Word.Length != PrevWord.Length)//If they're not equal length
                    { 
                        InsertionPoint = LoadedDictionary.Capacity - 1; //then set InsertionPoint at current point
                        /*AddToJumpMap();*/ //part of individual sub class
                    }
                    LoadedDictionary.Insert( /*at*/ InsertionPoint, /*the*/ Word);//Word placed at defined index
                    
                    NotAtFileEnd = DictionaryFile.OpenText().Peek() != -1;//See if at array's end
                }

                //Brings back alphabetic order after the intentional order reversing by word length, and sets the element order from longest word to shortest.
                LoadedDictionary.Reverse();//Puts biggest words first. Of Course, this is assuming that the smallest words are first in a dictionary file
            }
            catch (EndOfStreamException) { Console.WriteLine("Exception thrown: EndOfStreamException"); }
            catch (FileNotFoundException) { Console.WriteLine("Exception thrown: FileNotFoundException"); }
            catch (AccessViolationException) { Console.Write("Exception thrown: AccessViolationException"); }
        }
        //---NESTED CLASSES---
        public partial class JumpMap { }
    }
}
