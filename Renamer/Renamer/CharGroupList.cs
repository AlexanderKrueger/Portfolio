using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renamer
{
    partial class CharGroupList
    {
        //---FIELDS---
        public static List<CharGroup> CharGroupList = new List<CharGroup>();
       
        //---CONTRUCTORS---
        //public void CharGroupList() { /*Required empty constructor*/ }
    
        //---METHODS---
        //public void IdPrefixes() {}
        //public void IdRootWords() {}
        //public void IdSuffixes() {}
        public void IdWords()
        {
            int FirstIndexOfMatched = 0;//'FirstIndexOfMatched' is the substring in the 'FileNameCopy' that matchs the word from the loaded dictionary
            /*FileName;*/ //Title of file that is to remain unmodified
            string FileNameCopy;/*= FileName;*/ //Copy of 'FileName' that is meant for modifacation. Matched words in 'FileNameCopy' will be removed.
            string MatchedSubstring = null; //Contains substring from 'FileNameCopy' that matches a word from the loaded dictionary
            //TODO: Place "LoadDictionary(/*Dictionary Name*/);" here
            foreach(string Word in Dictionary.LoadedDictionary)
            {
                foreach()
                {
            //...delclarations

            //copy file name to new string: FileNameCopy

            //:Top
            //check for a substring in 'FileNameCopy' containing next word in loaded dictionary

            //if there's no match, then...
            //return to top

            //Else, if there's a match, then...
            //(+) create 'CharGroup' with match
            //remove matched substring from 'FileNameCopy'
            //
            //<placing>
            //if there  are characters before the matched substring, then...
            //create a empty 'CharGroup' before the matched substring's 'CharGroup'
            //
            //if there are characters after the matched substring, then...
            //create a empty 'CharGroup' after the matched substring's 'CharGroup'

            FirstIndexOfMatched = FileNameCopy.Length - MatchedSubstring.Length;//Correctly calculates before or after removal of matched substring
 
            //Check if a character existed after the matched. Note: below condition was derived from the above lines of comments
            //Note: IndexOfCharAfter = FirstIndexOfMatched ; 'IndexOfCharAfter' is purly descriptive and isn't a variable in the program.
            //TODO: May need to be placed elsewhere. Is here now as to create a new objectc.  
            if ( FileNameCopy.ElementAtOrDefault(FirstIndexOfMatched) is char ) { /*At this point, there are 1 or more chars after matched substring in 'FileNameCopy' */ CreateEmptyLeftOfSelf(); }//attach method to CharGroup type

            //Check if a character existed before the matched. Note: below condition was derived from the above lines of comments//TODO: reavaluate above chunk of comment lines
            //Note: IndexOfCharBefore = FirstIndexOfMatch - 1 ; 'IndexOfCharBefore' is purly descriptive and isn't a variable in the program.
            if ( FileNameCopy.ElementAtOrDefault(FirstIndexOfMatched - 1) is char ) { /*At this point, there are 1 or more chars before matched substring in 'FileNameCopy' */ CreateEmptyRightOfSelf(); }//Note: Make PlaceNewEmptyLeft() & PlaceNewEmptyRight() as methods of the 'CharGroup' class
        }
            }
        }
        public void IdRemainingAsStuffing() { }

        /// <summary>
        /// Adds a new empty 'CharGroup' object to the 'CharGroupList'.
        /// </summary>
        public void AddCharGroup()
        {
            CharGroupList.Add(new CharGroup());
        }
        /// <summary>
        /// Adds a new 'CharGroup' object to the 'CharGroupList'.
        /// </summary>
        /// <param name="CharGroupArg"></param>
        public void AddCharGroup(CharGroup CharGroupArg)
        {
            CharGroupList.Add(CharGroupArg);
        }
        /// <summary>
        /// Adds a new 'CharGroup' object to the 'CharGroupList'.
        /// </summary>
        /// <param name="TypeOfGroup"></param>
        public void AddCharGroup(CharGroup.GroupTypes TypeOfGroup)
        {
           CharGroupList.Add(new CharGroup(TypeOfGroup));
        }
        /// <summary>
        /// Adds a new 'CharGroup' object to the 'CharGroupList'.
        /// </summary>
        /// <param name="TypeOfGroup"></param>
        /// <param name="CharsOfGroup"></param>
        public void AddCharGroup(CharGroup.GroupTypes TypeOfGroup, List<char> CharsOfGroup)
        {
            CharGroupList.Add(new CharGroup(TypeOfGroup, CharsOfGroup));
        }
        /// <summary>
        /// Adds a new 'CharGroup' object to the 'CharGroupList'.
        /// </summary>
        /// <param name="TypeOfGroup"></param>
        /// <param name="PacketOfChars"></param>
        public void AddCharGroup(CharGroup.GroupTypes TypeOfGroup, string PacketOfChars)
        {
            CharGroupList.Add(new CharGroup(TypeOfGroup, PacketOfChars));
        }

        //---NESTED CLASSES---
        public partial class CharGroup {}
    }
}
