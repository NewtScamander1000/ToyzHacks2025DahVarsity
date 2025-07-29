using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextDis2 : MonoBehaviour
{
    float timeText = 0f;
    public TextMeshProUGUI textComp;
    // Start is called before the first frame update
    void Start()
    {
    }
    void Update()
    {
        timeText += Time.deltaTime;
        if (timeText > 30)
        {
            textComp.text = "Mission Started!";
        }
    }

}
