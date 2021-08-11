using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisablePlayerAndResetOnTriggerEnter : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.gameObject.SetActive(false);
            other.GetComponent<Rigidbody>().Sleep();
            // Score ++
        }
    }
}