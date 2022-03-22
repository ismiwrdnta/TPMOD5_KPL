using System;

namespace tpmodul5_1302201135
{
    public class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo newVid = new SayaTubeVideo("Tutorial Design By Contract - Ismi Wardanita");
            newVid.IncreasePlayCount(3);
            newVid.PrintVideoDetails();
        }
    }
}