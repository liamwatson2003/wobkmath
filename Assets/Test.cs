using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    public GameObject test1;
    public GameObject test2;
    float distance;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        distance = wobkmath.Instance.GetMag(test1.transform, test2.transform);
        Debug.Log(distance);
	}
}
