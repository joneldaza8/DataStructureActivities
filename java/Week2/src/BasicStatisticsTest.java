import static org.junit.jupiter.api.Assertions.assertEquals;

import java.util.stream.Stream;

import org.junit.jupiter.params.ParameterizedTest;
import org.junit.jupiter.params.provider.Arguments;
import org.junit.jupiter.params.provider.MethodSource;

public class BasicStatisticsTest
{

    private static Stream<Arguments> GetSumParameterProvider() {
        return Stream.of(
          Arguments.of(new int[] { 87, 67, 43, 45, 67, 34, 89, 54, 87, 67 }, 640),
          Arguments.of(new int[] { 92, 90, 84, 75, 68, 34, 56, 87, 44, 56, 92, 90, 91, 90, 88 }, 1137)
        );
    }

    @ParameterizedTest
    @MethodSource("GetSumParameterProvider")
    public void TestGetSum(int[] n, int expected)
    {
        int actual = BasicStatistics.GetSum(n);
        assertEquals(expected, actual);
    }


    private static Stream<Arguments> GetMeanParameterProvider() {
        return Stream.of(
          Arguments.of(new int[] { 87, 67, 43, 45, 67, 34, 89, 54, 87, 67 }, 64.00),
          Arguments.of(new int[] { 92, 90, 84, 75, 68, 34, 56, 87, 44, 56, 92, 90, 91, 90, 88 }, 75.80)
        );
    }

    @ParameterizedTest
    @MethodSource("GetMeanParameterProvider")
    public void TestGetSum(int[] n, double expected)
    {
        double actual = BasicStatistics.GetMean(n);
        assertEquals(expected, actual);
    }

    private static Stream<Arguments> GetMedianParameterProvider() {
        return Stream.of(
          Arguments.of(new int[] { 87, 67, 43, 45, 67, 34, 89, 54, 87, 67 }, 67),
          Arguments.of(new int[] { 92, 90, 84, 75, 68, 34, 56, 87, 44, 56, 92, 90, 91, 90, 88 }, 87)
        );
    }

    @ParameterizedTest
    @MethodSource("GetMedianParameterProvider")
    public void TestGetMedian(int[] n, int expected)
    {
        int actual = BasicStatistics.GetMedian(n);
        assertEquals(expected, actual);
    }

    private static Stream<Arguments> GetModeParameterProvider() {
        return Stream.of(
          Arguments.of(new int[] { 87, 67, 43, 45, 67, 34, 89, 54, 87, 67 }, 67),
          Arguments.of(new int[] { 92, 90, 84, 75, 68, 34, 56, 87, 44, 56, 92, 90, 91, 90, 88 }, 90)
        );
    }

    @ParameterizedTest
    @MethodSource("GetModeParameterProvider")
    public void TestGetMode(int[] n, int expected)
    {
        int actual = BasicStatistics.GetMode(n);
        assertEquals(expected, actual);
    }

    private static Stream<Arguments> GetMaxValueParameterProvider() {
        return Stream.of(
          Arguments.of(new int[] { 87, 67, 43, 45, 67, 34, 89, 54, 87, 67 }, 89),
          Arguments.of(new int[] { 92, 90, 84, 75, 68, 34, 56, 87, 44, 56, 92, 90, 91, 90, 88 }, 92)
        );
    }

    @ParameterizedTest
    @MethodSource("GetMaxValueParameterProvider")
    public void TestGetMaxValue(int[] n, int expected)
    {
        int actual = BasicStatistics.GetMaxValue(n);
        assertEquals(expected, actual);
    }
    
}