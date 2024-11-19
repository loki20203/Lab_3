public class Компютер
{
    // Основні властивості
    public string IpАдреса { get; private set; }
    public int Потужність { get; private set; }
    public string ТипОс { get; private set; }

    // Конструктор
    public Компютер(string ipАдреса, int потужність, string типОс)
    {
        IpАдреса = ipАдреса;
        Потужність = потужність;
        ТипОс = типОс;
    }

    // Метод для виведення інформації
    public virtual void ВивестиІнформацію()
    {
        Console.WriteLine($"IP: {IpАдреса}, Потужність: {Потужність}, ОС: {ТипОс}");
    }
}
