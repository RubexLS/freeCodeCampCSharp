int healthMonster = 10;
int healthHero = 10;

Random hit = new Random();
int i = 0;

do
{
	i++;
	int damage = hit.Next(1, 10);
	if(i % 2 != 0)
	{
		healthMonster -= damage;
		if(healthMonster >= 0)
			Console.WriteLine($"Monster was damaged and lost {damage} health and now has {healthMonster} health.");
		else
			Console.WriteLine($"Monster was damaged and lost {damage} health and now has 0 health.");
	}
	else
	{
		healthHero -= damage;
		if(healthHero >= 0)
			Console.WriteLine($"Hero was damaged and lost {damage} health and now has {healthHero} health.");
		else
			Console.WriteLine($"Hero was damaged and lost {damage} health and now has 0 health.");
	}
}while(healthMonster > 0 && healthHero > 0);

if(healthMonster < 1)
	Console.WriteLine("Hero wins!");

else if(healthHero < 1)
	Console.WriteLine("Monster wins!");

// Alternative solution --------------------------------------------------------------------------

/*
int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");
*/