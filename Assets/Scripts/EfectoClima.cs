using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfectoClima : MonoBehaviour
{
    public GameObject MyMelee;
    public GameObject MyRange;
    public GameObject MySiege;
    public GameObject EnemyMelee;
    public GameObject EnemyRange;
    public GameObject EnemySiege;

    void Start()
    {
        MyMelee = GameObject.FindWithTag("MyMelee");
        MyRange = GameObject.FindWithTag("MyRange");
        MySiege = GameObject.FindWithTag("MySiege");
        EnemyMelee = GameObject.FindWithTag("EnemyMelee");
        EnemyRange = GameObject.FindWithTag("EnemyRange");
        EnemySiege = GameObject.FindWithTag("EnemySiege"); 
    }
    
    
    void Update()
    {
        if(gameObject.transform.parent.name == "MyAreaClima")//EFECTOS DE LAS CARTAS DE CLIMA DEL PLAYER 1
        {
            if(gameObject.transform.name == "CartaPoseidonImg(Clone)")//EFECTO DE LA CARTA POSEIDON
            {
                for (int i = 0; i < MyMelee.transform.childCount; i++)
                {
                    if(MyMelee.transform.GetChild(i).GetComponent<CartaUnidad>().afectadaPorClimaP1 == false && MyMelee.transform.GetChild(i).name != "CartaKratosImg")
                    {
                        MyMelee.transform.GetChild(i).GetComponent<CartaUnidad>().Poder += -4;
                        MyMelee.transform.GetChild(i).GetComponent<CartaUnidad>().afectadaPorClimaP1 = true;
                    }
                }
                for (int i = 0; i < EnemyMelee.transform.childCount; i++)
                {
                    if(EnemyMelee.transform.GetChild(i).GetComponent<CartaUnidad>().afectadaPorClimaP1 == false && EnemyMelee.transform.GetChild(i).name != "CartaCuboRubikImg")
                    {
                        EnemyMelee.transform.GetChild(i).GetComponent<CartaUnidad>().Poder += -4;
                        EnemyMelee.transform.GetChild(i).GetComponent<CartaUnidad>().afectadaPorClimaP1 = true;
                    }
                }            
            }
        
            if(gameObject.transform.name == "CartaSolMuertoImg(Clone)")//EFECTO DE LA CARTA SOL MUERTO
            {
                for (int i = 0; i < MyRange.transform.childCount; i++)
                    {
                        if(MyRange.transform.GetChild(i).GetComponent<CartaUnidad>().afectadaPorClimaP1 == false && MyRange.transform.GetChild(i).name != "CartaKratosImg")
                        {
                            MyRange.transform.GetChild(i).GetComponent<CartaUnidad>().Poder += -3;
                            MyRange.transform.GetChild(i).GetComponent<CartaUnidad>().afectadaPorClimaP1 = true;
                        }
                    }
                for (int i = 0; i < MySiege.transform.childCount; i++)
                    {
                        if(MySiege.transform.GetChild(i).GetComponent<CartaUnidad>().afectadaPorClimaP1 == false && MySiege.transform.GetChild(i).name != "CartaKratosImg")
                        {
                            MySiege.transform.GetChild(i).GetComponent<CartaUnidad>().Poder += -4;
                            MySiege.transform.GetChild(i).GetComponent<CartaUnidad>().afectadaPorClimaP1 = true;
                        }
                    }
                for (int i = 0; i < EnemyRange.transform.childCount; i++)
                    {
                        if(EnemyRange.transform.GetChild(i).GetComponent<CartaUnidad>().afectadaPorClimaP1 == false && EnemyRange.transform.GetChild(i).name != "CartaCuboRubikImg")
                        {
                            EnemyRange.transform.GetChild(i).GetComponent<CartaUnidad>().Poder += -3;
                            EnemyRange.transform.GetChild(i).GetComponent<CartaUnidad>().afectadaPorClimaP1 = true;
                        }
                    }
                for (int i = 0; i < EnemySiege.transform.childCount; i++)
                    {
                        if(EnemySiege.transform.GetChild(i).GetComponent<CartaUnidad>().afectadaPorClimaP1 == false && EnemySiege.transform.GetChild(i).name != "CartaCuboRubikImg")
                        {
                            EnemySiege.transform.GetChild(i).GetComponent<CartaUnidad>().Poder += -4;
                            EnemySiege.transform.GetChild(i).GetComponent<CartaUnidad>().afectadaPorClimaP1 = true;
                        }
                    }
            }
        }        
        else if (gameObject.transform.parent.name == "EnemyAreaClima")
        {
            if(gameObject.transform.name == "CartaLaboratorioImg(Clone)")
            {
                for (int i = 0; i < MySiege.transform.childCount; i++)
                {
                    if(MySiege.transform.GetChild(i).GetComponent<CartaUnidad>().afectadaPorClimaP2 == false && MySiege.transform.GetChild(i).name != "CartaKratosImg")
                    {
                        MySiege.transform.GetChild(i).GetComponent<CartaUnidad>().Poder += -3;
                        MySiege.transform.GetChild(i).GetComponent<CartaUnidad>().afectadaPorClimaP2 = true;
                    }
                }
                for (int i = 0; i < EnemySiege.transform.childCount; i++)
                {
                    if(EnemySiege.transform.GetChild(i).GetComponent<CartaUnidad>().afectadaPorClimaP2 == false && EnemySiege.transform.GetChild(i).name != "CartaCuboRubikImg")
                    {
                        EnemySiege.transform.GetChild(i).GetComponent<CartaUnidad>().Poder += -3;
                        EnemySiege.transform.GetChild(i).GetComponent<CartaUnidad>().afectadaPorClimaP2 = true;
                    }
                }
            }
            if(gameObject.transform.name == "CartaMetaversoImg(Clone)")
            {
                for (int i = 0; i < MyRange.transform.childCount; i++)
                {
                    if(MyRange.transform.GetChild(i).GetComponent<CartaUnidad>().afectadaPorClimaP2 == false && MyRange.transform.GetChild(i).name != "CartaKratosImg")
                    {
                        MyRange.transform.GetChild(i).GetComponent<CartaUnidad>().Poder += -2;
                        MyRange.transform.GetChild(i).GetComponent<CartaUnidad>().afectadaPorClimaP2 = true;
                    }
                }
                for (int i = 0; i < EnemyRange.transform.childCount; i++)
                {
                    if(EnemyRange.transform.GetChild(i).GetComponent<CartaUnidad>().afectadaPorClimaP2 == false && EnemyRange.transform.GetChild(i).name != "CartaCuboRubikImg")
                    {
                        EnemyRange.transform.GetChild(i).GetComponent<CartaUnidad>().Poder += -2;
                        EnemyRange.transform.GetChild(i).GetComponent<CartaUnidad>().afectadaPorClimaP2 = true;
                    }
                }
            }

        }

        if((gameObject.transform.parent.name == "MyAreaClima" && gameObject.transform.name == "CartaSeptimoDiaImg(Clone)") || (gameObject.transform.parent.name == "EnemyAreaClima" && gameObject.transform.name == "CartaResetImg(Clone)"))
        {
            for(int i = 0; i < MyMelee.transform.childCount; i++)
            {
                if(MyMelee.transform.GetChild(i).GetComponent<CartaUnidad>().afectadaPorClimaP1 == true)
                {
                    MyMelee.transform.GetChild(i).GetComponent<CartaUnidad>().Poder += 4;
                    MyMelee.transform.GetChild(i).GetComponent<CartaUnidad>().afectadaPorClimaP1 = false;
                }
            }
            for(int i = 0; i < EnemyMelee.transform.childCount; i++)
            {
                if(EnemyMelee.transform.GetChild(i).GetComponent<CartaUnidad>().afectadaPorClimaP1 == true)
                {
                    EnemyMelee.transform.GetChild(i).GetComponent<CartaUnidad>().Poder += 4;
                    EnemyMelee.transform.GetChild(i).GetComponent<CartaUnidad>().afectadaPorClimaP1 = false;
                }
            }
            for (int i = 0; i < MyRange.transform.childCount; i++)
            {
                if(MyRange.transform.GetChild(i).GetComponent<CartaUnidad>().afectadaPorClimaP2 == true)
                {
                    MyRange.transform.GetChild(i).GetComponent<CartaUnidad>().Poder += 2;
                    MyRange.transform.GetChild(i).GetComponent<CartaUnidad>().afectadaPorClimaP2 = false;
                }
                if(MyRange.transform.GetChild(i).GetComponent<CartaUnidad>().afectadaPorClimaP1 == true)
                {
                    MyRange.transform.GetChild(i).GetComponent<CartaUnidad>().Poder += 3;
                    MyRange.transform.GetChild(i).GetComponent<CartaUnidad>().afectadaPorClimaP1 = false;
                }
            }
            for (int i = 0; i < EnemyRange.transform.childCount; i++)
            {
                if(EnemyRange.transform.GetChild(i).GetComponent<CartaUnidad>().afectadaPorClimaP2 == true)
                {
                   EnemyRange.transform.GetChild(i).GetComponent<CartaUnidad>().Poder += 2;
                    EnemyRange.transform.GetChild(i).GetComponent<CartaUnidad>().afectadaPorClimaP2 = false;
                }
                if(EnemyRange.transform.GetChild(i).GetComponent<CartaUnidad>().afectadaPorClimaP1 == true)
                {
                    EnemyRange.transform.GetChild(i).GetComponent<CartaUnidad>().Poder += 3;
                    EnemyRange.transform.GetChild(i).GetComponent<CartaUnidad>().afectadaPorClimaP1 = false;
                }
            }
            for (int i = 0; i < MySiege.transform.childCount; i++)
            {
                if(MySiege.transform.GetChild(i).GetComponent<CartaUnidad>().afectadaPorClimaP1 == true)
                {
                    MySiege.transform.GetChild(i).GetComponent<CartaUnidad>().Poder += 4;
                    MySiege.transform.GetChild(i).GetComponent<CartaUnidad>().afectadaPorClimaP1 = false;
                }
                if(MySiege.transform.GetChild(i).GetComponent<CartaUnidad>().afectadaPorClimaP2 == true)
                {
                    MySiege.transform.GetChild(i).GetComponent<CartaUnidad>().Poder += 3;
                    MySiege.transform.GetChild(i).GetComponent<CartaUnidad>().afectadaPorClimaP2 = false;
                }
            }
            for (int i = 0; i < EnemySiege.transform.childCount; i++)
            {
                if(EnemySiege.transform.GetChild(i).GetComponent<CartaUnidad>().afectadaPorClimaP1 == true)
                {
                    EnemySiege.transform.GetChild(i).GetComponent<CartaUnidad>().Poder += 4;
                    EnemySiege.transform.GetChild(i).GetComponent<CartaUnidad>().afectadaPorClimaP1 = false;
                }
                if(EnemySiege.transform.GetChild(i).GetComponent<CartaUnidad>().afectadaPorClimaP2 == true)
                {
                    EnemySiege.transform.GetChild(i).GetComponent<CartaUnidad>().Poder += 3;
                    EnemySiege.transform.GetChild(i).GetComponent<CartaUnidad>().afectadaPorClimaP2 = false;
                }
            }
            
        }

    }
}   