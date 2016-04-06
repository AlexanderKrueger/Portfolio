using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Renamer
{
    class SpacingStyle
    {
        //---LOCALIZING DIRECTORY/FILE INFORMATION FROM FOLDER DIALOGE---
        //TODO: Replace creation of new field variables with usable references to 'FormRenamer' file/dir variables.
        //private static DirectoryInfo selectedDir = FormRenamer.selectedDir;
        //private static DirectoryInfo[] subDirInfo = FormRenamer.subDirInfo;
        //private static DirectoryInfo selectedDir = null;
        //private static DirectoryInfo[] subDirInfo = null;
        //private static FileInfo[] files = null;


        //---FIELDS---
        private static string oldName = "";
        private static string newName = "";
        private static string newNameSubString = "";
        private static int startIndexName = 0;
        private static StringBuilder strBuilderNewName = new StringBuilder();

        public static void ToSelectedStyle()
        {
            //---UPDATE IMPORTANT VARIABLES---
            //selectedDir = FormRenamer.selectedDir;
            //subDirInfo = FormRenamer.subDirInfo;
            //files = FormRenamer.files;

            //---TO NORMAL---
            //Formats files name with 'normal' spacing.
            //i.e. "My File Name"
            if (FormatSettings.fileSettings.isNormal == true)
            {
                foreach (FileInfo file in FormRenamer.files)
                {
                    if (file.Exists)
                    {
                        if (file.Name.Contains<char>('_'))//note: drive type//else go to word identifyer
                        {
                            oldName = file.FullName;
                            startIndexName = file.FullName.LastIndexOf('\\', file.FullName.Length - 1);//Length - 1 = lastIndex
                            newName = file.FullName.Remove(startIndexName + 1) + file.Name.Replace('_', ' '); //Renames file name within the full path
                            newNameSubString = newName.Substring(0, newName.Length - 1);//TODO: Handle scenario when substring of 'newName', and substrings of substring equal existing directory/file names by removing a letter each time till emptie; if still not working, keep adding char 'a' till name is diffrent. Also, handle scenario when name is initialy blank.

                            try
                            {
                                //WARNING: Below 2 'Move()' statments prevents the file/dir source and destination the same(i.e. .../dest.txt = .../dest.txt OR .../DEST.txt = dest.txt). Don't delete below.

                                //Change old filename to a slighlty short version of the new name, guarentieing that in 'case insensitive' context both strings are diffrent. Thus, alowing the 'Move()' method to work under normal circumstances.
                                File.Move(oldName, newNameSubString);
                                //Change 'newNameSubstring' to the intended new file name to complete the renaming process
                                File.Move(newNameSubString, newName);
                            }
                            catch (FileNotFoundException ex)
                            { /*Continue*/
                                Console.WriteLine(ex.Message);
                                Console.WriteLine(ex.StackTrace);
                            }//BUG: Mehtod 'File.Move()' renames dirFiles
                            //, but triggers a 'FileNotFoundException' despite success.
                        }
                    }
                }
            }

            if (FormatSettings.folderSettings.isNormal == true)
            {
                foreach (DirectoryInfo dir in FormRenamer.subDirInfo)
                {
                    if (dir.Exists)
                    {
                        if (dir.Name.Contains<char>('_'))
                        {
                            oldName = dir.FullName;
                            startIndexName = dir.FullName.LastIndexOf('\\', dir.FullName.Length - 1);//Length - 1 = lastIndex
                            newName = dir.FullName.Remove(startIndexName + 1) + dir.Name.Replace('_', ' '); //Renames file name within the full path
                            newNameSubString = newName.Substring(0, newName.Length - 1);//TODO: Handle scenario when substring of 'newName', and substrings of substring equal existing directory/file names by removing a letter each time till emptie; if still not working, keep adding char 'a' till name is diffrent. Also, handle scenario when name is initialy blank.

                            try
                            {
                                //WARNING: Below 2 'Move()' statments prevents the file/dir source and destination the same(i.e. .../dest.txt = .../dest.txt OR .../DEST.txt = dest.txt). Don't delete below.

                                //Change old directory name to a slighlty short version of the new name, guarentieing that in 'case insensitive' context both strings are diffrent. Thus, alowing the 'Move()' method to work under normal circumstances.
                                Directory.Move(oldName, newNameSubString);
                                //Change 'newNameSubstring' to the intended new file name to complete the renaming process
                                Directory.Move(newNameSubString, newName);
                            }
                            catch (DirectoryNotFoundException ex)
                            { /*Continue*/
                                Console.WriteLine(ex.Message);
                                Console.WriteLine(ex.StackTrace);
                            }//BUG: Mehtod 'Directory.Move()' renames dirFiles
                            //, but triggers a 'DirectoryNotFoundException' despite success.
                        }
                    }
                }
            }

            //---TO UNDERSCORE---
            //Formats files name with 'underscore' spacing.
            //i.e. "My_File_Name"
            if (FormatSettings.fileSettings.isUnderScore == true)
            {
                foreach (FileInfo file in FormRenamer.files)
                {
                    if (file.Exists)
                    {
                        if (file.Name.Contains<char>(' '))//note: drive type//else go to word identifyer
                        {
                            oldName = file.FullName;
                            startIndexName = file.FullName.LastIndexOf('\\', file.FullName.Length - 1);//Length - 1 = lastIndex
                            newName = file.FullName.Remove(startIndexName + 1) + file.Name.Replace(' ', '_'); //Renames file name within the full path
                            newNameSubString = newName.Substring(0, newName.Length - 1);//TODO: Handle scenario when substring of 'newName', and substrings of substring equal existing directory/file names by removing a letter each time till emptie; if still not working, keep adding char 'a' till name is diffrent. Also, handle scenario when name is initialy blank.

                            try
                            {
                                //WARNING: Below 2 'Move()' statments prevents the file/dir source and destination the same(i.e. .../dest.txt = .../dest.txt OR .../DEST.txt = dest.txt). Don't delete below.

                                //Change old filename to a slighlty short version of the new name, guarentieing that in 'case insensitive' context both strings are diffrent. Thus, alowing the 'Move()' method to work under normal circumstances.
                                File.Move(oldName, newNameSubString);
                                //Change 'newNameSubstring' to the intended new file name to complete the renaming process
                                File.Move(newNameSubString, newName);
                            }
                            catch (FileNotFoundException ex)
                            { /*Continue*/
                                Console.WriteLine(ex.Message);
                                Console.WriteLine(ex.StackTrace);
                            }//BUG: Mehtod 'File.Move()' renames dirFiles
                            //, but triggers a 'FileNotFoundException' despite success.
                        }
                    }
                }
            }

            if (FormatSettings.folderSettings.isUnderScore == true)
            {
                foreach (DirectoryInfo dir in FormRenamer.subDirInfo)
                {
                    if (dir.Exists)
                    {
                        if (dir.Name.Contains<char>(' '))
                        {
                            oldName = dir.FullName;
                            startIndexName = dir.FullName.LastIndexOf('\\', dir.FullName.Length - 1);//Length - 1 = lastIndex
                            newName = dir.FullName.Remove(startIndexName + 1) + dir.Name.Replace(' ', '_'); //Renames file name within the full path
                            newNameSubString = newName.Substring(0, newName.Length - 1);//TODO: Handle scenario when substring of 'newName', and substrings of substring equal existing directory/file names by removing a letter each time till emptie; if still not working, keep adding char 'a' till name is diffrent. Also, handle scenario when name is initialy blank.

                            try
                            {
                                //WARNING: Below 2 'Move()' statments prevents the file/dir source and destination the same(i.e. .../dest.txt = .../dest.txt OR .../DEST.txt = dest.txt). Don't delete below.

                                //Change old directory name to a slighlty short version of the new name, guarentieing that in 'case insensitive' context both strings are diffrent. Thus, alowing the 'Move()' method to work under normal circumstances.
                                Directory.Move(oldName, newNameSubString);
                                //Change 'newNameSubstring' to the intended new file name to complete the renaming process
                                Directory.Move(newNameSubString, newName);
                            }
                            catch (DirectoryNotFoundException ex)
                            { /*Continue*/
                                Console.WriteLine(ex.Message);
                                Console.WriteLine(ex.StackTrace);
                            }//BUG: Mehtod 'Directory.Move()' renames dirFiles
                            //, but triggers a 'DirectoryNotFoundException' despite success.
                        }
                    }
                }
            }

            //---TO NO SPACING---
            //Formats files name with no spacing.
            //i.e. "MyFileName"
            if (FormatSettings.fileSettings.isNoSpacing == true)
            {
                foreach (FileInfo file in FormRenamer.files)
                {
                    if (file.Exists)
                    {
                        oldName = file.FullName;
                        startIndexName = file.FullName.LastIndexOf('\\', file.FullName.Length - 1);//Length - 1 = lastIndex (note: 0 starts at right side in array for this method)
                        strBuilderNewName.Clear();

                        /*Instead of editing the string variable by assigning alterd copys of itself,
                         *a 'StringBuilder' object reduces the work by appending characters to a string.
                         *At the moment, the 'StringBuilder' object -after string is built-
                         *must pass its string value to the string 'newName'. Otherwise,
                         *the 'StringBuilder' object would be repeatedly converted into a string, and this
                         *is less effecient than the divised usage of the 'StringBuilder' object.
                         */

                        strBuilderNewName.Append(file.FullName.Remove(/*group of chars from*/startIndexName + 1 /*to string end*/));
                        foreach (char character in file.Name)
                        {
                            //Restricted characters are left out here.
                            switch (character)
                            {
                                //***Characters that make a 'Space Style'***
                                case (' '): break;
                                case ('_'): break;
                                //***Characters that don't make a 'Space Style'***
                                case ('-'): break;
                                default: strBuilderNewName.Append(character); break;
                            }
                        }
                        newNameSubString = newName.Substring(0, newName.Length - 1);//TODO: Handle scenario when substring of 'newName', and substrings of substring equal existing directory/file names by removing a letter each time till emptie; if still not working, keep adding char 'a' till name is diffrent. Also, handle scenario when name is initialy blank.

                        try
                        {
                            //WARNING: Below 2 'Move()' statments prevents the file/dir source and destination the same(i.e. .../dest.txt = .../dest.txt OR .../DEST.txt = dest.txt). Don't delete below.

                            //Change old filename to a slighlty short version of the new name, guarentieing that in 'case insensitive' context both strings are diffrent. Thus, alowing the 'Move()' method to work under normal circumstances.
                            File.Move(oldName, newNameSubString);
                            //Change 'newNameSubstring' to the intended new file name to complete the renaming process
                            File.Move(newNameSubString, newName);
                        }
                        catch (FileNotFoundException ex)
                        { /*Continue*/
                            Console.WriteLine(ex.Message);
                            Console.WriteLine(ex.StackTrace);
                        }//BUG: Mehtod 'File.Move()' renames dirFiles
                        //, but triggers a 'FileNotFoundException' despite success.
                    }
                }
            }

            if (FormatSettings.folderSettings.isNoSpacing == true)
            {
                foreach (DirectoryInfo dir in FormRenamer.subDirInfo)
                {
                    if (dir.Exists)
                    {
                        oldName = dir.FullName;
                        startIndexName = dir.FullName.LastIndexOf('\\', dir.FullName.Length - 1);//Length - 1 = lastIndex (note: 0 starts at right side in array for this method)
                        strBuilderNewName.Clear();

                        /*Instead of editing the string variable by assigning alterd copys of itself,
                         *a 'StringBuilder' object reduces the work by appending characters to a string.
                         *At the moment, the 'StringBuilder' object -after string is built-
                         *must pass its string value to the string 'newName'. Otherwise,
                         *the 'StringBuilder' object would be repeatedly converted into a string, and this
                         *is less effecient than the divised usage of the 'StringBuilder' object.
                         */

                        strBuilderNewName.Append(dir.FullName.Remove(/*group of chars from*/startIndexName + 1 /*to string end*/));
                        foreach (char character in dir.Name)
                        {
                            //Restricted characters are left out here.
                            switch (character)
                            {
                                //***Characters that make a 'Space Style'***
                                case (' '): break;
                                case ('_'): break;
                                //***Characters that don't make a 'Space Style'***
                                case ('-'): break;
                                default: strBuilderNewName.Append(character); break;
                            }
                        }
                        newNameSubString = newName.Substring(0, newName.Length - 1);//TODO: Handle scenario when substring of 'newName', and substrings of substring equal existing directory/file names by removing a letter each time till emptie; if still not working, keep adding char 'a' till name is diffrent. Also, handle scenario when name is initialy blank.

                        try
                        {
                            //WARNING: Don't delete below. Below 2 'Move()' statments prevents the file/dir source and destination the same(i.e. .../dest.txt = .../dest.txt OR .../DEST.txt = dest.txt).

                            //Change old directory name to a slighlty short version of the new name, guarentieing that in 'case insensitive' context both strings are diffrent. Thus, alowing the 'Move()' method to work under normal circumstances.
                            Directory.Move(oldName, newNameSubString);
                            //Change 'newNameSubstring' to the intended new file name to complete the renaming process
                            Directory.Move(newNameSubString, newName);
                        }
                        catch (DirectoryNotFoundException ex)
                        { /*Continue*/
                            Console.WriteLine(ex.Message);
                            Console.WriteLine(ex.StackTrace);
                        }//BUG: Mehtod 'Directory.Move()' renames dirFiles
                        //, but triggers a 'DirectoryNotFoundException' despite success.
                    }
                }
            }
        }
    }
}