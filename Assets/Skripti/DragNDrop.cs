using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragNDrop : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {
    //Uzglabās norādi uz Objekti skriptu
    public Objekti objektuSkripts;
    //Uzglabās norādi uz katra objekta CanvasGroup
    private CanvasGroup kanvasGrupa;
    private RectTransform velkObjRectTransf;

    public void OnBeginDrag(PointerEventData eventData)
    {
        objektuSkripts.pedejaisVilktais = null;
        kanvasGrupa.alpha = 0.6f;
        kanvasGrupa.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 cursorPos;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(objektuSkripts.kanva.transform as RectTransform, eventData.position, eventData.pressEventCamera, out cursorPos);
        transform.position = objektuSkripts.kanva.transform.TransformPoint(cursorPos);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        objektuSkripts.pedejaisVilktais = eventData.pointerDrag;
        kanvasGrupa.alpha = 1f;

        if (objektuSkripts.vaiIstajaVieta)
        {
            objektuSkripts.pedejaisVilktais = null;
            objektuSkripts.vaiIstajaVieta = false;
            objektuSkripts.noliktasM++; // Skaita spēlētāja novietotās mašīnas
        }
        else
        {
            kanvasGrupa.blocksRaycasts = true;
        }
    }

    void Start()
    {
        kanvasGrupa = GetComponent<CanvasGroup>();
        velkObjRectTransf = GetComponent<RectTransform>();
    }
}
