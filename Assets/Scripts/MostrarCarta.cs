using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MostrarCarta : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject Img;
    private AudioSource sonidoDeMostrar;

    void Start()
    {
        sonidoDeMostrar = GameObject.FindWithTag("MainCamera").GetComponent<AudioSource>();
    }
    
    
    public void OnPointerEnter(PointerEventData eventData)
    {
        gameObject.transform.localScale = new Vector3(1.3f,1.3f,1);
        GameObject img = Instantiate(Img, new Vector3(350,0,0), Quaternion.identity);
        img.transform.localScale = new Vector3(4.5f,4.5f,1);
        img.transform.SetParent(GameObject.FindWithTag("GameBoard").transform, false);
        img.tag = "IMG";
        sonidoDeMostrar.Play();

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        gameObject.transform.localScale = new Vector3(1,1,1);
        Destroy(GameObject.FindWithTag("IMG"));
    }

    void Update()
    {
        if(Input.GetMouseButton(0) && GameObject.FindWithTag("IMG") != null )
        {
            Destroy(GameObject.FindWithTag("IMG"));
        }
    }

}
