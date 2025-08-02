using System.Diagnostics;

int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
int SumSegment(int start, int end)
{
    int segmentSum = 0;
    for (var i = start; i < end; i++)
    {
        Thread.Sleep(100); // Simulating a delay to mimic a more complex operation
        segmentSum += array[i];
    }
    return segmentSum;
}
int sum = 0, sum1 =0, sum2 =0, sum3 = 0;
var startTime = Stopwatch.StartNew();
int segmentThread = array.Length / 4;
Thread[] threads = new Thread[4];

threads[0] = new Thread(() =>
{
   sum = SumSegment(0, segmentThread);
});
threads[1] = new Thread(() =>
{
    sum1 = SumSegment(segmentThread, segmentThread*2);
});
threads[2] = new Thread(() =>
{
    sum2 = SumSegment(segmentThread*2, segmentThread * 3);
});
threads[3] = new Thread(() =>
{
    sum3 = SumSegment(segmentThread*3, segmentThread * 4);
});

foreach (var thread in threads)
{
    thread.Start();
}
foreach (var thread in threads)
{
    thread.Join();
}
startTime.Stop();

Console.WriteLine($"the sum is {sum+sum1+sum2+sum3}");
Console.WriteLine($"the time it takes is :{startTime.Elapsed.TotalMilliseconds}");