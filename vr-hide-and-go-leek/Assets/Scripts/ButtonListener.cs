using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonListener : MonoBehaviour
{   
    public Button FirstButton;
    // Start is called before the first frame update
    void Start()
    {
        FirstButton.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}