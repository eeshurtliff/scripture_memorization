using System;

class Scripture {
    private string _khReferenceInstance;
    string _khScripture;
    List<string> khVerseList;

    List<Word> ListOfWordClass;


    public Scripture(string khReference, string khScripture) {
        _khReferenceInstance = khReference;
        _khScripture = khScripture;
        CreateWordInstance();
        

    }
    private void CreateWordInstance(){
        foreach (string e in khVerseList){
            Word word1 = new Word(e);
            ListOfWordClass.Add(word1);
        }
    }

    public List<Word> GetListWord(){
        return ListOfWordClass;
    }
    private void khVerseToList(string khGivenVerse) {
        List<string> khVerseList1 = khGivenVerse.Split(" ").ToList();
        khVerseList = khVerseList1;

    }

    public List<string> GetVerseList(){
        return khVerseList;
    }

    // public string khScriptureToString(string khReference, List<string> khVerse) {

    // }

    public override string ToString()
    {
        //format print
        return $"{_khReferenceInstance} - {string.Join(" ", khVerseList)}";
    }


    

}