using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;


public class GameBehaviour : MonoBehaviour
{
    [SerializeField] GameObject[] hangMan;
    string[] Words = File.ReadAllLines("Assets/Words to Find.txt");  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S)){
            hangMan[1].SetActive(true);
        }
    }
}
