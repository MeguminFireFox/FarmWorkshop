using UnityEngine;

/// <summary>
/// Permet de quitter un panel
/// </summary>
public class Back : MonoBehaviour
{
    /// <summary>
    /// Un gameObject pour r�cup�rer un panel et le d�sactiver.
    /// </summary>
    [SerializeField] private GameObject panel;

    public void OnBack()
    {
        panel.SetActive(false);
        Time.timeScale = 1;
    }
}
