using System;
using System.Collections.Generic;
using cs_Participant;

namespace ParticipantApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Participant p1 = new Participant();
            Participant p2 = new Participant();
            Console.ReadLine();


            Console.WriteLine(p1.particiantName);
            Console.WriteLine(p2.particiantName);

            Console.ReadLine();

            p1.showParticipant(p1);
            
        }

        
        
    }
}
