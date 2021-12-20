using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class TargetSoalLatihan : MonoBehaviour
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
                ObjectTitle.GetComponent<Text>().text = "Perhatikan Kubus Berikut";
                ObjectDescription.GetComponent<Text>().text = "Pertanyaan:\n\na.Diagonal Sisi AC, Sejajar dengan Diagonal Sisi ....\nb.Sisi DCHG berhadapan dengan Sisi....\nc.Rusuk EH sejajar dengan Rusuk, ... , ..., ...";
            }
            if (name == "2")
            {
                ObjectTitle.GetComponent<Text>().text = "Perhatikan Balok Berikut";
                ObjectDescription.GetComponent<Text>().text = "Pertanyaan:\n\na.Berbentuk apakah bidang KMQO?\nb.Sebutkan bidang diagonal yang sama dengan KLQR?\nc.Jika panjang KP = 8 cm.Sebutkan semua diagonal sisi yang panjangnya 8 cm?\nd.Sebutkan diagonal sisi yang panjangnya sama dengan KM?";
            }
        }
    }
}
