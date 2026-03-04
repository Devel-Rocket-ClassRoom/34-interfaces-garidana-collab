using System;
using static System.Console;
// README.md를 읽고 코드를 작성하세요.




// 1-1
Car car = new();
car.Go();

WriteLine();

// 1-2
IRepository repository = new Repository();
repository.Get();

WriteLine();

// 1-3
IPerson person = new Person();
person.Work();
person.Rest();

WriteLine();

// 2
Carr car1 = new Carr(new GoodBattery());
car1.Run();
Carr car2 = new Carr(new NormalBattery());

car2.Run();

WriteLine();

// 3-1
Dog dog = new();
dog.Eat();
dog.Bark();

WriteLine();

// 3-2
Bird bird = new();
bird.Breathe();
bird.Fly();

Console.WriteLine();

// 4-1
Pet pet = new();
((IDog)pet).Eat();  // 인터페이스 타입으로 명시적 캐스팅 후 호출
((ICat)pet).Eat();
IDog dog1 = new Pet();  // 인터페이스 타입 변수 사용
dog1.Eat();
ICat cat1 = new Pet();
cat1.Eat();

WriteLine();

// 4-2
Example example = new();
// example.Dowork();  // 직접 호출 불가띠
IExample iexample = example;
iexample.DoWork();

Console.WriteLine();

// 5
TextEditor te = new();
te.Undo();
te.Redo();

WriteLine();

// 6
Carrr car3 = new Carrr();
car3.Run();
car3.Left();
car3.Back();

WriteLine();

// 7-1
Player p1 = new();
Enemy e1 = new();
Building b1 = new();

void Attack(IDamageable target, int damage)
{
    target.TakeDamage(damage);
}

Attack(p1, 20);
Attack(e1, 30);
Attack(b1, 100);

WriteLine();

// 7-2
Hero hero = new();
hero.Move();
hero.Attack();

Turret turret = new();
turret.Attack();