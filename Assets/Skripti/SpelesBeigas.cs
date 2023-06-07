using System;
using UnityEngine;
using UnityEngine.UI;

public class SpelesBeigas : MonoBehaviour
{
    public float gameDuration = 1000000f;
    public Text TaimeraTeksts;
    public Objekti objektuSkripts;
    public Image Restart;
    public Image[] rezultataBildes;
    private bool spelePabeigta;
    private float spelesTaimeris = 0f;
    private int rezultatsZvaigznes = 0; 


    private void Start()
    {
        foreach (Image rezultataBildes in rezultataBildes)
        {
            rezultataBildes.gameObject.SetActive(false);
            TaimeraTeksts.gameObject.SetActive(false);
            Restart.gameObject.SetActive(false);
        }
    }


    private void Update()
    {
        if (!spelePabeigta)
        {
            spelesTaimeris += Time.deltaTime;

            JaunaisTaimeraTeksts();
        }
        if (objektuSkripts.noliktasM == 12)
            {
                Pabeigta();
            }
    }


    private void Pabeigta()
    {
        spelePabeigta = true;
        rezultatsZvaigznes = ZvaigznesSkaits();
        Rezultats(rezultatsZvaigznes);
        objektuSkripts.noliktasM = 0;
    }

    


    private void Rezultats(int rezultatsZvaigznes)
    {
        for (int i = 0; i < rezultatsZvaigznes; i++)
        {
            if (i < rezultataBildes.Length)
            {
                rezultataBildes[i].gameObject.SetActive(true);
                TaimeraTeksts.gameObject.SetActive(true);
                Restart.gameObject.SetActive(true);
            }
        }
    }






    private void JaunaisTaimeraTeksts()
    {
        TimeSpan timeSpan = TimeSpan.FromSeconds(spelesTaimeris);
        string formatetsLaiks = string.Format("{0:00}:{1:00}:{2:00}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
        TaimeraTeksts.text = formatetsLaiks;
    }


    private int ZvaigznesSkaits()
    {
        if (spelesTaimeris < 80f)
        {
            return 3;
        }
        else if (spelesTaimeris < 130f)
        {
            return 2;
        }
        else
        {
            return 1;
        }
    }
}