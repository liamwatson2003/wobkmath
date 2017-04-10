using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    public GameObject test1;
    public GameObject test2;
    public float Amount = 0;
    public bool MoveAway = false;
    public bool KeepOriginalFacing = false;
   

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
            wobkmath.Instance.MoveTowards(test1.transform, test2.transform, Amount, MoveAway, KeepOriginalFacing);
        
	}
}
