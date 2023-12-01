// Задача 3: 
// Задайте массив из вещественных чисел с ненулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементов массива.


double[] res = new double[10];
for (int i = 0; i < res.Length; i++)
{
    res[i] = Math.Round(new Random().NextDouble() * new Random().Next(1001), 2);
}
Console.WriteLine($"Результат: [ {string.Join("; ", res)} ]");
Console.WriteLine("Минимальный элемент: " + res.Min());
Console.WriteLine("Максимальный элемент: " + res.Max());
Console.WriteLine($"Разница между максимальным и минимальным элементами массива составляет: {res.Max() - res.Min()}");
