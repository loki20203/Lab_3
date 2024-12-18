﻿public class РобочаСтанція : Компютер, IConnectable
{
    public string Користувач { get; private set; }

    public РобочаСтанція(string ipАдреса, int потужність, string типОс, string користувач)
        : base(ipАдреса, потужність, типОс)
    {
        Користувач = користувач;
    }

    public void Зєднатися(Компютер іншийКомпютер)
    {
        Console.WriteLine($"Робоча станція {IpАдреса} з'єдналася з {іншийКомпютер.IpАдреса}");
    }

    public void Відєднатися(Компютер іншийКомпютер)
    {
        Console.WriteLine($"Робоча станція {IpАдреса} від'єдналася від {іншийКомпютер.IpАдреса}");
    }

    public void ПередатиДані(Компютер іншийКомпютер, string дані)
    {
        Console.WriteLine($"Робоча станція {IpАдреса} передала дані '{дані}' до {іншийКомпютер.IpАдреса}");
    }
}
