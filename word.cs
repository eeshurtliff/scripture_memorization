using System;
using System.Diagnostics.Contracts;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Security.Authentication.ExtendedProtection;

class Word {
    private string _JTPgivenWord;

    private bool _isDisplayable;
    //private bool wordbool = JTPSet_isDisplayable(JTPgivenWord);
    
    public Word(string word){
        _JTPgivenWord = word;
    }

    public void Set_isDisplayable(bool chosenBoolean){
        _isDisplayable = chosenBoolean;
    }
    
    public void JTPSet_isDisplayable(wordname){
        if (JTPgivenWord==" ___ "){
            bool boolword= true;
        }
        else {
            bool boolword = false;
        };
        return boolword;
    }
    public ChangeWord(wordname, wordbool){
        if (wordbool==false){
            wordname=" ___ ";
        }
        return wordname
    }

}