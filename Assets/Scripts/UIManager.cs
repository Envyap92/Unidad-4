using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public Text currentScoreText;

    public Text bestScoreText;

    public Slider slider;

    public Text ActualLevel;
    public Text NextLevel;

    public Transform topTransform;
    public Transform goalTransform;

    public Transform ball;

    void Update()
    {
        currentScoreText.text = "Score:" + GameManager.singleton.currentScore;

        bestScoreText.text = "Best: " + GameManager.singleton.bestScore;

        ChangeSliderLevelAndProgress();
    }

    public void ChangeSliderLevelAndProgress()
    {
        ActualLevel.text = "" + (GameManager.singleton.currentLevel+1);

        NextLevel.text = "" + (GameManager.singleton.currentLevel + 2);

        float totalDistance = (topTransform.position.y - goalTransform.position.y);

        float distanceLeft = totalDistance - (ball.position.y - goalTransform.position.y);

        float value = (distanceLeft / totalDistance);

        slider.value = Mathf.Lerp(slider.value, value, 5);
    }
}