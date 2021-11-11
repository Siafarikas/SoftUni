using System;

namespace Pokemon
{
    class Pokemon
    {
        static void Main(string[] args)
        {
            int nPower = int.Parse(Console.ReadLine());
            int mDistance = int.Parse(Console.ReadLine());
            int yExhaust = int.Parse(Console.ReadLine());
            int pokeCounter = 0;
            int nPowerRemainder = nPower;
            while (mDistance <= nPowerRemainder)
            {
                nPowerRemainder -= mDistance;
                pokeCounter++;
                if (nPowerRemainder == nPower / 2)
                {
                    if (nPowerRemainder <= yExhaust)
                    {
                        continue;
                    }
                    else
                    {
                        nPowerRemainder = nPowerRemainder / yExhaust;
                    }
                }
            }
            Console.WriteLine(nPowerRemainder);
            Console.WriteLine(pokeCounter);
        }
    }
}
