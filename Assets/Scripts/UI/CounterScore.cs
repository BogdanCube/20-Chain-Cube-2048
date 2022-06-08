using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class CounterScore : MonoBehaviour
    {
        [SerializeField] private Text _text;
        private int score = 0;

        public void AddScore(int additionalScore)
        {
            score += additionalScore;
            _text.text = score.ToString();
        }

        public void SetText(string text)
        {
            _text.text = text;
        }
    }
}