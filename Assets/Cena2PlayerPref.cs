using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cena2PlayerPref : MonoBehaviour
{
    float v;
    string r;
    int s;

    public Text textoCena2;
    // Start is called before the first frame update
    void Start()
    {
        
        //PlayerPrefs.DeleteAll();
        CarregaPrefs();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CarregaPrefs(){
        v = PlayerPrefs.GetFloat("Volume");
        r = PlayerPrefs.GetString("Resolucao");
        s = PlayerPrefs.GetInt("Score");

         textoCena2.text = "Volume: " + v + "\n" +
                    "Resolução: " + r + "\n" + 
                    "Score: " + s + ".";
    }
}
