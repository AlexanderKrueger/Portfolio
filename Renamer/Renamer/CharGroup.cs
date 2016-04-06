using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renamer
{
    partial class CharGroupList
    {
        partial class CharGroup
        {
            //---FIELDS---
            static enum GroupTypes : byte { Prefix, RootWord, Suffix, Stuffing };//All posiable types for a character group//TODO: figure out how to switch 'readonly' modifier to a 'const'
            public GroupTypes GroupType; //An individual object's 'CharGroup' type
            public List<char> GroupChars = new List<char>(); //Characters in character group
            public string CharPacket; //'Packet' is simply a word collected by a method, though, can also contain 'stuffing'(random stuff)

            //---CONSTRUCTORS---
            public CharGroup() { /* Empty Constructor */ }
            public CharGroup(GroupTypes TypeOfGroup) { GroupType = TypeOfGroup; }
            public CharGroup(GroupTypes TypeOfGroup, List<char> CharsOfGroup) { GroupType = TypeOfGroup; GroupChars = CharsOfGroup; }
            public CharGroup(GroupTypes TypeOfGroup, string PacketOfChars) { GroupType = TypeOfGroup; CharPacket = PacketOfChars; }

            //---METHODS---
            /// <summary>
            /// While a 'CharGroup' object is in the 'CharGroupList', the invoking 'CharGroup' object can use this method to create an empty 'CharGroup' object on it's left side.
            /// </summary>
            /// <example>
            /// Contents of list array: Before: {myCharGroupObj} After: {(empty CharGroup),myCharGroupObj}
            /// </example>
            public void CreateEmptyLeftOfSelf()
            {
                if (CharGroupList.Contains(this))
                {
                    CharGroupList.Insert(CharGroupList.IndexOf(this), new CharGroup(/*Keep Empty*/));//Upon insertion of object, the element at the targeted index is pushed to the right. Thus, the creating 'CharGroup' object is pushed to the right, and the created 'CharGroup' object lands on the left side of the creater
                }
            }
            /// <summary>
            /// While a 'CharGroup' object is in the 'CharGroupList', the invoking 'CharGroup' object can use this method to create an empty 'CharGroup' object on it's right side.
            /// </summary>
            /// <example>
            /// Contents of list array: Before: {myCharGroupObj} After: {myCharGroupObj, (empty CharGroup)}
            /// </example>
            public void CreateEmptyRightOfSelf()
            {
                if (CharGroupList.Contains(this))
                {
                    CharGroupList.Insert(CharGroupList.IndexOf(this) + 1, new CharGroup(/*Keep Empty*/));//The new 'CharGroup' is inserted at the index after the creater's index so the 'CharGroup' lands on the right side of the creater
                }
            }
        }
    }
}
