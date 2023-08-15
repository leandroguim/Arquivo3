﻿

string sourcePath = @"c:\temp\file1.txt";
string targetPath = @"c:\temp\file2.txt";


try 
{
    string[] lines = File.ReadAllLines(sourcePath);

    using (StreamWriter sw = File.AppendText(targetPath))
    {
        foreach (string line in lines)
        {
            sw.WriteLine(line.ToUpper());
        }
    }
}
catch(IOException e)
{

}
