public class Inventory
{

   public List<Item> Items = [];

    void display()
    {
        for (int i = 0; i < Items.Count; i++)
        {
            Console.WriteLine($"{i+1}) {Items[i].Name}");
        }
    }

}
