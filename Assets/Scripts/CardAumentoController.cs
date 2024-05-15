using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardAumentoController : MonoBehaviour
{
    public GameObject carta;
    public GameObject cartaImg;

    public void OnClick()
    {
        GameObject MySiegeAumento = GameObject.FindWithTag("MySiegeAumento");
        GameObject cartaInvocada = Instantiate(cartaImg, new Vector3(0,0,0), Quaternion.identity);
        cartaInvocada.transform.SetParent(MySiegeAumento.transform, false);
        carta.SetActive(false);
    }

   
}
    