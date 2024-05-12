using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.UIElements;

public class dieukhien : MonoBehaviour
{
    //khop va khop90
  
    public ArticulationBody joint0;
    public ArticulationBody joint1;
    public ArticulationBody joint2;
    public ArticulationBody joint3;
    public ArticulationBody joint4;
    public ArticulationBody joint5;
    public Slider khop;
    public Slider khop1;

    // slider value for base platform that goes from -90 to 90.
    public float khopValue = 0.0f;

    // slider value for upper arm that goes from -90 to 90.
    public float khop1Value = 0.0f;

    //khop2 va khop3
    public Slider khop2;
    public Slider khop3;

    // slider value for base platform that goes from -90 to 90.
    public float khop2Value = 0.0f;

    // slider value for upper arm that goes from -90 to 90.
    public float khop3Value = 0.0f;
    
    //khop4 va khop5
    public Slider khop4;
    public Slider khop5;

    // slider value for base platform that goes from -90 to 90.
    private float khop4Value = 0.0f;

    // slider value for upper arm that goes from -90 to 90.
    private  float khop5Value = 0.0f;
    
   
    
    //khop va khop90 
    // Allow us to have numbers to adjust in the inspector the speed of each part's rotation.
    private float khopTurnRate = 90.0f;
    private float khop1TurnRate = 90.0f;

    private float khopYRot = 0.0f;
    private float khopYRotMin = -90.0f;
    private float khopYRotMax = 90.0f;

    private float khop1XRot = 0.0f;
    private float khop1XRotMin = -90.0f;
    private float khop1XRotMax = 90.0f;
    
    //khop2 va khop3
    private float khop2TurnRate = 90.0f;
    private float khop3TurnRate = 90.0f;

    private float khop2YRot = 0.0f;
    private float khop2YRotMin = -90.0f;
    private float khop2YRotMax = 90.0f;

    private float khop3YRot = 0.0f;
    private float khop3YRotMin = -90.0f;
    private float khop3YRotMax = 90.0f;
    
    //khop4 va khop5 
    // Allow us to have numbers to adjust in the inspector the speed of each part's rotation.
    private  float khop4TurnRate = 90.0f;
    private float khop5TurnRate = 90.0f;

    private float khop4XRot = 0.0f;
    private float khop4XRotMin = -90.0f;
    private float khop4XRotMax = 90.0f;

    private float khop5XRot = 0.0f;
    private float khop5XRotMin = -90.0f;
    private float khop5XRotMax = 90.0f;
    
    void Start()
    {
        //khop va khop90   
        /* Set default values to that we can bring our UI sliders into negative values */
        khop.minValue = -90;
        khop1.minValue = -90;
        khop.maxValue = 90;
        khop1.maxValue = 90;
        
        //khop2 va khop3
        khop2.minValue = -90;
        khop3.minValue = -90;
        khop2.maxValue = 90;
        khop3.maxValue = 90;
        
        //khop4 va khop5
        khop4.minValue = -90;
        khop5.minValue = -90;
        khop4.maxValue = 90;
        khop5.maxValue = 90;
        
    }
    void CheckInput()
    {
        //khop va khop90
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
        ArticulationDrive xDrive_temp; 
        xDrive_temp=joint0.xDrive;
        xDrive_temp.target=khopValue;
        joint0.xDrive = xDrive_temp;

        ArticulationDrive xDrive_temp1; 
        xDrive_temp1=joint1.xDrive;
        xDrive_temp1.target=khop1Value;
        joint1.xDrive = xDrive_temp1;

        ArticulationDrive xDrive_temp2; 
        xDrive_temp2=joint2.xDrive;
        xDrive_temp2.target=khop2Value;
        joint2.xDrive = xDrive_temp2;

        ArticulationDrive xDrive_temp3; 
        xDrive_temp3=joint3.xDrive;
        xDrive_temp3.target=khop3Value;
        joint3.xDrive = xDrive_temp3;


        ArticulationDrive xDrive_temp4; 
        xDrive_temp4=joint4.xDrive;
        xDrive_temp4.target=khop4Value;
        joint4.xDrive = xDrive_temp4;

        ArticulationDrive xDrive_temp5; 
        xDrive_temp5=joint5.xDrive;
        xDrive_temp5.target=khop5Value;
        joint5.xDrive = xDrive_temp5;

        // //khop va 
        // //rotating our base of the robot here around the Y axis and multiplying
        // //the rotation by the slider's value and the turn rate for the base.
        // khopYRot = khopValue * khopTurnRate;
        // khopYRot = Mathf.Clamp(khopYRot, khopYRotMin, khopYRotMax);
        // khoprobot.localEulerAngles = new ;

        // //rotating our upper arm of the robot here around the X axis and multiplying
        // //the rotation by the slider's value and the turn rate for the upper arm.
        // khop90XRot += khop90Value * khop90TurnRate;
        // khop90XRot = Mathf.Clamp(khop90XRot, khop90XRotMin, khop90XRotMax);
        // khoprobot90.localEulerAngles = new Vector3(khop90XRot, khoprobot90.localEulerAngles.y, khoprobot90.localEulerAngles.z);
        
        // //khop2 va khop3
        // khop2YRot += khop2Value * khop2TurnRate;
        // khop2YRot = Mathf.Clamp(khop2YRot, khop2YRotMin, khop2YRotMax);
        // khoprobot2.localEulerAngles = new Vector3(khoprobot2.localEulerAngles.x, khop2YRot, khoprobot2.localEulerAngles.z);

        // //rotating our upper arm of the robot here around the X axis and multiplying
        // //the rotation by the slider's value and the turn rate for the upper arm.
        // khop3YRot += khop3Value * khop3TurnRate;
        // khop3YRot = Mathf.Clamp(khop3YRot, khop3YRotMin, khop3YRotMax);
        // khoprobot3.localEulerAngles = new Vector3(khoprobot3.localEulerAngles.x, khop3YRot, khoprobot3.localEulerAngles.z);
        
        // //khop4 va khop5
        // //rotating our base of the robot here around the Y axis and multiplying
        // //the rotation by the slider's value and the turn rate for the base.
        // khop4XRot += khop4Value * khop4TurnRate;
        // khop4XRot = Mathf.Clamp(khop4XRot, khop4XRotMin, khop4XRotMax);
        // khoprobot4.localEulerAngles = new Vector3(khop4XRot, khoprobot4.localEulerAngles.y, khoprobot4.localEulerAngles.z);

        // //rotating our upper arm of the robot here around the X axis and multiplying
        // //the rotation by the slider's value and the turn rate for the upper arm.
        // khop5XRot += khop5Value * khop5TurnRate;
        // khop5XRot = Mathf.Clamp(khop5XRot, khop5XRotMin, khop5XRotMax);
        // khoprobot5.localEulerAngles = new Vector3(khop5XRot, khoprobot5.localEulerAngles.y, khoprobot5.localEulerAngles.z);
        
    }

    public void ResetSliders()
    {
    	//khop va khop90
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
