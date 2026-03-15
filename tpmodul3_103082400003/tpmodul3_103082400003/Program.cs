// See https://aka.ms/new-console-template for more information
using tpmodul3_103082400003;

class Program
{
    static void Main(string[] args)
    {
        KodePos kp = new KodePos();
        string[,] listkp = kp.getKodePos();

        Console.WriteLine("Daftar Kelurahan dan Kode Pos");
        Console.WriteLine("--------------------------------------------------");
        for (int i = 0; i < listkp.GetLength(0); i++)
        {
            Console.WriteLine("Kelurahan : " + listkp[i,0] + "| Kode Pos : " + listkp[i, 1]);
        }
    }
}
