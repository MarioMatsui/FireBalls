using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class RotacionarBola : MonoBehaviour
{
    public AudioSource scoreAudio;
    public AudioSource dieAudio;
    public GameObject Bola1;
    public GameObject Bola2;
    public float velocidade;
    public GameObject gameOver;
    public TextMeshProUGUI best;
    private int pontuacao;
    private int death;
    private int quantidade_mortes;
    private int BestScore = 0;
    public TextMeshProUGUI pontuacaotext;
    public TextMeshProUGUI pontuacaotext_GO;
    public TextMeshProUGUI best_score;
    public UnityMonetization AD;
    bool direita = false;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("best_score")){
            BestScore = PlayerPrefs.GetInt("best_score");
            best_score.text = "Best: " + BestScore;
        }
        pontuacaotext_GO.text = "0";
        death = PlayerPrefs.GetInt("quantidade_mortes", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            direita = !direita;
        }

        if(direita == false){
            transform.Rotate(new Vector3(0f,0f, velocidade * Time.deltaTime));
        }
        else{
            transform.Rotate(new Vector3(0f,0f, -velocidade * Time.deltaTime));
        }
        if (death >= 3){
            AD.DisplayInterstitialAD();
            death = 0;
        }
    }
    public void ChamarGameOver(){
        death += 1;
        PlayerPrefs.SetInt("quantidade_mortes", death);
        gameOver.SetActive(true);
        dieAudio.Play();
        Destroy(Bola1);
        Destroy(Bola2);
        if(PlayerPrefs.GetInt("quantidade_mortes") >= 3){
            death = 0;
            AD.DisplayInterstitialAD();
        }
    }
    public void ReiniciarGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void AtualizarPontuacao(){
        pontuacao++;
        pontuacaotext.text = pontuacao.ToString();
        pontuacaotext_GO.text = pontuacao.ToString();
        scoreAudio.Play();
        if (PlayerPrefs.GetInt("best_score") < pontuacao) {
            PlayerPrefs.SetInt("best_score", pontuacao);

            BestScore = PlayerPrefs.GetInt("best_score");
            best_score.text = "Best: " + BestScore;
        }
        pontuacaotext_GO.text = "" + pontuacao;
    }
}
