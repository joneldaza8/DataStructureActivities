import static org.junit.jupiter.api.Assertions.assertEquals;

import java.util.stream.Stream;

import org.junit.jupiter.params.ParameterizedTest;
import org.junit.jupiter.params.provider.Arguments;
import org.junit.jupiter.params.provider.MethodSource;

public class DigitsTest {

    private static Stream<Arguments> AddDigitsParameterProvider() {
        return Stream.of(
          Arguments.of(29, 11),
          Arguments.of(123, 6)
        );
    }

    @ParameterizedTest
    @MethodSource("AddDigitsParameterProvider")
    public void TestAddDigits(int n, int expected)
    {
        int actual = Digits.AddDigits(n);
        assertEquals(expected, actual);
    }
    
}
