using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class AspectRatioScaler : MonoBehaviour
{
    private Image imageComponent;
    public float originalWidth = 490f;  // Original width of your image
    public float originalHeight = 620f; // Original height of your image

    void Start()
    {
        imageComponent = GetComponent<Image>();
        ScaleImage();
    }

    [ContextMenu("Scale Image")]
    public void ScaleImage()
    {
        // Calculate the scale ratio based on screen width
        float scaleRatio = Screen.width / originalWidth;

        // Set the image width to screen width
        float newWidth = Screen.width;

        // Set the image height based on the scale ratio
        float newHeight = originalHeight * scaleRatio;

        // Apply the new width and height to the image's RectTransform
        imageComponent.rectTransform.sizeDelta = new Vector2(newWidth, newHeight);
    }
}

