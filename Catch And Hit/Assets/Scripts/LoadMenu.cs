
using UnityEngine.SceneManagement;

public class LoadMenu : RestartGame
{
    public override void EndGame()
    {
        SceneManager.LoadScene(0);
        Res = true;
    }
}
