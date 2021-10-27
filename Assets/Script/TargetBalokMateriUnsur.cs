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
                ObjectDescription.GetComponent<Text>().text = "Sisi balok adalah bidang permukaan yang membatasi suatu balok.\n\nSisi bawah(ABCD)\nSisi atas(EFGH)\nSisi depan(ABFE)\nSisi belakang(DCGH)\nSisi samping kiri(BCGF)\nSisi samping kanan(ADHE)\n\nPada sebuah bangun balok, terdapat tiga pasang sisi yang berhadapan dengan bentuk dan ukuran yang sama. Ketiga pasang sisi tersebut adalah yaitu:\nSisi ABFE = DCGH\nSisi ABCD = EFGH\nSisi BCGF = ADHE";
            }
            if (name == "2")
            {
                ObjectTitle.GetComponent<Text>().text = "Rusuk Balok";
                ObjectDescription.GetComponent<Text>().text = "Pada sebuah balok memiliki 12 buah rusuk.\nSetiap bangun balok memiliki tiga buah pasang rusuk yang sama panjang, rusuk - rusuk yang sama panjang pada balok yaitu:\n\nAB = EF = HG = DC \nAE = BF = CG = DH\nAD = EH = FG = BC";
            }
            if (name == "3")
            {
                ObjectTitle.GetComponent<Text>().text = "Sudut Balok";
                ObjectDescription.GetComponent<Text>().text = "Titik sudut balok adalah titik temu atau titik potong ketiga rusuk (titik pojok balok) atau lebih.\n\nPada balok ABCD.EFGH terdapat 8 buah titik sudut yaitu :\nA,  B,  C,  D,  E,  F,  G,  H,";
            }
        }
    }
}
