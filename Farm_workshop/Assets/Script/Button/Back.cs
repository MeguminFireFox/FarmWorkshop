using UnityEngine;

/// <summary>
/// Permet de quitter un panel
/// </summary>
public class Back : MonoBehaviour
{
    /// <summary>
    /// Un gameObject pour récupérer un panel et le désactiver.
    /// </summary>
    [SerializeField] private GameObject panel;

    public void OnBack()
    {
        panel.SetActive(false);
        Time.timeScale = 1;
    }
}
