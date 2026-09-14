using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioArray : MonoBehaviour
{
    public GameObject[] cubitos;

    // Contador para el ejercicio 3 (desactivar de primero a último)
    private int contadora = 0;

    // Contador para el ejercicio 4 (desactivar de último a primero)
    private int contadoraInversa;

    // Contador para el ejercicio 5 (activar de primero a último)
    private int contadorActivar = 0;

    void Start()
    {
        /* ---------- EJERCICIO 1 ----------
         Desactivar el primer elemento del array al iniciar la escena
         DesactivarPrimerElemento(cubitos);

         ---------- EJERCICIO 2 ----------
         Desactivar todos los elementos del array al iniciar la escena
         DesactivarTodosLosElementos(cubitos);

         Inicializa el contador inverso (usado en el ejercicio 4)
         contadoraInversa = cubitos.Length - 1;

         ---------- EJERCICIO 5 ----------
         Arranca con todo desactivado, para después ir activando de a uno
        DesactivarTodosLosElementos(cubitos);
    }
*/
    void Update()
    {
        /* ---------- EJERCICIO 3 ----------
         Desactivar de a uno, del primero al último, con la tecla D
        
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (contadora < cubitos.Length)
            {
                cubitos[contadora].SetActive(false);
                contadora++;
            }
            else
            {
                Debug.Log("Ya se desactivaron todos los elementos (orden normal)");
            }
        }
        */

        /* ---------- EJERCICIO 4 ----------
         Desactivar de a uno, del último al primero, con la tecla A
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (contadoraInversa >= 0)
            {
                cubitos[contadoraInversa].SetActive(false);
                contadoraInversa--;
            }
            else
            {
                Debug.Log("Ya se desactivaron todos los elementos (orden inverso)");
            }
        }
        */

        // ---------- EJERCICIO 5 ----------
        // Activar de a uno, del primero al último, con la tecla D
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (contadorActivar < cubitos.Length)
            {
                cubitos[contadorActivar].SetActive(true);
                contadorActivar++;
            }
            else
            {
                Debug.Log("Ya se activaron todos los elementos");
            }
        }
    }

    // ---------- EJERCICIO 1 ----------
    void DesactivarPrimerElemento(GameObject[] arr)
    {
        if (arr.Length > 0)
        {
            arr[0].SetActive(false);
        }
        else
        {
            Debug.Log("El array esta vacio");
        }
    }

    // ---------- EJERCICIO 2 ----------
    void DesactivarTodosLosElementos(GameObject[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i].SetActive(false);
        }
    }
}