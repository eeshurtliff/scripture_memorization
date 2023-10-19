using System;

class Memorizer {
    int _eesNumToHide;
    List<int> _eesHiddenIndexes = new List<int>();
    Scripture eesScripture = new Scripture(string eesReference, string eesVerse );
    public Memorizer(){
        _eesNumToHide = 2;
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

    public override string ToString(){
        foreach (word in Scripture.ToString()){
            Console.Write(Word.ToString());
        }
    }
    
}



// Research:
// https://learn.microsoft.com/en-us/dotnet/api/system.random?view=net-7.0
// stackoverflow.com/questions/1698308/finding-the-maximum-length-of-lists-in-c-sharp