using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T05 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Tipos de datos:

        // Números enteros: int
        // 1, 4, 10, -5, -1000, 0, etc

        // Números reales: float
        // 3.14159f, 0.5f, 99.99f, -45.75f, etc.

        // Cadenas de texto: string
        // "¡Hola mundo!", "Antonio", "Maria", etc.

        // Valores logicos: bool
        // true, false.

        // Ejemplos de declaración
        int puntos = 0;
        float notaExamen = 9.75f;
        string nombreJugador = "BrushBrosh";
        bool personajeVivo = true;

        Debug.Log(puntos);
        Debug.Log(notaExamen);
        Debug.Log(nombreJugador);
        Debug.Log(personajeVivo);

        string mensaje = "Este es \\ un mensaje \"especial\"\nEsta es una nueva linea";
        Debug.Log(mensaje);

        // Para definir variables del mismo tipo
        // int edadManolo = 20, edadPaco = 18, edadLuis = 21;

        // Modificar el contenido de una variable
        puntos = 100;
        Debug.Log(puntos);

        // Modificar el contenido de una variable
        puntos = 200;
        Debug.Log(puntos);

        // Ambitos de las variables
        {
            int a = 0;
            Debug.Log(a);
            {
                int b = 1;
                Debug.Log(b);
            }
            // Aquí la variable a no existe por lo que esta linea de código no funciona
            // Debug.Log(b);
        }
        // Aquí la variable a no existe por lo que esta linea de código no funciona
        // Debug.Log(a);

    }
}
