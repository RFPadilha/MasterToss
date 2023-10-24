using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AmmoDisplay : MonoBehaviour
{
    System.Random random = new System.Random();
    public static int knivesLeft = 0;
    TextMeshProUGUI score;
    void Start()
    {
        score = GetComponent<TextMeshProUGUI>();
        knivesLeft = 3;
    }

    // Update is called once per frame
    void Update()
    {
        score.text = ("Ammo: " + knivesLeft);
    }
}
