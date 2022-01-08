using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolitaCC : MonoBehaviour
{
    public HoyoCC hole;

    
    [SerializeField] private Rigidbody rig;
    [SerializeField] private GameObject pivote;
    [SerializeField] private AudioSource pop;
    
    private void Update()
    {
        Rotate();
        if (Input.GetButtonDown("Fire2"))
        {
            hole.Spawn(gameObject);
        }
    }
    public void Disparar(float _force)
    {
        hole.AddHit();
        rig.AddForce(transform.forward * _force, ForceMode.Impulse);
        pop.Stop();
        pop.Play();
    }
    private void Rotate()
    {
        var axisX = Input.GetAxis("Mouse X");
        //var axisY = Input.GetAxis("Mouse Y");
        transform.Rotate(new Vector3(0f, axisX,0f));
        //pivote.transform.Rotate(new Vector3(axisY, 0f, 0f));
    }
    public bool IsStopped()
    {
        return rig.velocity == Vector3.zero;
    }
}
