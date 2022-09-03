namespace SnakeLadder
{

    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Number\n 1.Starting Position\n 2.Rolls a Die(Generates Random Value\n3.game\n4.Winning Position");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Start start = new Start();
                    Console.WriteLine(start.playerPosition);
                    break;
                case 2:
                    DieRoll roll = new DieRoll();
                    Console.WriteLine(roll.RollDie());
                    break;
                case 3:
                    PlayerCheckOption check = new PlayerCheckOption();
                    Console.WriteLine(check.DieRoll());
                    PlayerCheckOption option = new PlayerCheckOption();
                    Console.WriteLine(option.Play());
                    break;
                case 4:
                    WinningPosition position = new WinningPosition();
                    Console.WriteLine(position.DieRoll());
                    WinningPosition dieCount = new WinningPosition();
                    Console.WriteLine(dieCount.DieRoll());
                    break;
                case 5:
                    ExactWinning exact = new ExactWinning();
                    Console.WriteLine(exact.DieRoll());
                    WinningPosition exact1 = new WinningPosition();
                    Console.WriteLine(exact1.Play());
                    break;

                default:
                    Console.WriteLine("Entered Wrong Number");
                    break;
            }
        }
    }
}