using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Pour acheter Seed3
/// </summary>
public class Button3 : MonoBehaviour
{
    [SerializeField] private Inventory _inventory;
    [SerializeField] private SeedDirectory _seedDirectory;

    public void OnClick()
    {
        if (_inventory.Money >= _seedDirectory.Seed3._purchaseValue)
        {
            _inventory.Money -= _seedDirectory.Seed3._purchaseValue;
            _inventory.NumberSeed3 += 1;
        }
    }
}
