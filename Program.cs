namespace GuessMyNumberGame
{
    partial class Program
    {


        static void Main(string[] args)
        {

            var humanPlay = new HumanPlay();

            var tenValues = humanPlay.MakeArray(10);


            new Bisection().SerchValue(tenValues);


            humanPlay.SerchValue(tenValues);

            new ComputerPlay().SerchValue(tenValues);


        }
    }
}
