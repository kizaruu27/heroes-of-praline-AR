using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureScreen : MonoBehaviour
{
    public GameObject CapturePanel;
    
    public void OnClickScreenshot()
    {
        Invoke("Screenshot", 0.25f);
    }

    void Screenshot()
    {
        StartCoroutine(TakeScreenshot());
    }
    
    
    
    IEnumerator TakeScreenshot()
    {
        yield return new WaitForEndOfFrame();

        Texture2D screenImage = new Texture2D(Screen.width, Screen.height);
        
        
        screenImage.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
        screenImage.Apply();

        byte[] imageBytes = screenImage.EncodeToPNG();

        NativeGallery.SaveImageToGallery(imageBytes, "Heroes of Praline", "Screenshots.png", null);

        yield return new WaitForSeconds(0.5f);
        
        CapturePanel.SetActive(true);
    }
}
