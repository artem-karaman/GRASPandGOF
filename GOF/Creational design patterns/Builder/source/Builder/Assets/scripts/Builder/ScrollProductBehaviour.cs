using System;
using UnityEngine;

namespace Builder
{
    public class ScrollProductBehaviour : IScrollProduct, IDisposable
    {
        private Transform _content;

        public void SetContent(Transform content)
        {
            _content = content;
        }

        public void AddItemToScroll(GameObject item)
        {
            if (item == null)
                return;

            var prefab = UnityEngine.Object.Instantiate(item);
            prefab.transform.SetParent(_content, false);
        }

        public void Dispose()
        {
            _content = null;
        }
    }
}

