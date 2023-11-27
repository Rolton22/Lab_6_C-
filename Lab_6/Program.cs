using Lab_6;
using File = Lab_6.File;

internal class Program
{
    private static void Main(string[] args)
    {
        File textFile1 = new TextFile("text.txt", "txt", "utf-8", false);
        File textFile2 = new TextFile("doc.doc", "doc", "ASCII", true);

        File binaryFile1 = new BinaryFile("data.bin", "little-endian",16,true);
        File binaryFile2 = new BinaryFile("file.bin", "big-endian", 2, false);

        File jsonFile1 = new JsonFile("data.json", "array", "json", false);
        File jsonFile2 = new JsonFile("data.bson", "associative array", "bson", false);

        File newTextFile1 = new TextFile("data.txt", "txt", "utf-16", true);

        textFile1.Close();
        textFile2.Open();
        binaryFile1.Close();
        binaryFile2.Save();
        jsonFile1.Open();
        jsonFile2.Save();

        newTextFile1.Open();
        Files files = new Files(textFile1, textFile2, binaryFile1, binaryFile2, jsonFile1);

        Console.WriteLine("Source array:");
        Console.WriteLine(files.ToString());

        files.AddFile(jsonFile2);
        Console.WriteLine("After adding:");
        Console.WriteLine(files.ToString());

        Console.WriteLine("After editing:");
        files.EditFile(0, newTextFile1);
        Console.WriteLine(files.ToString());

        Console.WriteLine("After removal:");
        files.RemoveFile(0);
        Console.WriteLine(files.ToString());
    }
}