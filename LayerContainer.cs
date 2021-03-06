﻿using System;
using System.Collections.Generic;

namespace FbxSharp
{
    public abstract class LayerContainer : NodeAttribute
    {
        protected LayerContainer(string name="")
            : base(name)
        {
            Layers = new CollectionView<Layer, Layer>(layers, eh => layers.CollectionChanged += eh);
        }

        readonly ChangeNotifyList<Layer> layers = new ChangeNotifyList<Layer>();
        public readonly CollectionView<Layer, Layer> Layers;

        public int CreateLayer()
        {
            layers.Add(new Layer());
            return layers.Count - 1;
        }

        public void ClearLayers()
        {
            throw new NotImplementedException();
        }

        public int GetLayerCount()
        {
            return layers.Count;
        }

        public int GetLayerCount(LayerElement.EType pType, bool pUVCount = false)
        {
            throw new NotImplementedException();
        }

        public Layer GetLayer(int pIndex)
        {
            return layers[pIndex];
        }

        public Layer GetLayer(int pIndex, LayerElement.EType pType, bool pIsUV = false)
        {
            throw new NotImplementedException();
        }

        public int GetLayerIndex(int pIndex, LayerElement.EType pType, bool pIsUV = false)
        {
            throw new NotImplementedException();
        }

        public int GetLayerTypedIndex(int pGlobalIndex, LayerElement.EType pType, bool pIsUV = false)
        {
            throw new NotImplementedException();
        }
    }
}

