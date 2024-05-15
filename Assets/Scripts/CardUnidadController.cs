using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardUnidadController : MonoBehaviour
{
    public GameManager deck;
    public AudioSource sonidoDeInvocacion;
    public GameObject cartaImg;
    public GameObject carta;
    
    void Start()
    {
        deck = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
        sonidoDeInvocacion = GameObject.FindWithTag("GameManager").GetComponent<AudioSource>();
    }
    public void OnClick()
    {
        GameObject MySiege = GameObject.FindWithTag("MySiege");
        GameObject MyRange = GameObject.FindWithTag("MyRange");
        GameObject MyMelee = GameObject.FindWithTag("MyMelee");
        GameObject EnemySiege = GameObject.FindWithTag("EnemySiege");
        GameObject EnemyRange = GameObject.FindWithTag("EnemyRange");
        GameObject EnemyMelee = GameObject.FindWithTag("EnemyMelee");
        GameObject cartaInvocada;

        if (gameObject.name == "ButtonZeus")
        {
            cartaInvocada = Instantiate(cartaImg, new Vector3(0,0,0), Quaternion.identity);
            cartaInvocada.transform.SetParent(MySiege.transform, false);
            carta.SetActive(false);
            sonidoDeInvocacion.Play();
            // EFECTO
            GameObject MinPoder = cartaInvocada;
            if (EnemyMelee.transform.childCount != 0 || EnemyRange.transform.childCount != 0 || EnemySiege.transform.childCount != 0)
            {
                MinPoder.GetComponent<CartaUnidad>().Poder = 300;          
                for(int i = 0; i < EnemyMelee.transform.childCount; i++)
                {
                    if(EnemyMelee.transform.GetChild(i).gameObject.activeSelf == true && EnemyMelee.transform.GetChild(i).name != "CartaCuboRubikImg" && EnemyMelee.transform.GetChild(i).GetComponent<CartaUnidad>().Poder < MinPoder.GetComponent<CartaUnidad>().Poder)
                    {
                        MinPoder = EnemyMelee.transform.GetChild(i).gameObject;
                    }
                }
                for(int i = 0; i < EnemyRange.transform.childCount; i++)
                {
                    if(EnemyRange.transform.GetChild(i).gameObject.activeSelf == true && EnemyRange.transform.GetChild(i).name != "CartaCuboRubikImg" && EnemyRange.transform.GetChild(i).GetComponent<CartaUnidad>().Poder < MinPoder.GetComponent<CartaUnidad>().Poder)
                    {
                        MinPoder = EnemyRange.transform.GetChild(i).gameObject;
                    }
                }
                for(int i = 0; i < EnemySiege.transform.childCount; i++)
                {
                    if(EnemySiege.transform.GetChild(i).gameObject.activeSelf == true && EnemySiege.transform.GetChild(i).name != "CartaCuboRubikImg" && EnemySiege.transform.GetChild(i).GetComponent<CartaUnidad>().Poder < MinPoder.GetComponent<CartaUnidad>().Poder)
                    {
                        MinPoder = EnemySiege.transform.GetChild(i).gameObject;
                    }
                }
                if(MinPoder != cartaInvocada) MinPoder.SetActive(false);
                cartaInvocada.GetComponent<CartaUnidad>().Poder = 8;
            }

        }
        else if(gameObject.name == "ButtonMarte")
        {
            cartaInvocada = Instantiate(cartaImg, new Vector3(0,0,0), Quaternion.identity);
            cartaInvocada.transform.SetParent(MyMelee.transform, false);
            carta.SetActive(false);
            sonidoDeInvocacion.Play();
        }
        else if(gameObject.name == "ButtonMonje")
        {
            cartaInvocada = Instantiate(cartaImg, new Vector3(0,0,0), Quaternion.identity);
            cartaInvocada.transform.SetParent(MyMelee.transform, false);
            carta.SetActive(false);
            sonidoDeInvocacion.Play();
            //EFECTO
            for (int i = 0; i < MyMelee.transform.childCount; i++)
            {
                if(MyMelee.transform.GetChild(i).name != "CartaKratosImg")
                    MyMelee.transform.GetChild(i).GetComponent<CartaUnidad>().Poder += 3;
            }
        }
        else if(gameObject.name == "ButtonRa")
        {
            cartaInvocada = Instantiate(cartaImg, new Vector3(0,0,0), Quaternion.identity);
            cartaInvocada.transform.SetParent(MySiege.transform, false);
            carta.SetActive(false);
            sonidoDeInvocacion.Play();
            //EFECTO
            GameObject MaxPoder = cartaInvocada;
            if (MyMelee.transform.childCount != 0 || MyRange.transform.childCount != 0 || MySiege.transform.childCount != 0 || EnemyMelee.transform.childCount != 0 || EnemyRange.transform.childCount != 0 || EnemySiege.transform.childCount != 0)
            {
                for(int i = 0; i < MyMelee.transform.childCount; i++)
                {
                    if(MyMelee.transform.GetChild(i).gameObject.activeSelf == true && MyMelee.transform.GetChild(i).name != "CartaKratosImg" && MyMelee.transform.GetChild(i).GetComponent<CartaUnidad>().Poder > MaxPoder.GetComponent<CartaUnidad>().Poder)
                    {
                        MaxPoder = MyMelee.transform.GetChild(i).gameObject;
                    }
                }
                for(int i = 0; i < MyRange.transform.childCount; i++)
                {
                    if(MyRange.transform.GetChild(i).gameObject.activeSelf == true && MyRange.transform.GetChild(i).name != "CartaKratosImg" && MyRange.transform.GetChild(i).GetComponent<CartaUnidad>().Poder > MaxPoder.GetComponent<CartaUnidad>().Poder)
                    {
                        MaxPoder = MyRange.transform.GetChild(i).gameObject;
                    }
                }
                for(int i = 0; i < MySiege.transform.childCount; i++)
                {
                    if(MySiege.transform.GetChild(i).gameObject.activeSelf == true && MySiege.transform.GetChild(i).name != "CartaKratosImg" && MySiege.transform.GetChild(i).GetComponent<CartaUnidad>().Poder > MaxPoder.GetComponent<CartaUnidad>().Poder)
                    {
                        MaxPoder = MySiege.transform.GetChild(i).gameObject;
                    }
                }
                for(int i = 0; i < EnemyMelee.transform.childCount; i++)
                {
                    if(EnemyMelee.transform.GetChild(i).gameObject.activeSelf == true && EnemyMelee.transform.GetChild(i).name != "CartaCuboRubikImg" && EnemyMelee.transform.GetChild(i).GetComponent<CartaUnidad>().Poder > MaxPoder.GetComponent<CartaUnidad>().Poder)
                    {
                        MaxPoder = EnemyMelee.transform.GetChild(i).gameObject;
                    }
                }
                for(int i = 0; i < EnemyRange.transform.childCount; i++)
                {
                    if(EnemyRange.transform.GetChild(i).gameObject.activeSelf == true && EnemyRange.transform.GetChild(i).name != "CartaCuboRubikImg" && EnemyRange.transform.GetChild(i).GetComponent<CartaUnidad>().Poder > MaxPoder.GetComponent<CartaUnidad>().Poder)
                    {
                        MaxPoder = EnemyRange.transform.GetChild(i).gameObject;
                    }
                }
                for(int i = 0; i < EnemySiege.transform.childCount; i++)
                {
                    if(EnemySiege.transform.GetChild(i).gameObject.activeSelf == true && EnemySiege.transform.GetChild(i).name != "CartaCuboRubikImg" && EnemySiege.transform.GetChild(i).GetComponent<CartaUnidad>().Poder > MaxPoder.GetComponent<CartaUnidad>().Poder)
                    {
                        MaxPoder = EnemySiege.transform.GetChild(i).gameObject;
                    }
                }
            }
            MaxPoder.SetActive(false);
            
        }
        else if(gameObject.name == "ButtonSacerdote")
        {
            cartaInvocada = Instantiate(cartaImg, new Vector3(0,0,0), Quaternion.identity);
            cartaInvocada.transform.SetParent(MyRange.transform, false);
            carta.SetActive(false);
            sonidoDeInvocacion.Play();
        }
        else if(gameObject.name == "ButtonValkyria")
        {
            cartaInvocada = Instantiate(cartaImg, new Vector3(0,0,0), Quaternion.identity);
            cartaInvocada.transform.SetParent(MyRange.transform, false);
            carta.SetActive(false);
            sonidoDeInvocacion.Play();
            // EFECTO
            int a = Random.Range(0, deck.deckReligion.Count);    
            Carta randCard = deck.deckReligion[a];
            Carta player1Card = Instantiate(randCard, new Vector3(0,0,0), Quaternion.identity);
            player1Card.transform.SetParent(deck.Player1Hand.transform, false);
            deck.deckReligion.Remove(deck.deckReligion[a]);

        }
        ///EL OTRO DECK

        else if (gameObject.name == "ButtonBanner")
        {
            cartaInvocada = Instantiate(cartaImg, new Vector3(0,0,0), Quaternion.identity);
            cartaInvocada.transform.SetParent(EnemyMelee.transform, false);
            carta.SetActive(false);
            sonidoDeInvocacion.Play();
            // EFECTO
            bool duplicado = false;
            for(int i = 0; i < EnemyMelee.transform.childCount; i++)
            {
                if(EnemyMelee.transform.GetChild(i).gameObject.activeSelf == true && EnemyMelee.transform.GetChild(i).gameObject.name.Substring(0, EnemyMelee.transform.GetChild(i).gameObject.name.Length - 10) == "CartaBanner" && EnemyMelee.transform.GetChild(i).gameObject != cartaInvocada)
                {
                    EnemyMelee.transform.GetChild(i).GetComponent<CartaUnidad>().Poder += 6;
                    if(duplicado == false)
                    {
                        cartaInvocada.transform.GetComponent<CartaUnidad>().Poder += 6;
                        duplicado = true;
                    }
                }
            }
            
        }
        else if (gameObject.name == "ButtonCurie")
        {
            cartaInvocada = Instantiate(cartaImg, new Vector3(0,0,0), Quaternion.identity);
            cartaInvocada.transform.SetParent(EnemyMelee.transform, false);
            carta.SetActive(false);
            sonidoDeInvocacion.Play();
        }
        else if (gameObject.name == "ButtonEinstein")
        {
            deck.devolver = true;
            carta.tag = "cartaAJugar";
            cartaImg.tag = "cartaAInvocar";
        }
        else if (gameObject.name == "ButtonSheldon")
        {
            cartaInvocada = Instantiate(cartaImg, new Vector3(0,0,0), Quaternion.identity);
            cartaInvocada.transform.SetParent(EnemyRange.transform, false);
            carta.SetActive(false);
            sonidoDeInvocacion.Play();
            // EFECTO
            for (int i = 0; i < EnemyRange.transform.childCount; i++)
            {
                if(EnemyRange.transform.GetChild(i).name != "CartaCuboRubikImg")
                    EnemyRange.transform.GetChild(i).GetComponent<CartaUnidad>().Poder += 2;
            }
        }
        else if (gameObject.name == "ButtonZuck")
        {
            cartaInvocada = Instantiate(cartaImg, new Vector3(0,0,0), Quaternion.identity);
            cartaInvocada.transform.SetParent(EnemySiege.transform, false);
            carta.SetActive(false);
            sonidoDeInvocacion.Play();
        }
        else if (gameObject.name == "ButtonTesla")
        {
            cartaInvocada = Instantiate(cartaImg, new Vector3(0,0,0), Quaternion.identity);
            cartaInvocada.transform.SetParent(EnemyRange.transform, false);
            carta.SetActive(false);
            sonidoDeInvocacion.Play();
            // EFECTO
            int b = Random.Range(0, deck.deckCiencia.Count);
            Carta randCard = deck.deckCiencia[b];
            Carta player2Card = Instantiate(randCard, new Vector3(0,0,0), Quaternion.identity);
            player2Card.transform.SetParent(deck.Player2Hand.transform, false);
            deck.deckCiencia.Remove(deck.deckCiencia[b]);
        }



    }  
    
}
