using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Localization
{
    public class LocalizationText : MonoBehaviour
    {
        [SerializeField]  ListItem _items;

        [Space] [SerializeField] private TextAsset _file;
        [SerializeField] private Text _text;
        

        [ContextMenu("LoadFiled")]
        private void Start()
        {
            _items = JsonUtility.FromJson<ListItem>(_file.text);
        }

        public void SetText(int index)
        {
            _text.text = _items.Items[index].Text;
        }
    }

    [System.Serializable]
    public class ListItem
    {
        public List<Item> Items;
    }
    
    [System.Serializable]
    public class Item
    {
        public string Text;
    }
}