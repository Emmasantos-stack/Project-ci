using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CarrosselVeiculos : MonoBehaviour
{
    public Image displayImagem;
    public TextMeshProUGUI campoTitulo;
    public TextMeshProUGUI campoResumo;
    public Sprite[] listaImagens;

    private string[] titulos = {
        "Saturno V",
        "Space Shuttle",
        "SLS (NASA)",
        "Starship (SpaceX)"
    };

    private string[] resumos = {
        "O foguetão mais potente de sempre a voar com sucesso. Tinha 110 metros de altura e levou as missões Apollo à Lua.",
        "O Vaivém Espacial foi a primeira nave reutilizável. Ajudou a construir a ISS e a colocar o telescópio Hubble em órbita.",
        "O Space Launch System é o novo pilar das missões Artemis. É desenhado para levar cápsulas Orion e humanos de volta à Lua.",
        "O veículo totalmente reutilizável mais potente do mundo. O seu objetivo principal é a colonização de Marte e transporte de carga pesada."
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