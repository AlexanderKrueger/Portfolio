using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renamer
{
    public partial class Dictionary
    {
        public partial class JumpMap
        {
            //---FIELDS---
            /// <summary>
            ///  Helps bypass datatype conversions by being a map of references. Key value is the length of words in a section of the dictionary(as dictionary is sorted by word length too).
            /// </summary>
            /// <remarks>
            ///  After being filled with markers extrapalated from the 'LoadedDictionary' (from 'Dictionary' class), dictionary might contain empty elements. Empty elements in the dictionary is not a code breaker and is unlikly, however, should -as a recomdation- be factored into the conditonal logic of new code to prevent future posiable issues.
            /// </remarks>
            public Dictionary<byte, int> Markers = new Dictionary<byte, int>();
            public byte CurrentIndex = 0;//For looping, variable acts a controllable focus on the lookup table.

            //---CONSTRUCTORS---
            /// <summary>
            /// An empty constructor that assigns no values to constructed objects.
            /// </summary>
            public JumpMap() { /*Empty Constructer*/ } //Question: Is this even posiable with a lookup table?

            /// <summary>
            /// Constructor takes the 'LoadedDictionary' (from 'Dictionary' class) as an argument, and makes markers for the new jumpmap.
            /// </summary>
            /// <remarks>
            /// Constructor does NOT incure an error if the argument is not 'LoadedDictionary' (from 'Dictionary' class) as the constructor, unfortunetly, accepts any List&ltstring&gt.
            /// </remarks>
            /// <seealso cref="Dictionary.JumpMap.Markers"/>
            /// <seealso cref="Dictionary.LoadedDictionary"/>
            /// <param name="LoadedDictionary"></param>
            public JumpMap(List<string> LoadedDictionary)//Data type may not be linked(referenced to origin). For instance, a data type defined in the parent class that is unusable in it's nested class; in which case this is a issue with scope.
            {
                this.RegisterMarkers(LoadedDictionary);
            }

            //---METHODS---
            /// <summary>
            /// Gets a index from a specified 'marker'.
            /// </summary>
            /// <param name="TargetMarker"></param>
            /// <returns></returns>
            public int JumpTo(byte TargetMarker)
            {
                return Markers[TargetMarker];
            }
            /// <summary>
            /// Gets the next marker's index.
            /// </summary>
            /// <returns></returns>
            public int JumpToNext()
            {
                CurrentIndex++;
                return Markers[CurrentIndex];
            }
            /// <summary>
            /// Gets the previouses marker's index.
            /// </summary>
            /// <returns></returns>
            public int JumpToPrev()
            {
                CurrentIndex--;
                return Markers[CurrentIndex];
            }
            /// <summary>
            /// Registers markers from the 'LoadedDictionary' argument.
            /// </summary>
            /// <remarks>
            /// Although not the only acceptable argument, please use the list 'LoadedDictionary' from 'Dictionary' class.
            /// </remarks>
            /// <seealso cref="Dictionary.LoadedDictionary"/>
            /// <seealso cref="Dictionary.JumpMap.Markers"/>
            /// <param name="LoadedDictionary"></param>
            public void RegisterMarkers(List<string> LoadedDictionary)
            {
                int BiggestWord = LoadedDictionary[LoadedDictionary.Length - 1];//Refers to length of last word
                int MarkerNumber = 0;//Serves as a counter so markers can be put in their rightfull place in the 'Markers' dictionary, instead of overighting previous values.
                for (int TargetWordLength = 0; TargetWordLength < BiggestWord; i++)//TrackedWordLength: 
                {
                    //TODO: Use improved use of LINQ methods for a performance and readability boost.
                    if (LoadedDictionary.Contains(Word => Word.Length == TargetWordLength))//Find first(could be issue) element of 'TargetWordLength', and mark it on the jumpmap's dictionary.
                    {
                        Markers[MarkerNumber] = LoadedDictionary.IndexOf(LoadedDictionary.Find(Word => Word.Length == TargetWordLength));
                        MarkerNumber++;
                    }
                    else
                    {
                        MarkerNumber++;
                    }
                }
            }
        }
    }
}
