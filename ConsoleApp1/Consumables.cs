public class Consumables : Item
{
    public int UsesMax = 3;
    public int UsesCurrent = 3;

    public void use(Character target)
    {
        if(UsesCurrent > 0)
        {
            target.Hp += 10;
            UsesCurrent--;
        }
    }

}
