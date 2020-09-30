//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TestButtonBehaviour : MonoBehaviour
{
    //public TMP_Text sceneLabel;
    public TMP_Text LivesLabel;
    public TMP_Text ScoreLabel;
    public void OnTestButtonPressed()
    {
        Debug.Log("TestButton Pressed");
        LivesLabel.rectTransform.position = new Vector3(370f, -105f, 0.0f);
        ScoreLabel.rectTransform.anchoredPosition = new Vector3(-349f, -105f, 0.0f);
    }
}
