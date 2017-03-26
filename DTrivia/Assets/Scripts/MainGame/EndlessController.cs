using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Utils;
using Fungus;
public class EndlessController : Command {
    [SerializeField]
    private GameObject CanvasController;
    private Procedural2DGrid ProceduralGrid;
    private int userScore = 0;
    private float fixTime;

    public bool isReloadingGrid = false;
    public Flowchart mainFlowChart;
    public static EndlessController Instance;
    public GameObject gameCorePanel;
    public GameObject gamePausePanel;
    public float gameTime = 0f;
    public eGameState gameState;
    public Text userScoreText;
    public GameObject GRBox;
    public Text pauseScoreText;
    public GameObject continueButton;

    public Image timeImage;
    public float CountdownFrom = 120; // Segundos

    

    void Awake()
    {
        if (Instance) return;
        Instance = this;
        gameState = eGameState.onMenus;
    }

	// Use this for initialization
	void Start () {
        fixTime = CountdownFrom;
        ProceduralGrid = CanvasController.GetComponent<Procedural2DGrid>();        
	}

    void Update()
    {
        if (CountdownFrom > 0 && (gameState != eGameState.pause && gameState != eGameState.onMenus))
        {
            CountdownFrom -= Time.deltaTime;
            float percentage = (CountdownFrom / fixTime);
            timeImage.fillAmount = percentage;
        }
        if (CountdownFrom <= 0f && gameState == eGameState.playing)
        {
            TimesUp();
        }
    }

    public void setUpTimerWithTime(float time = 60f)
    {
        CountdownFrom = time;
        fixTime = time;
    }

    private void InitGame()
    {
        userScore = 0;
        userScoreText.text = ""+userScore;
        timeImage.fillAmount = 1f;
        gameCorePanel.SetActive(true);
        gameState = eGameState.playing;
        ProceduralGrid.Init(UILokingSingleton.Instance.rSize, UILokingSingleton.Instance.cSize);
    }

    public void ReloadGrid()
    {
        ProceduralGrid.ClearGrid();
    }

    public void TimesUp(){
        gameState = eGameState.onMenus;
        gameCorePanel.SetActive(false);
        mainFlowChart.ExecuteBlock("GoToPause");
    }

    public void IncreaseScore()
    {
        userScore++;
        userScoreText.text = "" + userScore;
        CountdownFrom = CountdownFrom + 3f;
        if (CountdownFrom >= fixTime) CountdownFrom = fixTime;
    }

    public void DecreaseTime()
    {
        CountdownFrom = CountdownFrom - 2f;
    }

    public void SetUpEndless()
    {
        gameState = eGameState.playing;
        setUpTimerWithTime();
        InitGame();
    }

    public void PauseGame()
    {
        if(gameState != eGameState.onMenus) gameState = eGameState.pause;
        gameCorePanel.SetActive(false);    
    }

    public void UnPauseGame()
    {
        gameState = eGameState.playing;
        gameCorePanel.SetActive(true);
    }

    public void showPausePanel()
    { 
        gamePausePanel.SetActive(true);
        if (gameState == eGameState.onMenus) continueButton.SetActive(false);
        else continueButton.SetActive(true);
        pauseScoreText.text = ""+userScore;
    }

    public void hidePausePanel()
    {
        gamePausePanel.SetActive(false);
    }

}
