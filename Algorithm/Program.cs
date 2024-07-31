// See https://aka.ms/new-console-template for more information
using Algorithm;

int[] array = Tool.GenerateRandomArray(10);
Console.WriteLine(string.Join(',', array));
Tool.Partition(array, 0, array.Length - 1);
Console.WriteLine(string.Join(',', array));
