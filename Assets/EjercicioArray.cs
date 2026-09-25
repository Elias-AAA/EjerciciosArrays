using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    public int[] edades = new int[4];
   
    void Start()
    {
        edades[2] = 16;
        SquareOfIndex(edades);
        RandomNumbers(edades, 0, 21);
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            ClearArray(edades);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            SquareOfIndex(edades);
        }
    }

    void ClearArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = 0;
        }
    }

    void SquareOfIndex(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i * i;
        }
    }

    void RandomNumbers(int[] array, int min, int max)
    {
        
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = UnityEngine.Random.Range(min, max);
        }}
    }
