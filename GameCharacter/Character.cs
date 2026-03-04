using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

class Character : IAttacker, IDefender
{
    public string Name = "용사";
    int MaxHp => 100;
    int IAttacker.AttackPower => 20;

    public int CurrentHp => MaxHp - ;

    int IDefender.MaxHp => MaxHp;

    bool IDefender.IsDead => throw new NotImplementedException();

    public void Attack(IDefender target)
    {
       
    }

    public void TakeDamage(int damage)
    {
        throw new NotImplementedException();
    }

    public bool IsDead = false;
    

    public int 
}

class Monster
{
    public string Name;
    public int MaxHealth; 
    public int AttackPower;
    public Monster(string name, int maxHp, int attackPower)
    {
        Name = name;
        MaxHealth = maxHp;
        AttackPower = attackPower;
    }
}