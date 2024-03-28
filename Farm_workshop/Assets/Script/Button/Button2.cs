using UnityEngine;

/// <summary>
/// Pour acheter Seed2
/// </summary>
public class Button2 : MonoBehaviour
{
    [SerializeField] private Inventory _inventory;
    [SerializeField] private SeedDirectory _seedDirectory;

    public void OnClick()
    {
        if (_inventory.Money >= _seedDirectory.Seed2._purchaseValue)
        {
            _inventory.Money -= _seedDirectory.Seed2._purchaseValue;
            _inventory.NumberSeed2 += 1;
        }
    }
}
