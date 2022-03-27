using Unity.VectorGraphics;
using UnityEngine;

public class BorderDecorator : Decorator
{
    private readonly Sprite _borderSprite;

    public BorderDecorator(Sprite borderSprite, ICell cell) : base(cell)
    {
        _borderSprite = borderSprite;
    }
   
    public override SVGImage Show()
    {
        var image = base.Show();
        AddBorder(image);
        return image;
    }

    private void AddBorder(SVGImage image)
    {
        var border = new GameObject("border");
        var borderImage = border.AddComponent<SVGImage>();
        borderImage.sprite = _borderSprite;
        border.transform.SetParent(image.transform, false);
    }
}
