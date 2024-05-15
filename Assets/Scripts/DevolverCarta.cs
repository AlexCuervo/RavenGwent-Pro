using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DevolverCarta : MonoBehaviour
{

    private AudioSource sonidoDeInvocacion;
    public GameManager devolver;
    

    void Start()
    {
        devolver = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
        sonidoDeInvocacion = GameObject.FindWithTag("GameManager").GetComponent<AudioSource>();
    }

    public void OnClick()
    {
        if( devolver.devolver == true && GameObject.FindWithTag("cartaAJugar").transform.name == "CartaCruzado(Clone)")
        {
            gameObject.transform.parent.gameObject.SetActive(false);
            for (int i = 0; i < GameObject.FindWithTag("MyHand").transform.childCount; i++)
            {
                // DEVOLVER EL OBJETO A LA MANO
                if(GameObject.FindWithTag("MyHand").transform.GetChild(i).name.Substring(0, GameObject.FindWithTag("MyHand").transform.GetChild(i).name.Length - 7) == gameObject.transform.parent.name.Substring(0, gameObject.transform.parent.name.Length - 10))
                {
                    GameObject.FindWithTag("MyHand").transform.GetChild(i).gameObject.SetActive(true);
                    GameObject reemplazo = Instantiate(GameObject.FindWithTag("cartaAInvocar"), new Vector3(0,0,0), Quaternion.identity);
                    reemplazo.transform.SetParent(gameObject.transform.parent.parent, false);
                    GameObject reemplazoMain = GameObject.FindWithTag("cartaAJugar");
                    reemplazoMain.tag = "Untagged";
                    reemplazoMain.SetActive(false);
                    reemplazo.tag = "Untagged";
                    sonidoDeInvocacion.Play();
                    break;
                }
            }
            devolver.devolver = false;
        }
        if( devolver.devolver == true && GameObject.FindWithTag("cartaAJugar").transform.name == "CartaStark(Clone)")
        {
            gameObject.transform.parent.gameObject.SetActive(false);
            for (int i = 0; i < GameObject.FindWithTag("EnemyHand").transform.childCount; i++)
            {
                // DEVOLVER EL OBJETO A LA MANO
                if(GameObject.FindWithTag("EnemyHand").transform.GetChild(i).name.Substring(0, GameObject.FindWithTag("EnemyHand").transform.GetChild(i).name.Length - 7) == gameObject.transform.parent.name.Substring(0, gameObject.transform.parent.name.Length - 10))
                {
                    GameObject.FindWithTag("EnemyHand").transform.GetChild(i).gameObject.SetActive(true);
                    GameObject reemplazo = Instantiate(GameObject.FindWithTag("cartaAInvocar"), new Vector3(0,0,0), Quaternion.identity);
                    reemplazo.transform.SetParent(gameObject.transform.parent.parent, false);
                    GameObject reemplazoMain = GameObject.FindWithTag("cartaAJugar");
                    reemplazoMain.tag = "Untagged";
                    reemplazoMain.SetActive(false);
                    reemplazo.tag = "Untagged";
                    sonidoDeInvocacion.Play();
                    break;
                }
            }
            devolver.devolver = false;
        }
        if( devolver.devolver == true && GameObject.FindWithTag("cartaAJugar").transform.name == "CartaEinstein(Clone)")
        {
            gameObject.transform.parent.gameObject.SetActive(false);

            for (int i = 0; i < devolver.Player1Hand.transform.childCount; i++)
            {
                // DEVOLVER EL OBJETO A LA MANO
                if(devolver.Player1Hand.transform.GetChild(i).name.Substring(0,devolver.Player1Hand.transform.GetChild(i).name.Length - 7) == gameObject.transform.parent.name.Substring(0, gameObject.transform.parent.name.Length - 10))
                {
                    devolver.Player1Hand.transform.GetChild(i).gameObject.SetActive(true);
                }
            }
            GameObject einstein = Instantiate(GameObject.FindWithTag("cartaAInvocar"), new Vector3(0,0,0), Quaternion.identity);
            einstein.transform.SetParent(GameObject.FindWithTag("EnemySiege").transform, false);
            einstein.tag = "Untagged";
            GameObject carta = GameObject.FindWithTag("cartaAJugar");
            carta.tag = "Untagged";
            carta.SetActive(false);            
            sonidoDeInvocacion.Play(); 
        }
    }
} 