// Lobaba Auther 5/9/2024 

//integer array [100 elements]
using System.Collections.Generic;
using System.Diagnostics;
//Solution One If calculate the number of occurrences while generating numbers in the array
var excuteTime = Stopwatch.StartNew();

int[] randomNumberList = new int[100];
Dictionary<int, int> numberOfoccurrences = new Dictionary<int, int>();
Random random = new Random();
Console.WriteLine("Solution No 1");
Console.Write("Numbers: ");

for (int i = 0; i < randomNumberList.Length; i++)
{
    //Generate Random numbers between 20-40
    randomNumberList[i] = random.Next(20, 40);
    if (numberOfoccurrences.ContainsKey(randomNumberList[i]) == true)
    {

        if (numberOfoccurrences.TryGetValue(randomNumberList[i], out int currentValue))
        {
            numberOfoccurrences[randomNumberList[i]] = currentValue + 1;
        }
        else
        {
            numberOfoccurrences[randomNumberList[i]] = 1;
        }
    }
    else
    {
        numberOfoccurrences.Add(randomNumberList[i], 1);

    }
    Console.Write(" - "+randomNumberList[i] );


}

Console.WriteLine("\n Value - number of occurrences ");

foreach (KeyValuePair<int, int> element in numberOfoccurrences)
{
    Console.WriteLine("{0} - {1}", element.Key, element.Value);
}
excuteTime.Stop();
Console.WriteLine($"The Execution time of the Solution No1 ={excuteTime.ElapsedMilliseconds}ms");


//Solution two If calculate the number of occurrences after generating numbers in the array
var excuteTime2 = Stopwatch.StartNew();

int[] randomNumberList2 = new int[100];
Dictionary<int, int> numberOfoccurrences2 = new Dictionary<int, int>();
Random random2 = new Random();
Console.WriteLine("Solution No 2 ");
Console.Write("Numbers: ");

for (int i = 0; i < randomNumberList2.Length; i++)
{
    //Generate Random numbers between 20-40
    randomNumberList2[i] = random2.Next(20, 40);
}
for (int i = 0; i < randomNumberList2.Length; i++)
{
    if (numberOfoccurrences2.ContainsKey(randomNumberList2[i]) == true)
    {

        if (numberOfoccurrences2.TryGetValue(randomNumberList2[i], out int currentValue))
        {
            numberOfoccurrences2[randomNumberList2[i]] = currentValue + 1;
        }
        else
        {
            numberOfoccurrences2[randomNumberList2[i]] = 1;
        }
    }
    else
    {
        numberOfoccurrences2.Add(randomNumberList2[i], 1);

    }
    Console.Write(" - " + randomNumberList2[i]);
}
Console.WriteLine("\nValue - number of occurrences ");

foreach (KeyValuePair<int, int> element in numberOfoccurrences2)
{
    Console.WriteLine(" {0}   -          {1}", element.Key, element.Value);
}

excuteTime2.Stop();
Console.WriteLine($"The Execution time of the Solution No2 ={excuteTime2.ElapsedMilliseconds}ms");

