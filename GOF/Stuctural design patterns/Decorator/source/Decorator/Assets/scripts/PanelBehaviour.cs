using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.UI;

public class PanelBehaviour : MonoBehaviour
{
    [SerializeField] private SVGImage _image;
    [SerializeField] private Sprite _cellSprite;
    [SerializeField] private Sprite _borderSprite;
    [SerializeField] private Button _addBorderButton;
    [SerializeField] private Button _addCounterButton;
    [SerializeField] private Button _addCounterAndBorderButton;
    [SerializeField] private Button _setDefaultCell;

    private ICell _cell;

    void Start()
    {
        _cell = new Cell(_image, _cellSprite);
        _cell.Show();

        _addBorderButton.onClick.AddListener(AddBorder);
        _addCounterButton.onClick.AddListener(AddCounter);
        _addCounterAndBorderButton.onClick.AddListener(AddCounterAndBorder);
        _setDefaultCell.onClick.AddListener(SetDefaultCell);
    }

    private void SetDefaultCell()
    {
        foreach (Transform child in _image.transform)
        {
            Destroy(child.gameObject);
        }
    }

    private void AddCounterAndBorder() => 
        new CounterDecorator(
           new BorderDecorator(
               _borderSprite,
               _cell))
            .Show();

    private void AddCounter() => 
        new CounterDecorator(
            _cell)
        .Show();

    private void AddBorder() => 
        new BorderDecorator(
            _borderSprite, 
            _cell)
        .Show();

    private void OnDisable()
    {
        _addBorderButton.onClick.RemoveListener(AddBorder);
        _addCounterButton.onClick.RemoveListener(AddCounter);
        _addCounterAndBorderButton.onClick.RemoveListener(AddCounterAndBorder);
        _setDefaultCell.onClick.RemoveListener(SetDefaultCell);
    }
}
