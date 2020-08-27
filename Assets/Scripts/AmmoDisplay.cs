using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoDisplay : MonoBehaviour
{
    System.Random random = new System.Random();
    public static int knivesLeft = 0;
    
    Text score;
    void Start()
    {
        score = GetComponent<Text>();
        knivesLeft = random.Next(5, 10);//jogador recebe entre 5 e 10 facas para arremessar
    }

    // Update is called once per frame
    void Update()
    {
        score.text = ("Ammo: " + knivesLeft);
    }
}
