﻿public class Сервер : Компютер, IConnectable
{
    public int Ємність { get; private set; } // Обсяг пам’яті сервера

    public Сервер(string ipАдреса, int потужність, string типОс, int ємність)
        : base(ipАдреса, потужність, типОс)
    {
        Ємність = ємність;
    }

    public void Зєднатися(Компютер іншийКомпютер)
    {
        Console.WriteLine($"Сервер {IpАдреса} з'єднався з {іншийКомпютер.IpАдреса}");
    }

    public void Відєднатися(Компютер іншийКомпютер)
    {
        Console.WriteLine($"Сервер {IpАдреса} від'єднався від {іншийКомпютер.IpАдреса}");
    }

    public void ПередатиДані(Компютер іншийКомпютер, string дані)
    {
        Console.WriteLine($"Сервер {IpАдреса} передав дані '{дані}' до {іншийКомпютер.IpАдреса}");
    }
}
