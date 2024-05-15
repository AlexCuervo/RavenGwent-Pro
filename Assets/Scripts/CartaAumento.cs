using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartaAumento : Carta
{
    public string Efecto;

    public CartaAumento(string nombre, string efecto) : base(nombre)
    {
        Efecto = efecto;
    }

    public override string ToString()
    {
        return $"{Nombre}\t{Efecto}";
    }
}