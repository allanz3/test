using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temperaturesensor : MonoBehaviour
{

    public bool is_connected;
    private float Tempratur;
    public GameObject panel;
    public GameObject display;
    // Start is called before the first frame update
    void Start()
    {
            display.GetComponent<TMPro.TextMeshProUGUI>().text = "Not connected";

    }

    // Update is called once per frame
    void Update()
    {
        if(!is_connected)
            {
            display.GetComponent<TMPro.TextMeshProUGUI>().text = "Not connected";
            }
        else
        {
            display.GetComponent<TMPro.TextMeshProUGUI>().text = Tempratur.ToString();
        }
 
    }
}
