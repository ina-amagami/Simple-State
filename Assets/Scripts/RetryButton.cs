using UnityEngine;

public class RetryButton : MonoBehaviour
{
    private Player player;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag(Player.Tag).GetComponent<Player>();
        player.OnDeathAction += () =>
        {
            gameObject.SetActive(true);
        };
        gameObject.SetActive(false);
    }

    public void Retry()
	{
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
	}
}
