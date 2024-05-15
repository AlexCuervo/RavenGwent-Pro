using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //----------- DECK 1(RELIGION)----------

public AudioSource sonidoGanaste;
public AudioSource sonidoEmpate;
public GameObject Player1AreaLider;
public GameObject Player2AreaLider;
public GameObject Player1Hand;
public GameObject Player2Hand;
public Text deckReligionCount;
public Text deckCienciaCount;
public Text Player1Score;
public Text Player2Score;
public GameObject MyAreaSiege;
public GameObject MyAreaRange;
public GameObject MyAreaMelee;
public GameObject MyAreaSiegeAumento;
public GameObject MyAreaRangeAumento;
public GameObject MyAreaMeleeAumento;
public GameObject MyAreaClima;
public GameObject EnemyAreaSiege;
public GameObject EnemyAreaRange;
public GameObject EnemyAreaMelee;
public GameObject EnemyAreaSiegeAumento;
public GameObject EnemyAreaRangeAumento;
public GameObject EnemyAreaMeleeAumento;
public GameObject EnemyAreaClima;
public GameObject PassP1Button;
public GameObject PassP2Button;
protected int P1Rondas = 0;
protected int P2Rondas = 0;
public bool devolver;
public GameObject TextoEntreRondas;



public List<Carta> deckReligion = new List<Carta>();
public List<Carta> deckCiencia = new List<Carta>();

public CartaLider Dios;
public CartaUnidad Monje;
public CartaUnidad Zeus;
public CartaUnidad Valkyria;
public CartaUnidad Ra;
public CartaUnidad Cruzado;
public CartaUnidad Sacerdote;
public CartaUnidad Marte;
public CartaUnidad Kratos;
public CartaClima Poseidon;
public CartaClima SolMuerto;
public CartaClima SeptimoDia;
public CartaAumento Rosario;
public CartaAumento Clero;
public CartaAumento AguaBendita;

