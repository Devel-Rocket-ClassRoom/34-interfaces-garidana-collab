using System;

// README.md를 읽고 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");

Character player = new Character();
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
}