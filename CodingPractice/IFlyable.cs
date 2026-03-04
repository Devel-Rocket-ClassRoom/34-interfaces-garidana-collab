using System;
using System.Collections.Generic;
using System.Text;

interface IFlyable
{
    void Fly();
}

class Animal
{
    public void Breathe()
    {
        Console.WriteLine("숨을 쉽니두.");
    }
}

class Bird : Animal, IFlyable
{
    public void Fly()
    {
        Console.WriteLine("날아갑니두.");
    }
}
