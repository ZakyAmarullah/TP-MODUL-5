using System;
using System.Runtime.ConstrainedExecution;

public class HaloGeneric
{
    public void SapaUser<T>(T user)
    {
        Console.WriteLine("Halo user ");
    }
}

public class DataGeneric<T>
{
    private T data;
    public DataGeneric(T data)
    {
        this.data = data;
    }
    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + data);
    }
}

public class Program
{
    public static void Main()
    {
    {
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser("Zaky");
    }

    DataGeneric<string> dataNIM = new DataGeneric<string>("103022300045");
        dataNIM.PrintData();
    }

}