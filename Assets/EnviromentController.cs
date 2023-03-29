using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ArabicSupport;
public class EnviromentController : MonoBehaviour
{
    // k in midle c right f left

    public GameObject Thermometer;
    public GameObject Thermometer2;
    public GameObject Thermometer3;

    public Transform ThermometerChild;
    public Transform ThermometerChild2;
    public Transform ThermometerChild3;

    public Transform ThermometerSteamChild;
    public Transform ThermometerSteamChild2;
    public Transform ThermometerSteamChild3;

    private ParticleSystem Steam;
    private ParticleSystem Steam2;
    private ParticleSystem Steam3;

    private int C;
    private int f;
    private int k;

    private Slider slider;
    private Slider slider2;
    private Slider slider3;

    private int raiseby = 10;

    public Text text;

    private void Awake()
    {
        //ThermometerChild = Thermometer.transform.FindChild("Slider");
        //ThermometerChild2 = Thermometer2.transform.FindChild("Slider");
        //ThermometerChild3 = Thermometer3.transform.FindChild("Slider");

        slider = ThermometerChild.GetComponent<Slider>();
        slider2 = ThermometerChild2.GetComponent<Slider>();
        slider3 = ThermometerChild3.GetComponent<Slider>();

        Steam = ThermometerSteamChild.GetComponent<ParticleSystem>();
        Steam2 = ThermometerSteamChild2.GetComponent<ParticleSystem>();
        Steam3 = ThermometerSteamChild3.GetComponent<ParticleSystem>();

        
    }

    private void Update()
    {
        slider.value = C;
        slider2.value = f;
        slider3.value = k;

        if(f >= 100)
        {
            Steam2.Play();
        }
        else
        {
            Steam2.Stop();
        }

        if (C >= 100)
        {
            Steam.Play();
        }
        else
        {
            Steam.Stop();
        }

        if (k >= 100)
        {
            Steam3.Play();
        }
        else
        {
            Steam3.Stop();
        }

        text.text = ArabicFixer.Fix("œ—Ã… Õ—«—  «·„«¡"+ C + "c∞");
    }

    public void RiseTemp() {

        C += raiseby;
        f += raiseby;
        k += raiseby;
    }
    public void RropTemp() {

        C -= raiseby;
        f -= raiseby;
        k -= raiseby;
    }
}
