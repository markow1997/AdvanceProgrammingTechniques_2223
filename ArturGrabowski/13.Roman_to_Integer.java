import java.util.HashMap;
import java.util.Locale;
import java.util.Map;

class Solution {
    Map<Character, Integer> romanLettersMap = Map.of(
            'I', 1,
            'V', 5,
            'X', 10,
            'L', 50,
            'C', 100,
            'D', 500,
            'M', 1000
    );

    public int romanToInt(String s) {
        s = s.toUpperCase();
        int temp;
        int result = 0;

        for (int i = 0; i < s.length(); i++) {
            int value = romanLettersMap.get(s.charAt(i));

            if (i < s.length() - 1 && value < romanLettersMap.get(s.charAt(i + 1)))
                result -= value;
            else
                result += value;
        }

        return result;
    }
}
