using System;
using System.Collections.Generic;
using System.Text;

interface IBattery
{
    string GetName();
}

class GoodBattery : IBattery
{
    public string GetName()  // IBattery안에 string 으로 메서드 시그니처를 선언했기 때문에 string 형으로 메서드 구현 해야함
    {
        return "고급 배터리";
    }
}

class NormalBattery : IBattery
{
    public string GetName()
    {
        return "일반 배터리";
    }
}

class Carr
{
    private IBattery _battery;

    public Carr(IBattery battery)
    {
        _battery = battery;
    }

    public void Run()
    {
        Console.WriteLine($"{_battery.GetName()}를 장착한 자동차가 달립니다.");
        // _battery.GatName을 해줘야 배터리 이름을 출력함
    }
}