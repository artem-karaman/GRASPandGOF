using UnityEngine;
using UnityEngine.UI;

namespace Builder {
    public class HorizontalScrollBuilder : IBuilder
    {
        private readonly GameObject _scrollViewContent;

        public HorizontalScrollBuilder(GameObject scrollContent)
        {
            _scrollViewContent = scrollContent;
        }

        public void AddContentSizeFitter()
        {
            var contentSizeFitter = _scrollViewContent.AddComponent<ContentSizeFitter>();
            contentSizeFitter.horizontalFit = ContentSizeFitter.FitMode.PreferredSize;
        }

        public void AddLayoutGroup()
        {
            var horizontalLayoutGroup = _scrollViewContent.AddComponent<HorizontalLayoutGroup>();
            horizontalLayoutGroup.childAlignment = TextAnchor.MiddleCenter;
            horizontalLayoutGroup.childControlHeight = false;
            horizontalLayoutGroup.childControlWidth = false;
            horizontalLayoutGroup.spacing = 10;
        }

        public void PrepareRectTransform()
        {
            var rectTransform = _scrollViewContent.GetComponent<RectTransform>();
            rectTransform.anchorMin = new Vector2(0, 0);
            rectTransform.anchorMax = new Vector2(0, 1);
            rectTransform.pivot = new Vector2(0, 0.5f);
            rectTransform.offsetMin = new Vector2(0, 0);
            rectTransform.offsetMax = new Vector2(0, 0);
        }

        public IScrollProduct GetResult()
        {
            var scrollProductBehaviour = new ScrollProductBehaviour();
            scrollProductBehaviour.SetContent(_scrollViewContent.transform);
            return scrollProductBehaviour;
        }
    }
}


