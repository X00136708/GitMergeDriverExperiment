using System;
using System.IO;

class CustomMergeDriver
{
    static void Main(string[] args)
    {
        Console.WriteLine("Custom merge driver started");
        if (args.Length < 4)
        {
            Console.WriteLine("Usage: CustomMergeDriver <base> <current> <other> <marker-size>");
            Environment.Exit(1);
        }

        string baseFile = args[0];
        string currentFile = args[1];
        string otherFile = args[2];
        string markerSize = args[3];
		
		string toFile = "C:\\Users\\doran\\source\\repos\\GitMergeDriverExperiment\\mergeError.txt";
         Console.WriteLine("Base file: " + baseFile);
         Console.WriteLine("Current file: " + currentFile);
         Console.WriteLine("Other file: " + otherFile);
         Console.WriteLine("Marker size: " + markerSize);

        try
        {
            string baseContent = File.ReadAllText(baseFile);
            string currentContent = File.ReadAllText(currentFile);
            string otherContent = File.ReadAllText(otherFile);

            string result = "Base:\n" + baseContent + "\n\nCurrent:\n" + currentContent + "\n\nOther:\n" + otherContent;
            Console.WriteLine(result);
			
            // Write the result to the current file
            File.WriteAllText(toFile, result);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error merging files: " + ex.Message);
            Environment.Exit(1);
        }
    }
}
