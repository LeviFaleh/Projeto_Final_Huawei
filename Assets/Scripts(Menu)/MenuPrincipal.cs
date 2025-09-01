using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public GameObject menuPrincipal;  // Painel do menu principal
    public GameObject opcoes;         // Painel de opções

    // Inicia o jogo
    public void IniciarJogo()
    {
        SceneManager.LoadScene("Laboratorio");
    }

    // Abre as configurações
    public void AbrirConfiguracoes()
    {
        menuPrincipal.SetActive(false);
        opcoes.SetActive(true);
    }

    // Voltar para o menu principal
    public void VoltarMenu()
    {
        opcoes.SetActive(false);
        menuPrincipal.SetActive(true);
    }

    // Sair do jogo
    public void SairJogo()
    {
        Debug.Log("Saindo do jogo...");
        Application.Quit();
    }
}
