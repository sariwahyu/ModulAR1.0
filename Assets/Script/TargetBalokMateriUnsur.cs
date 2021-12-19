using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class TargetBalokMateriUnsur : MonoBehaviour
{
    public Transform TextInstruction;
    public Transform ObjectTitle;
    public Transform ObjectDescription;

    void Update()
    {
        StateManager statemanager = TrackerManager.Instance.GetStateManager();
        IEnumerable<TrackableBehaviour> tbs = statemanager.GetActiveTrackableBehaviours();

        foreach (TrackableBehaviour trackbehaviour in tbs)
        {
            string name = trackbehaviour.TrackableName;
            ImageTarget imagetarget = trackbehaviour.Trackable as ImageTarget;

            Vector2 size = imagetarget.GetSize();

            Debug.Log("Active image target:" + name + " -size: " + size.x + ", " + size.y);

            TextInstruction.gameObject.SetActive(false);

            if (name == "1")
            {
                ObjectTitle.GetComponent<Text>().text = "Sisi Balok";
                ObjectDescription.GetComponent<Text>().text = "Sisi Balok adalah bidang yang membatasi balok.";
            }
            if (name == "2")
            {
                ObjectTitle.GetComponent<Text>().text = "Rusuk Balok";
                ObjectDescription.GetComponent<Text>().text = "Rusuk Balok adalah garis potong antara dua sisi bidang balok.";
            }
            if (name == "3")
            {
                ObjectTitle.GetComponent<Text>().text = "Sudut Balok";
                ObjectDescription.GetComponent<Text>().text = "Titik sudut adalah titik potong antara dua atau tiga rusuk.";
            }
        }
    }
}
