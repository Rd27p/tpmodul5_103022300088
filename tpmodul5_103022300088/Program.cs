using tpmodul5_103022300088;
using System;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Masukkan NIM: ");
        string nim = Console.ReadLine();
        DataGeneric<string> dataNIM = new DataGeneric<string>(nim);
        dataNIM.PrintData();
    }
}
