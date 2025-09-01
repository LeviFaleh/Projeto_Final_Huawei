using UnityEngine;

public class ElectronExcitation : MonoBehaviour
{
    public Light energyLight;  
    public float jumpHeight = 0.5f;
    public float jumpTime = 2f;

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    public void ExciteElectron()
    {
        StartCoroutine(JumpAndReturn());
    }

    private System.Collections.IEnumerator JumpAndReturn()
    {
        Vector3 upPos = startPos + Vector3.up * jumpHeight;

        float elapsed = 0;
        while (elapsed < jumpTime)
        {
            transform.position = Vector3.Lerp(startPos, upPos, elapsed / jumpTime);
            elapsed += Time.deltaTime;
            yield return null;
        }

        // Liberar energia (acender luz por 1s)
        energyLight.enabled = true;
        yield return new WaitForSeconds(1f);
        energyLight.enabled = false;

        transform.position = startPos;
    }
}
