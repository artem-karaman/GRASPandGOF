using Builder;
using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.UI;

public class MainBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject _scrollViewContent;
    [SerializeField] private Button _constructHorizontalScrollButton;
    [SerializeField] private Button _constructVerticalScrollButton;
    [SerializeField] private Button _addItem;
    [SerializeField] private Button _clearContent;
    [SerializeField] private SVGImage _item;

    private Director _director;
    private IScrollProduct _currentScrollContent;

    void Start()
    {
        _director = new Director();

        _constructHorizontalScrollButton?.onClick.AddListener(ConstructHorizontalScrollContent);
        _constructVerticalScrollButton?.onClick.AddListener(ConstructVerticalScrollContent);
        _addItem?.onClick.AddListener(AddItemtoScrollContent);
        _clearContent?.onClick.AddListener(ClearContent);
    }

    private void ConstructHorizontalScrollContent()
    {
        var builder = new HorizontalScrollBuilder(_scrollViewContent);
        _director.Construct(builder);
        _currentScrollContent = builder.GetResult();
    }

    private void ConstructVerticalScrollContent()
    {
        var builder = new VerticalScrollBuilder(_scrollViewContent);
        _director.Construct(builder);
        _currentScrollContent = builder.GetResult();
    }

    private void AddItemtoScrollContent()
    {
        _currentScrollContent.AddItemToScroll(_item.gameObject);
    }

    private void ClearContent()
    {
        clearContent();
    }    

    private void clearContent()
    {
        foreach (Transform child in _scrollViewContent.transform)
        {
            var image = child.GetComponent<SVGImage>();
            Destroy(image);
            Destroy(child.gameObject);
        }

        var group = _scrollViewContent.GetComponent<HorizontalOrVerticalLayoutGroup>();
        if (group != null)
        {
            Destroy(group);
        }

        var contentSizeFitter = _scrollViewContent.GetComponent<ContentSizeFitter>();
        if (contentSizeFitter != null)
        {
            Destroy(contentSizeFitter);
        }

        _currentScrollContent?.Dispose();
        _currentScrollContent = null;
    }
}
