using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class materialchange : MonoBehaviour {
    Material mat;
    // Use this for initialization
    void Start()
    {
        mat = FindObjectOfType<MeshRenderer>().material;
        gameObject.GetComponentInChildren<MeshRenderer>().material = mat;

        int numOfChildren = transform.childCount;
        for (int i = 0; i < numOfChildren; i++)
        {
            GameObject child = transform.GetChild(i).gameObject;
            child.GetComponent<MeshRenderer>().material = mat;
        }
    }

        // Update is called once per frame
        void Update () {
		
	    }
}
