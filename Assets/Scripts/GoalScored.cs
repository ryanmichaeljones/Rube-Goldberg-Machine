using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScored : MonoBehaviour {

    public GameObject GoalText;
    public GameObject ExitButton;
    public GameObject ReplayButton;
    public GameObject ExitButton1;
    public GameObject InstructionsText;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.gameObject.name.Contains("Goal net (back)")) 
        {
            GoalText.SetActive(true);
            ExitButton.SetActive(false);
            ReplayButton.SetActive(true);
            ExitButton1.SetActive(true);
            InstructionsText.SetActive(false);
        }
    }
}
