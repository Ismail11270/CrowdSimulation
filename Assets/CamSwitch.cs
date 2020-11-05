using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using UnityStandardAssets.Characters.FirstPerson;

public class CamSwitch : MonoBehaviour
{

    public Slider slider;
    public Text text;
    public GameObject[] camObject;
    private Camera camOne, camTwo, camThree, camFour;
    private MouseLook mouseLook;
    public GameObject fpsController;

    // Start is called before the first frame update
    void Start()
    {
        camOne = camObject[0].GetComponent<Camera>();
        camTwo = camObject[1].GetComponent<Camera>();
        camThree = camObject[2].GetComponent<Camera>();
        camFour = camObject[3].GetComponent<Camera>();

        slider.onValueChanged.AddListener(delegate { UpdateCamera(); });


        mouseLook = fpsController.GetComponent<FirstPersonController>().GetMouseLook();
        toggleCamera((int)slider.value);
    }

    private void toggleCamera(int id)
    {
        if (id == 1) camControl(true, false, false, false);
        if (id == 2) camControl(false, true, false, false);
        if (id == 3) camControl(false, false, true, false);
        if (id == 4)
        {
            camControl(false, false, false, true);
            mouseLook.lockCursor = true; 
        } else
        {
            mouseLook.lockCursor = false;
        }
        

        text.text = "Camera View #" + id;
    }

    private void camControl( bool one, bool two, bool three, bool four)
    {
        camOne.enabled = one;
        camTwo.enabled = two;
        camThree.enabled = three;
        camFour.enabled = four;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void UpdateCamera()
    {
        toggleCamera((int)slider.value);
    }
}
