using UnityEngine;
using UnityEngine.UI;

public class ScreenBrightness : MonoBehaviour
{
    public Image filtroBrilho; // Painel usado para ajustar o brilho

    // Função chamada pelo slider
    public void AjustarBrilho(float valor)
    {
        if (filtroBrilho != null)
        {
            Color cor = filtroBrilho.color;
            cor.a = 1f - valor;
            filtroBrilho.color = cor;
        }
    }
}
