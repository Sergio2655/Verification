/*Написать программу которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 
3 символам. Первоначальный массив можно ввести с клавиатуры или задать на старте выполнения алгоритма*/
string[] array = {"Moscow", "London", "Paris", "Berlin", "Voronesh"};
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
string[] myArray = new string[3];
for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = array[i];
}
Console.WriteLine();
for (int i = 0; i < myArray.Length; i++)
{
    Console.Write("\t" + myArray[i]);
}