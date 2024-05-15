using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class CartaUnidad : Carta
{
    
    public string Rango;
    public int Poder;
    public string Efecto;
    public string Clase;
    public string Faccion;
    public bool afectadaPorClimaP1 = false;
    public bool afectadaPorClimaP2 = false;

    public CartaUnidad(string nombre, string rango, int poder, string efecto, string clase, string faccion) : base(nombre)
    {
        Rango = rango;
        Poder = poder;
        Efecto = efecto;
        Clase = clase;
        Faccion = faccion;
    }
    


}