using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardClimaController : MonoBehaviour
{
    public GameObject cartaImg;
    public GameObject carta;
    private AudioSource sonidoDeInvocacion;

    void Start()
    {
        sonidoDeInvocacion = GameObject.FindWithTag("GameManager").GetComponent<AudioSource>();
    }

    public void OnClick()
    {
        GameObject myAreaClima = GameObject.FindWithTag("MyAreaClima");
        GameObject enemyAreaClima = GameObject.FindWithTag("EnemyAreaClima");
        GameObject cartaInvocada;
        
        if(gameObject.name == "ButtonSeptimoDia")
        {
            if(myAreaClima.transform.childCount != 0) Destroy(myAreaClima.transform.GetChild(0).gameObject);
            if(enemyAreaClima.transform.childCount != 0) Destroy(enemyAreaClima.transform.GetChild(0).gameObject);
            cartaInvocada = Instantiate(cartaImg, new Vector3(0,0,0), Quaternion.identity);
            cartaInvocada.transform.SetParent(myAreaClima.transform, false);
            carta.SetActive(false);
            sonidoDeInvocacion.Play();
        }
        else if(gameObject.name == "ButtonPoseidon" || gameObject.name == "ButtonSolMuerto")
        {
            if(myAreaClima.transform.childCount == 0 || !myAreaClima.transform.GetChild(0).gameObject.activeSelf)
            {
                cartaInvocada = Instantiate(cartaImg, new Vector3(0,0,0), Quaternion.identity);
                cartaInvocada.transform.SetParent(myAreaClima.transform, false);
                carta.SetActive(false);
                sonidoDeInvocacion.Play();
            }
            else
            {
                Debug.LogError("Ya hay una carta Clima en el campo");
            }
        }
        else if(gameObject.name == "ButtonReset")
        {
            if(myAreaClima.transform.childCount != 0) Destroy(myAreaClima.transform.GetChild(0).gameObject);
            if(enemyAreaClima.transform.childCount != 0) Destroy(enemyAreaClima.transform.GetChild(0).gameObject);
            cartaInvocada = Instantiate(cartaImg, new Vector3(0,0,0), Quaternion.identity);
            cartaInvocada.transform.SetParent(enemyAreaClima.transform, false);
            carta.SetActive(false);
            sonidoDeInvocacion.Play();
        }
        else if(gameObject.name == "ButtonMetaverso" || gameObject.name == "ButtonLaboratorio")
        {
            if(enemyAreaClima.transform.childCount == 0 || !enemyAreaClima.transform.GetChild(0).gameObject.activeSelf)
            {
                cartaInvocada = Instantiate(cartaImg, new Vector3(0,0,0), Quaternion.identity);
                cartaInvocada.transform.SetParent(enemyAreaClima.transform, false);
                carta.SetActive(false);
                sonidoDeInvocacion.Play();
            }
            else
            {
                Debug.LogError("Ya hay una carta Clima en el campo");   
            }
        }

        
        
    }


}
