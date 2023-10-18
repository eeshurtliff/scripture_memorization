using System;

class Memorizer {
    int _eesNumToHide;
    List<int> _eesHiddenIndexes = new List<int>();
    Scripture eesScripture = new Scripture(string eesReference, string eesVerse );
    public Memorizer(){
        _eesNumToHide = 2;
    }
    // Constructor to initialize the memorizer with a scripture
    public Memorizer(string reference, string verses)
    {
        // Initialize the Scripture instance with the given reference and verses
        eesScripture = new Scripture(reference, verses);
        -eesHiddenWordIndex = new List<int>();
    }
    
    public Memorizer(int numToHide){
        _eesNumToHide = numToHide;
    }

    public void EesUpdateVerse(_eesNumToHide){
        Random eesRandom = new Random();
        List<string> eesVerse = Scripture.GetVerse();
        for (int i = 0; i < _eesNumToHide + 1; i++){
            int eesHideIndex = eesRandom.Next(eesVerse.Count);
            Word.Set_isDisplayable(false);
            _eesHiddenIndexes.Add(eesHideIndex);
        }
    }

    public void ToString(){
        foreach (word in Scripture.ToString()){
            Console.Write(Word.ToString());
        }
    }
    public bool IsDone()
    {
        //gets return value from Scripture to check if there are words left
        return _eesHiddenIndexes.Count == eesScripture.EesUpdateVerse().Count;
    }
}



// Research:
// https://learn.microsoft.com/en-us/dotnet/api/system.random?view=net-7.0
// stackoverflow.com/questions/1698308/finding-the-maximum-length-of-lists-in-c-sharp
