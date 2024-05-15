using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class CartaLider : Carta
{
    public string Efecto;
    public string Faccion;

    public CartaLider(string nombre, string efecto, string faccion) : base(nombre)
    {
        Efecto = efecto;
        Faccion = faccion;
    }

    public override string ToString()
    {
        return $"{Nombre}\t{Efecto}\t{Faccion}";
    }

}

