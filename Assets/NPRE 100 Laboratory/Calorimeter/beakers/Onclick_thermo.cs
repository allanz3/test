using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onclick_thermo : MonoBehaviour
{
    public GameObject thermo;
    //public GameObject final_thermo;
    public GameObject panel;
    private GameObject beaker;
    public GameObject temp_sensor;
    private int count;
    // Start is called before the first frame update
    void Start()
    {
        beaker = panel.GetComponent<Panel>().curr_beaker;
        thermo = beaker.transform.Find("wire").gameObject;
        thermo.SetActive(false);
        count = 0;

    }

    // Update is called once per frame
    void Update()
    {
        beaker = panel.GetComponent<Panel>().curr_beaker;
        thermo = beaker.transform.Find("wire").gameObject;
        if (beaker.activeSelf == true)
        {
            if (count % 2 == 0)
            {
                thermo.SetActive(false);
                temp_sensor.GetComponent<temp_sensor>().is_connected = false;
            }
            if (count % 2 != 0)
            {
                thermo.SetActive(true);
                temp_sensor.GetComponent<temp_sensor>().is_connected = true;
            }
        }
        else
        {
            thermo.SetActive(false);
        }
    }
    private void OnMouseDown()
    {
        count += 1;

        //thermo.transform.position = final_thermo.transform.position;
    }
}
