using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;


public class GameBehaviour : MonoBehaviour
{
    string ChosenWord;
    [SerializeField] GameObject[] hangMan;
    string[] Words = File.ReadAllLines("Assets/Words to Find.txt");
    [SerializeField] Text DesiredWordText;
    [SerializeField] Text LettersUsed;

    string hiddenword;
    int fails = 0;
    // Start is called before the first frame update
    void Start()
    {
        hiddenword = "";
        ChosenWord = Words[UnityEngine.Random.Range(0, Words.Length)];
        for(int i = 0; i < ChosenWord.Length; i++)
        {
            if (char.IsWhiteSpace(ChosenWord[i]))
            {
               hiddenword += " ";
            }else
            {
             hiddenword += "_";
            }
            
        }
        Debug.Log(ChosenWord);
        DesiredWordText.text = hiddenword;
       
    }
   
    
     void OnGUI()
    {
        Event e = Event.current;
        if (e.type == EventType.KeyDown && e.keyCode.ToString().Length == 1)
        {
            string Letter = e.keyCode.ToString();
            if (!LettersUsed.text.Contains(Letter))
            {
                LettersUsed.text = LettersUsed.text + Letter + ", ";
            }
            
            if (ChosenWord.Contains(Letter))
            {
                Debug.Log("Letter used: " + Letter);
                int i = ChosenWord.IndexOf(Letter);
                while (i != -1)
                {
                    hiddenword = hiddenword.Substring(0, i) + Letter + hiddenword.Substring(i +1);
                    ChosenWord = ChosenWord.Substring(0,i) + "_" + ChosenWord.Substring(i+1);
                    Debug.Log(hiddenword);
                    i = ChosenWord.IndexOf(Letter);
                }
                DesiredWordText.text = hiddenword;
            }
            else
            {
                
                hangMan[fails].SetActive(true);
                fails++;

            }
            if (fails == hangMan.Length)
            {

            }
        }
    }

}
