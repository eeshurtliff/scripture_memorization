using System;

class Memorizer {
    int _eesNumToHide;
    List<int> _eesHiddenIndexes = new List<int>();
    // Scripture eesScripture = new Scripture(new Reference(eesReference), string eesVerse );
    public Memorizer(){
        _eesNumToHide = 2;
    }

    // public Memorizer(int numToHide){
        // _eesNumToHide = numToHide;
    // }
    private Scripture LhScripture;

    public Memorizer(string lhReference, string lhVerses, int ChooseHiddenNumber)
    {
        //creates a new instance of sripture verse to be used by memorizer
        

        LhScripture = new Scripture(lhReference, lhVerses);
        _eesNumToHide = ChooseHiddenNumber;
        // LhHiddenWordIndex = new List<int>();
    }


    public void EesUpdateVerse(){
        Random eesRandom = new Random();
        List<string> eesVerse = Scripture.GetVerse();
        for (int i = 0; i < _eesNumToHide + 1; i++){
            int eesHideIndex = eesRandom.Next(eesVerse.Count);
            Word.SetIsDisplayable(false);
            _eesHiddenIndexes.Add(eesHideIndex);
        }
    }

    public override string ToString(){
        return LhScripture;
    }

    public bool IsDone()
    {
        return LhHiddenWordIndex.Count == LhScripture.GetWords().Count;
    }
    
}



// Research:
// https://learn.microsoft.com/en-us/dotnet/api/system.random?view=net-7.0
// stackoverflow.com/questions/1698308/finding-the-maximum-length-of-lists-in-c-sharp