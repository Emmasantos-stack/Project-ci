using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CarrosselTripuladas : MonoBehaviour
{
    public Image displayImagem;
    public TextMeshProUGUI campoTitulo;
    public TextMeshProUGUI campoResumo;
    public Sprite[] listaImagens;

    private string[] titulos = {
        "Programa Apollo",
        "Missão Artemis",
        "Efeitos no Corpo",
        "SpaceX Crew Dragon"
    };

    private string[] resumos = {
        "A Apollo 11 foi a primeira a aterrar na Lua. Apenas 12 pessoas pisaram solo lunar até hoje.",
        "O plano de levar a primeira mulher e a primeira pessoa de cor à Lua e estabelecer uma base lá.",
        "A microgravidade causa perda de massa óssea e muscular. Astronautas precisam de 2h de exercício diário.",
        "Usa naves reutilizáveis e ecrãs táteis modernos em vez de milhares de botões físicos."
    };

    private int indice = 0;

    void Start() { AtualizarInterface(); }

    public void Proximo()
    {
        indice = (indice + 1) % titulos.Length;
        AtualizarInterface();
    }

    public void Anterior()
    {
        indice--;
        if (indice < 0) indice = titulos.Length - 1;
        AtualizarInterface();
    }

    void AtualizarInterface()
    {
        displayImagem.sprite = listaImagens[indice];
        campoTitulo.text = titulos[indice];
        campoResumo.text = resumos[indice];
    }
}
