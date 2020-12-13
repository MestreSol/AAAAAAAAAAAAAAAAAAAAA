using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MoveDirection{
    Left, Right, Up, Down
}
public class Inputs : MonoBehaviour
{
    private GameManager gm;
    void Awake(){
        gm = GameObject.FindObjectOfType<GameManager>();

    }
    void Start()
    {
        
    }


    void Update()
    {
        if(GameManager.GAMESTATE == "Normal" || GameManager.GAMESTATE == "Hard"){
        if(Input.GetKeyDown (KeyCode.RightArrow)){
            gm.Move(MoveDirection.Right);
                Debug.Log("Right");
        }
        else if(Input.GetKeyDown (KeyCode.LeftArrow)){
            gm.Move(MoveDirection.Left);
            Debug.Log("Left");
        }
        else if(Input.GetKeyDown (KeyCode.UpArrow)){
            gm.Move(MoveDirection.Up);
            Debug.Log("Up");
        }
        else if(Input.GetKeyDown (KeyCode.DownArrow)){
            gm.Move(MoveDirection.Down);
            Debug.Log("Down");
        }
    }
    }
}
