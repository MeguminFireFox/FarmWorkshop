using UnityEngine;

public class Plant : MonoBehaviour
{
    [field: SerializeField] public bool Grow { get; set; }
    [SerializeField] private int _typePlant;
    [SerializeField] private Inventory _inventory;
    [SerializeField] private SeedDirectory _seedDirectory;

    private float _collect = 0;

    void Update()
    {
        if (Grow == true)
        {
            _collect += Time.deltaTime;
        }
    }
}
