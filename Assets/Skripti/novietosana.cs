using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class novietosana : MonoBehaviour, IDropHandler {
	private float vietasZRot, velkObjZRot, rotacijasStarpiba;
	private Vector2 vietasIzm, velkObjIzm;
	private float xIzmeruStarp, yIzmeruStarp;
	public Objekti objektuSkripts;

    public void OnDrop(PointerEventData eventData)
    {
        if(eventData.pointerDrag != null)
        {
            if(eventData.pointerDrag.tag.Equals(tag))
            {
                vietasZRot = GetComponent<RectTransform>().transform.eulerAngles.z;
                velkObjZRot = eventData.pointerDrag.GetComponent<RectTransform>().transform.eulerAngles.z;
                rotacijasStarpiba = Mathf.Abs(velkObjZRot - vietasZRot);
                velkObjIzm = eventData.pointerDrag.GetComponent<RectTransform>().localScale;
                vietasIzm = GetComponent<RectTransform>().localScale;
                
                xIzmeruStarp = Mathf.Abs(velkObjIzm.x - vietasIzm.x);
                yIzmeruStarp = Mathf.Abs(velkObjIzm.y - vietasIzm.y);
               
                if ((rotacijasStarpiba <= 6 || (rotacijasStarpiba >= 354 && rotacijasStarpiba <= 360)) && (xIzmeruStarp <= 0.3 && yIzmeruStarp <= 0.3))
                {
                    objektuSkripts.vaiIstajaVieta = true;
                    eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                    eventData.pointerDrag.GetComponent<RectTransform>().localRotation = GetComponent<RectTransform>().localRotation;
                    eventData.pointerDrag.GetComponent<RectTransform>().localScale= GetComponent<RectTransform>().localScale;
                     objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skana[0]);
                    switch (eventData.pointerDrag.tag)
                    {
                        case "atkritumuMasina":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skana[1]);
                            break;
                        case "atraP":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skana[2]);
                            break;
                        case "autobuss":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skana[3]);
                            break;
                        case "policija":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skana[4]);
                            break;
                        case "traktors1":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skana[5]);
                            break;
                        case "traktors5":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skana[6]);
                            break;
                        case "ugunsdzesejs":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skana[7]);
                            break;
                            case "b2":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skana[8]);
                            break;
                        case "cementuMasina":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skana[9]);
                            break;
                        case "e46":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skana[10]);
                            break;
                        case "e61":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skana[11]);
                            break;
                        case "ekskavators":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skana[12]);
                            break;
                    }      
                }
            }
            else
            {
                objektuSkripts.vaiIstajaVieta = false;
               
                switch (eventData.pointerDrag.tag)
                {
                    case "atkritumuMasina":
                        objektuSkripts.atkritumuMasina.GetComponent<RectTransform>().localPosition = objektuSkripts.atkritumuMasinaKoord;
                        break;
                    case "atraP":
                        objektuSkripts.atraP.GetComponent<RectTransform>().localPosition = objektuSkripts.atraPKoord;
                        break;
                    case "autobuss":
                        objektuSkripts.autobuss.GetComponent<RectTransform>().localPosition = objektuSkripts.autobussKoord;
                        break;
                    case "policija":
                        objektuSkripts.policija.GetComponent<RectTransform>().localPosition = objektuSkripts.policijaKoord;
                        break;
                    case "traktors1":
                        objektuSkripts.traktors1.GetComponent<RectTransform>().localPosition = objektuSkripts.traktors1Koord;
                        break;
                    case "traktors5":
                        objektuSkripts.traktors5.GetComponent<RectTransform>().localPosition = objektuSkripts.traktors5Koord;
                        break;
                    case "ugunsdzesejs":
                        objektuSkripts.ugunsdzesejs.GetComponent<RectTransform>().localPosition = objektuSkripts.ugunsdzesejsKoord;
                        break;
                        case "b2":
                        objektuSkripts.b2.GetComponent<RectTransform>().localPosition = objektuSkripts.b2Koord;
                        break;
                    case "cementuMasina":
                        objektuSkripts.cementuMasina.GetComponent<RectTransform>().localPosition = objektuSkripts.cementuMasinaKoord;
                        break;
                    case "e46":
                        objektuSkripts.e46.GetComponent<RectTransform>().localPosition = objektuSkripts.e46Koord;
                        break;
                    case "e61":
                        objektuSkripts.e61.GetComponent<RectTransform>().localPosition = objektuSkripts.e61Koord;
                        break;
                    case "ekskavators":
                        objektuSkripts.ekskavators.GetComponent<RectTransform>().localPosition = objektuSkripts.ekskavatorsKoord;
                        break;
                }
            }
        }
    }
}