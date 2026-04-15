using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CarrosselNaoTripuladas : MonoBehaviour
{
    public Image displayImagem;
    public TextMeshProUGUI campoTitulo;
    public TextMeshProUGUI campoResumo;
    public Sprite[] listaImagens;

    private string[] titulos = {
        "Rovers de Marte",
        "Voyager 1 e 2",
        "Sonda Parker",
        "Missão Rosetta"
    };

    private string[] resumos = {
        "Os rovers Curiosity e Perseverance procuram sinais de vida antiga e recolhem amostras de solo marciano.",
        "Os objetos feitos pelo homem que estão mais longe da Terra. Ambas já saíram do Sistema Solar.",
        "A missão que 'tocou' o Sol, aguentando temperaturas extremas para estudar o vento solar.",
        "A primeira vez que a humanidade conseguiu aterrar um pequeno robô (Philae) num cometa em movimento."
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