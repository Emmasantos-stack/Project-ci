using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GerenciadorMenu : MonoBehaviour
{
    [Header("Configurações de UI")]
    public Button botaoPlay;
    public GameObject objetoAviso; // Arraste aqui o texto "Escolha um tema!"
    public Text textoInformativo;  // Opcional: Para mostrar o tema atual na tela

    private string temaSelecionado = "";

    void Start()
    {
        // Começa com o aviso escondido e o botão de play desativado (opcional)
        if (objetoAviso != null) objetoAviso.SetActive(false);
        
        // Se você quer que o botão nem clique antes do tema, deixe false.
        // Se quer que clique para mostrar o aviso, deixe true.
        botaoPlay.interactable = false; 
    }

    // Função para os botões de Tema (Ex: Botão Missões, Botão Planetas)
    public void SelecionarTema(string nomeDoTema)
    {
        temaSelecionado = nomeDoTema;
        Debug.Log("Tema selecionado: " + temaSelecionado);
        
        // Agora que tem tema, libera o botão Play e esconde o aviso
        botaoPlay.interactable = true;
        if (objetoAviso != null) objetoAviso.SetActive(false);

        if (textoInformativo != null) 
            textoInformativo.text = "Selecionado: " + temaSelecionado;
    }

    public void IniciarJogo()
    {
        // Se por algum motivo o tema estiver vazio, mostra o aviso e para
        if (string.IsNullOrEmpty(temaSelecionado))
        {
            if (objetoAviso != null) objetoAviso.SetActive(true);
            return;
        }

        // SALVA o tema para usar depois, se precisar
        PlayerPrefs.SetString("TemaEscolhido", temaSelecionado);

        // LÓGICA DE DIRECIONAMENTO:
        if (temaSelecionado == "Missoes")
        {
            SceneManager.LoadScene("CenaDasMissoes"); // Nome exato da cena
        }
        else if (temaSelecionado == "Planetas")
        {
            SceneManager.LoadScene("CenaDosPlanetas"); // Nome exato da cena
        }
        else
        {
            Debug.LogError("O nome do tema no botão não coincide com a lógica do script!");
        }
    }
}