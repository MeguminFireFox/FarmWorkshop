using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Pour acheter Seed1
/// </summary>
public class Button1 : MonoBehaviour
{
    [SerializeField] private Inventory _inventory;
    [SerializeField] private SeedDirectory _seedDirectory;

    public void OnClick()
    {
        if (_inventory.Money >= _seedDirectory.Seed1._purchaseValue)
        {
            _inventory.Money -= _seedDirectory.Seed1._purchaseValue;
            _inventory.NumberSeed1 += 1;
        }
    }
}
