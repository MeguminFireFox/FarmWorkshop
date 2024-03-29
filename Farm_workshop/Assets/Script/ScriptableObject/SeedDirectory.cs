using UnityEngine;

/// <summary>
/// Permet de récupérer les différents scriptableObjects
/// </summary>
public class SeedDirectory : MonoBehaviour
{
    [field : SerializeField] public SeedData Seed1 { get; private set; }
    [field : SerializeField] public SeedData Seed2 { get; private set; }
    [field : SerializeField] public SeedData Seed3 { get; private set; }
    [field : SerializeField] public SeedData Seed4 { get; private set; }
}
