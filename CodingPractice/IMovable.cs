using System;
using System.Collections.Generic;
using System.Text;

interface IMovable
{
    void Move();
}

interface IAttackable
{
    void Attack();
}

class Hero
{
    public void Move()
    {
        Console.WriteLine("영웅이 이동합니다,");
    }
    public void Attack()
    {
        Console.WriteLine("영웅이 공격합니다");
    }
}

class Turret
{
    public void Attack()
    {
        Console.WriteLine("포탑이 발사합니다.");
    }
}