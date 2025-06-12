using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialPopup : MonoBehaviour
{
    public GameObject tutorialPanel;
    public float displayTime = 5f;

    void Start()
    {
        StartCoroutine(ShowTutorial());

    }

    IEnumerator ShowTutorial()
    {
        tutorialPanel.SetActive(true);
        yield return new WaitForSeconds(displayTime);
        tutorialPanel.SetActive(false);
    }
 
}
