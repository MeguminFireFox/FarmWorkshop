using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Seed", menuName = "NewSeed")]
public class SeedData : ScriptableObject
{
    public int _purchaseValue;
    public int _sellValue;
}
