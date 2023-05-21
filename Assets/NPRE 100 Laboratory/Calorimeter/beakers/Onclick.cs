using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onclick : MonoBehaviour
{
    public GameObject beaker0;
    public GameObject beakeron;
    public GameObject beakeroff;
    public GameObject placeholder;
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnMouseDown()
    {
       // Debug.Log("option");
        beakeroff.SetActive(false);
        beaker0.SetActive(false);
        beakeron.SetActive(true);
        beakeron.transform.localPosition = placeholder.transform.localPosition;
        panel.SetActive(false);
        panel.GetComponent<Panel>().curr_beaker = beakeron;
    }
}
