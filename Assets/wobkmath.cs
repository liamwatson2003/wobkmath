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
    public Transform MoveTowards(Transform obj1, Transform obj2, float Amount, bool MoveAwayFrom, bool KeepRotation)
    {
        //used to rotate the object back to its original rotation
        Quaternion old = obj1.transform.rotation;
        

        if (!MoveAwayFrom)
        {
            obj1.transform.LookAt(obj2);
            obj1.transform.Translate(Vector3.forward * Amount * Time.deltaTime);
            if (KeepRotation)
                obj1.rotation = old;
            return obj1.transform;
        }
        else
        {
            obj1.transform.LookAt(obj2);
            obj1.transform.Rotate(0, 180, 0);
            obj1.transform.Translate(Vector3.forward * Amount * Time.deltaTime);
            obj1.transform.Rotate(0, 180, 0);
            if (KeepRotation)
                obj1.rotation = old;
            return obj1.transform;
        }
    }

    //homing missile
    public Transform HomingMissile(Transform Obj, Transform TargetObj, float RocketSpeed, float RocketRotate)
    {

        Obj.transform.rotation = Quaternion.Slerp(Obj.transform.rotation, Quaternion.LookRotation(TargetObj.transform.position - Obj.transform.position), RocketRotate * Time.deltaTime);
        Obj.transform.Translate (transform.forward * RocketSpeed * Time.deltaTime);

        return Obj.transform;
    }

    //gravity /// dont forget to add the this to the object that is asking for grav calc /// Velocity += 9.81f * Time.deltaTime;
    public Transform Gravity(Transform Obj, float Gravscale, float Velocity, float Maxspeed)
    {
        
        Velocity *=  Gravscale;
        if (Velocity > Maxspeed)
        { Velocity = Maxspeed; }
        Obj.transform.position += Vector3.down * Velocity* Time.deltaTime;
        return Obj.transform;
    }

    #endregion

}
