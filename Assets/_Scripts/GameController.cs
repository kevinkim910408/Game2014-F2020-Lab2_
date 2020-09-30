using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    //public TMP_Text sceneLabel;
    public TMP_Text LivesLabel;
    public TMP_Text ScoreLabel;

    // Update is called once per frame
    void Update()
    {
        switch(Input.deviceOrientation)
        {
            case DeviceOrientation.LandscapeLeft:
                LivesLabel.rectTransform.anchoredPosition = new Vector2(370f, -105f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(-349f, -105f);
                break;

            case DeviceOrientation.LandscapeRight:
                LivesLabel.rectTransform.anchoredPosition = new Vector2(248f, -105f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(-490f, -105f);
                break;

            case DeviceOrientation.Portrait:
                LivesLabel.rectTransform.anchoredPosition = new Vector2(248f, -185f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(-349f, -185f);
                break;

            case DeviceOrientation.Unknown:
                break;
        }
    }

  
}
