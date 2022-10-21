using System;

namespace OOP_Lab_4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            AnotherClass another = new AnotherClass();
            Console.WriteLine("End of Task 1");

            Horror soma = new Horror("SOMA", 2015, "Soma takes place on an underwater remote research facility containing machinery that exhibits human characteristics, " +
                "such as consciousness. Simon Jarrett, a fish-out-of-water protagonist, finds himself there under mysterious circumstances and embarks upon discovering its history, " +
                "while trying to make sense of his predicament and potential future.");
            soma.PrintInfo(soma.Name, soma.ReleaseDate, soma.Descryption);
            Strategy supCom = new Strategy("Supreme Commander: Forged Alliance", 2007, "Supreme Commander allowed the player to employ all four traditional battlespaces — air, information, land and sea." +
                "The player uses a giant bipedal mech called an Armored Command Unit (or ACU) to build an army with which they can conquer their opponents. ");
            supCom.PrintInfoGenre();
            ClassA classA = new ClassA(supCom.Name, supCom.ReleaseDate, supCom.Genre);

            Console.WriteLine();
            Console.WriteLine("/////// ClassB ///////");
            Console.WriteLine("////Horror//Shooter//Strategy////");
            Console.WriteLine("//////Name, ReleaseDate, Descryption, Genre//////");
            Console.WriteLine("End of Task 2");

            // Basically, I did Task 3 in Task 2, so no new classes created
            Console.WriteLine();
            soma = new Horror("SOMA", 2015, "Soma takes place on an underwater remote research facility containing machinery that exhibits human" +
                " characteristics, such as consciousness. Simon Jarrett, a fish-out-of-water protagonist, finds himself there under mysterious " +
                "circumstances and embarks upon discovering its history, while trying to make sense of his predicament and potential future.");
            soma.PrintInfoGenre();
            supCom = new Strategy("Supreme Commander: Forged Alliance", 2007, "Supreme Commander allowed the player to employ all four traditional " +
                "battlespaces — air, information, land and sea.The player uses a giant bipedal mech called an Armored Command Unit (or ACU) to " +
                "build an army with which they can conquer their opponents. ");
            supCom.PrintInfoGenre();
            Shooter readyOrNot = new Shooter("Ready or Not", 2021, "The game is centered on a team of SWAT operatives in the fictional American city of " +
                "Los Huenos. Realism is a central pillar of the experience, with both players and suspects being killed in only a few shots." +
                " A variety of less-lethal weapons such as stun grenades, tasers and pepper spray are available in addition to firearms and players " +
                "are awarded more points for arresting suspects rather than killing them.");
            Console.WriteLine("End of Task 3");
            Console.WriteLine();

            ApplicationLicense applicationLicense = new ApplicationLicense();
            Console.WriteLine("Please, enter your application code: ");
            applicationLicense.KeyCheck(Int32.Parse(Console.ReadLine()));
        }
    }
}
