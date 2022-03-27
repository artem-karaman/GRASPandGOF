using UnityEngine;
using UnityEngine.UI;

namespace Builder
{
    public class VerticalScrollBuilder : IBuilder
    {
        private readonly GameObject _scrollViewContent;
        public VerticalScrollBuilder(GameObject scrollViewContent)
        {
            _scrollViewContent = scrollViewContent;
        }

        public void PrepareRectTransform()
        {
            var rectTransform = _scrollViewContent.GetComponent<RectTransform>();
            rectTransform.anchorMin = new Vector2(0, 1);
            rectTransform.anchorMax = new Vector2(1, 1);
            rectTransform.pivot = new Vector2(0.5f, 1);
            rectTransform.offsetMin = new Vector2(0, 0);
            rectTransform.offsetMax = new Vector2(0, 0);
        }

        public void AddLayoutGroup()
        {
            var verticalLayoutGroup = _scrollViewContent.AddComponent<VerticalLayoutGroup>();
            verticalLayoutGroup.childAlignment = TextAnchor.MiddleCenter;
            verticalLayoutGroup.childControlHeight = false;
            verticalLayoutGroup.childControlWidth = false;
            verticalLayoutGroup.spacing = 10;
        }

        public void AddContentSizeFitter()
        {
            var contenSizeFitter = _scrollViewContent.AddComponent<ContentSizeFitter>();
            contenSizeFitter.verticalFit = ContentSizeFitter.FitMode.PreferredSize;
        }

        public IScrollProduct GetResult()
        {
            var scrollProductBehaviour = new ScrollProductBehaviour();
            scrollProductBehaviour.SetContent(_scrollViewContent.transform);
            return scrollProductBehaviour;
        }
    }
}

