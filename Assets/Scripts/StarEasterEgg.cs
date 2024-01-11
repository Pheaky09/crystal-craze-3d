using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StarEasterEgg : MonoBehaviour
{
    public GameObject eastereggbackground;
    public TextMeshProUGUI stareasteregg;
    public GameObject starbutton;

    public TextMeshProUGUI hexgoneasteregg;
    public GameObject hexbutton;
    public TextMeshProUGUI diamondeasteregg;
    public GameObject diamondbutton;
    public TextMeshProUGUI cuboideasteregg;
    public GameObject cuboidbutton;

    private void Start()
    {
        stareasteregg.gameObject.SetActive(false);
        hexgoneasteregg.gameObject.SetActive(false);
        diamondeasteregg.gameObject.SetActive(false);
        cuboideasteregg.gameObject.SetActive(false);

        eastereggbackground.gameObject.SetActive(false);


    }

    public void RunStar()
    {
        bool isActive = stareasteregg.gameObject.activeSelf;
        stareasteregg.gameObject.SetActive(!isActive);
        bool isActive2 = eastereggbackground.gameObject.activeSelf;
        eastereggbackground.gameObject.SetActive(!isActive2);
    }
    public void Runhexgone()
    {
        bool isActive = hexgoneasteregg.gameObject.activeSelf;
        hexgoneasteregg.gameObject.SetActive(!isActive);
    }
    public void Rundiamond()
    {
        bool isActive = diamondeasteregg.gameObject.activeSelf;
        diamondeasteregg.gameObject.SetActive(!isActive);
    }
    public void Runcuboid()
    {
        bool isActive = cuboideasteregg.gameObject.activeSelf;
        cuboideasteregg.gameObject.SetActive(!isActive);
    }
}
