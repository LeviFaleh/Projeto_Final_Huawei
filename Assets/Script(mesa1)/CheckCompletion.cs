using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckCompletion : MonoBehaviour
{
    public static CheckCompletion Instance;

    [Header("UI")]
    public Text checklistText;

    [Header("Luz da mesa")]
    public Light mesaLight;
    public Color successColor = Color.green;

    private HashSet<string> correctMatches = new HashSet<string>();
    private int totalModels = 4; // quantidade de modelos

    void Awake()
    {
        Instance = this;
    }

    public void RegisterCorrectMatch(string modelID)
    {
        if (!correctMatches.Contains(modelID))
        {
            correctMatches.Add(modelID);
            checklistText.text += "\n✔ " + modelID;
        }

        if (correctMatches.Count >= totalModels)
            OnAllMatched();
    }

    private void OnAllMatched()
    {
        mesaLight.color = successColor;
        mesaLight.intensity = 3f;
        checklistText.text += "\n\n✅ Todos os modelos foram concluídos!";
    }
}

