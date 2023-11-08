using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class z5 : MonoBehaviour
{
   // Instantiates prefabs in a circle formation
   public GameObject prefab;
   public int numberOfObjects = 10;
   private Vector3 planeSize = new Vector3(10, 1, 10);

    void Start()
    {
        for (int i = 0; i < numberOfObjects; i++)
        {
                GenerateCube();
                
        }
    }

        
    void GenerateCube()
    {
            Vector3 randomPosition = new Vector3(
                Random.Range(-planeSize.x / 2, planeSize.x / 2),
                4.0f,
                Random.Range(-planeSize.z / 2, planeSize.z / 2)
            );
            if (Physics.OverlapSphere(randomPosition, 0.5f).Length <= 0)
            {
                Instantiate(prefab, randomPosition, Quaternion.identity);
            }
            else
            {
                GenerateCube();
            }
    }
}