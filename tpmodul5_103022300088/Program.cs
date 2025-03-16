using System;
using tpmodul5_103022300088;
 
class Program
{
    static void Main()
    {
        HaloGeneric halo = new HaloGeneric();
        Console.Write("Masukkan nama panggilan anda: ");
        string nama = Console.ReadLine();
        halo.SapaUser(nama);

        // branch generic-class
        Console.Write("Masukkan NIM: ");
        string nim = Console.ReadLine();
        DataGeneric<string> dataNIM = new DataGeneric<string>(nim);
        dataNIM.PrintData();
    }
}
