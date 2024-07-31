// See https://aka.ms/new-console-template for more information
using Algorithm.DataStructure;

var priorityQueue = new PriorityQueue<string>();
for (int i = 0; i < 100; i++)
{
    int val = Random.Shared.Next(1, 50);
    priorityQueue.Enqueue(val.ToString(), val);
}

for (int i = 0; i < 100; i++)
{
    Console.WriteLine(priorityQueue.Dequeue());
}
