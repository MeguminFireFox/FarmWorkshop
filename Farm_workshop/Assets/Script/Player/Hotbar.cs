using UnityEngine;

/// <summary>
/// Permet de choisir entre les différentes graines.
/// </summary>
public class Hotbar : MonoBehaviour
{
    /// <summary>
    /// Un int pour savoir sur quel touche on appuis.
    /// </summary>
    [SerializeField] public int Choice {  get; private set; }

    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            Choice = 1;
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            Choice = 2;
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            Choice = 3;
        }
        if (Input.GetKey(KeyCode.Alpha4))
        {
            Choice = 4;
        }
    }
}
