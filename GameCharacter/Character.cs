using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Threading;
using System.Xml.Linq;

class Character : IAttacker, IDefender
{
    public string Name { get; private set; } = "용사";
    public int AttackPower { get; private set; } = 20;

    public int CurrentHp { get; private set; }

    public int MaxHp { get; private set; } = 100;

    public bool IsDead { get; private set; }

    public void Attack(IDefender target)
    {
        target.TakeDamage(AttackPower);
        Console.WriteLine($"{Name}(이/가) {target}에게 {AttackPower} 대미지! ({target} HP : {target.CurrentHp}/{target.MaxHp})");
    }

    public void TakeDamage(int damage)
    {
        CurrentHp = MaxHp - damage  ;
        if (CurrentHp <= 0)
        {
            IsDead = true;
            Console.WriteLine($"{Name}(이/가) 쓰러졌습니다!");
        }
    }
}