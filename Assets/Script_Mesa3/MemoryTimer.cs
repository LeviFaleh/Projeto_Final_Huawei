using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MemoryTimer : MonoBehaviour
{
    [Header("Configurações")]
    public GameObject tabelaCanvas; // Canvas com os 5 elementos
    public float tempoExibicao = 10f;

    private bool iniciado = false;

    public void IniciarMesa()
    {
        if (iniciado) return;
        iniciado = true;
        tabelaCanvas.SetActive(true);
        Invoke(nameof(EsconderTabela), tempoExibicao);
    }

    private void EsconderTabela()
    {
        tabelaCanvas.SetActive(false);
    }
}
