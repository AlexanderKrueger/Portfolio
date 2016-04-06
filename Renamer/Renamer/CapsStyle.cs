using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Renamer
{
    class CapsStyle
    {
        //---LOCALIZING DIRECTORY/FILE INFORMATION FROM FOLDER DIALOGE---
        //TODO: Replace creation of new field variables with usable references to 'FormRenamer' file/dir variables.
        //private static DirectoryInfo selectedDir = null;
        //private static DirectoryInfo[] subDirInfo = null;
        //private static FileInfo[] files = null;

        //---FEILDS---
        private static string oldName = "";
        private static string newName = "";
        private static string newNameSubString = "";
        private static int startIndexName = 0;
        private static StringBuilder strBuilderNewName = new StringBuilder();

        public static void ToSelectedStyle()
        {
            //---Update imporant variables---
            //selectedDir = FormRenamer.selectedDir;
            //subDirInfo = FormRenamer.subDirInfo;
            //files = FormRenamer.files;

            //---TO UPPER---
            //Formats caps style of files name to upper (full title) case.
            //i.e. "My File Name"
            if (FormatSettings.fileSettings.isUpper == true)
            {
                foreach (FileInfo file in FormRenamer.files)
                {
                    if (file.Exists)
                    {
                        oldName = file.FullName;
                        startIndexName = file.FullName.LastIndexOf('\\', file.FullName.Length - 1);//Length - 1 = lastIndex
                        newName = file.FullName.Remove(startIndexName + 1) + file.Name.ToUpper();//Renames file name within the full path
                        newNameSubString = newName.Substring(0, newName.Length - 1);//TODO: Handle scenario when substring of 'newName', and substrings of substring equal existing directory/file names by removing a letter each time till emptie; if still not working, keep adding char 'a' till name is diffrent. Also, handle scenario when name is initialy blank.

                        try
                        {
                            //WARNING: Don't delete below. Below 2 'Move()' statments prevents the file/dir source and destination the same(i.e. .../dest.txt = .../dest.txt OR .../DEST.txt = dest.txt). 

                            //Change old filename to a slighlty short version of the new name, guarentieing that in 'case insensitive' context both strings are diffrent. Thus, alowing the 'Move()' method to work under normal circumstances.
                            File.Move(oldName, newNameSubString);
                            //Change 'newNameSubstring' to the intended new file name to complete the renaming process
                            File.Move(newNameSubString, newName);
                        }
                        catch (FileNotFoundException ex)
                        { /*Continue*/ 
                        Console.WriteLine(ex.Message);
                        Console.WriteLine(ex.StackTrace);
                        }//BUG: Method 'File.Move()' renames dirFiles
                        //, but triggers a 'FileNotFoundException' despite success.
                    }
                }
            }

            if (FormatSettings.folderSettings.isUpper == true)
            {
                foreach (DirectoryInfo dir in FormRenamer.subDirInfo)
                {
                    if (dir.Exists)
                    {
                        oldName = dir.FullName;
                        startIndexName = dir.FullName.LastIndexOf('\\', dir.FullName.Length - 1);//Length - 1 = lastIndex
                        newName = dir.FullName.Remove(startIndexName + 1) + dir.Name.ToUpper(); //Renames file name within the full path

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
                        }//BUG: Method 'Directory.Move()' renames dirFiles
                        //, but triggers a 'DirectoryNotFoundException' despite success.
                    }
                }
            }

            //---TO LOWER---
            //Formats caps style of files name to lower case.
            //i.e. "my files name"
            if (FormatSettings.fileSettings.isLower == true)
            {
                foreach (FileInfo file in FormRenamer.files)
                {
                    if (file.Exists)
                    {
                        oldName = file.FullName;
                        startIndexName = file.FullName.LastIndexOf('\\', file.FullName.Length - 1);//Length - 1 = lastIndex
                        newName = file.FullName.Remove(startIndexName + 1) + file.Name.ToLower(); //Renames file name within the full path

                        try
                        {
                            //WARNING: Don't delete below. Below 2 'Move()' statments prevents the file/dir source and destination the same(i.e. .../dest.txt = .../dest.txt OR .../DEST.txt = dest.txt). 

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

            if (FormatSettings.folderSettings.isLower == true)
            {
                foreach (DirectoryInfo dir in FormRenamer.subDirInfo)
                {
                    if (dir.Exists)
                    {
                        oldName = dir.FullName;
                        startIndexName = dir.FullName.LastIndexOf('\\', dir.FullName.Length - 1);//Length - 1 = lastIndex
                        newName = dir.FullName.Remove(startIndexName + 1) + dir.Name.ToLower(); //Renames directory name within the full path

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
                        }//BUG: Method 'Directory.Move()' renames dirFiles
                        //, but triggers a 'DirectoryNotFoundException' despite success.
                    }
                }
            }

            //---TO CAMMEL CASE---
            //Formats caps style of files name to cammel case.
            //i.e. "my File Name"
            if (FormatSettings.fileSettings.isCammel == true)
            {
                foreach (FileInfo file in FormRenamer.files)
                {
                    if (file.Exists)
                    {
                        oldName = file.FullName;
                        startIndexName = file.FullName.LastIndexOf('\\', file.FullName.Length - 1);//Length - 1 = lastIndex
                        strBuilderNewName.Clear();

                        strBuilderNewName.Append(file.FullName.Remove(startIndexName + 1));
                        foreach (char character in file.Name)
                        {

                        }

                        try
                        {
                            //WARNING: Don't delete below. Below 2 'Move()' statments prevents the file/dir source and destination the same(i.e. .../dest.txt = .../dest.txt OR .../DEST.txt = dest.txt). 

                            //Change old filename to a slighlty short version of the new name, guarentieing that in 'case insensitive' context both strings are diffrent. Thus, alowing the 'Move()' method to work under normal circumstances.
                            File.Move(oldName, newNameSubString);
                            //Change 'newNameSubstring' to the intended new file name to complete the renaming process
                            File.Move(newNameSubString, newName);
                        }
                        catch (FileNotFoundException ex)
                        { /*Continue*/
                            Console.WriteLine(ex.Message);
                            Console.WriteLine(ex.StackTrace);
                        }//BUG: Method 'File.Move()' renames dirFiles
                        //, but triggers a 'FileNotFoundException' despite success.
                    }
                }
            }

            if (FormatSettings.folderSettings.isCammel == true)
            {
                foreach (DirectoryInfo dir in FormRenamer.subDirInfo)
                {
                    if (dir.Exists)
                    {
                        oldName = dir.FullName;
                        startIndexName = dir.FullName.LastIndexOf('\\', dir.FullName.Length - 1);//Length - 1 = lastIndex
                        strBuilderNewName.Clear();

                        strBuilderNewName.Append(dir.FullName.Remove(startIndexName + 1));

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
                        }//BUG: Method 'Directory.Move()' renames dirFiles
                        //, but triggers a 'DirectoryNotFoundException' despite success.
                    }
                }
            }
        }
    }
}
