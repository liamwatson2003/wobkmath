using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    public GameObject test1;
    public GameObject test2;
    public GameObject test3;
    public GameObject test4;
    public GameObject test5;
    public float Amount = 0;
    public bool MoveAway = false;
    public bool KeepOriginalFacing = false;
    public float Velocity1 = 0;
    public float Velocity2 = 0;

    public float timer;
    public float timerreset;
    public bool rotationswitch = true;

    // Use this for initialization
    void Start () {
        timer = timerreset;

    }
	
	// Update is called once per frame
	void Update () {
        // Velocity1 += 9.81f * Time.deltaTime;
        // wobkmath.Instance.Gravity(test1.transform, 1, Velocity1,10);

        //Velocity2 += 9.81f * Time.deltaTime;
        //wobkmath.Instance.Gravity(test2.transform, 2, Velocity2,5);

        wobkmath.Instance.HomingMissile(test1.transform, test2.transform, 5, 4f);
        wobkmath.Instance.HomingMissile(test3.transform, test2.transform, 5, 4f);
        wobkmath.Instance.HomingMissile(test4.transform, test2.transform, 5, 4f);
        wobkmath.Instance.HomingMissile(test5.transform, test2.transform, 5, 4f);

        //wobkmath.Instance.MoveTowards(test1.transform, test2.transform, 1, false, false);


        //Debug.Log(wobkmath.Instance.GetMag(test1.transform, test2.transform));
        timer -= Time.deltaTime;
            if (rotationswitch == true)
            {
            
            test1.transform.Rotate(0, -2f, 0);
            test3.transform.Rotate(0, 2f, 0);
            test4.transform.Rotate(0, -2f, 0);
            test5.transform.Rotate(0, 2f, 0);

        }

            else if (rotationswitch == false)
            {

            test1.transform.Rotate(0, 2f, 0);
            test3.transform.Rotate(0, -2f, 0);
            test4.transform.Rotate(0, 2f, 0);
            test5.transform.Rotate(0, -2f, 0);

        }

        if (timer < 0)
        {
            rotationswitch = !rotationswitch;
            timer = timerreset;

        }
        
        
    }
}
