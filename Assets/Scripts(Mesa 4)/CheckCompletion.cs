using UnityEngine;

public class CheckCompletion : MonoBehaviour
{
    public Light tableLight;
    public GameObject checkMark;

    public void CompleteTask()
    {
        tableLight.enabled = false;  // apaga a luz
        checkMark.SetActive(true);   // mostra ✔
    }
}
