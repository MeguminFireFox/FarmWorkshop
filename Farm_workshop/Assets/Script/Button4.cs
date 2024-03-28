using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Pour acheter Seed4
/// </summary>
public class Button4 : MonoBehaviour
{
    [SerializeField] private Inventory _inventory;
    [SerializeField] private SeedDirectory _seedDirectory;

    public void OnClick()
    {
        if (_inventory.Money >= _seedDirectory.Seed4._purchaseValue)
        {
            _inventory.Money -= _seedDirectory.Seed4._purchaseValue;
            _inventory.NumberSeed4 += 1;
        }
    }
}
