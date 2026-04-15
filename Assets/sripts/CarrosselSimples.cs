using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CarrosselSimples : MonoBehaviour
{
    public Image displayImagem;
    public TextMeshProUGUI textoTitulo;
    public TextMeshProUGUI textoResumo;
    public GameObject painelResumo;


    public Sprite[] imagens;

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
        "Peça de 17 metros na ISS. Move-se como um verme e captura naves de carga.",
        "Fonte de energia perto do Sol. Os da ISS cobririam quase oito campos de basquetebol.",
        "Protege os astronautas na reentrada, dissipando temperaturas de quase 1600°C."
    };

    private int indice = 0;

    void Start() { AtualizarEcra(); }

    public void Proximo()
    {
        indice = (indice + 1) % titulos.Length;
        AtualizarEcra();
    }

    public void Anterior()
    {
        indice--;
        if (indice < 0) indice = titulos.Length - 1;
        AtualizarEcra();
    }

    public void AbrirResumo() { painelResumo.SetActive(true); }
    public void FecharResumo() { painelResumo.SetActive(false); }

    void AtualizarEcra()
    {
        displayImagem.sprite = imagens[indice];
        textoTitulo.text = titulos[indice];
        textoResumo.text = resumos[indice];
        painelResumo.SetActive(false); 
    }
}