using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{

    public GameObject playerCam;

    public GameObject MainCam;

    public GameObject firstPersonCam;

    // public GameObject cam1;

    // Start is called before the first frame update
    void Start()
    {
        playerCam.SetActive(false);
        MainCam.SetActive(true);
        firstPersonCam.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Switch1")) {
            playerCam.SetActive(true);
            MainCam.SetActive(false);
            firstPersonCam.SetActive(false);
        }
        
        if (Input.GetButtonDown("Switch2")) {
            playerCam.SetActive(false);
            MainCam.SetActive(true);
            firstPersonCam.SetActive(false);
        }

        if (Input.GetButtonDown("Switch3")) {
            playerCam.SetActive(false);
            MainCam.SetActive(false);
            firstPersonCam.SetActive(true);
        }
    }
}
