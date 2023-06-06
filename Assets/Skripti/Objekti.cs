using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour
{
    public GameObject atkritumuMasina;
    public GameObject atraP;
    public GameObject autobuss;
    public GameObject policija;
    public GameObject traktors1;
    public GameObject traktors5;
    public GameObject ugunsdzesejs;
    public GameObject b2;
    public GameObject cementuMasina;
    public GameObject e46;
    public GameObject e61;
    public GameObject ekskavators;


    [HideInInspector]
    public Vector2 atkritumuMasinaKoord;
    [HideInInspector]
    public Vector2 atraPKoord;
    [HideInInspector]
    public Vector2 autobussKoord;
    [HideInInspector]
    public Vector2 policijaKoord;
    [HideInInspector]
    public Vector2 traktors1Koord;
    [HideInInspector]
    public Vector2 traktors5Koord;
    [HideInInspector]
    public Vector2 ugunsdzesejsKoord;
    [HideInInspector]
    public Vector2 b2Koord;
    [HideInInspector]
    public Vector2 cementuMasinaKoord;
    [HideInInspector]
    public Vector2 e46Koord;
    [HideInInspector]
    public Vector2 e61Koord;
    [HideInInspector]
    public Vector2 ekskavatorsKoord;
    public Canvas kanva;
    public AudioSource audioAvots;
    public AudioClip[] skana;
    [HideInInspector]

    
    public bool vaiIstajaVieta = false;


    public GameObject pedejaisVilktais = null;


    public int noliktasM = 0;

 
    void Start()
    {
        atkritumuMasinaKoord = atkritumuMasina.GetComponent<RectTransform>().localPosition;
        atraPKoord = atraP.GetComponent<RectTransform>().localPosition;
        autobussKoord = autobuss.GetComponent<RectTransform>().localPosition;
        policijaKoord = policija.GetComponent<RectTransform>().localPosition;
        traktors1Koord = traktors1.GetComponent<RectTransform>().localPosition;
        traktors5Koord = traktors5.GetComponent<RectTransform>().localPosition;
        ugunsdzesejsKoord = ugunsdzesejs.GetComponent<RectTransform>().localPosition;
        b2Koord = b2.GetComponent<RectTransform>().localPosition;
        cementuMasinaKoord = cementuMasina.GetComponent<RectTransform>().localPosition;
        e46Koord = e46.GetComponent<RectTransform>().localPosition;
        e61Koord = e61.GetComponent<RectTransform>().localPosition;
        ekskavatorsKoord = ekskavators.GetComponent<RectTransform>().localPosition;
    }
}
