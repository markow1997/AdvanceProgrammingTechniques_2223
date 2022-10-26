 
internal class Program
{
    private static int Main(string[] args)
    {
        int LengthOfLastWord(string s)
        {
            string noTrails = s.Trim();
            string[] words = noTrails.Split(" ");
            return words[(words.Length - 1)].Length;
        }

        string exampleStr = "  This sentence is filled with a lot of   spaces and other distractions   ";

        Console.WriteLine("The length of the last word of string \""+exampleStr+"\" is "+LengthOfLastWord(exampleStr) );
        Console.ReadKey();

        return 0;
    }
}