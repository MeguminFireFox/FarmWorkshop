using UnityEngine;

/// <summary>
/// Les mouvement du personnage
/// </summary>
public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed;

    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(x, y);
        transform.Translate(movement * _speed * Time.deltaTime);
    }
}
