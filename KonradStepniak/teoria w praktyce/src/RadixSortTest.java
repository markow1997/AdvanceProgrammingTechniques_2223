import org.junit.*;
import static org.junit.Assert.*;

public class RadixSortTest {

    Radix sort = new Radix();

    @After
    public void cleanupTest() {
        System.out.flush();
        System.out.println("Cleared the buffer");
    }

//    @Before
//    @AfterClass
//    @BeforeClass



    @Test
    public void testCountingSort() {
        String input = "Hello World";
        //String input = "helloworld";
        String expectedOutput = "dehllloorw";
        String output = sort.countingSort(input);
        assertEquals(expectedOutput, output);
    }

    @Test
    public void testRadixSort() {
        String[] input = {"hello", "world", "this", "is", "a", "test"};
        String[] expectedOutput = {"A", "Hello", "Is", "Test", "This", "World"};

        //String[] expectedOutput = null;
        //String[] expectedOutput = {"a", "hello", "is", "test", "this", "world"};
        String[] output = sort.radixSort(input, 26);
        assertArrayEquals(expectedOutput, output);
    }

    @Test
    public void testCountingSortRange() {
        String input = "helloworld";
        String out = sort.countingSort(input);
        char[] cout = out.toCharArray();
        for (char c : cout) {
            assertTrue(c >= 'a' && c <= 'z');
        }
    }
}
