using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TestArrays
{
 interface ISpellChecker
{
    ArrayList CheckSpelling (string word);
 
 }

class EnglishSpellChecker: ISpellChecker
{

    public ArrayList CheckSpelling(string word)
    {
        ArrayList possibleWords=new ArrayList();
        if (word=="Instituion")
        {
        possibleWords.Add("School");
        possibleWords.Add("college");
        possibleWords.Add("acadmy");


        } return possibleWords;

    }
}
class HindiSpellChecker: ISpellChecker
{

    public ArrayList CheckSpelling(string word)
    {
        ArrayList possibleWords = new ArrayList();
        if (word == "Instituion")
        {
            possibleWords.Add("PathShala");
            possibleWords.Add("Mahavidhylay");
            possibleWords.Add("Shikshan Sanstha");
        } return possibleWords;
    }
}

    class Program
    {
        static void Main(string[] args)
        {
            //ISpellChecker checker = new EnglishSpellChecker();
            ISpellChecker checker = new HindiSpellChecker();
            //
            ///
            ///
           //

            ArrayList words = checker.CheckSpelling("school");


        }
    } 
}
 
 