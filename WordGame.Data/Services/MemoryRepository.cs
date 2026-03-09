using WordGame.Data.Models;

namespace WordGame.Data.Services;

public class MemoryRepository : IRepository
{
    private List<Word> _words = new List<Word>();

    public bool Add(Word word)
    {
        _words.Add(word);
        return true;
    }

    public List<Word> All()
    {
        return _words;
    }
}
