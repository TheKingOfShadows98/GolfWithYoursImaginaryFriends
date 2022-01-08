using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetAreaCC : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            HolesManager.Instance.GetCurrentHole().Spawn(other.gameObject);
        }
    }
}
