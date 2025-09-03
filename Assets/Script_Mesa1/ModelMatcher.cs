using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ModelMatcher : MonoBehaviour, IDropHandler
{
    [Header("ID do Modelo que deve encaixar aqui")]
    public string correctModelID;

    public void OnDrop(PointerEventData eventData)
    {
        var dragged = eventData.pointerDrag;
        if (dragged != null)
        {
            ModelID modelID = dragged.GetComponent<ModelID>();

            if (modelID != null && modelID.id == correctModelID)
            {
                // Encaixa corretamente
                dragged.transform.SetParent(transform);
                dragged.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;

                // Notifica o gerenciador
                CheckCompletion.Instance.RegisterCorrectMatch(modelID.id);
            }
            else
            {
                // Volta para posição inicial
                dragged.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
            }
        }
    }
}

