using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;






interface IStandart
{
    void Run();
}


abstract class Vehicle
{
    public abstract void Back();  // 추상 메서드는 상속받는 클래스에서 구현

    public void Left()
    {
        Console.WriteLine("좌회전");
    }
}

class Carrr : Vehicle
{
    public void Run()
    {
        Console.WriteLine("전진");
    }
    public override void Back()
    {
        Console.WriteLine("후진");
    }
}