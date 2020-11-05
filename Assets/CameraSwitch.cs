using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class CameraSwitch : MonoBehaviour
{

    public Button but;

    // Start is called before the first frame update
    void Start()
    {
        but.onClick.AddListener(delegate { OnClick(); });
    }

    public void OnClick()
    {
        Debug.Log("On click");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {

        }
        if (Input.GetKeyDown(KeyCode.X))
        {

        }
    }
    
}
