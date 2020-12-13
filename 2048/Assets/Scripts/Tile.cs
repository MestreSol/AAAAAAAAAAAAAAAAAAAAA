using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class Tile : MonoBehaviour
{
    public int indCol;
    public int indLin;
    public bool margedThisTurn = false;
    public int Numero{
        get{
            return numero;
        }
        set{
            numero = value;
            if(numero==0){
                setEmpty();
            }else{
                ApplyStyle(numero);
                setVisible();
            }
        }
    }
    private int numero;
    public Text NumeroDoElemento;
    public Text NomeDoElemento;
    public Text Simbolo;
    public GameObject ti;
    private Image Backgroundi;

    void Awake(){
        Backgroundi = transform.Find("Panel").GetComponent<Image>();
    }
    void ApplyStyleFromHolder(int index){
        NumeroDoElemento.text = TileStyleHolder.Instance.TileStyle [index].numero.ToString();
        NomeDoElemento.text = TileStyleHolder.Instance.TileStyle [index].Nome.ToString();
        Simbolo.text = TileStyleHolder.Instance.TileStyle [index].Simbolo;
        Backgroundi.color = TileStyleHolder.Instance.TileStyle [index].Background;
    }
    void ApplyStyle(int num){
        num -= 1;
        if(num > 118){

        }else if(num < 0){

        }else{
        ApplyStyleFromHolder(num);
        }
    }
    public void setVisible(){
       NumeroDoElemento.enabled = true;
       NomeDoElemento.enabled = true;
       Simbolo.enabled = true;
       Backgroundi.enabled = true;
      // ti.SetActive(true);
    }
     public void setEmpty(){
       //ti.SetActive(false);
       NumeroDoElemento.enabled = false;
       NomeDoElemento.enabled = false;
       Simbolo.enabled = false;
       Backgroundi.color = TileStyleHolder.Instance.TileStyle [118].Background;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MostraMaisSobreOElemento(Text numeroAtomico){
      
        int num = 0;
        string numstg = numeroAtomico.text;
        num = int.Parse(numstg);
        
    }
}
