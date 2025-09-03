using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ElementSlot : MonoBehaviour, IDropHandler
{
    [Header("ID do elemento correto")]
    public string correctElementID;

    public void OnDrop(PointerEventData eventData)
    {
        var dragged = eventData.pointerDrag;
        if (dragged != null)
        {
            ElementID element = dragged.GetComponent<ElementID>();

            if (element != null && element.id == correctElementID)
            {
                // Encaixa no slot
                dragged.transform.SetParent(transform);
                dragged.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;

                // Notifica conclusão
                CheckCompletion.Instance.RegisterCorrectMatch(element.id);
            }
            else
            {
                // Volta para posição inicial se errado
                dragged.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
            }
        }
    }
}
