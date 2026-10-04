Console.Write("Введите первую сторону: ");
double a = double.Parse(Console.ReadLine());
Console.Write("Введите вторую сторону: ");
double b = double.Parse(Console.ReadLine());
Console.Write("Введите третью сторону: ");
double c = double.Parse(Console.ReadLine());


double p = a + b + c;
Console.WriteLine($"Периметр: {p}");

double semiP = (a + b + c) / 2;
Console.WriteLine($"Площадь: {Math.Sqrt(semiP*(semiP-a)*(semiP-b)*(semiP-c)):F2}");
// Проверка Git