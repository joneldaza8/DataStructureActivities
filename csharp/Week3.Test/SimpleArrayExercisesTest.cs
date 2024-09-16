using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Week3.Test
{
    [TestClass]
    public class SimpleArrayExercisesTest
    {
        [DataTestMethod]
        [DataRow("Computer programmIng IS jusT a LangUage based ON lOgic", 18)]
        [DataRow("C# is a general-purpose, multi-paradigm programming language. C# encompasses static typing, strong typing, lexically scoped, imperative, declarative, functional, generic, object-oriented, and component-oriented programming disciplines.", 72)]
        [DataRow("The quick brown fox jumps over the lazy dog.",11)]
        [DataRow("LOrem ipsum dolor sit Amet, consectetur adipiscing Elit, sed do eiusmod tEmpor Incididunt ut lAbore et dolOre magna aliqua. Porttitor rhoncus dolor purus nOn enIm praesent.",60)]
        public void TestCountVowels(string parameter, int expectedResult)
        {
            // Arrange
            SimpleArrayExercises simpleArrayExercises = new SimpleArrayExercises();
            int actualResult = 0;
            
            // Act
            actualResult = simpleArrayExercises.CountVowels(parameter);

            // Assert

            Assert.AreEqual(expectedResult, actualResult);
        }

        [DataTestMethod]
        [DataRow(new int[]{ 15, 12, 56, 776, 34, 45, 23, 89, 67, 14, 126, 223, 980, 34 } , 8)]
        [DataRow(new int[] { 1126, 431, 899, 467, 231, 22, 448, 891, 888, 722, 1234, 422, 224, 112, 99, 298 } , 10)]
        [DataRow(new int[]{ 78, 90, 99, 65, 28, 12, 345, 21, 34, 6, 77, 23 } , 6)]
        public void TestCountEvenNumbers(int[] numberArray, int expectedResult)
        {
            // Arrange
            SimpleArrayExercises simpleArrayExercises = new SimpleArrayExercises();
            int actualResult = 0;

            // Act
            actualResult = simpleArrayExercises.CountEvenNumbers(numberArray);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [DataTestMethod]
        [DataRow(new int[]{ 15, 12, 56, 776, 34, 45, 23, 89, 67, 14, 126, 223, 980, 34 }, new int[] { 34, 980, 223, 126, 14, 67, 89, 23, 45, 34, 776, 56, 12, 15})]
        [DataRow(new int[]{ 1126, 431, 899, 467, 231, 22, 448, 891, 888, 722, 1234, 422, 224, 112, 99, 298 }, new int[] {298, 99, 112, 224, 422, 1234, 722, 888, 891, 448, 22, 231, 467, 899, 431, 1126 })]
        [DataRow(new int[]{ 78, 90, 99, 65, 28, 12, 345, 21, 34, 6, 77, 23 }, new int[]{23, 77, 6, 34, 21, 345, 12, 28, 65, 99, 90, 78})]
        public void TestCountEvenNumbers(int[] numberArray, int[] expectedResult)
        {
            // Arrange
            SimpleArrayExercises simpleArrayExercises = new SimpleArrayExercises();

            // Act
            var actualResult = simpleArrayExercises.ReverseArrayOrder(numberArray);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
