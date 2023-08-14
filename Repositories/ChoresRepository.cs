
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

    internal Chore CreateChore(Chore choreData)
    {
        dbChores.Add(choreData);
        return choreData;
    }

    internal Chore EditChore(Chore choreToBeEdited, Chore choreData)
    {
        if(choreData.Name == null || choreData.Name == "")
        {
        choreToBeEdited.Name = choreToBeEdited.Name;
        } else
        {
        choreToBeEdited.Name = choreData.Name;
        }
        if(choreData.IsDone == null)
        {
            choreToBeEdited.IsDone = choreToBeEdited.IsDone;
        } else
        {
        choreToBeEdited.IsDone = choreData.IsDone;
        }
        if(choreData.WorkTime == 0)
        {
            choreToBeEdited.WorkTime = choreToBeEdited.WorkTime;
        } else
        {
        choreToBeEdited.WorkTime = choreData.WorkTime;
        }
        if(choreData.Type == null)
        {
            choreToBeEdited.Type = choreToBeEdited.Type;
        } else
        {
        choreToBeEdited.Type = choreData.Type;
        }
        return choreToBeEdited;
    }

    internal Chore GetChoreByName(string choreName)
    {
        Chore chore = dbChores.Find(c => c.Name.ToLower() == choreName.ToLower());
        return chore;
    }

    internal List<Chore> GetChores()
    {
        return dbChores;
    }

    internal Chore RemoveChore(Chore chore)
    {
        
        dbChores.Remove(chore);
        return chore;
    }
}
