//Шаг 1. Линейный поиск с флагом
int[] recordBooks = { 1042, 1058, 1071, 1093, 1105 };
int target = 1093;

bool found = false;

foreach (int number in recordBooks) {
    if (number == target) {
        found = true;
        break;
    }
}

Console.WriteLine(found ? "Студент найден" : "Студент не найден");
//Шаг 2. Проверка числа на простоту
int variant = 1;
bool isPrime = true;

if (variant == 1){
    Console.WriteLine($"Число {variant} не считается ни простым, ни составным числом");
} else {
    for (int divisor = 2; divisor < variant; divisor++)
    {
        if (variant % divisor == 0)
        {
            isPrime = false;
            break;
        }
    }
    Console.WriteLine(isPrime ? "Номер варианта простой" : "Номер варианта составной");
}