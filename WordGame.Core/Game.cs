using System.Runtime.CompilerServices;
namespace WordGame.Core;

/// <summary>
/// Represents a word chain game where each new word must start with the last letter of the previous word.
/// </summary>

public class Game
{
    public Game(bool allowDupplicates = false)
    {
        this._doubleWordsAllowed = allowDupplicates;
    }

    private bool _doubleWordsAllowed = false;

    public void AllowDoubleWords(bool a)
    {
       this._doubleWordsAllowed = a;
    }

    private List<string> _words = new();

    private List<string> _notAllowedWords = ["dummkopf", "doof"];

    public void SetWords(List<string> words)
    {
        this._words = words;
    }

    /// <summary>
    /// Gets the current chain of words as a comma-separated string.
    /// </summary>
    public string Get
    {
        get
        {
            return String.Join(", ", _words);
        }
    }

    /// <summary>
    /// Attempts to add a new word to the chain.
    /// </summary>
    /// <param name="word"></param>
    /// <returns></returns>
    public bool Add(string word)
    {
        if (_notAllowedWords.Contains(word.ToLower()))
        {
            throw new WordNotAllowedException($"Das Wort '{word}' ist in diesem Spiel nicht erlaubt.");
        }
        // first word is start word
        if (_words.Count == 0)
        {
            _words.Add(word);
            return true;
        }
        else
        {
            // check if word starts with last letter of previous word
            string lastWord = _words[^1];

            string lastLetter = lastWord.Substring(lastWord.Length -1);

            lastLetter = lastLetter.ToLower();

            string firstLetter = word.Substring(0, 1).ToLower();

            if (lastLetter == firstLetter)
            {
                if (_doubleWordsAllowed)
                {
                    _words.Add(word);
                    return true;
                }
                else if (_words.Contains(word))
                {
                    return false;
                }
                else
                {
                    _words.Add(word);
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }
}