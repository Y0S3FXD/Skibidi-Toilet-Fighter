using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SliderScript : MonoBehaviour
{
    public Slider StaminaSlider;
    public Slider HealthSlider;
    public static float MaxStamina;
    public static float MaxHealth;

    public TMP_Text StaminaMeter;
    public TMP_Text HealthMeter;

    void Update()
    {
        StaminaMeter.text = "Stamina: " + StaminaSlider.value.ToString();
        HealthMeter.text = "Health: " + HealthSlider.value.ToString();
        MaxStamina = StaminaSlider.value;
        MaxHealth = HealthSlider.value;
        Debug.Log(MaxHealth);
    }
}
