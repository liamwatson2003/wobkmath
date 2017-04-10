using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wobkmath : MonoBehaviour {

    //Create the Singleton
    public static wobkmath Instance;

    void Awake()
    {
        Instance = this;
    }


    //wobkmath 
    //This is my scripting API used to shorten math required by games
    #region Vector 3 Math
    //Magnitude Function, takes 2 transforms and returns a float of distance
    public float GetMag(Transform obj1, Transform obj2)
    {
        Vector3 VectorDifference = obj1.position - obj2.position;
        float Distance = VectorDifference.sqrMagnitude;
        return Distance;
    }

    #endregion

}
