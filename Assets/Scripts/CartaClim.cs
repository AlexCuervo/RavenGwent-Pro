    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartaClima : Carta
{
    public string Efecto;

    public CartaClima(string nombre, string efecto) : base(nombre)
    {
        Efecto = efecto;
    }
    
    
}