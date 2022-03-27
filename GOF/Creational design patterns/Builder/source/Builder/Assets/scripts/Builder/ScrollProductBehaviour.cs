using UnityEngine;

namespace Builder
{
    public class ScrollProductBehaviour : IScrollProduct
    {
        private Transform _content;

        public void SetContent(Transform content)
        {
            _content = content;
        }

        public void AddItemToScrollContent(GameObject item)
        {
            if (item == null)
                return;

            var prefab = Object.Instantiate(item);
            prefab.transform.SetParent(_content, false);
        }

        public void Dispose()
        {
            _content = null;
        }
    }
}

