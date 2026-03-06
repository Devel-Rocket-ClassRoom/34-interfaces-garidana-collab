using System;
using System.Collections.Generic;
using System.Text;

class Monster : IAttacker, IDefender
{
    public string Name { get; private set; }
    public int AttackPower { get; private set; }

    public int CurrentHp { get; private set; }

    public int MaxHp { get; private set; }

    public bool IsDead { get; set; }

    public Monster(string name, int maxHp, int attackPower)
    {
        Name = name;
        MaxHp = maxHp;
        AttackPower = attackPower;
        IsDead = false;
        CurrentHp = maxHp;
    }

    public override string ToString()
    {
        return Name;
    }
    
    public void Attack(IDefender target)
    {
        target.TakeDamage(AttackPower);
        Console.WriteLine($"{Name}(이/가) {ToString()}에게 {AttackPower} 대미지! ({target} HP : {target.CurrentHp}/{target.MaxHp}");
    }

    public void TakeDamage(int damage)
    {
        CurrentHp = CurrentHp - damage;
        if (CurrentHp <= 0)
        {
            IsDead = true;
            Console.WriteLine($"{Name}(이/가) 쓰러졌습니다!");
        }
    }
}