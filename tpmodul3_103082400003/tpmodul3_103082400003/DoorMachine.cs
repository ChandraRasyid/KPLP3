using System;
using System.Collections.Generic;
using System.Text;

namespace tpmodul3_103082400003
{
    internal class DoorMachine
    {
        enum State { Terkunci, Terbuka, Exit };
        public void DoorDriven()
        {
            State state = State.Terkunci;
            string[] doorName = { "Terkunci", "Terbuka", "Exit" };
            while (state != State.Exit) { 
                Console.Clear();
                Console.WriteLine("Pintu saat ini : " + doorName[(int)state]);
                Console.WriteLine("Ketik Perintah (Buka, Tutup, Exit)");
                //Console.WriteLine("Ketik 'Buka' untuk membuka pintu");
                string command = Console.ReadLine();

                switch (state)
                {
                    case State.Terkunci:
                        if (command.Equals("Buka", StringComparison.OrdinalIgnoreCase))
                        {
                            state = State.Terbuka;
                        }
                        else if (command.Equals("Exit", StringComparison.OrdinalIgnoreCase))
                        {
                            state = State.Exit;
                        }
                        else
                        {
                            Console.WriteLine("Perintah tidak dikenali. Ketik 'Buka' untuk membuka pintu.");
                        }
                        break;
                    case State.Terbuka:
                        if (command.Equals("Tutup", StringComparison.OrdinalIgnoreCase))
                        {
                            state = State.Terkunci;
                        }
                        else if (command.Equals("Exit", StringComparison.OrdinalIgnoreCase))
                        {
                            state = State.Exit;
                        }
                        else
                        {
                            Console.WriteLine("Perintah tidak dikenali. Ketik 'Tutup' untuk menutup pintu.");
                        }
                        break;
                    case State.Exit:
                        return;
                }
            }
        }
    }
}
