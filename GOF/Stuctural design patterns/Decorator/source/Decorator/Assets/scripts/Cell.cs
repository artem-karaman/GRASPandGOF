using UnityEngine;
using Unity.VectorGraphics;

public class Cell : ICell
{
    private readonly SVGImage _image;
    private readonly Sprite _sprite;
    public Cell(SVGImage image, Sprite sprite)
    {
        _image = image;
        _sprite = sprite;
    }

    public SVGImage Show()
    {
        _image.sprite = _sprite;
        return _image;
    }
}
