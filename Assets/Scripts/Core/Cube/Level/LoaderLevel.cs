using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Core.Cube.Level
{
    public class LoaderLevel : MonoBehaviour
    {
        [SerializeField] private List<Text> _texts;
        [SerializeField] private MeshRenderer _meshRenderer;
        
        [Space] [SerializeField] private List<DataLevelCube> _data;
        public void LoadLevel(int level)
        {
            if (level < _data.Count)
            {
                var currentData = _data[level];
                
                _texts.ForEach(text => text.text = currentData.Score.ToString());
                _meshRenderer.material.color = currentData.Color;
            }
            else
            {
                print("конец");
            }
        }

        public DataLevelCube GetCurrentData(int level)
        {
            return _data[level];
        }
    }
}