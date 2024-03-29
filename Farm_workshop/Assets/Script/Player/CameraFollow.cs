using UnityEngine;

/// <summary>
/// Permet a la Camera de suivre le joueur.
/// </summary>
public class CameraFollow : MonoBehaviour
{
    /// <summary>
    /// Prend la position du joueur.
    /// </summary>
    [SerializeField] private Transform _player;

    void Update()
    {
        Vector3 newPosition = _player.position;
        newPosition.z = transform.position.z;
        transform.position = newPosition;
    }
}
