import static org.junit.jupiter.api.Assertions.assertEquals;

import java.util.stream.Stream;

import org.junit.jupiter.params.ParameterizedTest;
import org.junit.jupiter.params.provider.Arguments;
import org.junit.jupiter.params.provider.MethodSource;

public class DigitsTest {

    private static Stream<Arguments> AddDigitsParameterProvider() {
        return Stream.of(
          Arguments.of(29, 11),
          Arguments.of(123, 6),
          Arguments.of(527, 14),
          Arguments.of(123456, 21)
        );
    }

    @ParameterizedTest
    @MethodSource("AddDigitsParameterProvider")
    public void TestAddDigits(int n, int expected)
    {
        int actual = Digits.AddDigits(n);
        assertEquals(expected, actual);
    }

    private static Stream<Arguments> LargestNumberParameterProvider() {
        return Stream.of(
          Arguments.of(2, 99),
          Arguments.of(3, 999),
          Arguments.of(4, 9999),
          Arguments.of(5, 99999)
        );
    }

    @ParameterizedTest
    @MethodSource("LargestNumberParameterProvider")
    public void TestLargestNumber(int n, int expected)
    {
        int actual = Digits.LargestNumber(n);
        assertEquals(expected, actual);
    }


    private static Stream<Arguments> OptimalEqualSplitParameterProvider() {
        return Stream.of(
          Arguments.of(3, 10, 9),
          Arguments.of(1, 2, 2),
          Arguments.of(10, 5, 0),
          Arguments.of(4, 15, 12)
        );
    }

    @ParameterizedTest
    @MethodSource("OptimalEqualSplitParameterProvider")
    public void TestOptimalEqualSplit(int n, int m, int expected)
    {
        int actual = Digits.OptimalEqualSplit(n, m);
        assertEquals(expected, actual);
    }

    private static Stream<Arguments> PersistenceParameterProvider() {
        return Stream.of(
          Arguments.of(39, 3),
          Arguments.of(4, 0),
          Arguments.of(25, 2),
          Arguments.of(999, 4)
        );
    }

    @ParameterizedTest
    @MethodSource("PersistenceParameterProvider")
    public void TestPersistence(int n, int expected)
    {
        int actual = Digits.Persistence(n);
        assertEquals(expected, actual);
    }
    
}
