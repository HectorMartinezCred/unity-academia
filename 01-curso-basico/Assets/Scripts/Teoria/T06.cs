using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T06 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Inicializar tipos arrays
        int[] puntos = new int[10];
        float[] reales = new float[10];
        string[] cadenas = new string[10];
        bool[] logicos = new bool[10];

        // Formas de inicializar un array
        int[] inicializadoA = new int[5] { 1, 2, 3, 4, 5 };
        int[] inicializadoB = new int[] { 1, 2, 3, 4, 5 };
        int[] inicializadoC = { 1, 2, 3, 4, 5 };

        float[] realesInicializado = { 1f, 2f, 3f, 4f, 5f };
        string[] cadenasInicializado = { "Hector", "Junior", "Martinez", "Cervantes" };
        bool[] logicosInicializado = { true, false, true, true };

        // Llamar a un elemento de un array
        Debug.Log(cadenasInicializado[0]);

        // Cambiar el valor de un elemento de un array
        cadenasInicializado[0] = "Cesar";
        Debug.Log(cadenasInicializado[0]);

        // Obtener el número de elementos de un array
        Debug.Log(cadenasInicializado.Length);

    }
}
