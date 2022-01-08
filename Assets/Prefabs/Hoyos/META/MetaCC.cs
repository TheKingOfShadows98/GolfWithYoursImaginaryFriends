using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetaCC : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            HolesManager.Instance.NextHole(other.gameObject);
        }
    }
}
