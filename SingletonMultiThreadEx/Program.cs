// See https://aka.ms/new-console-template for more information
using SingletonMultiThreadEx;
Task task1 = Task.Factory.StartNew(() =>
{
    Count c1 = Count.getInstance();
    c1.increment();
    Console.WriteLine(" counter num 1 : " + c1.Couunt);
});
Task task2= Task.Factory.StartNew(() =>
{
    Count c2 = Count.getInstance();
    c2.increment();
    Console.WriteLine(" counter num 2 : " + c2.Couunt);
});
Console.ReadKey();

