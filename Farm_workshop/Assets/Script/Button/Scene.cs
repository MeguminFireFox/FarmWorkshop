using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Pour changer de sc�ne.
/// </summary>
public class Scene : MonoBehaviour
{
    /// <summary>
    /// Un string pour marquer vers quel sc�ne on veut aller.
    /// </summary>
    [SerializeField] private string _scenename;

    public void ChangeScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(_scenename);
    }
}
