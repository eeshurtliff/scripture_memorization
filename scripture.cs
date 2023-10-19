using System;

class Scripture {
    private Reference _khreferenceinstance = new Reference();
    List<string> khVerseList;
    private void khVerseToList(string khGivenVerse) {
        List<string> khVerseList1 = khGivenVerse.Split(" ").ToList();
        khVerseList = khVerseList1;
    }

    // public string khScriptureToString(string khReference, List<string> khVerse) {

    // }

    public override string ToString()
    {
        //format print
        return $"{_khreferenceinstance} - {string.Join(" ", khVerseList)}";
    }


    private string _khReferenceInstance;
    private string _khScripture;
    public Scripture(string khReference, string khScripture) {
        _khReferenceInstance = khReference;
        _khScripture = khScripture;
    }

}