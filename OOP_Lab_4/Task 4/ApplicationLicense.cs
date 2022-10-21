using System;
namespace OOP_Lab_4
{
    public class ApplicationLicense
    {
        public Boolean isCommon = false;
        public Boolean isPro = false;

        public int CommonKey = 1848;
        public int ProKey = 2003;


        public void KeyCheck(int key)
        {
            if (key == CommonKey)
            {
                AllowCommon();
            }
            else if (key == ProKey)
            {
                AllowPro();
            }
            else
            {
                AllowTrial();
            }
        }
        public void AllowTrial()
        {
            isCommon = false;
            isPro = false;
            Console.WriteLine("Congratulations! You are too poor or too greedy to buy at least common version of our program. You're on free trial." +
                " Come on, at least buy common version.");
        }
        public void AllowCommon()
        {
            isCommon = true;
            isPro = false;
            Console.WriteLine("Congratulations! You bought common version of our program. But, of course, you are not so respected as our Pro" +
                " clients, so your functionality is limited. Don't be greedy, buy full version for 99 dollars/month.");
        }
        public void AllowPro()
        {
            isCommon = false;
            isPro = true;
            Console.WriteLine("Valued client! We do our best to make a better user experience for you and to meet your requirements. " +
                "Our developers are constantly working overtime to ensure that there are no problems, but if you do have one, please contact" +
                " our 24/7 technical support. Have a nice day!");
        }
    }
}
