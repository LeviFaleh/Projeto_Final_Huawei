using UnityEngine;

public class ElectronCollector : MonoBehaviour
{
    public string correctElectronTag = "ValenceElectron";
    public HapticFeedback feedback;

    private int collected = 0;
    private int target = 1; // Quantos elétrons precisam ser coletados

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(correctElectronTag))
        {
            feedback.Success();
            Destroy(other.gameObject);
            collected++;

            if (collected >= target)
            {
                FindObjectOfType<CheckCompletion>().CompleteTask();
            }
        }
        else
        {
            feedback.Error();
        }
    }
}
    