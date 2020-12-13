using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elemento{
    public string nome = "N.A.";
    public string nomeLatin = "N.A.";
    public string simbolo = "N.A.";
    public int numero = 0;
    public int anoDescoberta = 0;
    public string CAS = "N.A.";
    public string descobridor = "N.A.";
    public string valor = "N.A.";
    public int k = 0;
    public int l = 0;
    public int m = 0;
    public int n = 0;
    public int o = 0;
    public int p = 0;
    public int q = 0;
    public int e = 0;
    public int eletrons = 0;
    public int protons = 0;
    public int neutrons = 0;
    public string pesoAtomico = "N.A.";
    public string fusao = "N.A.";
    public string ebulicao = "N.A.";
    public string fase = "N.A.";
    public string valencia = "N.A.";
    public string periodo = "N.A.";
    public string grupo = "N.A.";
    public string quadra = "N.A.";
    public string configuracao = "N.A.";
    public string carga = "N.A.";
    public string potenciaIoni = "N.A.";
    public string raioAtomico = "N.A.";
    public string raioCovalente = "N.A.";
    public string raioWaals = "N.A.";
    public string eletronegatividade = "N.A.";
    public string camadadevalencia = "N.A.";
    public string afinidade = "N.A.";
    public string condutividade = "N.A.";
    public string tipoEletronico = "N.A.";
    public string sensibilidade = "N.A.";
    public string resistividade = "N.A.";
    public string pontoDeSuper = "N.A.";
    public string info = "N.A.";
    public string Densidade = "N.A.";
    public string tipoMagnetico = "N.A";
    public elemento(){ }
}
public class Lib : MonoBehaviour
{
 
    public  void Hidrogenio(){
        elemento elemento = new elemento();
        elemento.nome = "Hidrogenio";
        elemento.nomeLatin = "Hydrogenium";
        elemento.anoDescoberta = 1766;
        elemento.CAS = "CAS1333-74-0";
        elemento.descobridor = "Henry Cavendish";
        elemento.valor = "65,14";
        elemento.k = 1;
        elemento.l = 0;
        elemento.m = 0;
        elemento.n = 0;
        elemento.o = 0;
        elemento.p = 0;
        elemento.q = 0;
        elemento.e = 0;
        elemento.eletrons = 1;
        elemento.protons = 1;
        elemento.numero = 1;
        elemento.pesoAtomico = "1.00784";
        elemento.fusao = "-259.14";
        elemento.ebulicao = "-252.87";
        elemento.fase = "Gasoso";
        elemento.valencia = "I";
        elemento.periodo ="1";
        elemento.grupo = "IA";
        elemento.quadra = "s-quadra";
        elemento.carga = "H+,H-";
        elemento.potenciaIoni = "13.53";
        elemento.raioAtomico = "53";
        elemento.raioCovalente = "38";
        elemento.raioWaals = "120";
        elemento.eletronegatividade = "2.2";
        elemento.afinidade = "72.8";
        elemento.condutividade = "N.A.";
        elemento.tipoEletronico = "N.A.";
        elemento.tipoMagnetico = "Diamagnetico";
        elemento.sensibilidade = "-2.23*10^-9";
        elemento.resistividade = "N.A.";
        elemento.pontoDeSuper = "N.A.";
        elemento.info = "O hidrogênio é um gas sem cor, sabor e odor e é encontrado em 75% do universo,";

    }
}
