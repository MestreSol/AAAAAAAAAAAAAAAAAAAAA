using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]
public class TileStyle{
    public int numero;
    public string Nome;

    public string Simbolo;
    public Color32 Background;
    public bool Radioativo;
}
public class TileStyleHolder : MonoBehaviour
{


    public static TileStyleHolder Instance;

    public TileStyle[] TileStyle;
    void Awake(){
        Instance = this;
    }
}
