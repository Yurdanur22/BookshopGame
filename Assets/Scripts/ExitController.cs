using UnityEngine;
using UnityEngine.UI;

public class ExitController : MonoBehaviour
{
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Oyundan çıkıldı");
    }
}
