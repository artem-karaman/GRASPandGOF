using TMPro;
using Unity.VectorGraphics;
using UnityEngine;

public class CounterDecorator : Decorator
{
    public CounterDecorator(ICell cell) : base(cell){}

    public override SVGImage Show()
    {
        var image = base.Show();
        return AddCounter(image);
    }

    private SVGImage AddCounter(SVGImage image)
    {
        var counter = new GameObject("counter");
        var counterText = counter.AddComponent<TextMeshProUGUI>();
        prepareText(counterText);
        counter.transform.SetParent(image.transform, false);
        var transform = counter.GetComponent<RectTransform>();
        prepareTransform(transform);
        return image;
    }

    private void prepareTransform(RectTransform transform)
    {
        transform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 70);
        transform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 70);
    }

    private void prepareText(TextMeshProUGUI counterText)
    {
        counterText.text = 1.ToString();
        counterText.alignment = TextAlignmentOptions.BottomRight;
        counterText.color = Color.black;
        counterText.fontSize = 16;
    }
}