using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGame : MonoBehaviour
{
    public void CarregarJogo(){
        if(GameManager.GAMESTATE == "Hard"){
              UnityEngine.SceneManagement.SceneManager.LoadScene("Scenes/JogoHard");
        }else{
            UnityEngine.SceneManagement.SceneManager.LoadScene("Scenes/Jogo");
        }
    }
    public void CarregarJogoDificil(){
         GameManager.GAMESTATE = "Hard";
         UnityEngine.SceneManagement.SceneManager.LoadScene("Scenes/JogoHard");
         
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
