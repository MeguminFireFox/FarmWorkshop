using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Gère l'inventaire
/// </summary>
public class Inventory : MonoBehaviour
{
    [field : SerializeField] public int Money { get; set; }
    [field : SerializeField] public int NumberSeed1 { get; set; }
    [field : SerializeField] public int NumberSeed2 { get; set; }
    [field : SerializeField] public int NumberSeed3 { get; set; }
    [field : SerializeField] public int NumberSeed4 { get; set; }

    [SerializeField] private DayNight _dayNight;
    [SerializeField] private SeedDirectory _seedDirectory;

    private GameObject _object;
    private GameObject _object2;
    private GameObject _object3;
    private GameObject _object4;

    void Update()
    {
        _object = GameObject.Find("Square(Clone)");
        _object2 = GameObject.Find("Square 1(Clone)");
        _object3 = GameObject.Find("Square 2(Clone)");
        _object4 = GameObject.Find("Square 3(Clone)");

        if (_dayNight.Hour2 == true)
        {
            if (_object != null)
            {
                Money += _seedDirectory.Seed1._sellValue;
                Destroy(_object);
            }
            if (_object2 != null)
            {
                Money += _seedDirectory.Seed2._sellValue;
                Destroy(_object2);
            }
            if (_object3 != null)
            {
                Money += _seedDirectory.Seed3._sellValue;
                Destroy(_object3);
            }
            if (_object4 != null)
            {
                Money += _seedDirectory.Seed4._sellValue;
                Destroy(_object4);
            }
        }
    }
}
