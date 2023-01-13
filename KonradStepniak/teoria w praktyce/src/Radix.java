import java.util.Arrays;

public class Radix {

    static int operations = 0;

    public static String countingSort(String str) {
        int operations = 6;

        char[] arr = str.toCharArray();//.toLowerCase();
        int n = arr.length;
        System.out.println("length: " + n);
        char[] output = new char[n];

        //initialize count array as 0
        int countSize = 'z' - 'a' + 1;
        int[] count = new int[countSize];
        Arrays.fill(count, 0);

        for (int i = 0; i < n; i++) {
            count[arr[i] - 'a']++;
            operations++;
        }
        //store the cumulative count of each array
        for (int i = 1; i <= countSize - 1; i++) {
            count[i] += count[i - 1];
            operations++;
        }

        for (int i = n - 1; i >= 0; i--) {
            output[count[arr[i] - 'a'] - 1] = arr[i];
            count[arr[i] - 'a']--;
            operations += 2;
        }

        System.out.println("Liczba operacji: " + operations);
        return String.valueOf(output);
    }

    public static String[] countingSort(String[] input, int radix, int position, char first) {
        operations += 4;

        int[] count = new int[radix];
        int n = input.length;

        char temp;
        for (String value : input) {
            temp = value.charAt(value.length() - 1 - position);
            count[temp - first]++;

            operations++;
        }

        for (int i = 1; i < radix; i++) {
            count[i] = count[i] + count[i - 1];
            operations++;
        }

        String[] output = new String[n];
        for (int i = n - 1; i >= 0; i--) {
            temp = input[i].charAt(input[i].length() - 1 - position);

            output[count[temp - first] - 1] = input[i];
            count[temp - first]--;

            operations += 2;
        }

        //System.out.println(operations);

        return output;
    }


    public static String[] radixSort(String[] input, int radix) {
        operations = 3;

        int longest = 0;
        for (String str : input) {
            longest = Math.max(str.length(), longest);
            operations++;
        }
        //System.out.println("longest: "+longest);

        int diff = 0;
        for (int j = 0; j < input.length; j++) {
            diff = longest - input[j].length();
            operations++;

            for (int i = 0; i < diff; i++) {
                input[j] = new StringBuilder(input[j]).insert(input[j].length(), "`").toString();
                operations++;
            }
        }

        String[] temp = input;
        for (int i = 0; i < longest; i++) {
            temp = countingSort(temp, radix + 1, i, '`');
            operations++;
        }

        for (int i = 0; i < temp.length; i++) {
            temp[i] = temp[i].replace("`", "");
            operations++;
        }

        System.out.println("Liczba operacji: " + operations);

        return temp;
    }

    public static String[] radixSortBinary(String str, int stringLength) {

        operations = 3;

        //convert letters to binary
        char[] charArr = str.toCharArray();
        String[] array = new String[charArr.length];
        for (int i = 0; i < charArr.length; i++) {
            array[i] = Integer.toBinaryString(charArr[i]);
            operations++;
        }

        System.out.println("Binary input:" + Arrays.toString(array));


        //iterate over each character position
        for (int i = 0; i < stringLength; i++) {
            array = countingSort(array, 2, i, '0');
            operations++;
        }

        System.out.println("Binary output:" + Arrays.toString(array));

        //convert back to letters
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < array.length; i++) {
            Arrays.stream(array[i].split("(?<=\\G.{7})")).forEach(s -> {
                sb.append((char) Integer.parseInt(s, 2));
                operations++;
            });
            array[i] = sb.toString();
            sb.setLength(0);

            operations += 3;
        }

        System.out.println("Liczba operacji: " + operations);

        return array;
    }
}
