using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Carta : MonoBehaviour
{
    public string Nombre { get; protected set; }
   
    public Carta(string Nombre)
    {
        this.Nombre = Nombre;
    }

   

}

