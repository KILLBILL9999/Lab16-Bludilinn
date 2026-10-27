// Console.Write("Сколько студентов в группе? ");
// int studentsCount = int.Parse(Console.ReadLine());
// int[] grades = new int[studentsCount];

// for (int i = 0; i < grades.Length; i++) {
//     Console.Write($"Оценка студента {i + 1}: ");
//     grades[i] = int.Parse(Console.ReadLine());
// }
// int sum = 0;
// foreach (int grade in grades) {
//     sum += grade;
//     Console.WriteLine(grade);
// }
// Console.WriteLine($"Средний балл: {(double)sum / grades.Length}");


// int[] points = { 4, 7, 2, 9, 5 };
// for (int i = 0; i < points.Length; i++) {
//     if (points[i] < 10) {
//         points[i] = points[i] + 1;
//     }
// }

// foreach (int point in points) {
//     Console.WriteLine(point);
// }

// int[] grades = { 4, 5, 3, 5, 4, 2 };
// for (int i = 0; i < grades.Length - 1; i++) {
//     for (int j = 0; j < grades.Length - 1 - i; j++) {
//         if (grades[j] < grades[j + 1]) {
//             int temp = grades[j];
//             grades[j] = grades[j + 1];
//             grades[j + 1] = temp;
//         }
//     }
// }

// foreach (int grade in grades) {
//     Console.WriteLine(grade);
// }

// int[] GenerateScheduleSlots(int lessonsCount) {
//     int[] slots = new int[lessonsCount];
//     for (int i = 0; i < lessonsCount; i++) {
//         slots[i] = i + 1;
//     }
//     return slots;
// }

// int[] GenerateEvenSlots(int lessonsCount) {
//     int[] slots = new int[lessonsCount];
//     for (int i = 0; i < lessonsCount; i++) {
//         slots[i] = (i + 1) * 2;
//     }
//     return slots;
// }
// int[] slots = GenerateEvenSlots(6);
// foreach (int slot in slots) {
//     Console.WriteLine(slot);
// }

// Console.Write("Введите N: ");
// int n = int.Parse(Console.ReadLine());
// int[] squares = new int[n];

// for (int i = 0; i < n; i++) {
//     squares[i] = (i + 1) * (i + 1);
// }

// foreach (int num in squares) {
//     Console.WriteLine(num);
// }


// int[] numbers = { -5, 3, -2, 8, -1, 0, 4 };
// Console.WriteLine("Исходный массив:");
// foreach (int num in numbers)
// {
//     Console.Write($"{num} ");
// }
// Console.WriteLine();
// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] < 0)
//     {
//         numbers[i] = 0;
//     }
// }
// Console.WriteLine("Массив после замены:");
// foreach (int num in numbers)
// {
//     Console.Write($"{num} ");
// }

// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)) {
// Console.WriteLine("Фамилия не введена. Завершение работы.");
// return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
// .OrderBy(_ => rnd.Next())
// .Take(2)
// .OrderBy(x => x)
// .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

// Console.Write("Введите размер массива: ");
// int size = int.Parse(Console.ReadLine());
// int[] numbers = new int[size];

// Console.WriteLine("Введите элементы массива:");
// for (int i = 0; i < numbers.Length; i++)
// {
//     Console.Write($"Элемент {i + 1}: ");
//     numbers[i] = int.Parse(Console.ReadLine());
// }

// int sum = 0;
// foreach (int num in numbers)
// {
//     sum += num;
// }

// Console.WriteLine("\nВведённые числа:");
// foreach (int num in numbers)
// {
//     Console.Write($"{num} ");
// }

// Console.WriteLine($"\n\nСумма всех чисел: {sum}");


// int[] numbers = { 5, 9, 12, 7, 3, 8, 15 };

// Console.WriteLine("Исходный массив:");
// foreach (int num in numbers)
// {
//     Console.Write($"{num} ");
// }

// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] % 3 == 0)
//     {
//         numbers[i] = -1;
//     }
// }

// Console.WriteLine("\n\nМассив после замены:");
// foreach (int num in numbers)
// {
//     Console.Write($"{num} ");
// }
