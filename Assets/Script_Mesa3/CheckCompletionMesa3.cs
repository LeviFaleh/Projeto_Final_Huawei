using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CheckCompletionMesa3 : MonoBehaviour
{
    public static CheckCompletionMesa3 Instance;

    [Header("UI")]
    public Text checklistText;

    [Header("Luz da mesa")]
    public Light mesaLight;
    public Color successColor = Color.green;

    private HashSet<string> correctMatches = new HashSet<string>();
    [Tooltip("Número total de elementos que precisam estar corretos")]
    public int totalSlots = 5;

    void Awake()
    {
        Instance = this;
    }

    /// <summary>
    /// Registra quando um elemento foi colocado corretamente em seu slot
    /// </summary>
    public void RegisterCorrectMatch(string elementID)
    {
        if (!correctMatches.Contains(elementID))
        {
            correctMatches.Add(elementID);
            checklistText.text += "\n✔ " + elementID;
        }

        if (correctMatches.Count >= totalSlots)
            OnAllMatched();
    }

    private void OnAllMatched()
    {
        mesaLight.color = successColor;
        mesaLight.intensity = 3f;
        checklistText.text += "\n\n✅ Todos os elementos foram concluídos!";
    }
}

