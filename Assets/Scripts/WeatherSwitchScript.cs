using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeatherSwitchScript : MonoBehaviour
{
    public Slider slider;
    public Text text;

    private int currentWeather;
    public GameObject[] weatherList;

    // Start is called before the first frame update
    void Start()
    {
        currentWeather = -1;
        UpdateWeather();
        slider.onValueChanged.AddListener(delegate { UpdateWeather(); });
    }


    private void UpdateWeather()
    {
        if(currentWeather != -1)
        {
            weatherList[currentWeather].SetActive(false);
        }
        currentWeather = (int)slider.value;
        weatherList[currentWeather].SetActive(true);
        text.text = "Weather Condition #" + (currentWeather + 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
