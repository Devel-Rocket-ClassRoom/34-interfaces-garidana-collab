using System;
using System.Collections.Generic;
using System.Text;

interface IAnimal
{
    void Eat();
}

interface IDog
{
   // void Bark();
    void Eat();
}

interface ICat
{
    void Eat();
}

class Pet : ICat, IDog
{
    void IDog.Eat()
    {
        Console.WriteLine("개처럼 먹습니두.");
    }
    void ICat.Eat()
    {
        Console.WriteLine("고양이처럼 먹습니두.");
    }
}

class Dog : IAnimal, IDog  // 인터페이스 IAnimal, IDog 둘다 상속 받음
{
    public void Eat()
    {
        Console.WriteLine("먹습니다.");
    }
    public void Bark()
    {
        Console.WriteLine("짖습니다.");
    }
}
