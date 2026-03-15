// See https://aka.ms/new-console-template for more information
using tpmodul3_103082400003;

class Program
{
    static void Main(string[] args)
    {
        KodePos kp = new KodePos();
        string[,] listkp = kp.getKodePos();
        DoorMachine dm = new DoorMachine();



        while (true)
        {
            Console.WriteLine("Jalankan Program (1/2) ");
            int input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.WriteLine("Daftar Kelurahan dan Kode Pos");
                    Console.WriteLine("--------------------------------------------------");
                    for (int i = 0; i < listkp.GetLength(0); i++)
                    {
                        Console.WriteLine("Kelurahan : " + listkp[i, 0] + "| Kode Pos : " + listkp[i, 1]);
                    }
                    break;

                case 2:
                    dm.DoorDriven();
                    break;

                default:
                    Console.WriteLine("Input tidak valid");
                    break;
            }
        }

    }
}
