using System;
using System.Collections.Generic;
using System.Text;

interface Icar
{
    void Go();
}

class Car : Icar
{
    public void Go()
    {
        Console.WriteLine("자동차가 달립니다.");
    }
}