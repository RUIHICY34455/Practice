/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.*/

Console.Write("Введите количество элементова массива:\t");

int elementsCount = int.Parse(Console.ReadLine());

string[] myArray = new string [elementsCount];

for(int i = 0; i < myArray.Length; i++)
{
    System.Console.Write($"\nВведите элемент массива номер {i+1}:\t");
    myArray[i] = Console.ReadLine();
}


string[] newArray = new string [elementsCount];

System.Console.WriteLine("\nМассив:");
for(int i = 0; i < myArray.Length; i++)
{
    if (myArray[i].Length < 4)
        {
            newArray[i] = myArray[i];
            System.Console.Write($"{newArray[i]}\t");
        }
}
