using UnityEngine;

public class HPGauge : MonoBehaviour
{
	private Player player;
	private RectTransform rectTransform;
	private float maxWidth;

	private void Start()
	{
		player = GameObject.FindGameObjectWithTag(Player.Tag).GetComponent<Player>();
		rectTransform = GetComponent<RectTransform>();
		maxWidth = rectTransform.sizeDelta.x;
	}

	private void Update()
    {
		Vector2 size = rectTransform.sizeDelta;
		size.x = player.Hp / player.MaxHp * maxWidth;
		rectTransform.sizeDelta = size;
    }
}
