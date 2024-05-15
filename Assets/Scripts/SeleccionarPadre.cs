using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeleccionarPadre : MonoBehaviour
{
    private AudioSource sonidoDeInvocacion;

    private GameObject myPadreSiege;
    private GameObject myPadreRange;
    private GameObject myPadreMelee;
    private GameObject myPadreSiegeAum;
    private GameObject myPadreRangeAum;
    private GameObject myPadreMeleeAum;
    private GameObject enemyPadreSiege;
    private GameObject enemyPadreRange;
    private GameObject enemyPadreMelee;
    private GameObject enemyPadreSiegeAum;
    private GameObject enemyPadreRangeAum;
    private GameObject enemyPadreMeleeAum;
    private GameObject cartaAInvocar;
    private GameObject carta;
    private GameObject botonSiege;
    private GameObject botonRange;
    private GameObject botonMelee;
    void Start()
    {
        sonidoDeInvocacion = GameObject.FindWithTag("GameManager").GetComponent<AudioSource>();
        myPadreSiege = GameObject.FindWithTag("MySiege");
        myPadreRange = GameObject.FindWithTag("MyRange");
        myPadreMelee = GameObject.FindWithTag("MyMelee");
        myPadreSiegeAum = GameObject.FindWithTag("MySiegeAumento");
        myPadreRangeAum = GameObject.FindWithTag("MyRangeAumento");
        myPadreMeleeAum = GameObject.FindWithTag("MyMeleeAumento");
        enemyPadreSiege = GameObject.FindWithTag("EnemySiege");
        enemyPadreRange = GameObject.FindWithTag("EnemyRange");
        enemyPadreMelee = GameObject.FindWithTag("EnemyMelee");
        enemyPadreSiegeAum = GameObject.FindWithTag("EnemySiegeAumento");
        enemyPadreRangeAum = GameObject.FindWithTag("EnemyRangeAumento");
        enemyPadreMeleeAum = GameObject.FindWithTag("EnemyMeleeAumento");
        cartaAInvocar = GameObject.FindWithTag("cartaAInvocar");
        carta = GameObject.FindWithTag("cartaAJugar");
        botonSiege = GameObject.FindWithTag("botonSiege");
        botonRange = GameObject.FindWithTag("botonRange");
        botonMelee = GameObject.FindWithTag("botonMelee");
    }
    public void OnClick()
    {

        if (carta.name == "CartaAgua(Clone)" || carta.name == "CartaClero(Clone)" || carta.name == "CartaRosario(Clone)")
        {
            if (gameObject.name == "botonMelee(Clone)" && (myPadreMeleeAum.transform.childCount == 0 || !myPadreMeleeAum.transform.GetChild(0).gameObject.activeSelf))
            {
                cartaAInvocar.transform.SetParent(myPadreMeleeAum.transform, false);
                cartaAInvocar.tag = "Untagged";
                Destroy(botonMelee);
                Destroy(botonRange);
                Destroy(botonSiege);
                if (carta.name == "CartaAgua(Clone)")
                {
                    for (int i = 0; i < myPadreMelee.transform.childCount; i++)
                    {
                        if(myPadreMelee.transform.GetChild(i).name != "CartaKratosImg")    
                            myPadreMelee.transform.GetChild(i).GetComponent<CartaUnidad>().Poder += 2;
                    }
                }
                else if (carta.name == "CartaClero(Clone)")
                {
                    for (int i = 0; i < myPadreMelee.transform.childCount; i++)
                    {
                        if(myPadreMelee.transform.GetChild(i).name != "CartaKratosImg")     
                            myPadreMelee.transform.GetChild(i).GetComponent<CartaUnidad>().Poder += 3;
                    }
                }
                else if(carta.name == "CartaRosario(Clone)" )
                {
                    for (int i = 0; i < myPadreMelee.transform.childCount; i++)
                    {
                        if(myPadreMelee.transform.GetChild(i).name != "CartaKratosImg")
                            myPadreMelee.transform.GetChild(i).GetComponent<CartaUnidad>().Poder = myPadreMelee.transform.GetChild(i).GetComponent<CartaUnidad>().Poder * 2;
                    }
                }
                carta.SetActive(false);
                sonidoDeInvocacion.Play();
            }
            else if (gameObject.name == "botonRange(Clone)" && (myPadreRangeAum.transform.childCount == 0 || !myPadreRangeAum.transform.GetChild(0).gameObject.activeSelf))
            {
                cartaAInvocar.transform.SetParent(myPadreRangeAum.transform, false);
                cartaAInvocar.tag = "Untagged";
                Destroy(botonMelee);
                Destroy(botonRange);
                Destroy(botonSiege);
                if (carta.name == "CartaAgua(Clone)")
                {
                    for (int i = 0; i < myPadreRange.transform.childCount; i++)
                    {
                        if(myPadreRange.transform.GetChild(i).name != "CartaKratosImg")
                            myPadreRange.transform.GetChild(i).GetComponent<CartaUnidad>().Poder += 2;
                    }
                }
                else if (carta.name == "CartaClero(Clone)")
                {
                    for (int i = 0; i < myPadreRange.transform.childCount; i++)
                    {
                        if(myPadreRange.transform.GetChild(i).name != "CartaKratosImg")
                            myPadreRange.transform.GetChild(i).GetComponent<CartaUnidad>().Poder += 3;
                    }
                }
                else if(carta.name == "CartaRosario(Clone)")
                {
                    for (int i = 0; i < myPadreRange.transform.childCount; i++)
                    {
                        if(myPadreRange.transform.GetChild(i).name != "CartaKratosImg")
                            myPadreRange.transform.GetChild(i).GetComponent<CartaUnidad>().Poder = myPadreRange.transform.GetChild(i).GetComponent<CartaUnidad>().Poder * 2;
                    }
                }
                carta.SetActive(false);
                sonidoDeInvocacion.Play();
            }
            else if (gameObject.name == "botonSiege(Clone)" && (myPadreSiegeAum.transform.childCount == 0 || !myPadreSiegeAum.transform.GetChild(0).gameObject.activeSelf))
            {
                cartaAInvocar.transform.SetParent(myPadreSiegeAum.transform, false);
                cartaAInvocar.tag = "Untagged";
                Destroy(botonMelee);
                Destroy(botonRange);
                Destroy(botonSiege);
                if (carta.name == "CartaAgua(Clone)")
                {
                    for (int i = 0; i < myPadreSiege.transform.childCount; i++)
                    {
                        if(myPadreSiege.transform.GetChild(i).name != "CartaKratosImg")
                            myPadreSiege.transform.GetChild(i).GetComponent<CartaUnidad>().Poder += 2;
                    }
                }
                else if (carta.name == "CartaClero(Clone)")
                {
                    for (int i = 0; i < myPadreSiege.transform.childCount; i++)
                    {
                        if(myPadreSiege.transform.GetChild(i).name != "CartaKratosImg")
                            myPadreSiege.transform.GetChild(i).GetComponent<CartaUnidad>().Poder += 3;
                    }
                }
                else if(carta.name == "CartaRosario(Clone)")
                {
                    for (int i = 0; i < myPadreSiege.transform.childCount; i++)
                    {
                        if(myPadreSiege.transform.GetChild(i).name != "CartaKratosImg")
                            myPadreSiege.transform.GetChild(i).GetComponent<CartaUnidad>().Poder = myPadreSiege.transform.GetChild(i).GetComponent<CartaUnidad>().Poder * 2;
                    }
                }
                carta.SetActive(false);
                sonidoDeInvocacion.Play();
            }
            else    
                Debug.LogError("No se pude jugar");
        }
        else if (carta.name == "CartaCruzado(Clone)" || carta.name == "CartaKratos(Clone)")
        {
            if (gameObject.name == "botonMelee(Clone)")
            {
                cartaAInvocar.transform.SetParent(myPadreMelee.transform, false);
                cartaAInvocar.tag = "Untagged";
                Destroy(botonMelee);
                Destroy(botonRange);
                Destroy(botonSiege);
                carta.SetActive(false);
                sonidoDeInvocacion.Play();
            }
            else if (gameObject.name == "botonRange(Clone)")
            {
                cartaAInvocar.transform.SetParent(myPadreRange.transform, false);
                cartaAInvocar.tag = "Untagged";
                Destroy(botonMelee);
                Destroy(botonRange);
                Destroy(botonSiege);
                carta.SetActive(false);
                sonidoDeInvocacion.Play();
            }
            else if (gameObject.name == "botonSiege(Clone)")
            {
                cartaAInvocar.transform.SetParent(myPadreSiege.transform, false);
                cartaAInvocar.tag = "Untagged";
                Destroy(botonMelee);
                Destroy(botonRange);
                Destroy(botonSiege);
                carta.SetActive(false);
                sonidoDeInvocacion.Play();
            }
        }
        else if(carta.name == "CartaCurso(Clone)" || carta.name == "CartaPizarra(Clone)" || carta.name == "CartaRedPill(Clone)")
        {
            if (gameObject.name == "botonMelee(Clone)" && (enemyPadreMeleeAum.transform.childCount == 0 || !enemyPadreMeleeAum.transform.GetChild(0).gameObject.activeSelf))
            {
                cartaAInvocar.transform.SetParent(enemyPadreMeleeAum.transform, false);
                cartaAInvocar.tag = "Untagged";
                Destroy(botonMelee);
                Destroy(botonRange);
                Destroy(botonSiege);
                if (carta.name == "CartaCurso(Clone)")
                {
                    for (int i = 0; i < enemyPadreMelee.transform.childCount; i++)
                    {
                        if(enemyPadreMelee.transform.GetChild(i).name != "CartaCuboRubikImg")
                            enemyPadreMelee.transform.GetChild(i).GetComponent<CartaUnidad>().Poder += 4;
                    }
                }
                else if (carta.name == "CartaPizarra(Clone)")
                {
                    for (int i = 0; i < enemyPadreMelee.transform.childCount; i++)
                    {
                        if(enemyPadreMelee.transform.GetChild(i).name != "CartaCuboRubikImg")
                            enemyPadreMelee.transform.GetChild(i).GetComponent<CartaUnidad>().Poder += 5;
                    }
                }
                else if(carta.name == "CartaRedPill(Clone)")
                {
                    for (int i = 0; i < enemyPadreMelee.transform.childCount; i++)
                    {
                        if(enemyPadreMelee.transform.GetChild(i).name != "CartaCuboRubikImg")
                            enemyPadreMelee.transform.GetChild(i).GetComponent<CartaUnidad>().Poder += 3;
                    }
                }
                carta.SetActive(false);
                sonidoDeInvocacion.Play();
            }
            else if (gameObject.name == "botonRange(Clone)" && (enemyPadreRangeAum.transform.childCount == 0 || !enemyPadreRangeAum.transform.GetChild(0).gameObject.activeSelf))
            {
                cartaAInvocar.transform.SetParent(enemyPadreRangeAum.transform, false);
                cartaAInvocar.tag = "Untagged";
                Destroy(botonMelee);
                Destroy(botonRange);
                Destroy(botonSiege);
                 if (carta.name == "CartaCurso(Clone)")
                {
                    for (int i = 0; i < enemyPadreRange.transform.childCount; i++)
                    {
                        if(enemyPadreRange.transform.GetChild(i).name != "CartaCuboRubikImg")
                            enemyPadreRange.transform.GetChild(i).GetComponent<CartaUnidad>().Poder += 4;
                    }
                }
                else if (carta.name == "CartaPizarra(Clone)")
                {
                    for (int i = 0; i < enemyPadreRange.transform.childCount; i++)
                    {
                        if(enemyPadreRange.transform.GetChild(i).name != "CartaCuboRubikImg")
                            enemyPadreRange.transform.GetChild(i).GetComponent<CartaUnidad>().Poder += 5;
                    }
                }
                else if(carta.name == "CartaRedPill(Clone)")
                {
                    for (int i = 0; i < enemyPadreRange.transform.childCount; i++)
                    {
                        if(enemyPadreRange.transform.GetChild(i).name != "CartaCuboRubikImg")
                            enemyPadreRange.transform.GetChild(i).GetComponent<CartaUnidad>().Poder += 3;
                    }
                }
                carta.SetActive(false);
                sonidoDeInvocacion.Play();
            }
            else if (gameObject.name == "botonSiege(Clone)" && (enemyPadreSiegeAum.transform.childCount == 0 || !enemyPadreSiegeAum.transform.GetChild(0).gameObject.activeSelf))
            {
                cartaAInvocar.transform.SetParent(enemyPadreSiegeAum.transform, false);
                cartaAInvocar.tag = "Untagged";
                Destroy(botonMelee);
                Destroy(botonRange);
                Destroy(botonSiege);
                 if (carta.name == "CartaCurso(Clone)")
                {
                    for (int i = 0; i < enemyPadreSiege.transform.childCount; i++)
                    {
                        if(enemyPadreSiege.transform.GetChild(i).name != "CartaCuboRubikImg")
                            enemyPadreSiege.transform.GetChild(i).GetComponent<CartaUnidad>().Poder += 4;
                    }
                }
                else if (carta.name == "CartaPizarra(Clone)")
                {
                    for (int i = 0; i < enemyPadreSiege.transform.childCount; i++)
                    {
                        if(enemyPadreSiege.transform.GetChild(i).name != "CartaCuboRubikImg")
                            enemyPadreSiege.transform.GetChild(i).GetComponent<CartaUnidad>().Poder += 5;
                    }
                }
                else if(carta.name == "CartaRedPill(Clone)")
                {
                    for (int i = 0; i < enemyPadreSiege.transform.childCount; i++)
                    {
                        if(enemyPadreSiege.transform.GetChild(i).name != "CartaCuboRubikImg")
                            enemyPadreSiege.transform.GetChild(i).GetComponent<CartaUnidad>().Poder += 3;
                    }
                }
                carta.SetActive(false);
                sonidoDeInvocacion.Play();
            }
            else    
                Debug.LogError("No se pude jugar");
        }
        else if (carta.name == "CartaStark(Clone)" || carta.name == "CartaCuboRubik(Clone)")
        {
            if (gameObject.name == "botonMelee(Clone)")
            {
                cartaAInvocar.transform.SetParent(enemyPadreMelee.transform, false);
                cartaAInvocar.tag = "Untagged";
                Destroy(botonMelee);
                Destroy(botonRange);
                Destroy(botonSiege);
                carta.SetActive(false);
                sonidoDeInvocacion.Play();
            }
            else if (gameObject.name == "botonRange(Clone)")
            {
                cartaAInvocar.transform.SetParent(enemyPadreRange.transform, false);
                cartaAInvocar.tag = "Untagged";
                Destroy(botonMelee);
                Destroy(botonRange);
                Destroy(botonSiege);
                carta.SetActive(false);
                sonidoDeInvocacion.Play();
            }
            else if (gameObject.name == "botonSiege(Clone)")
            {
                cartaAInvocar.transform.SetParent(enemyPadreSiege.transform, false);
                cartaAInvocar.tag = "Untagged";
                Destroy(botonMelee);
                Destroy(botonRange);
                Destroy(botonSiege);
                carta.SetActive(false);
                sonidoDeInvocacion.Play();
            }
        }
        
        
    }
    void Update()
    {
        if(Input.GetMouseButton(1))
        {
            carta.tag = "Untagged";
            cartaAInvocar.tag = "Untagged";
            Destroy(botonMelee);
            Destroy(botonRange);
            Destroy(botonSiege);
        }
    }

}