using UnityEngine;
using UnityEngine.UI;

public class DynamicUIAdjuster : MonoBehaviour
{
    //public RectTransform learnMoreTextRect;
    public RectTransform playPauseButtonRect;

    public GameObject text;
    
   // public Text learnMoreText;

    private void Start()
    {
        AdjustUIElements();
    }

    private void AdjustUIElements()
    {
        // Adjust based on screen size
        float screenRatio = (float)Screen.width / Screen.height;
        
        //Get rect transform of text and adjust size
        RectTransform learnMoreTextRect = text.GetComponent<RectTransform>();
        learnMoreTextRect.sizeDelta = new Vector2(screenRatio * 100f, 50f);
        
        playPauseButtonRect.sizeDelta = new Vector2(screenRatio * 100f, 50f);

        //Get the text component from the text object and adjust font size
        var learnMoreText = text.GetComponent<Text>();
        learnMoreText.fontSize = (int)(screenRatio * 100f);
    }
}

