using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Pour changer de scène.
/// </summary>
public class Scene : MonoBehaviour
{
    /// <summary>
    /// Un string pour marquer vers quel scène on veut aller.
    /// </summary>
    [SerializeField] private string _scenename;

    public void ChangeScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(_scenename);
    }
}
