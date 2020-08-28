using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AppleScore : MonoBehaviour
{
    public static int ApplePoints = 0;
    TextMeshProUGUI apple;
    void Start()
    {
        apple = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        apple.text = ("Apples: " + ApplePoints);
    }
}
