using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StageProgress : MonoBehaviour
{
    TextMeshProUGUI stageText;
    public static int stage = 0;
    void Start()
    {
        stageText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<Target>().numberOfApples > 3)
        {
            stageText.text = ("BOSS");
        }else stageText.text = ("Level: "+ (stage+1));
    }

    

}
