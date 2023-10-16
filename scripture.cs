using System;

class Scripture {
    private Reference _khreferenceinstance = new Reference();

    public List<string> khVerse(string khGivenVerse) {
        List<string> khVerseList = khGivenVerse.Split(" ").ToList();
        return khVerseList;
    }

    public void khScriptureToString(string khReference, List<string> khVerse) {

    }

}