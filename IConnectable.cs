﻿public interface IConnectable
{
    void Зєднатися(Компютер іншийКомпютер);
    void Відєднатися(Компютер іншийКомпютер);
    void ПередатиДані(Компютер іншийКомпютер, string дані);
}
