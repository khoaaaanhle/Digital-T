using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Arm_Controller : MonoBehaviour
{
    //khop va khop1
    public Slider khop;
    public Slider khop1;

    // slider value for base platform that goes from -1 to 1.
    public float khopValue = 0.0f;

    // slider value for upper arm that goes from -1 to 1.
    public float khop1Value = 1f;

    //khop2 va khop3
    public Slider khop2;
    public Slider khop3;

    // slider value for base platform that goes from -1 to 1.
    public float khop2Value = -1f;

    // slider value for upper arm that goes from -1 to 1.
    public float khop3Value = 0.0f;
    
    //khop4 va khop5
    public Slider khop4;
    public Slider khop5;

    // slider value for base platform that goes from -1 to 1.
    public float khop4Value = 0.0f;

    // slider value for upper arm that goes from -1 to 1.
    public float khop5Value = 0.0f;
    
    // These slots are where you will plug in the appropriate arm parts into the inspector.
    //khop va khop1
    public ArticulationBody khoprobot;
    public ArticulationBody khoprobot1;
    
    //khop2 va khop3
    public ArticulationBody khoprobot2;
    public ArticulationBody khoprobot3;
    
    //khop4 va khop5
    public ArticulationBody khoprobot4;
    public ArticulationBody khoprobot5;
    
    //khop va khop1 
    // Allow us to have numbers to adjust in the inspector the speed of each part's rotation.
    public float khopTurnRate = 1.0f;
    public float khop1TurnRate = 1.0f;

    private float khopYRot = 0.0f;
    public float khopYRotMin = -90.0f;
    public float khopYRotMax = 90.0f;

    private float khop1XRot = 0.0f;
    public float khop1XRotMin = -90.0f;
    public float khop1XRotMax = 90.0f;
    
    //khop2 va khop3
    public float khop2TurnRate = 1.0f;
    public float khop3TurnRate = 1.0f;

    private float khop2YRot = 0.0f;
    public float khop2YRotMin = -90.0f;
    public float khop2YRotMax = 90.0f;

    private float khop3YRot = 0.0f;
    public float khop3YRotMin = -90.0f;
    public float khop3YRotMax = 90.0f;
    
    //khop4 va khop5 
    // Allow us to have numbers to adjust in the inspector the speed of each part's rotation.
    public float khop4TurnRate = 1.0f;
    public float khop5TurnRate = 1.0f;

    private float khop4XRot = 0.0f;
    public float khop4XRotMin = -90.0f;
    public float khop4XRotMax = 90.0f;

    private float khop5XRot = 0.0f;
    public float khop5XRotMin = -90.0f;
    public float khop5XRotMax = 90.0f;
    
    void Start()
    {
        //khop va khop1   
        /* Set default values to that we can bring our UI sliders into negative values */
        khop.minValue = -1;
        khop1.minValue = -1;
        khop.maxValue = 1;
        khop1.maxValue = 1;
        
        //khop2 va khop3
        khop2.minValue = -1;
        khop3.minValue = -1;
        khop2.maxValue = 1;
        khop3.maxValue = 1;
        
        //khop4 va khop5
        khop4.minValue = -1;
        khop5.minValue = -1;
        khop4.maxValue = 1;
        khop5.maxValue = 1;
        
    }
    void CheckInput()
    {
        //khop va khop1
        khopValue = khop.value;
        khop1Value = khop1.value;
        
        //khop2 va khop3
        khop2Value = khop2.value;
        khop3Value = khop3.value;
        
        //khop4 va khop5
        khop4Value = khop4.value;
        khop5Value = khop5.value;
        
    }
    void ProcessMovement()
    {
        //khop va khop1
        //rotating our base of the robot here around the Y axis and multiplying
        //the rotation by the slider's value and the turn rate for the base.
        //khopYRot += khopValue * khopTurnRate;
        //khopYRot = Mathf.Clamp(khopYRot, khopYRotMin, khopYRotMax);
        //khoprobot.localEulerAngles = new Vector3(khoprobot.localEulerAngles.x, khopYRot, khoprobot.localEulerAngles.z);

        //rotating our upper arm of the robot here around the X axis and multiplying
        //the rotation by the slider's value and the turn rate for the upper arm.
        khop1XRot += khop1Value * khop1TurnRate;
        khop1XRot = Mathf.Clamp(khop1XRot, khop1XRotMin, khop1XRotMax);
        var joint1XDrive = khoprobot1.xDrive;
            joint1XDrive.target = (float)(khop1XRot);
            khoprobot1.xDrive = joint1XDrive;
        
        //khop2 va khop3
        //khop2YRot += khop2Value * khop2TurnRate;
        //khop2YRot = Mathf.Clamp(khop2YRot, khop2YRotMin, khop2YRotMax);
        //khoprobot2.localEulerAngles = new Vector3(khoprobot2.localEulerAngles.x, khop2YRot, //khoprobot2.localEulerAngles.z);

        //rotating our upper arm of the robot here around the X axis and multiplying
        //the rotation by the slider's value and the turn rate for the upper arm.
        //khop3YRot += khop3Value * khop3TurnRate;
        //khop3YRot = Mathf.Clamp(khop3YRot, khop3YRotMin, khop3YRotMax);
        //khoprobot3.localEulerAngles = new Vector3(khoprobot3.localEulerAngles.x, khop3YRot, khoprobot3.localEulerAngles.z);
        
        //khop4 va khop5
        //rotating our base of the robot here around the Y axis and multiplying
        //the rotation by the slider's value and the turn rate for the base.
       // khop4XRot += khop4Value * khop4TurnRate;
       // khop4XRot = Mathf.Clamp(khop4XRot, khop4XRotMin, khop4XRotMax);
       //khoprobot4.localEulerAngles = new Vector3(khop4XRot, khoprobot4.localEulerAngles.y, khoprobot4.localEulerAngles.z);

        //rotating our upper arm of the robot here around the X axis and multiplying
        //the rotation by the slider's value and the turn rate for the upper arm.
       // khop5XRot += khop5Value * khop5TurnRate;
        //khop5XRot = Mathf.Clamp(khop5XRot, khop5XRotMin, khop5XRotMax);
       // khoprobot5.localEulerAngles = new Vector3(khop5XRot, khoprobot5.localEulerAngles.y, khoprobot5.localEulerAngles.z);
        
    }

    public void ResetSliders()
    {
    	//khop va khop1
        //resets the sliders back to 0 when you lift up on the mouse click down (snapping effect)
        khopValue = 0.0f;
        khop1Value = 0.0f;
        khop.value = 0.0f;
        khop1.value = 0.0f;
        
        //khop2 va khop3
        khop2Value = 0.0f;
        khop3Value = 0.0f;
        khop2.value = 0.0f;
        khop3.value = 0.0f;
        
        //khop4 va khop5
        khop4Value = 0.0f;
        khop5Value = 0.0f;
        khop4.value = 0.0f;
        khop5.value = 0.0f;
        
    }

    void Update()
    {
        CheckInput();
        ProcessMovement();
    }
}
