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
                ObjectDescription.GetComponent<Text>().text = "Diagonal sisikubus adalah ruas garis yang  menghubungkan dua titik sudut sebidang dan saling berhadapan pada sebuah sisi kubus, dan memiliki 12 diagonal sisi yang berukuran sama panjang.\n\nAC = BD = EG = HF = AF = BE = CH = DG = AH = DE = BG = CF.";
            }
            if (name == "2")
            {
                ObjectTitle.GetComponent<Text>().text = "Diagonal Ruang";
                ObjectDescription.GetComponent<Text>().text = "Diagonal ruang kubus adalah ruas garis yang menghubungkan dua titik sudut yang tidak sebidang dan diagonal ruang kubus berpotongan di tengah-tengah kubus.\n\nPanjang diagonal ruang AG = BH = CE = DF terdapat 4 buah diagonal ruang pada sebuah kubus dengan panjang sama.";
            }
            if (name == "3")
            {
                ObjectTitle.GetComponent<Text>().text = "Bidang Diagonal";
                ObjectDescription.GetComponent<Text>().text = "Bidang diagonal kubus adalah bidang yang memuat dua rusuk berhadapan dalam suatu kubus (melalui diagonal ruang).\n\nBidang diagonal kubus berbentuk persegi.Terdapat 6 buah bidang diagonal, yaitu:\nACGE, BDHF, ABGH, CDEF, ADGF, BCHE";
            }

        }
    }
}
