using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordGame.Data.Models;


namespace WordGame.Data;

public interface IRepository
{
    //schreiben
    bool Add(Word word);

    //lesen
    List<Word> All();
}
