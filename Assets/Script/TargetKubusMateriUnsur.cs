using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class TargetKubusMateriUnsur : MonoBehaviour
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
                ObjectTitle.GetComponent<Text>().text = "Sisi Kubus";
                ObjectDescription.GetComponent<Text>().text = "Sisi adalah persegi yang membatasi bangun ruang kubus, dan memiliki 6 buah sisi.\n\nSisi alas = ABCD\nSisi atas = EFGH\nSisi depan = ABFE\nSisi belakang = CDHG\nSisi kiri = ADHE\nSisi kanan = BCGF";
            }
            if(name == "2")
            {
                ObjectTitle.GetComponent<Text>().text = "Rusuk Kubus";
                ObjectDescription.GetComponent<Text>().text = "Rusuk kubus merupakan garis potong antara sisi-sisi kubus.\n\nTerdapat 12 rusuk sama panjang yaitu :\n\nRusuk Alas : AB, BC, CD, AD\nRusuk Tegak: AE, BF, CG, DH\nRusuk Atas: EF, FG, GH, EH.";
            }
            if (name == "3")
            {
                ObjectTitle.GetComponent<Text>().text = "Sudut Kubus";
                ObjectDescription.GetComponent<Text>().text = "Titik sudut kubus adalah titik temu atau titik potong ketiga rusuk (titik pojok kubus) atau lebih.\n\nPada kubus ABCD.EFGH terdapat 8 buah titik sudut yaitu :\n A,  B,  C,  D,  E,  F,  G,  H";
            }

        }
    }
}
