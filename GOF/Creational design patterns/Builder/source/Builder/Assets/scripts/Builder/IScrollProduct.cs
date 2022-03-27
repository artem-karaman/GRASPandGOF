using System;
using UnityEngine;

namespace Builder
{
    public interface IScrollProduct: IDisposable
    {
        void AddItemToScrollContent(GameObject item);
    }
}