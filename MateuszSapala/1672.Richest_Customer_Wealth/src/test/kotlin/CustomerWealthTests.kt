import org.junit.jupiter.api.TestInstance
import org.junit.jupiter.params.ParameterizedTest
import org.junit.jupiter.params.provider.Arguments
import org.junit.jupiter.params.provider.MethodSource
import java.util.stream.Stream


@TestInstance(TestInstance.Lifecycle.PER_CLASS)
class CustomerWealthTests {
    @ParameterizedTest
    @MethodSource("data")
    fun accounts(accounts: Array<IntArray>, expected: Int) {
        assert(Solution().wealth(accounts) == expected)
    }

    private fun data(): Stream<Arguments?>? {
        return Stream.of(
            Arguments.of(arrayOf(intArrayOf(1, 2, 3), intArrayOf(3, 2, 1)), 6),
            Arguments.of(arrayOf(intArrayOf(1, 5), intArrayOf(7, 3), intArrayOf(3, 5)), 10),
            Arguments.of(arrayOf(intArrayOf(2, 8, 7), intArrayOf(7, 1, 3), intArrayOf(1, 9, 5)), 17)
        )
    }
}