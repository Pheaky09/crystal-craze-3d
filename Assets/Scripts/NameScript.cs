using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NameScript : MonoBehaviour
{

    public TextMeshProUGUI gameNameText;
    public float animationDuration = 1f;
    public Color startColor;
    public Color endColor;

    private float timer = 0f;

    private void Start()
    {
        gameNameText = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        timer += Time.deltaTime;
        float t = Mathf.PingPong(timer / animationDuration, 1f);
        gameNameText.color = Color.Lerp(startColor, endColor, t);
    }
}


