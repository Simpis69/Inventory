using ConsoleApp1;

public class Character
{

    public int Hp;

    public string Name;

    public Inventory backpack;


    public Character()
    {
        backpack = new();

        Weapon w = new() {Name = "axe", weight = 10f};
        Consumables p = new() { Name = "Health potion", weight = 2f};

        backpack.Items.Add(w);
        backpack.Items.Add(p);

        Hp = 100;
        Name = "";
    }
}
