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
    }
}