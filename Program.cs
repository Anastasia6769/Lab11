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
//Шаг 3. continue для пропуска элементов
// int[] pointsPerLab = {8, -1, 10, 9, -1, 7};
// int sum = 0;
// int count =0;

// foreach (int points in pointsPerLab)
// {
//     if (points <0){
//         continue;
//     }
//     sum += points;
//     count++;
// }
// Console.WriteLine($"Сумма баллов за сданные работы: {sum}");
// Console.WriteLine($"Количество сданных работ: {count}");
//Шаг 4. Дубликаты в массиве
Console.WriteLine();
int[] groupIds = { 101, 104, 107, 104, 110 };
bool hasDuplicates = false;

for (int i = 0; i < groupIds.Length; i++) {
    for (int j = i + 1; j < groupIds.Length; j++) {
        if (groupIds[i] == groupIds[j]) {
            Console.WriteLine($"Совпавшие номера зачеток: {groupIds[i]} и {groupIds[j]}");
            hasDuplicates = true;
            break;
        }
    }
    if (hasDuplicates) {
        break;
    }
}
if (!hasDuplicates) {
    Console.WriteLine("Все номера уникальны");
}
//Шаг 5. Выход сразу из двух циклов
int days = 5;
int lessonPerDay = 6;
bool found1 = false;

for (int day = 1; day <= days && !found1; day++){
    for (int lesson = 1; lesson <= lessonPerDay; lesson++){
        bool isFree = (day == 3 && lesson == 4);

        if (isFree){
            Console.WriteLine($"Свободный слот: день {day}, урок {lesson}");
            found1 = true;
            break;
        }
    }
}
if (!found1){
    Console.WriteLine("Свободных слотов нет");
}
//Самостоятельные задания ★
//Задача А
int[] arr = { 5, 3, 8, 4, 2 };
int target1 = 4;

int index = -1;          
bool found2 = false;     

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] == target1)
    {
        index = i;
        found2 = true;
        break;
    }
}

if (found2)
{
    Console.WriteLine($"Число {target1} найдено по индексу: {index}");
}
else
{
    Console.WriteLine($"Число {target1} не найдено в массиве.");
}
//Задача Б
int n = 17;
bool flg = true;   

if (n <= 1)
{
    flg = false;
}
else
{
    for (int d = 2; d <= n; d++)
    {
        if (n % d == 0)
        {
            flg = false;
            break;      
        }
    }
}

if (flg)
{
    Console.WriteLine($"{n} — простое число.");
}
else
{
    Console.WriteLine($"{n} — не простое число.");
}
//Индивидуальный вариант ★★
Console.Write("Введите свою фамилию: ");
string surname = Console.ReadLine()!.Trim();
if (string.IsNullOrEmpty(surname)) {
Console.WriteLine("Фамилия не введена. Завершение работы.");
return;
}
Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
var assigned = Enumerable.Range(1, 10)
.OrderBy(_
=> rnd.Next())
.Take(2)
.OrderBy(x => x)
.ToList();
Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");
//Вариант 8
int[] arr1 = { 10, 25, 3, 7 };
int[] arr2 = { 9, 3, 18, 42, 7 };

bool found3 = false;          
int commonValue = 0;       

for (int i = 0; i < arr1.Length; i++)
{
    for (int j = 0; j < arr2.Length; j++)
    {
        if (arr1[i] == arr2[j])
        {
            found3 = true;
            commonValue = arr1[i];
            break;         
        }
    }

    if (found3)
    {
        break;             
    }
}

if (found3)
{
    Console.WriteLine($"Общий элемент найден: {commonValue}");
}
else
{
    Console.WriteLine("Общих элементов нет.");
}
//Вариант 10
int l = 10;          
int a = 1;           
int b = 1;           

while (true)
{
    int next = a + b;        

    if (next > l)            
    {
        Console.WriteLine(next);  
        break;
    }                    

    a = b;                    
    b = next;
}
//Дополнительное задание. Пара чисел с заданной суммой. ★★★
int[] num = {1, 4, 3, 9, 11};
int target4 = 7;
bool flag = false;

for (int i = 0; i < num.Length; i++){
    for (int j = i+1; j < num.Length; j++){
        if (num[i] + num[j] == target4){
            Console.WriteLine($"Индексы: {i} и {j}");
            flag = true;
            break;
        }
    }
}
if (!flag){
   Console.WriteLine("Пара не найдена"); 
}