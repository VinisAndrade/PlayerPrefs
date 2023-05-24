using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrefsJogador : MonoBehaviour
{
    float volume;
    string resolucao;
    int score;

    public Text texto;

    void Start()
    {
        SavePrefs();
        LoadPrefs();
    }

    void Update()
    {
        
    }

    private void SavePrefs(){
        PlayerPrefs.SetFloat("Volume", 0.5f);
        PlayerPrefs.SetString("Resolucao", "1280");
        PlayerPrefs.SetInt("Score", 55);
    }

    private void LoadPrefs(){
        volume = PlayerPrefs.GetFloat("Volume");
        resolucao = PlayerPrefs.GetString("Resolucao");
        score = PlayerPrefs.GetInt("Score");

        texto.text = "Volume: " + volume + "\n" + 
                        "Resolução: " + resolucao + "\n" +
                        "Score: " + score + "\n";
    }

    //PlayerPrefs.DeleteAll();
}
