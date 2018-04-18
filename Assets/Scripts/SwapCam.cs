using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapCam : MonoBehaviour {

    public GameObject Cam1;
    public GameObject Cam2;
    public GameObject Cam3;
    public GameObject Cam4;

    // Use this for initialization
    void Start () {

        Cam1.SetActive(true);
        Cam2.SetActive(false);
        Cam3.SetActive(false);
        Cam4.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown (KeyCode.Alpha1))
        {
            Cam1.SetActive(true);
            Cam2.SetActive(false);
            Cam3.SetActive(false);
            Cam4.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Cam2.SetActive(true);
            Cam1.SetActive(false);
            Cam3.SetActive(false);
            Cam4.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Cam3.SetActive(true);
            Cam1.SetActive(false);
            Cam2.SetActive(false);
            Cam4.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Cam4.SetActive(true);
            Cam1.SetActive(false);
            Cam2.SetActive(false);
            Cam3.SetActive(false);
        }

    }
}
