using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerCC : MonoBehaviour
{
    [SerializeField]Vector2 umbralFuerza;
    [SerializeField] float fuerza;
    [SerializeField] float sensivity;
    [SerializeField] BolitaCC bolitaCC;

    [SerializeField] Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        slider.minValue = umbralFuerza.x;
        slider.maxValue = umbralFuerza.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && bolitaCC.IsStopped())
        {
            bolitaCC.inFocus = true;
            fuerza += Input.GetAxis("Mouse Y") * sensivity;
            fuerza = fuerza > umbralFuerza.y ? umbralFuerza.y :
                fuerza < umbralFuerza.x ? umbralFuerza.x : fuerza;
            slider.value = fuerza;
        }
        if (Input.GetButtonUp("Fire1") && bolitaCC.IsStopped())
        {
            bolitaCC.inFocus = false;
            if (fuerza > 0)
            bolitaCC.Disparar(fuerza);
            fuerza = 0;
            slider.value = fuerza;
        }
    }
}
