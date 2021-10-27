using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class TargetBalokMateriDiagonal : MonoBehaviour
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
                ObjectDescription.GetComponent<Text>().text = "Diagonal bidang atau diagonal sisi adalah garis yang terbentuk jika kita menarik garis lurus pada setiap bidang balok dari titik-titik sudut yang saling berhadapan. Setiap bidang sisi balok memiliki 2 garis diagonal, sehingga dalam sebuah balok terdapat 12 diagonal bidang.\n\nPada balok tersebut, garis-garis diagonal bidang balok yaitu sebagai berikut:\nDiagonal bidang AC = BD = EG = HF\nDiagonal bidang AF = BE = CH = DG\nDiagonal bidang AH = DE = BG = CF";
            }
            if (name == "2")
            {
                ObjectTitle.GetComponent<Text>().text = "Diagonal Ruang";
                ObjectDescription.GetComponent<Text>().text = "Diagonal ruang adalah suatu garis lurus yang menghubungkan antara dua titik sudut yang saling berhadapan di dalam ruangan balok. Sama seperti kubus, setiap balok memiliki 4 buah diagonal ruang.\n\nPada balok tersebut, diagonal ruang balok dapat ditemukan jika kita menarik garis lurus dari:\nTitik B ke titik H\nTitik D ke titik F\nTitik A ke titik G\nTitik E ke titik C";
            }
            if (name == "3")
            {
                ObjectTitle.GetComponent<Text>().text = "Bidang Diagonal";
                ObjectDescription.GetComponent<Text>().text = "Bidang diagonal adalah sebuah bidang yang terbentuk oleh dua garis diagonal bidang sisi dan dua garis rusuk balok yang sejajar. Setiap balok mempunyai 6 buah bidang diagonal yang semuanya berbentuk persegi panjang.\n\nPada balok tersebut, bidang diagonal balok ditunjukan oleh :\nBidang ACGE\nBidang BCHE\nBidang CDEF\nBidang ADGF\nBidang ABGH\nBidang BDHF";
            }

        }
    }
}