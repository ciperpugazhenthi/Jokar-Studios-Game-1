using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
   public float rotateSpeed;
   public Vector3 rotateDir = new Vector3();
    

    private void Update()
    {
        transform.Rotate(rotateSpeed * rotateDir * Time.deltaTime);

    }

   //// private void OnTriggerEnter(Collider other)
   // {
   //   //  Destroy(gameObject);

   // }
}
