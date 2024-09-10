namespace Course;

class Program
{
    static void Main(string[] args)
    {
        string sourcePath = @"./file1.txt";
        string targetPath = @"./file2.txt";

        try
        {
            FileInfo file = new FileInfo(sourcePath);
            file.CopyTo(targetPath);

            string[] lines = File.ReadAllLines(sourcePath);
            foreach(string line in lines)
                Console.WriteLine(line);
        } catch (IOException e) {
            Console.WriteLine($"Um erro ocorreu...{e.Message}");
            throw;
        }
    }
}