using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Tile[,] AllTiles = new Tile[5,5];
    private List<Tile[]> coluns = new List<Tile[]>();
    private List<Tile[]> rowns = new List<Tile[]>();
    private List<Tile> EmptyTiles = new List<Tile>();
    public int et = 0;
    public static int pontos;
    public static int MaxCom = 1;
    public static int MaxEt = 0;
    public static string GAMESTATE = "Normal";
    // Start is called before the first frame update
    void Start()
    {

        Tile[] AllTilesOnDim = GameObject.FindObjectsOfType<Tile>();
        
        foreach (Tile t in AllTilesOnDim)
        {
            t.Numero = 0;
            AllTiles[t.indLin,t.indCol] = t;
            
            EmptyTiles.Add(t);
            Debug.Log("TileFind");

            
            et++;
        }
        coluns.Add(new Tile[]{AllTiles[0,0],AllTiles[1,0],AllTiles[2,0],AllTiles[3,0],AllTiles[4,0]});
        coluns.Add(new Tile[]{AllTiles[0,1],AllTiles[1,1],AllTiles[2,1],AllTiles[3,1],AllTiles[4,1]});
        coluns.Add(new Tile[]{AllTiles[0,2],AllTiles[1,2],AllTiles[2,2],AllTiles[3,2],AllTiles[4,2]});
        coluns.Add(new Tile[]{AllTiles[0,3],AllTiles[1,3],AllTiles[2,3],AllTiles[3,3],AllTiles[4,3]});
        coluns.Add(new Tile[]{AllTiles[0,4],AllTiles[1,4],AllTiles[2,4],AllTiles[3,4],AllTiles[4,4]});
    
        rowns.Add(new Tile[]{AllTiles[0,0],AllTiles[0,1],AllTiles[0,2],AllTiles[0,3],AllTiles[0,4]});
        rowns.Add(new Tile[]{AllTiles[1,0],AllTiles[1,1],AllTiles[1,2],AllTiles[1,3],AllTiles[1,4]});
        rowns.Add(new Tile[]{AllTiles[2,0],AllTiles[2,1],AllTiles[2,2],AllTiles[2,3],AllTiles[2,4]});
        rowns.Add(new Tile[]{AllTiles[3,0],AllTiles[3,1],AllTiles[3,2],AllTiles[3,3],AllTiles[3,4]});
        rowns.Add(new Tile[]{AllTiles[4,0],AllTiles[4,1],AllTiles[4,2],AllTiles[4,3],AllTiles[4,4]});
        Generate();
    }

    bool MakeOneMoveDownIndex(Tile[] LineOfTiles){
        for(int i = 0; i < LineOfTiles.Length-1; i++){
            if(LineOfTiles[i].Numero == 0 && LineOfTiles[i+1].Numero != 0){
                LineOfTiles[i].Numero = LineOfTiles[i+1].Numero;
                LineOfTiles[i+1].Numero = 0;
               // LineOfTiles[i].setActive(false);
                return true;
            }
            if(LineOfTiles[i].Numero != 0 && LineOfTiles[i].Numero == LineOfTiles[i+1].Numero && LineOfTiles[i].margedThisTurn == false && LineOfTiles[i+1].margedThisTurn == false){
                pontos += LineOfTiles[i].Numero;
               
                LineOfTiles[i].Numero++;
                if(LineOfTiles[i].Numero > MaxCom){
                    MaxCom = LineOfTiles[i].Numero;
                   
                }
                LineOfTiles[i+1].Numero = 0;
                LineOfTiles[i].margedThisTurn = true;
                et++;
               // LineOfTiles[i].SetActive(false);
                return true;
            }
        }
        return false;
    }
    bool MakeOneMoveUpIndex(Tile[] LineOfTiles){
        for(int i = LineOfTiles.Length-1; i>0; i--){
            if(LineOfTiles[i].Numero == 0 && LineOfTiles[i-1].Numero != 0){
                LineOfTiles[i].Numero = LineOfTiles[i-1].Numero;
                LineOfTiles[i-1].Numero = 0;
                //LineOfTiles[i].SetActive(false);
                return true;
            }
             if(LineOfTiles[i].Numero != 0 && LineOfTiles[i].Numero == LineOfTiles[i-1].Numero && LineOfTiles[i].margedThisTurn == false && LineOfTiles[i-1].margedThisTurn == false){
                pontos += LineOfTiles[i].Numero;
                LineOfTiles[i].Numero++;
                LineOfTiles[i-1].Numero = 0;
          if(LineOfTiles[i].Numero > MaxCom){
                    MaxCom = LineOfTiles[i].Numero;
                   
                }
                LineOfTiles[i].margedThisTurn = true;
                et++;
                //LineOfTiles[i].SetActive(false);
                return true;
            }
        }
        return false;
    }
    public void ResetMergedFlags(){
        foreach(Tile t in AllTiles){
            t.margedThisTurn = false;
        }
    }
    void Generate(){
       

        if(et != 0){
            int RandomCol = Random.Range(0,5);
            int RandomRow = Random.Range(0,5);
            if(AllTiles[RandomCol,RandomRow].Numero == 0){
                et--;
                int RandomNum = Random.Range(0,10);
                if( RandomNum == 0){
                    AllTiles[RandomCol,RandomRow].Numero =MaxCom;
                }else{
                    AllTiles[RandomCol,RandomRow].Numero =1;
                }            
            }else{
               Generate();
            }
        }else{
            return;
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown (KeyCode.G)){
            Generate();
        }
    }
    public void Move(MoveDirection md){
        ResetMergedFlags();
        // Debug.Log(md.ToString()+"move.");
        for(int i = 0; i<rowns.Count;i++){
            switch (md)
            {
                case MoveDirection.Down:
                    while (MakeOneMoveUpIndex(coluns[i]))
                    {
                        
                    }
                    
                break;                
                case MoveDirection.Left:
                while (MakeOneMoveDownIndex(rowns[i]))
                    {
                        
                    }
                    break;
                case MoveDirection.Right:
                    while (MakeOneMoveUpIndex(rowns[i]))
                        {
                            
                        }
                break;
                case MoveDirection.Up:
                while (MakeOneMoveDownIndex(coluns[i]))
                    {
                        
                    }
                    break;
            }
            
            if(et == 0){
                if(pontos > MaxEt){
                    if(GAMESTATE == "Hard"){
                        MaxCom = 1;
                    }
                    MaxEt = pontos;
                    pontos = 0;
                }
                UnityEngine.SceneManagement.SceneManager.LoadScene("Scenes/GameOver");
                
            }

        } Generate();

    }
}
