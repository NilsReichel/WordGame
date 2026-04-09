using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WordGame.Data.Models;

namespace WordGame.Data.Services;

public class XMLRepository : IRepository
{
    private XElement _rootElement;
    private string _fileName = "words.xml";

    public XMLRepository()
    {
        if (File.Exists(_fileName))
        {
            _rootElement = XElement.Load(_fileName);
        }
        else
        {
            _rootElement = new XElement("words");
        }
    }

    public bool Add(Word word)
    {
        var node = new XElement("word");

        var valueAttribute = new XAttribute("value", word.value);
        node.Add(valueAttribute);

        _rootElement.Add(node);
        _rootElement.Save(_fileName);
        return true;
    }

    public List<Word> All()
    {
        List<Word> result = new List<Word>();

        var allWords = from item in _rootElement.Descendants("word")
                       select new Word() { value = item?.Attribute("value")?.Value ?? "" };

        foreach (var word in allWords)
        {
            result.Add(word);
        }

        return result;
    }
}
