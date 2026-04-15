using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CarrosselSimples : MonoBehaviour
{
    [Header("Componentes de UI")]
    public Image displayImagem;
    public TextMeshProUGUI campoTitulo;
    public TextMeshProUGUI campoResumo;

    [Header("As tuas 5 Imagens")]
    public Sprite[] listaImagens;

    private string[] titulos = {
        "Fato Espacial (EMU)",
        "Telescópio James Webb",
        "Braço Canadarm2",
        "Painéis Solares",
        "Escudo Térmico"
    };

    private string[] resumos = {
        "É uma 'nave minúscula'. Protege contra o vácuo, temperaturas de -150°C a 120°C e micrometeoritos.",
        "Sucessor do Hubble. Observa em infravermelho, permitindo ver através de nuvens de poeira cósmica.",
        "Braço de 17 metros na ISS. Move-se como um verme e ajuda a capturar naves de carga.",
        "Fonte de energia para missões. Os da ISS cobririam quase oito campos de basquetebol.",
        "Essencial para o regresso. Suporta a fricção que gera temperaturas de quase 1600°C."
    };

    private int indice = 0;

    void Start()
    {
        AtualizarInterface();
    }

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