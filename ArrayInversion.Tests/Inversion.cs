using ArrayInversion;

namespace ArrayInversion.Tests {
  public class Inversion {
    // 1.1. Тест на типичных данных - грубый перебор
    [Theory]
    [InlineData(new int[] { 3, 1, 2 }, 2)] // Инверсии: (3,1) и (3,2)
    public void BruteForce_TypicalArray_ReturnsCorrectCountAsync(int[] data, int expected) {
      // Act (Действие)
      var result = ArrayInversion.BruteForce(data);

      // Assert (Проверка)
      Assert.Equal(expected, result.Count);
    }

    // 1.2. Тест на типичных данных - оптимизированный метод
    [Theory]
    [InlineData(new int[] { 3, 1, 2 }, 2)] // Инверсии: (3,1) и (3,2)
    public void Optimized_TypicalArray_ReturnsCorrectCountAsync(int[] data, int expected) {
      // Act (Действие)
      var result = ArrayInversion.Optimized(data);
      // Assert (Проверка)
      Assert.Equal(expected, result.Count);
    }

    // 2.1. Тест на отсортированном массиве (граничный случай) - грубый перебор
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 0)] // Нет инверсий
    public void BruteForce_SortedArray_ReturnsZeroAsync(int[] data, int expected) {
      var result = ArrayInversion.BruteForce(data);
      Assert.Equal(expected, result.Count);
    }

    // 2.2. Тест на отсортированном массиве (граничный случай) - оптимизированный метод
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 0)] // Нет инверсий
    public void Optimized_SortedArray_ReturnsZeroAsync(int[] data, int expected) {
      var result = ArrayInversion.Optimized(data);
      Assert.Equal(expected, result.Count);
    }

    // 3.1. Тест на массиве в обратном порядке (худший случай)
    [Theory]
    [InlineData(new int[] { 4, 3, 2, 1 }, 6)] // Все пары являются инверсиями
    public void BruteForce_ReverseSortedArray_ReturnsMaxInversionsAsync(int[] data, int expected) {
      var result = ArrayInversion.BruteForce(data);
      Assert.Equal(expected, result.Count);
    }

    // 3.2. Тест на массиве в обратном порядке (худший случай) - оптимизированный метод
    [Theory]
    [InlineData(new int[] { 4, 3, 2, 1 }, 6)] // Все пары являются инверсиями
    public void Optimized_ReverseSortedArray_ReturnsMaxInversionsAsync(int[] data, int expected) {
      var result = ArrayInversion.Optimized(data);
      Assert.Equal(expected, result.Count);
    }

    // 4. Тесты на пустых данных и одном элементе (граничные случаи)
    [Theory]
    [InlineData(new int[] { }, 0)] // Пустой массив
    [InlineData(new int[] { 42 }, 0)] // Массив из одного элемента
    public void BothMethods_EmptyOrSingleElementArray_ReturnsZeroAsync(int[] data, int expected) {
      var bruteForceResult = ArrayInversion.BruteForce(data);
      var optimizedResult = ArrayInversion.Optimized(data);

      Assert.Equal(expected, bruteForceResult.Count);
      Assert.Equal(expected, optimizedResult.Count);
    }

    // 5. Тест на больших объемах данных и сравнение корректности методов
    [Fact]
    public void BothMethods_LargeRandomArray_ReturnsSameCountAsync() {
      // Arrange (Подготовка)
      int size = 1000; // Размер массива для тестирования
      Random rand = new Random(42); // Фиксированный сид для воспроизводимости
      int[] data = Enumerable.Range(1, size).OrderBy(_ => rand.Next()).ToArray(); // Случайный массив

      // Act (Действие)
      var bruteForceResult = ArrayInversion.BruteForce(data);
      var optimizedResult = ArrayInversion.Optimized(data);

      // Assert (Проверка)
      Assert.Equal(bruteForceResult.Count, optimizedResult.Count);
      Assert.True(bruteForceResult.Operations >= optimizedResult.Operations);
    }

    // 6. Тест на некорректные входные данные (null)
    [Fact]
    public void BothMethods_NullArray_ThrowsArgumentNullExceptionAsync() {
      // Act & Assert (Действие и проверка)
      Assert.Throws<ArgumentNullException>(() => ArrayInversion.BruteForce(null));
      Assert.Throws<ArgumentNullException>(() => ArrayInversion.Optimized(null));
    }
  }
}
