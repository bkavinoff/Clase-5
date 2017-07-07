using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Persona
/// </summary>
public class Persona
{
    private string nombre;

    public Persona(string name)
    {
        this.nombre = name;
    }

    //PROPIEDAD es un set y get (acceso) de variables o atributos
    public string Nombre {
        get {
            return this.nombre;
        }
        set {
            this.nombre = value;
        }
    }
}