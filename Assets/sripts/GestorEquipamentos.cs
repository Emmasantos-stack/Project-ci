using UnityEngine;
using TMPro; 

public class GestorEquipamentos : MonoBehaviour
{
    public TextMeshProUGUI textoTitulo;
    public TextMeshProUGUI textoFacto; 
    public CustomVideoPlayer motorVideo;

   
    private string[] titulos = {
        "Fato Espacial (EMU)",
        "Telescópio James Webb (JWST)",
        "Braço Robótico Canadarm2",
        "Painéis Solares Espaciais",
        "Escudo Térmico"
    };

    private string[] factos = {
        "Protege contra temperaturas de -150°C a 120°C e micrometeoritos.",
        "Observa o universo em infravermelho através da poeira cósmica.",
        "Peça de 17m que move-se como um verme na ISS.",
        "Os painéis da ISS cobririam quase oito campos de basquetebol.",
        "Aguenta temperaturas de 1600°C no regresso à Terra."
    };

    private string[] videos = { "fato.mp4", "webb.mp4", "braco.mp4", "paineis.mp4", "escudo.mp4" };

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

    void AtualizarEcra()
    {
        textoTitulo.text = titulos[indice];
        textoFacto.text = "Facto Curioso: " + factos[indice];
        motorVideo.PlayVideo(videos[indice]);
    }
}