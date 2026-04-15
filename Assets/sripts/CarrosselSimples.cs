using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement; 

public class CarrosselSimples : MonoBehaviour
{
    public Image displayImagem;
    public TextMeshProUGUI textoTitulo;
    public Sprite[] imagens;

    
    public static int itemSelecionado;

    private string[] titulos = { "Fato Espacial (EMU)", "Telescópio James Webb", "Braço Canadarm2", "Painéis Solares", "Escudo Térmico" };
    private int indice = 0;

    void Start() { AtualizarEcra(); }

    public void Proximo() { indice = (indice + 1) % titulos.Length; AtualizarEcra(); }
    public void Anterior() { indice--; if (indice < 0) indice = titulos.Length - 1; AtualizarEcra(); }

    void AtualizarEcra()
    {
        displayImagem.sprite = imagens[indice];
        textoTitulo.text = titulos[indice];
    }

 
    public void IrParaDetalhe()
    {
        itemSelecionado = indice; 
        SceneManager.LoadScene("Cena_Detalhe_Equipamento"); 
    }
}