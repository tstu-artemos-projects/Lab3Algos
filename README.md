<div align="center">

# Лабораторная работа №3 по дисциплине "Алгоритмы и программирование"

![GitHub top language](https://img.shields.io/github/languages/top/tstu-artemos-projects/Lab3Algos?style=for-the-badge&logo=dotnet&color=8B00FF&logoColor=FFFFFF)
![GitHub repo size](https://img.shields.io/github/repo-size/tstu-artemos-projects/Lab3Algos?style=for-the-badge&logo=github&logoColor=FFFFFF)

![GitHub branch status](https://img.shields.io/github/check-runs/tstu-artemos-projects/Lab3Algos/master?style=for-the-badge&logo=githubactions&logoColor=FFFFFF)
![Last Commit](https://img.shields.io/github/last-commit/tstu-artemos-projects/Lab3Algos?style=for-the-badge&logo=git&logoColor=FFFFFF)  

</div>

## Обзор проекта
Приложение предназначено для экспериментального исследования производительности и анализа сложности алгоритмов на примере задачи подсчета инверсий в массиве (Вариант 12). Программа позволяет сопоставить классический подход «грубой силы» с оптимизированным алгоритмом, использующим стратегию «разделяй и властвуй».

### Основные функции:
- Алгоритмический анализ: Реализация двух методов подсчета инверсий: Brute Force ($O(n^2)$) и Optimized Merge Sort ($O(n \log n)$)
- Сравнительное тестирование: Автоматическая генерация наборов случайных данных размером от 100 до 5000 элементов для замера метрик.
- Сбор метрик: Точное измерение времени выполнения (мс) с помощью Stopwatch и точный подсчет элементарных операций сравнения/обмена.
- Визуализация: Отображение результатов в виде интерактивной таблицы (DataGridView) и линейного графика зависимости времени от объема данных.

## Технический стек
- Язык: C# (.NET 10)
- Технология: Windows Forms (WinForms)
- Тестирование: xUnit для реализации модульных тестов (граничные случаи, большие объемы, валидация)
- Графика: System.Windows.Forms.DataVisualization.Charting для построения кривых сложности.
- Среда разработки: Visual Studio 2026

## Структура проекта блок-схемой
<div align="center">

[![](https://mermaid.ink/img/pako:eNqNVFFLG0EQ_ivL4kNCL0Fj4uk9FKK2UmhoidIHmxLWu_Fy5W437O3ZqgTUPpRiodCXPvYviDQIgulf2PtHndtL4kWv4EFyO7PzffPtzM6dUld4QB3qhiyOtwPmSxb1OMHHeMhbKTIXOc2d2fOswwJeqS7lnlGPF-PbUrLjV_wIZBwI_lLIBWjN84-6ECehiolDtpliOzLw3gXwqRDjDphU91FbmVnYPlC8m3Dc2EyUEryg63HuSrWwvauQqM1ZGJxAJQbugXSIOPgIrrIIOOTFEXDVln5cANV2QSXDotAiZW0HOEimwGSuxEjskICravb3_sMTCrRQ102ZKEDZLlQ8zOjkLFUyj86LslSAvBmqIMK03lMRtQ5IH9rc2xIJVxUm5RRkEQXRcG6EcKiMYREZ-AM1PVcouF96rAcZF85lUmHD7sFT7VntEBIv7P2PeA9ivA_l9ervHQ8Dl4WmuP0u9kzyeEtIib3ND1otK1p_V0gF3gJqH6RYiO6AGggv7r9mWLgu456IZgBzRTtMuYMZYi5-Njf1-vOymXCI_qWv9N_0S3qub3E1Ti9yYEnwY44M_zO91Df4u87RJD3TV-l5-jUz0ssyMkP0sFEZk57oG31tCL5N2fQfXNzpO0wwzrkeNKJc1G8kmaCkcXqW_siJbvUEjTM91rfpBVJOUORF-p1a1MeRoo6SCVg0AhmxzKSmwz2qBhBBjzq49OCQodQe7fERwoaM7wsRzZBSJP6AOocsjNFKhjgIMP2Qzb3STLu5CdRZ3TAc1Dmln9Gy7fpGq7lmr7bsZrPRaFn0mDq1Rr211mgt2xutdXt5pbm6MrLoicm6XF-3MQi8QAnZmX49s9foH-NL47Y?type=png)](https://mermaid.live/edit#pako:eNqNVFFLG0EQ_ivL4kNCL0Fj4uk9FKK2UmhoidIHmxLWu_Fy5W437O3ZqgTUPpRiodCXPvYviDQIgulf2PtHndtL4kWv4EFyO7PzffPtzM6dUld4QB3qhiyOtwPmSxb1OMHHeMhbKTIXOc2d2fOswwJeqS7lnlGPF-PbUrLjV_wIZBwI_lLIBWjN84-6ECehiolDtpliOzLw3gXwqRDjDphU91FbmVnYPlC8m3Dc2EyUEryg63HuSrWwvauQqM1ZGJxAJQbugXSIOPgIrrIIOOTFEXDVln5cANV2QSXDotAiZW0HOEimwGSuxEjskICravb3_sMTCrRQ102ZKEDZLlQ8zOjkLFUyj86LslSAvBmqIMK03lMRtQ5IH9rc2xIJVxUm5RRkEQXRcG6EcKiMYREZ-AM1PVcouF96rAcZF85lUmHD7sFT7VntEBIv7P2PeA9ivA_l9ervHQ8Dl4WmuP0u9kzyeEtIib3ND1otK1p_V0gF3gJqH6RYiO6AGggv7r9mWLgu456IZgBzRTtMuYMZYi5-Njf1-vOymXCI_qWv9N_0S3qub3E1Ti9yYEnwY44M_zO91Df4u87RJD3TV-l5-jUz0ssyMkP0sFEZk57oG31tCL5N2fQfXNzpO0wwzrkeNKJc1G8kmaCkcXqW_siJbvUEjTM91rfpBVJOUORF-p1a1MeRoo6SCVg0AhmxzKSmwz2qBhBBjzq49OCQodQe7fERwoaM7wsRzZBSJP6AOocsjNFKhjgIMP2Qzb3STLu5CdRZ3TAc1Dmln9Gy7fpGq7lmr7bsZrPRaFn0mDq1Rr211mgt2xutdXt5pbm6MrLoicm6XF-3MQi8QAnZmX49s9foH-NL47Y)	

</div>

## 🏗 Архитектура проекта
Проект организован по принципу разделения бизнес-логики, интерфейса и тестов:

### Логика анализа (`ArrayInversion/ArrayInversion.cs`)
Содержит расчетный класс `ArrayInversion` с двумя статическими методами:
- `BruteForce`: Подсчет через вложенные циклы. Идеален для понимания базовой логики, но неэффективен на больших N.
- `Optimized`: Модифицированный алгоритм сортировки слиянием, который подсчитывает инверсии в процессе слияния подмассивов.
- `InversionResult`: Класс-контейнер для возврата количества инверсий и числа операций.

### Интерфейс пользователя (`Lab3Algos/ArrayInversionForm.cs` и `Lab3Algos/ArrayInversionForm.Designer.cs`)
- Реализует событийную модель управления
- Метод `StartAnalize` запускает цикл тестов на разных размерах входных данных, клонируя массивы для чистоты эксперимента.
- Динамически обновляет `Chart` и таблицу результатов прямо в процессе выполнения.

### Модульное тестирование (`ArrayInversion/Inversion.cs`)
Реализован с использованием `TabControl` для удобного переключения между режимами:

- Вкладка "Статистика и Анализ": Содержит многострочное поле ввода, кнопку "Рассчитать" и поля только для чтения для вывода цифр.
- Вкладка "Визуализация": Содержит PictureBox для отображения сгенерированного графика распределения букв.

## Развертывание и использование

### Сборка и запуск
1. Клонируйте репозиторий в какую то директорию:
	```bash
	git clone https://github.com/tstu-artemos-projects/Lab3Algos.git # или git@github.com:tstu-artemos-projects/Lab3Algos.git
	```
2. Откройте `Lab3Algos.sln` в Visual Studio.
3. Убедитесь, что установлена рабочая нагрузка ".NET Desktop Development".
4. Нажмите F5 для запуска приложения или Ctrl+Shift+T для запуска тестов.
5. Следуйте инструкциям в интерфейсе для анализа текста и визуализации данных.

### Скачивание исолнительного файла
Вы можете скачать готовый исполняемый файл из раздела "Releases" на GitHub
- [Releases](https://github.com/tstu-artemos-projects/Lab3Algos/releases/latest)

После скачивания распакуйте архив и запустите `Lab3Algos.exe` для использования приложения.

### Как использовать
1. Нажмите кнопку "Запустить анализ" в верхней части окна.
2. Программа автоматически сгенерирует массивы разных размерностей и прогонит через них оба алгоритма.
3. В левой части появится таблица с точными цифрами операций и миллисекунд.
4. В правой части сформируется график, наглядно демонстрирующий разрыв в производительности между $O(n^2)$ (красная линия) и $O(n \log n)$ (зеленая линия).
