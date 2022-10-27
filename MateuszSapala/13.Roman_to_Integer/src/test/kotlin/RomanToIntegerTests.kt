import org.junit.jupiter.api.Assertions
import org.junit.jupiter.api.TestInstance
import org.junit.jupiter.params.ParameterizedTest
import org.junit.jupiter.params.provider.Arguments
import org.junit.jupiter.params.provider.MethodSource
import java.util.stream.Stream


@TestInstance(TestInstance.Lifecycle.PER_CLASS)
class RomanToIntegerTests {
    @ParameterizedTest
    @MethodSource("data")
    fun testRomanToInt(roman: String,expected:Int){
        val result = Solution().romanToInt(roman)
        Assertions.assertEquals(expected, result)
    }

    private fun data(): Stream<Arguments?>? {
        return Stream.of(
            Arguments.of("III",3),
            Arguments.of("LVIII", 58),
            Arguments.of("MCMXCIV", 1994)
        )
    }
}