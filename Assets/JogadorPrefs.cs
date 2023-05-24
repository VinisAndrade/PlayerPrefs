using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JogadorPrefs : MonoBehaviour
{


    float volume;
    string resolucao;
    int score;

    public Text texto;

    // Start is called before the first frame update
    void Start()
    {
        //SavePrefs();
        LoadPrefs();
        
    }

    
    //Método para Salvar
    private void SavePrefs(){
        PlayerPrefs.SetFloat("Volume", 0.5f);
        PlayerPrefs.SetString("Resolucao", "1280");
        PlayerPrefs.SetInt("Score", 10);
    }
    

    //Método para Carregar
    private void LoadPrefs(){
      volume = PlayerPrefs.GetFloat("Volume");
      resolucao = PlayerPrefs.GetString("Resolucao");
      score = PlayerPrefs.GetInt("Score");

      texto.text = "Volume: " + volume + "\n" +
                    "Resolução: " + resolucao + "\n" + 
                    "Score: " + score + ".";
    }
}
