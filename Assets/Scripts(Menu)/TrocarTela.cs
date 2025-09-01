using UnityEngine;

public class TrocarTela : MonoBehaviour
{
    public GameObject menuPrincipal; // referência ao MenuPrincipal
    public GameObject opcoes;        // referência à tela de Opções

    public void AbrirOpcoes()
    {
        menuPrincipal.SetActive(false); // esconde menu principal
        opcoes.SetActive(true);         // mostra tela de opções
    }

    public void VoltarMenu()
    {
        opcoes.SetActive(false);        // esconde opções
        menuPrincipal.SetActive(true);  // volta pro menu principal
    }
}
