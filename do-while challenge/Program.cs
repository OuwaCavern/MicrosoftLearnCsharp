int heroHealth = 100;
int monsterHealth = 100;

Random attackvalue = new Random();

do
{   

    heroHealth  = heroHealth - attackvalue.Next(1,25);
    monsterHealth = monsterHealth  - attackvalue.Next(1,25);
    Console.WriteLine($"Hero: {heroHealth}\nMonster: {monsterHealth} ");
} while (heroHealth > 0 && monsterHealth > 0);

if (heroHealth > monsterHealth)
{
    Console.WriteLine($"Hero won with {heroHealth} health remaining!");
}
else if (heroHealth < monsterHealth)
{
    Console.WriteLine($"Monster won with {monsterHealth} health remaining!");
}