///----------------DECK 2(CIENCIA)-------------
public CartaLider Rick;
public CartaUnidad Sheldon;
public CartaUnidad Einstein;
public CartaUnidad Tesla;
public CartaUnidad Curie;
public CartaUnidad Stark;
public CartaUnidad Banner;
public CartaUnidad Zuckerberg;
public CartaUnidad CuboRubik;
public CartaClima Metaverso;
public CartaClima Laboratorio;
public CartaClima Reset;
public CartaAumento Curso;
public CartaAumento RedPill;
public CartaAumento Pizarra;

    ///VARIABLES PARA CONTROLAR LOS TURNOS
        public bool IsPlayer1Turn = true;
        private int mySiegeCount;
        private int myRangeCount;
        private int myMeleeCount;
        private int mySiegeAumCount;
        private int myRangeAumCount;
        private int myMeleeAumCount;
        private int myClimaCount;
        private int enemySiegeCount;
        private int enemyRangeCount;
        private int enemyMeleeCount;
        private int enemySiegeAumCount;
        private int enemyRangeAumCount;
        private int enemyMeleeAumCount;
        private int enemyClimaCount;

        // METODO PARA LIMPIAR A ESCENA
        public void LimpiarEscena()
        {
            foreach(Transform hijo in MyAreaMelee.transform)
            {hijo.gameObject.SetActive(false);}
            foreach(Transform hijo in MyAreaMeleeAumento.transform)
            {hijo.gameObject.SetActive(false);}
            foreach(Transform hijo in MyAreaRange.transform)
            {hijo.gameObject.SetActive(false);}
            foreach(Transform hijo in MyAreaRangeAumento.transform)
            {hijo.gameObject.SetActive(false);}
            foreach(Transform hijo in MyAreaSiege.transform)
            {hijo.gameObject.SetActive(false);}
            foreach(Transform hijo in MyAreaSiegeAumento.transform)
            {hijo.gameObject.SetActive(false);}
            foreach(Transform hijo in MyAreaClima.transform)
            {hijo.gameObject.SetActive(false);}
            foreach(Transform hijo in EnemyAreaMelee.transform)
            {hijo.gameObject.SetActive(false);}
            foreach(Transform hijo in EnemyAreaMeleeAumento.transform)
            {hijo.gameObject.SetActive(false);}
            foreach(Transform hijo in EnemyAreaRange.transform)
            {hijo.gameObject.SetActive(false);}
            foreach(Transform hijo in EnemyAreaRangeAumento.transform)
            {hijo.gameObject.SetActive(false);}
            foreach(Transform hijo in EnemyAreaSiege.transform)
            {hijo.gameObject.SetActive(false);}
            foreach(Transform hijo in EnemyAreaSiegeAumento.transform)
            {hijo.gameObject.SetActive(false);}
            foreach(Transform hijo in EnemyAreaClima.transform)
            {hijo.gameObject.SetActive(false);}
        }


    void Start()
    {
        deckReligion.Add(Monje);
        deckReligion.Add(Monje);
        deckReligion.Add(Monje);
        deckReligion.Add(Zeus);
        deckReligion.Add(Zeus);
        deckReligion.Add(Valkyria);
        deckReligion.Add(Valkyria);
        deckReligion.Add(Ra);
        deckReligion.Add(Ra);
        deckReligion.Add(Cruzado);
        deckReligion.Add(Cruzado);
        deckReligion.Add(Sacerdote);
        deckReligion.Add(Sacerdote);
        deckReligion.Add(Sacerdote);
        deckReligion.Add(Marte);
        deckReligion.Add(Marte);
        deckReligion.Add(Marte);
        deckReligion.Add(Kratos);
        deckReligion.Add(Poseidon);
        deckReligion.Add(SolMuerto);
        deckReligion.Add(SeptimoDia);
        deckReligion.Add(Rosario);
        deckReligion.Add(Clero);
        deckReligion.Add(AguaBendita);

        deckCiencia.Add(Sheldon);
        deckCiencia.Add(Sheldon);
        deckCiencia.Add(Sheldon);
        deckCiencia.Add(Einstein);
        deckCiencia.Add(Einstein);
        deckCiencia.Add(Tesla);
        deckCiencia.Add(Tesla);
        deckCiencia.Add(Curie);
        deckCiencia.Add(Curie);
        deckCiencia.Add(Stark);
        deckCiencia.Add(Stark);
        deckCiencia.Add(Banner);
        deckCiencia.Add(Banner);
        deckCiencia.Add(Banner);
        deckCiencia.Add(Zuckerberg);
        deckCiencia.Add(Zuckerberg);
        deckCiencia.Add(Zuckerberg);
        deckCiencia.Add(CuboRubik);
        deckCiencia.Add(Metaverso);
        deckCiencia.Add(Laboratorio);
        deckCiencia.Add(Reset);
        deckCiencia.Add(Curso);
        deckCiencia.Add(RedPill);
        deckCiencia.Add(Pizarra);
    	
        ///PONER LOS LIDERES EN SU CASILLA AL INICIO DEL JUEGO
        Carta Player1Lider = Instantiate(Dios, new Vector3(0,0,0), Quaternion.identity);
        Player1Lider.transform.SetParent(Player1AreaLider.transform, false);


        Carta Player2Lider = Instantiate(Rick, new Vector3(0,0,0), Quaternion.identity);
        Player2Lider.transform.SetParent(Player2AreaLider.transform, false);
            
        

        for(int i = 0; i < 10; i++)
        {
            int a = Random.Range(0, deckReligion.Count);
            int b = Random.Range(0, deckCiencia.Count);
            
            Carta randCard = deckReligion[a];
            Carta player1Card = Instantiate(randCard, new Vector3(0,0,0), Quaternion.identity);
            player1Card.transform.SetParent(Player1Hand.transform, false);
            deckReligion.Remove(deckReligion[a]);
            
            randCard = deckCiencia[b];
            Carta player2Card = Instantiate(randCard, new Vector3(0,0,0), Quaternion.identity);
            player2Card.transform.SetParent(Player2Hand.transform, false);
            deckCiencia.Remove(deckCiencia[b]);
        
        }

        mySiegeCount = MyAreaSiege.transform.childCount;
        myRangeCount = MyAreaRange.transform.childCount;
        myMeleeCount = MyAreaMelee.transform.childCount;
        mySiegeAumCount = MyAreaSiegeAumento.transform.childCount;
        myRangeAumCount = MyAreaRangeAumento.transform.childCount;
        myMeleeAumCount = MyAreaMeleeAumento.transform.childCount;
        myClimaCount = MyAreaClima.transform.childCount;
        enemySiegeCount = EnemyAreaSiege.transform.childCount;
        enemyRangeCount = EnemyAreaRange.transform.childCount;
        enemyMeleeCount = EnemyAreaMelee.transform.childCount;
        enemySiegeAumCount = EnemyAreaSiegeAumento.transform.childCount;
        enemyRangeAumCount = EnemyAreaRangeAumento.transform.childCount;
        enemyMeleeAumCount = EnemyAreaMeleeAumento.transform.childCount;
        enemyClimaCount = EnemyAreaClima.transform.childCount;

        sonidoGanaste = GameObject.FindWithTag("P1deck").GetComponent<AudioSource>();
        sonidoEmpate = GameObject.FindWithTag("P2deck").GetComponent<AudioSource>();
    }


    void Update()
    {
        //CONTEO DE LAS CARTAS QUE QUEDAN EN EL DECK
        deckReligionCount.text = deckReligion.Count.ToString();
        deckCienciaCount.text = deckCiencia.Count.ToString();
        
            //////CALCULAR EL PODER DE CADA JUGADOR
        if(MyAreaSiege.transform.childCount != 0 || MyAreaRange.transform.childCount != 0 || MyAreaMelee.transform.childCount != 0)
        {
            int p1score = 0;
           
            for (int i = 0; i < MyAreaSiege.transform.childCount; i++)
            {
                CartaUnidad carta = MyAreaSiege.transform.GetChild(i).GetComponent<CartaUnidad>();
                if (MyAreaSiege.transform.GetChild(i).gameObject.activeSelf)
                {
                    p1score += carta.Poder + 2;//LE SUMO 2 XQ EL EFECTO DEL LIDER DE FACCION ES SUMAR 2 AL PODER DE CADA UNIDAD DE LA FACCION
                }
            }
            for (int i = 0; i < MyAreaRange.transform.childCount; i++)
            {
                CartaUnidad carta = MyAreaRange.transform.GetChild(i).GetComponent<CartaUnidad>();
                if (MyAreaRange.transform.GetChild(i).gameObject.activeSelf)
                {
                    p1score += carta.Poder + 2;//LE SUMO 2 XQ EL EFECTO DEL LIDER DE FACCION ES SUMAR 2 AL PODER DE CADA UNIDAD DE LA FACCION
                }
            }
            for (int i = 0; i < MyAreaMelee.transform.childCount; i++)
            {
                CartaUnidad carta = MyAreaMelee.transform.GetChild(i).GetComponent<CartaUnidad>();
                if (MyAreaMelee.transform.GetChild(i).gameObject.activeSelf)
                {
                    p1score += carta.Poder + 2;//LE SUMO 2 XQ EL EFECTO DEL LIDER DE FACCION ES SUMAR 2 AL PODER DE CADA UNIDAD DE LA FACCION
                }
            }
        
            Player1Score.text = p1score.ToString();
        }
        if(EnemyAreaSiege.transform.childCount != 0 || EnemyAreaRange.transform.childCount != 0 || EnemyAreaMelee.transform.childCount != 0)
        {
            int p2score = 0;
            
            for (int i = 0; i < EnemyAreaSiege.transform.childCount; i++)
            {
                CartaUnidad carta = EnemyAreaSiege.transform.GetChild(i).GetComponent<CartaUnidad>();
                if (EnemyAreaSiege.transform.GetChild(i).gameObject.activeSelf)
                {
                    p2score += carta.Poder;
                }
            }
            for (int i = 0; i < EnemyAreaRange.transform.childCount; i++)
            {
                CartaUnidad carta = EnemyAreaRange.transform.GetChild(i).GetComponent<CartaUnidad>();
                if (EnemyAreaRange.transform.GetChild(i).gameObject.activeSelf)
                {
                    p2score += carta.Poder;
                }
            }
            for (int i = 0; i < EnemyAreaMelee.transform.childCount; i++)
            {
                CartaUnidad carta = EnemyAreaMelee.transform.GetChild(i).GetComponent<CartaUnidad>();
                if (EnemyAreaMelee.transform.GetChild(i).gameObject.activeSelf)
                {
                    p2score += carta.Poder;
                }
            }
            Player2Score.text = p2score.ToString();
        }
        //CAMBIAR DE TURNO CUANDO EL JUGADOR INVOQUE UNA CARTA
        PassTurn TurnoP1 = PassP1Button.transform.GetComponent<PassTurn>();
        PassTurn TurnoP2 = PassP2Button.transform.GetComponent<PassTurn>();

        if(TurnoP1.isPlayingP1 == true && TurnoP2.isPlayingP2 == true) 
            {
                if(IsPlayer1Turn == true )
                {
                    Player1Hand.SetActive(true);
                    Player2Hand.SetActive(false);
                    PassP1Button.SetActive(true);
                    PassP2Button.SetActive(false);
                    if( MyAreaSiege.transform.childCount != mySiegeCount || MyAreaRange.transform.childCount != myRangeCount || MyAreaMelee.transform.childCount != myMeleeCount || MyAreaSiegeAumento.transform.childCount != mySiegeAumCount || MyAreaRangeAumento.transform.childCount != myRangeAumCount || MyAreaMeleeAumento.transform.childCount != myMeleeAumCount || MyAreaClima.transform.childCount != myClimaCount)
                    {
                        Debug.Log("Cambio de turno");
                        IsPlayer1Turn = false;
                        mySiegeCount = MyAreaSiege.transform.childCount;
                        myRangeCount = MyAreaRange.transform.childCount;
                        myMeleeCount = MyAreaMelee.transform.childCount;
                        mySiegeAumCount = MyAreaSiegeAumento.transform.childCount;
                        myRangeAumCount = MyAreaRangeAumento.transform.childCount;
                        myMeleeAumCount = MyAreaMeleeAumento.transform.childCount;
                        myClimaCount = MyAreaClima.transform.childCount;
                    }
                }  
                if(IsPlayer1Turn == false)
                {

                    Player1Hand.SetActive(false);
                    Player2Hand.SetActive(true);
                    PassP1Button.SetActive(false);
                    PassP2Button.SetActive(true);
                    if(EnemyAreaSiege.transform.childCount != enemySiegeCount || EnemyAreaRange.transform.childCount != enemyRangeCount || EnemyAreaMelee.transform.childCount != enemyMeleeCount || EnemyAreaSiegeAumento.transform.childCount != enemySiegeAumCount || EnemyAreaRangeAumento.transform.childCount != enemyRangeAumCount || EnemyAreaMeleeAumento.transform.childCount != enemyMeleeAumCount || EnemyAreaClima.transform.childCount != enemyClimaCount)
                    {
                        Debug.Log("Cambio de turno");
                        IsPlayer1Turn = true;
                        enemySiegeCount = EnemyAreaSiege.transform.childCount;
                        enemyRangeCount = EnemyAreaRange.transform.childCount;
                        enemyMeleeCount = EnemyAreaMelee.transform.childCount;
                        enemySiegeAumCount = EnemyAreaSiegeAumento.transform.childCount;
                        enemyRangeAumCount = EnemyAreaRangeAumento.transform.childCount;
                        enemyMeleeAumCount = EnemyAreaMeleeAumento.transform.childCount;
                        enemyClimaCount = EnemyAreaClima.transform.childCount;
                    }   
                }
            }
        

        else if(TurnoP1.isPlayingP1 == true && TurnoP2.isPlayingP2 == false)
        {
            Player1Hand.SetActive(true);
            Player2Hand.SetActive(false);
            PassP1Button.SetActive(true);
            PassP2Button.SetActive(false);
        }
        
        else if(TurnoP1.isPlayingP1 == false && TurnoP2.isPlayingP2 == true)
        {
            Player1Hand.SetActive(false);
            Player2Hand.SetActive(true);
            PassP1Button.SetActive(false);
            PassP2Button.SetActive(true);
        }
        else if(TurnoP1.isPlayingP1 == false && TurnoP2.isPlayingP2 == false) //SI AMBOS JUGADORES PASARON TURNO ENTONCES SE ACABA LA RONDA
        {
            Player1Hand.SetActive(false);
            Player2Hand.SetActive(false);
            PassP1Button.SetActive(false);
            PassP2Button.SetActive(false);
            
            Debug.Log("RONDA TERMINADA");
            int p1score = int.Parse(Player1Score.text);
            int p2score = int.Parse(Player2Score.text);

            if(p1score != p2score)
            {
                GameObject Texto = Instantiate(TextoEntreRondas, new Vector3(0,0,0), Quaternion.identity);
                Texto.transform.SetParent(GameObject.FindWithTag("GameBoard").transform, false);
                Texto.tag = "rondasTxt";
                LimpiarEscena();
                Player1Hand.SetActive(false);
                Player2Hand.SetActive(false);
                
                if(p1score > p2score)
                {
                    Texto.transform.GetChild(0).GetComponent<Text>().text = "PLAYER 1 GANO LA RONDA";
                    P1Rondas++;
                    IsPlayer1Turn = true;
                    
                }
                else
                {
                    Texto.transform.GetChild(0).GetComponent<Text>().text = "PLAYER 2 GANO LA RONDA";
                    P2Rondas++;
                    IsPlayer1Turn = false;
                }
            
                TurnoP1.isPlayingP1 = true;
                TurnoP2.isPlayingP2 = true;

                for(int i = 0; i < 2; i++)
                {
                    int a = Random.Range(0, deckReligion.Count);
                    int b = Random.Range(0, deckCiencia.Count);
                    
                    Carta randCard = deckReligion[a];
                    Carta player1Card = Instantiate(randCard, new Vector3(0,0,0), Quaternion.identity);
                    player1Card.transform.SetParent(Player1Hand.transform, false);
                    deckReligion.Remove(deckReligion[a]);
                    
                    randCard = deckCiencia[b];
                    Carta player2Card = Instantiate(randCard, new Vector3(0,0,0), Quaternion.identity);
                    player2Card.transform.SetParent(Player2Hand.transform, false);
                    deckCiencia.Remove(deckCiencia[b]);
                
                }
            }
            else
            {
                GameObject Texto = Instantiate(TextoEntreRondas, new Vector3(0,0,0), Quaternion.identity);
                Texto.transform.SetParent(GameObject.FindWithTag("GameBoard").transform, false);
                Texto.tag = "rondasTxt";
                Texto.transform.GetChild(0).GetComponent<Text>().text = "EMPATE";
                P1Rondas++;
                P2Rondas++;
                LimpiarEscena();
                IsPlayer1Turn = false;  
                TurnoP1.isPlayingP1 = true;
                TurnoP2.isPlayingP2 = true;
            
                for(int i = 0; i < 2; i++)
                {
                    int a = Random.Range(0, deckReligion.Count);
                    int b = Random.Range(0, deckCiencia.Count);
                    
                    Carta randCard = deckReligion[a];
                    Carta player1Card = Instantiate(randCard, new Vector3(0,0,0), Quaternion.identity);
                    player1Card.transform.SetParent(Player1Hand.transform, false);
                    deckReligion.Remove(deckReligion[a]);
                    
                    randCard = deckCiencia[b];
                    Carta player2Card = Instantiate(randCard, new Vector3(0,0,0), Quaternion.identity);
                    player2Card.transform.SetParent(Player2Hand.transform, false);
                    deckCiencia.Remove(deckCiencia[b]);
                
                }
            }
            
        }

        if (GameObject.FindWithTag("rondasTxt") != null && GameObject.FindWithTag("rondasTxt").activeSelf && (P1Rondas != 2 && P2Rondas != 2) && Input.GetMouseButton(1))
        {
            GameObject.FindWithTag("rondasTxt").SetActive(false);
        }

        if(P1Rondas == 2 && P2Rondas == 2)
        {
            GameObject.FindWithTag("rondasTxt").transform.GetChild(0).GetComponent<Text>().text = "PARTIDA EMPATADA";
            GameObject.FindWithTag("rondasTxt").transform.GetChild(1).gameObject.SetActive(false);
            Player1Hand.SetActive(false);
            Player2Hand.SetActive(false);
            PassP1Button.SetActive(false);
            PassP2Button.SetActive(false);
            LimpiarEscena();
            sonidoEmpate.Play();
            P1Rondas = 0;
            P2Rondas = 0;

        }
        
        else if(P1Rondas == 2)
        {
            GameObject.FindWithTag("rondasTxt").transform.GetChild(0).GetComponent<Text>().text = "PLAYER 1 GANO LA PARTIDA";
            GameObject.FindWithTag("rondasTxt").transform.GetChild(1).gameObject.SetActive(false);
            Player1Hand.SetActive(false);
            Player2Hand.SetActive(false);
            PassP1Button.SetActive(false);
            PassP2Button.SetActive(false);
            LimpiarEscena();
            sonidoGanaste.Play();
            P1Rondas = 0;
            P2Rondas = 0;
        }
        else if(P2Rondas == 2)
        {
            GameObject.FindWithTag("rondasTxt").transform.GetChild(0).GetComponent<Text>().text = "PLAYER 2 GANO LA PARTIDA";
            GameObject.FindWithTag("rondasTxt").transform.GetChild(1).gameObject.SetActive(false);
            Player1Hand.SetActive(false);
            Player2Hand.SetActive(false);
            PassP1Button.SetActive(false);
            PassP2Button.SetActive(false);
            LimpiarEscena();
            sonidoGanaste.Play();
            P1Rondas = 0;
            P2Rondas = 0;
        }

        
    }

}