namespace ArrayInversion {

  /// <summary>
  /// Представляет результат подсчета инверсий, включая их количество и число выполненных операций.
  /// </summary>
  public class InversionResult {
    public long Count { get; set; }
    public long Operations { get; set; }
  }

  public class ArrayInversion {
    /// <summary>
    /// Подсчитывает количество инверсий в указанном массиве методом полного перебора (Brute Force).
    /// </summary>
    /// <remarks>
    /// Этот метод использует алгоритм перебора с временной сложностью O(n^2).
    /// Он подходит для небольших массивов, но может быть неэффективен для больших наборов данных.
    /// </remarks>
    /// <param name="array">Массив целых чисел для анализа. Не должен быть null.</param>
    /// <returns>Объект <see cref="InversionResult"/>, содержащий общее количество инверсий и число выполненных операций сравнения.</returns>
    public static InversionResult BruteForce(int[] array) {
      if (array == null) throw new ArgumentNullException(nameof(array));

      long ops = 0;
      long count = 0;
      for (int i = 0; i < array.Length - 1; i++) {
        for (int j = i + 1; j < array.Length; j++) {
          ops++; // Операция сравнения [cite: 58]
          if (array[i] > array[j]) count++;
        }
      }
      return new InversionResult { Count = count, Operations = ops };
    }

    /// <summary>
    /// Подсчитывает количество инверсий в массиве с использованием оптимизированного алгоритма сортировки слиянием.
    /// </summary>
    /// <remarks>
    /// Метод создает временный массив для процесса слияния и не изменяет оригинальный массив.
    /// Предназначен для эффективного подсчета инверсий со сложностью O(n log n).
    /// </remarks>
    /// <param name="array">Массив целых чисел для анализа. Не должен быть null.</param>
    /// <returns>Экземпляр <see cref="InversionResult"/> с общим количеством инверсий и числом выполненных операций.</returns>
    public static InversionResult Optimized(int[] array) {
      if (array == null) throw new ArgumentNullException(nameof(array));

      int[] temp = new int[array.Length]; // Временный массив для слияния [cite: 52]
      long ops = 0;
      int[] workingCopy = (int[])array.Clone(); // Не меняем оригинал, если это важно
      long count = SortAndCount(workingCopy, temp, 0, array.Length - 1, ref ops);
      return new InversionResult { Count = count, Operations = ops };
    }

    /// <summary>
    /// Рекурсивно сортирует указанный диапазон массива и подсчитывает количество инверсий и операций.
    /// </summary>
    /// <remarks>Реализует алгоритм «разделяй и властвуй». Разделяет массив и вызывает слияние отсортированных подмассивов.</remarks>
    /// <param name="arr">Массив для сортировки (изменяется в процессе).</param>
    /// <param name="temp">Вспомогательный временный массив. Должен быть не меньше основного.</param>
    /// <param name="left">Начальный индекс диапазона сортировки.</param>
    /// <param name="right">Конечный индекс диапазона сортировки.</param>
    /// <param name="ops">Ссылка на переменную для отслеживания количества операций.</param>
    /// <returns>Общее количество найденных инверсий в диапазоне.</returns>
    private static long SortAndCount(int[] arr, int[] temp, int left, int right, ref long ops) {
      long count = 0;
      if (left < right) {
        int mid = (left + right) / 2;
        count += SortAndCount(arr, temp, left, mid, ref ops);
        count += SortAndCount(arr, temp, mid + 1, right, ref ops);
        count += MergeAndCountInternal(arr, temp, left, mid + 1, right, ref ops);
      }
      return count;
    }

    /// <summary>
    /// Сливает два последовательных отсортированных подмассива и считает инверсии между ними.
    /// </summary>
    /// <remarks>Предполагает, что подмассивы в диапазонах [left, mid-1] и [mid, right] уже отсортированы.</remarks>
    /// <param name="arr">Массив, содержащий элементы для слияния.</param>
    /// <param name="temp">Временный массив для хранения промежуточных результатов.</param>
    /// <param name="left">Начало первого подмассива.</param>
    /// <param name="mid">Начало второго подмассива.</param>
    /// <param name="right">Конец второго подмассива.</param>
    /// <param name="ops">Ссылка на счетчик операций.</param>
    /// <returns>Количество инверсий, обнаруженных при слиянии подмассивов.</returns>
    private static long MergeAndCountInternal(int[] arr, int[] temp, int left, int mid, int right, ref long ops) {
      long invCount = 0;
      int i = left, j = mid, k = left;

      while (i <= mid - 1 && j <= right) {
        ops++; // Операция сравнения [cite: 58]
        if (arr[i] <= arr[j]) {
          temp[k++] = arr[i++];
        }
        else {
          temp[k++] = arr[j++];
          invCount += (mid - i);
        }
      }

      // Копируем остатки левой половины
      while (i <= mid - 1) {
        temp[k++] = arr[i++];
        ops++; // Операция пересылки
      }

      // Копируем остатки правой половины
      while (j <= right) {
        temp[k++] = arr[j++];
        ops++;
      }

      // Возвращаем данные в исходный массив
      for (i = left; i <= right; i++) arr[i] = temp[i];

      return invCount;
    }
  }
}
