using System;
using System.Xml.Linq;

// README.md를 읽고 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");

Character player = new Character("용사", 100, 20);
Monster goblin = new Monster("고블린", 50, 10);
Monster slime = new Monster("슬라임", 30, 5);




Console.WriteLine("=== 전투 시작 ===");
Console.WriteLine();
ProcessBattle(player, slime);
ProcessBattle(slime, player);
ProcessBattle(player, slime);
Console.WriteLine();
Console.WriteLine("=== 고블린 등장 ===");
Console.WriteLine();
ProcessBattle(player, goblin);
ProcessBattle(goblin, player);
ProcessBattle(player, goblin);
ProcessBattle(player, goblin);


void ProcessBattle (IAttacker attacker, IDefender defender)
{
    attacker.Attack(defender);
    if (defender.CurrentHp <= 0)
    {
        defender.IsDead = true;
        Console.WriteLine($"{defender.ToString()}(이/가) 쓰러졌습니다!");
    }
}