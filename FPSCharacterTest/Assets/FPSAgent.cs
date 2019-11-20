using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAgents;

// working from:
// https://github.com/Unity-Technologies/ml-agents/blob/master/docs/Learning-Environment-Create-New.md
//

public class FPSAgent : Agent
{
    Rigidbody rBody;
    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody>();
    }
    public Transform Target;
    public override void AgentReset()
    {
        //if (this.transform.position.y < 0)
        //{
        //    // If the Agent fell, zero its momentum
        //    this.rBody.angularVelocity = Vector3.zero;
        //    this.rBody.velocity = Vector3.zero;
        //    this.transform.position = new Vector3(0, 0.5f, 0);
        //}

        // Move the target to a new spot
        Target.position = new Vector3((Random.value * 8 - 4)+30,
                                      (0.5f)+21,
                                      (Random.value * 8 - 4)-50);
    }
    // Update is called once per frame
    //void Update()
    //{

    //}
    public override void CollectObservations()
    {
        // Target and Agent positions
        AddVectorObs(Target.position);
        AddVectorObs(this.transform.position);

        // Agent velocity
        AddVectorObs(rBody.velocity.x);
        AddVectorObs(rBody.velocity.z);
    }


    // NEED TO SET UP link to CONTROLER
    public float speed = 10;
    public override void AgentAction(float[] vectorAction, string textAction)
    {
        // Vector3 controlSignal = Vector3.zero;
        Vector3 test1 = Vector3.zero;
        if (vectorAction[0] == 1)
        {
        test1.x = 1;
            Debug.Log("Forward");

            rBody.MovePosition(rBody.position + test1);
           // rBody.AddForce(test1 * speed);
            test1 = Vector3.zero;
        }
        if (vectorAction[0] == 2)
        {

            test1.x = -1;
            Debug.Log("back");

           // rBody.AddForce(test1 * speed);
            rBody.MovePosition(rBody.position+test1);
            test1 = Vector3.zero;
        }
        if (vectorAction[1] == 1)
        {

            test1.z = 1;
            Debug.Log("left");

            rBody.MovePosition(rBody.position + test1);
            // rBody.AddForce(test1 * speed);
            test1 = Vector3.zero;
        }
        if (vectorAction[1] == 2)
        {
            test1.z = -1;
            Debug.Log("right");


            rBody.MovePosition(rBody.position + test1);
            //  rBody.AddForce(test1 * speed);
            test1 = Vector3.zero;
        }

        // Actions, size = 2
        // Vector3 controlSignal = Vector3.zero;
        //  controlSignal.x = vectorAction[0];
        //   controlSignal.z = vectorAction[1];

        // line needs removed when controler handled  
        // rBody.AddForce(controlSignal * speed);

        // Rewards
        float distanceToTarget = Vector3.Distance(this.transform.position,
                                                  Target.position);

        // Reached target
        if (distanceToTarget < 1.42f)
        {
            SetReward(1.0f);
            Done();
        }

        // Fell off platform
        //if (this.transform.position.y < 0)
        //{
        //    Done();
        //}

    }
}
