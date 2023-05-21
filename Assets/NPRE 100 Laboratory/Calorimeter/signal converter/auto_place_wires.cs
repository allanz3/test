using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class auto_place_wires : MonoBehaviour
{
    public GameObject placer;
    public GameObject final_pos;
    private float X_min;
    private float X_max;
    private float Z_min;
    private float Z_max;
    private bool is_up;
    // Start is called before the first frame update
    void Start()
    {
        BoxCollider col = placer.GetComponent<BoxCollider>();
        var trans = col.transform;
        var min = col.center - col.size * 0.5f;
        var max = col.center + col.size * 0.5f;
        var P000 = trans.TransformPoint(new Vector3(min.x, min.y, min.z));
        var P001 = trans.TransformPoint(new Vector3(max.x, max.y, max.z));
        X_min = P000.x < P001.x ? P000.x : P001.x;
        X_max = P000.x < P001.x ? P001.x : P000.x;
        Z_min = P000.z < P001.z ? P000.z : P001.z;
        Z_max = P000.z < P001.z ? P001.z : P000.z;
        Rigidbody rb_obj = GetComponent<Rigidbody>();





    }

    // Update is called once per frame
    void Update()
    {
        is_up = (transform.position.x < X_max && transform.position.x > X_min) && (transform.position.z < Z_max && transform.position.z > Z_min);
        if (is_up)
        {
            transform.position = final_pos.transform.position;
            Debug.Log(transform.position);

        }
    }

    public void OnMouseDrag()
    {
        if (is_up)
        {
            final_pos.SetActive(true);
        }

    }

    private void OnMouseUp()
    {
        final_pos.SetActive(false);
        if (is_up)
        {
            transform.position = final_pos.transform.position;
            Debug.Log(transform.position);

        }

    }
}

