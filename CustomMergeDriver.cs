using System;
using System.IO;

class CustomMergeDriver
{
    static void Main(string[] args)
    {
        if (args.Length < 4)
        {
            Console.WriteLine("Usage: CustomMergeDriver <base> <current> <other> <marker-size>");
            Environment.Exit(1);
        }

        string baseFile = args[0];
        string currentFile = args[1];
        string otherFile = args[2];

        try
        {
            string baseContent = File.ReadAllText(baseFile);
            string currentContent = File.ReadAllText(currentFile);
            string otherContent = File.ReadAllText(otherFile);

            string result = "Base:\n{baseContent}\n\nCurrent:\n{currentContent}\n\nOther:\n{otherContent}";

            // Write the result to the current file
            File.WriteAllText(currentFile, result);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error merging files: " + ex.Message);
            Environment.Exit(1);
        }
    }
}
