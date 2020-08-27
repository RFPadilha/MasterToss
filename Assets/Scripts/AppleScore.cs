using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppleScore : MonoBehaviour
{
    public static int ApplePoints = 0;
    Text apple;
    void Start()
    {
        apple = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        apple.text = ("Apples: " + ApplePoints);
    }
}
