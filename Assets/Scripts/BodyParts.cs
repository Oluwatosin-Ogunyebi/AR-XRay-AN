using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BodyParts : MonoBehaviour
{
    public Image brainImg;
    public Image heartImg;
    public Text text;
    private void Start()
    {
        text.text = "Welcome to Anatomy 101";
    }
    public void OnBrainFound()
    {
        brainImg.color = new Color(1, 1, 1, 1);
    }

    public void OnHeartFound()
    {
        heartImg.color = new Color(1, 1, 1, 1);
    }
}
