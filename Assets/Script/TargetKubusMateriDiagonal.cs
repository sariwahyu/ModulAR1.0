using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class TargetKubusMateriDiagonal : MonoBehaviour
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
                ObjectTitle.GetComponent<Text>().text = "Diagonal Bidang/Sisi";
                ObjectDescription.GetComponent<Text>().text = "Diagonal Sisi adalah ruas garis yang menghubungkan dua titik sudut yang berhadapan pada setiap bidang atau sisi kubus.";
            }
            if (name == "2")
            {
                ObjectTitle.GetComponent<Text>().text = "Diagonal Ruang";
                ObjectDescription.GetComponent<Text>().text = "Diagonal ruang adalah garis yang menghubungkan dua titik sudut yang saling berhadapan dalam satu ruang.";
            }
            if (name == "3")
            {
                ObjectTitle.GetComponent<Text>().text = "Bidang Diagonal";
                ObjectDescription.GetComponent<Text>().text = "Bidang diagonal adalah bidang yang dibentuk dari dua garis diagonal bidang dan dua rusuk kubus yang sejajar.";
            }

        }
    }
}
