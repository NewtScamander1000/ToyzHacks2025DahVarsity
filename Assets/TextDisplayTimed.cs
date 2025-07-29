using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextDisplayTimed : MonoBehaviour
{
    float timeText = 0f;
    public TextMeshProUGUI textComp;
    public string[] lines;
    private int index;
    // Start is called before the first frame update
    void Start()
    {
        index = 0;
        InvokeRepeating("NextLine", 36.0f, 5f);
    }
    void Update()
    {
        timeText += Time.deltaTime;
        int roundTime = Mathf.RoundToInt(timeText);
        //Debug.Log(roundTime);
        //Debug.Log(lines[index]);
        textComp.text = lines[index];
    }

    void StartDialogue()
    {
        index = 0;
        //StartCoroutine(TypeLine());
    }

    //IEnumerator TypeLine()
    //{
    //    foreach (char c in lines[index].ToCharArray())
    //    {
    //        textComp.text += c;
    //        yield return new WaitForSeconds(textSpeed);
    //    }
    //}

    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            //textComp.text = string.Empty;
            //StartCoroutine(TypeLine());
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
