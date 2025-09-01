using UnityEngine;
using UnityEngine.SceneManagement; // Necessário para trocar de cena

public class MenuController : MonoBehaviour
{

    [Header("Referências das Telas")]
    public GameObject menuPrincipal;
    public GameObject opcoes;

    // 👉 Função para iniciar o jogo
    public void IniciarJogo(string nomeCena)
    {
        SceneManager.LoadScene(nomeCena);
    }

    // 👉 Função para abrir tela de opções
    public void AbrirOpcoes()
    {
        menuPrincipal.SetActive(false);
        opcoes.SetActive(true);
    }

    // 👉 Função para voltar ao menu principal
    public void VoltarMenu()
    {
        opcoes.SetActive(false);
        menuPrincipal.SetActive(true);
    }

    // 👉 Função para sair do jogo
    public void SairJogo()
    {
        Debug.Log("Saindo do jogo..."); // aparece no editor
        Application.Quit(); // funciona no executável
    }
}
