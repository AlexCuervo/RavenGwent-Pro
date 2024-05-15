using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfectoRick : MonoBehaviour
{
    private bool efectoActivado = false;

    public void OnClick()
    {
        GameObject MyMelee = GameObject.FindWithTag("MyMelee");
        GameObject MyRange = GameObject.FindWithTag("MyRange");
        GameObject MySiege = GameObject.FindWithTag("MySiege");
        int hijosMelee = 0;
        int hijosRange = 0;
        int hijosSiege = 0;

        for(int i = 0; i < MyMelee.transform.childCount; i++)
        {
            if(MyMelee.transform.GetChild(i).gameObject.activeSelf) hijosMelee ++;
        }
        for(int i = 0; i < MyRange.transform.childCount; i++)
        {
            if(MyRange.transform.GetChild(i).gameObject.activeSelf) hijosRange ++;
        }
        for(int i = 0; i < MySiege.transform.childCount; i++)
        {
            if(MySiege.transform.GetChild(i).gameObject.activeSelf) hijosSiege++;
        }

        if(hijosMelee == 0) hijosMelee = 1000;
        if(hijosRange == 0) hijosRange = 1000;
        if(hijosSiege == 0) hijosSiege = 1000;

        
        if(efectoActivado == false)
        {
            if( hijosMelee != 0 && hijosMelee < hijosRange && hijosMelee < hijosSiege)
            {
                for(int i = 0; i < MyMelee.transform.childCount; i++)
                {
                    MyMelee.transform.GetChild(i).gameObject.SetActive(false);
                }
            }
            if(hijosRange != 0 && hijosRange < hijosMelee && hijosRange < hijosSiege)
            {
                for(int i = 0; i < MyRange.transform.childCount; i++)
                {
                    MyRange.transform.GetChild(i).gameObject.SetActive(false);
                }
            }
            if(hijosSiege != 0 && hijosSiege < hijosMelee && hijosSiege < hijosRange)
            {
                for(int i = 0; i < MySiege.transform.childCount; i++)
                {
                    MySiege.transform.GetChild(i).gameObject.SetActive(false);
                }
            }
            efectoActivado = true;
            GameObject.FindWithTag("GameManager").GetComponent<GameManager>().IsPlayer1Turn = true;
        }    
    }
}
