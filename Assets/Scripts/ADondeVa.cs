using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ADondeVa : MonoBehaviour
{
    public GameObject botonSiegePrefab;
    public GameObject botonRangePrefab;
    public GameObject botonMeleePrefab;
    public GameObject cartaImg;
    public GameObject carta;
    public Button Boton;
    public GameManager devolver;
    void Start()
    {
        devolver = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();    
    }
    
    public void OnClick()
    {
        carta.tag = "cartaAJugar";
        cartaImg.tag = "cartaAInvocar";
        GameObject GameBoard = GameObject.FindWithTag("GameBoard");
        if(carta.name == "CartaCruzado(Clone)" && (GameObject.FindWithTag("MyMelee").transform.childCount != 0 || GameObject.FindWithTag("MyRange").transform.childCount != 0 || GameObject.FindWithTag("MySiege").transform.childCount != 0))
        {
            devolver.devolver = true;
        }
        else if(carta.name == "CartaStark(Clone)" && (GameObject.FindWithTag("EnemyMelee").transform.childCount != 0 || GameObject.FindWithTag("EnemyRange").transform.childCount != 0 || GameObject.FindWithTag("EnemySiege").transform.childCount != 0))
        {
            devolver.devolver = true;
        }
        else
        {
            GameObject invocarEnSiege = Instantiate(botonSiegePrefab, new Vector3(0,-300,0), Quaternion.identity);
            GameObject invocarEnRange = Instantiate(botonRangePrefab, new Vector3(0,-210,0), Quaternion.identity);
            GameObject invocarEnMelee = Instantiate(botonMeleePrefab, new Vector3(0,-120,0), Quaternion.identity);

            invocarEnSiege.transform.SetParent(GameBoard.transform, false);
            invocarEnRange.transform.SetParent(GameBoard.transform, false);
            invocarEnMelee.transform.SetParent(GameBoard.transform, false);
        }
    }

}
