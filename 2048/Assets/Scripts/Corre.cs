using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Corre : MonoBehaviour
{
    public Text pontosStg;
    public Text maxStg;
    public Text Nome;
    // Start is called before the first frame update
    void Start()
    {
        maxStg.text = "Record: "+GameManager.MaxEt;
    }

    // Update is called once per frame
    void Update()
    {
        pontosStg.text = "Pontos: "+GameManager.pontos;
        Nome.text = "Maior Elemento: "+TileStyleHolder.Instance.TileStyle [GameManager.MaxCom-1].Nome.ToString();
    }
}
