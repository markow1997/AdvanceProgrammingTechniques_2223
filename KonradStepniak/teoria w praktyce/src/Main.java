import java.util.ArrayList;
import java.util.Scanner;
import java.util.Arrays;
//import java.;

public class Main {
    public static void main(String[] args) {

        Radix sort = new Radix();

        Scanner scan = new Scanner(System.in);  // Create a Scanner object

        //p1
        System.out.println("Podaj łańcuch znaków: ");
        String input = scan.next();

        String out = sort.countingSort(input);
        System.out.println("Output: " + out);
        System.out.println("\n");


        //p2
        //String[] arr = { "a", "bcd", "bcde", "bbbb", "abcde" };
        System.out.println("Podaj ilość łańcuchów do wpisania:");
        int numStrings = scan.nextInt();
        scan.nextLine();

        String[] arr = new String[numStrings];

        for (int i = 0; i < numStrings; i++) {
            System.out.println("Podaj zawartość łańcucha nr" + (i + 1) + " (do 20 znaków): ");
            arr[i] = scan.nextLine();

            if (arr[i].length() > 20) {
                arr[i] = arr[i].substring(0, 20);
            }
        }
        System.out.println("Input:" + Arrays.toString(arr));

        String[] output = sort.radixSort(arr, 26);
        System.out.println("Output:" + Arrays.toString(output));
        System.out.println("\n");


        //p4 - binary
        System.out.println("Podaj łańcuch znaków: ");
        String input2 = scan.next();

        String[] result = sort.radixSortBinary(input2, 7);
        System.out.println("Output:" + Arrays.toString(result));

    }
}

//Konrad Stepniak proj 2