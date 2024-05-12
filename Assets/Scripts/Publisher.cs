using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Robotics.ROSTCPConnector;
using RosMessageTypes.UnityRoboticsDemo;

public class Publisher : MonoBehaviour
{
    // Start is called before the first frame update

    ROSConnection ros;
    public string topicName = "joint_step";

    // The game object

    // Publish the cube's position and rotation every N seconds
    public float publishMessageFrequency = 0.5f;

    // Used to determine how much time has elapsed since the last message was published
    private float timeElapsed;
    public ArticulationBody joint0;
    public ArticulationBody joint1;
    public ArticulationBody joint2;
    public ArticulationBody joint3;
    public ArticulationBody joint4;
    public ArticulationBody joint5;
    void Start()
    {
        // start the ROS connection
        ros = ROSConnection.GetOrCreateInstance();
        ros.RegisterPublisher<JointstepMsg>(topicName);
    }

    // Update is called once per frame
   private void Update()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed > publishMessageFrequency)
        {

            JointstepMsg jointPos = new JointstepMsg(
                joint0.xDrive.target,
                joint1.xDrive.target,
                joint2.xDrive.target,
                joint3.xDrive.target,
                joint4.xDrive.target,
                joint5.xDrive.target
            );

            // Finally send the message to server_endpoint.py running in ROS
            ros.Publish(topicName, jointPos);

            timeElapsed = 0;
        }
    }
}