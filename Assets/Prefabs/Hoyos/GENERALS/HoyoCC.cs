using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class HoyoCC : MonoBehaviour
{
    public GameObject SpawnPoint;
    [SerializeField] private int hits;
    [SerializeField] private TextMeshPro counter;
    public void AddHit(){ 
        hits++;
        counter.text = $"{hits}";
    }

    public void Spawn(GameObject bolita)
    {
        bolita.transform.position = SpawnPoint.transform.position;
        bolita.transform.rotation = SpawnPoint.transform.rotation;
        bolita.GetComponent<Rigidbody>().velocity = Vector3.zero;
    }
}
