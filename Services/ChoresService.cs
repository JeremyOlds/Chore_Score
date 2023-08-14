

namespace Chore_Score.Services;
public class ChoresService
    {
    private readonly ChoresRepository _choresRepository;

    public ChoresService(ChoresRepository choresRepository)
    {
        _choresRepository = choresRepository;
    }

    internal Chore CreateChore(Chore choreData)
    {
        Chore chore = _choresRepository.CreateChore(choreData);
        return chore;
    }

    internal Chore EditChore(string choreName, Chore choreData)
    {
        Chore choreToBeEdited = GetChoreByName(choreName);
        Chore editedChore = _choresRepository.EditChore(choreToBeEdited, choreData);
        return editedChore;
    }

    internal Chore GetChoreByName(string choreName)
    {
        Chore chore = _choresRepository.GetChoreByName(choreName);
        if(chore == null)
        {
            throw new Exception($"No Chore with the name of {choreName}");
        }
        return chore;
    }

    internal List<Chore> GetChores()
    {
        List<Chore> chores = _choresRepository.GetChores();
        return chores;
    }

    internal Chore RemoveChore(string choreName)
    {
        Chore choreToRemove = GetChoreByName(choreName);
        Chore chore = _choresRepository.RemoveChore(choreToRemove);
        return chore;
    }
}
