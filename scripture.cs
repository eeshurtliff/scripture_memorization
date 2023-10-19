using System;

class Scripture {
    private Reference _khreferenceinstance = new Reference();

    private List<string> khVerse(string khGivenVerse) {
        List<string> khVerseList = khGivenVerse.Split(" ").ToList();
        return khVerseList;
    }

    public string khScriptureToString(string khReference, List<string> khVerse) {

    }

    private string _khReferenceInstance;
    private string _khScripture;
    private void Scripture(string khScripture, string khReference) {
        _khReferenceInstance = khReference;
        _khScripture = khScripture;
    }

}