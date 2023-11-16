using UnityEngine;

public class OpenUrlButton : MonoBehaviour
{
    public string urlToOpen = "http://example.com";

    public void OpenUrl()
    {
        Application.OpenURL(urlToOpen);
    }
}

