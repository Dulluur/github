using Laba_2;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Toyota toyota = new Toyota();
        toyota.Start();
        toyota.CarRadio.On();
        toyota.Speedup(100);
        toyota.Slowdown(50);
        toyota.CarRadio.Off();
        toyota.Stop();

        Ferrari ferrari = new Ferrari();
        ferrari.Start();
        ferrari.Speedup(200);
        ferrari.Slowdown(100);
        ferrari.Stop();

        Bugatti bugatti = new Bugatti();
        bugatti.Start();
        bugatti.Speedup(300);
        bugatti.CarRadio.On();
        bugatti.Slowdown(150);
        bugatti.CarRadio.Off();
        bugatti.Stop();
    }
}