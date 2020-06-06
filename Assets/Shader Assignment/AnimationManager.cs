using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    public GameObject Cam1;
    public GameObject Veg1;
    [Space]
    public GameObject Cam2;
    public GameObject hold1;
    [Space]
    public GameObject Cam3;
    public GameObject hold2;
    [Space]
    public GameObject Cam4;
    public GameObject hold4;
    [Space]
    public GameObject Cam5;
    public GameObject hold5;
    [Space]
    public GameObject cam7;
    public GameObject hold6;
    [Space]
    public GameObject cam8;
    public GameObject hold7;
    [Space]
    public GameObject cam9;
    public GameObject hold8;
    [Space]
    [Header("..")]
    public GameObject cam10;
    public GameObject hold9;
    [Space]
    public GameObject cam11;
    public GameObject hold10;
    [Space]
    public GameObject cam12;
    public GameObject hold11;
    [Space]
    public GameObject cam13;
    public GameObject hold12;
    [Space]
    public GameObject cam14;
    public GameObject hold13;
    [Space]
    [Header("vegeta")]
    public GameObject vegetabeam;
    [Space]
    public GameObject cam15;
    public GameObject hold14;


    public void LoadScene2()
    {
        Cam1.SetActive(false);
        Veg1.SetActive(false);
        hold1.SetActive(true);
        Cam2.SetActive(true);
    }

    public void LoadScene3()
    {
        hold1.SetActive(false);
        Cam2.SetActive(false);
        hold2.SetActive(true);
        Cam3.SetActive(true);
    }


    public void LoadScene4()
    {
        hold2.SetActive(false);
        Cam3.SetActive(false);
        hold4.SetActive(true);
        Cam4.SetActive(true);
    }

    public void LoadScene5()
    {
        hold4.SetActive(false);
        Cam4.SetActive(false);
        Cam5.SetActive(true);
        hold5.SetActive(true);
    }

    public void LoadScene6()
    {
        Cam5.SetActive(false);
        hold5.SetActive(false);
        hold2.SetActive(false);
        Cam4.SetActive(false);
        cam7.SetActive(true);
        hold6.SetActive(true);
    }

    public void LoadScene7()
    {
        cam7.SetActive(false);
        hold6.SetActive(false);
        cam8.SetActive(true);
        hold7.SetActive(true);
    }

    public void LoadScene8()
    {
        cam8.SetActive(false);
        hold7.SetActive(false);
        cam9.SetActive(true);
        hold8.SetActive(true);
    }

    public void LoadScene9()
    {
        cam9.SetActive(false);
        hold8.SetActive(false);
        cam10.SetActive(true);
        hold9.SetActive(true);
    }

    public void LoadScene10()
    {
        cam10.SetActive(false);
        hold9.SetActive(false);
        cam11.SetActive(true);
        hold10.SetActive(true);
    }

    public void LoadScene11()
    {
        cam11.SetActive(false);
        hold10.SetActive(false);
        cam12.SetActive(true);
        hold11.SetActive(true);
    }

    public void LoadScene12()
    {
        cam12.SetActive(false);
        hold11.SetActive(false);
        cam13.SetActive(true);
        hold12.SetActive(true);
    }

    public void LoadScene13()
    {
        cam13.SetActive(false);
        hold12.SetActive(false);
        cam14.SetActive(true);
        hold13.SetActive(true);
    }

    public void VegetaBeam()
    {
        vegetabeam.SetActive(true);
    }
    public void LoadScene14()
    {
        cam14.SetActive(false);
        hold13.SetActive(false);
        cam15.SetActive(true);
        hold14.SetActive(true);
    }

}

