using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T07 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Operador de asignación "="
        int puntosMaximos = 100;
        int puntos = 0;
        Debug.Log(puntos);
        Debug.Log(puntosMaximos);

        puntos = 10;
        puntos = 20;
        Debug.Log(puntos);

        puntos = puntosMaximos;
        Debug.Log(puntos);
        Debug.Log(puntosMaximos);

        // Asignación en cadena
        int a = 0, b = 0, c = 0, d = 0;
        a = b = c = 10;
        Debug.Log(a);
        Debug.Log(b);
        Debug.Log(c);
        Debug.Log(d);

        // Operadores aritmeticos "+, -, *, /, %"
        a = 1 + 2 + 3 + 4;
        b = a - 2;
        c = b * 2;
        d = c / 2;
        a = c % d;
        Debug.Log(a);
        Debug.Log(b);
        Debug.Log(c);
        Debug.Log(d);

        string c1 = "Hola ";
        string c2 = "Pepe!";
        string res = c1 + c2;

        Debug.Log(res);

        // Uso de parentesis
        int x = 0;
        x = (3 + 1) * 5;
        Debug.Log(x);

    }
}
