using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class connector : MonoBehaviour
{
    public LineRenderer line;
    public GameObject pointa;
    public GameObject pointb;
    // Start is called before the first frame update
    void Start()
    {
        line.positionCount = 2;
    }

    // Update is called once per frame
    void Update()
    {
        line.SetPosition(0, pointa.transform.position);
        line.SetPosition(1, pointb.transform.position);
    }
}
