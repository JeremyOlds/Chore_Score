
namespace Chore_Score.Repositories;

public class ChoresRepository
    {
    private List<Chore> dbChores;

    public ChoresRepository()
    {
        dbChores = new List<Chore>();
        dbChores.Add(new Chore("Dishes", false, 1.5, "Kitchen"));
        dbChores.Add(new Chore("Rake Leaves", false, 3, "Outdoor"));
        dbChores.Add(new Chore("Feed Animals", false, 1, "OutDoor"));
        dbChores.Add(new Chore("Laundry", false, 1.5, "Laundry Room"));
        dbChores.Add(new Chore("Dusting", false, 1.5, "Indoor"));
    }

    internal List<Chore> GetChores()
    {
        return dbChores;
    }
}
