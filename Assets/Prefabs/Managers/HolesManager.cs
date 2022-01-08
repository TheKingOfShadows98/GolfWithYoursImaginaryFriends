using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolesManager : MonoBehaviour
{
    public static HolesManager Instance;
    [SerializeField] private List<HoyoCC> Holes;
    [SerializeField] private int currentHoleIndex = 0;

    public HoyoCC GetCurrentHole() => Holes[currentHoleIndex];
    void Awake()
    {
        Instance = Instance ? Instance : this;
    }

    public void NextHole(GameObject _bolita)
    {
        currentHoleIndex = currentHoleIndex + 1 < Holes.Count ? currentHoleIndex + 1 : Holes.Count - 1;
        Holes[currentHoleIndex].Spawn(_bolita);
        _bolita.GetComponent<BolitaCC>().hole = Holes[currentHoleIndex];
    }
}
