﻿using System;

public class HaloGeneric
{
    public void SapaUser<T>(T user)
    {
        Console.WriteLine("Halo user ");
    }
}

public class Program
{
    public static void Main()
    {
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser("Zaky");
    }
}