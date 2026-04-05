using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            SayaMusicTrack lagu1 = new SayaMusicTrack("Hindia - Evaluasi");
            lagu1.IncreasePlayCount(100);
            lagu1.PrintTrackDetails();

            SayaMusicTrack laguError = new SayaMusicTrack(new string('A', 101));

            SayaMusicTrack lagu2 = new SayaMusicTrack("Overflow Test");
            for (int i = 0; i < 100; i++)
            {
                lagu2.IncreasePlayCount(int.MaxValue);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Terjadi error: " + e.Message);
        }
    }
}