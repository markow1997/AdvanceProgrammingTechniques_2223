public class Solution {
    public string IntToRoman(int num) {
        List<Tuple<string, int>> Romans = new List<Tuple<string, int>>
        {
            new Tuple<string, int>("M", 1000),
            new Tuple<string, int>("CM", 900),
            new Tuple<string, int>("D", 500),
            new Tuple<string, int>("CD", 400),
            new Tuple<string, int>("C", 100),
            new Tuple<string, int>("XC", 90),
            new Tuple<string, int>("L", 50),
            new Tuple<string, int>("XL", 40),
            new Tuple<string, int>("X", 10),
            new Tuple<string, int>("IX", 9),
            new Tuple<string, int>("V", 5),
            new Tuple<string, int>("IV", 4),
            new Tuple<string, int>("I", 1)
        };

        int helper = num;
        string result = "";

        foreach(Tuple<string, int> roman in Romans)
        {
            while(helper >= roman.Item2)
            {
                helper -= roman.Item2;
                result += roman.Item1;
            }
        }

        return result;
    }
}
