﻿using System;

namespace FbxSharp
{
    public class Skin : Deformer
    {
        public Skin(string name="")
            : base(name)
        {
            Geometry = this.DstObjects.CreateObjectView<Geometry>();
            Clusters = this.SrcObjects.CreateCollectionView<Cluster>();
        }

        public double DeformAccuracy;

        #region Public Member Functions

        public void SetDeformAccuracy(double pDeformAccuracy)
        {
            DeformAccuracy = pDeformAccuracy;
        }

        public double GetDeformAccuracy()
        {
            return DeformAccuracy;
        }

        public readonly ObjectView<Geometry> Geometry;

        public bool SetGeometry(Geometry pGeometry)
        {
            if (GetGeometry() != null)
            {
                DisconnectDstObject(GetGeometry());
            }

            return ConnectDstObject(pGeometry);
        }

        public Geometry GetGeometry()
        {
            return Geometry.Get();
        }

        public readonly CollectionView<Cluster> Clusters;

        public bool AddCluster(Cluster pCluster)
        {
            ConnectSrcObject(pCluster);
            return true;
        }

        public Cluster RemoveCluster(Cluster pCluster)
        {
            if (DisconnectSrcObject(pCluster))
                return pCluster;

            return null;
        }

        public int GetClusterCount()
        {
            return Clusters.Count;
        }

        public Cluster GetCluster(int pIndex)
        {
            return Clusters[pIndex];
        }

        public override EDeformerType GetDeformerType()
        {
            return EDeformerType.eSkin;
        }

        public void SetSkinningType(EType pType)
        {
            throw new NotImplementedException();
        }

        public enum EType
        {
            eRigid,
            eLinear,
            eDualQuaternion,
            eBlend,
        }

        public EType GetSkinningType()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Control Points

        public void AddControlPointIndex(int pIndex, double pBlendWeight=0)
        {
            throw new NotImplementedException();
        }

        public int GetControlPointIndicesCount()
        {
            throw new NotImplementedException();
        }

        public int[] GetControlPointIndices()
        {
            throw new NotImplementedException();
        }

        public double[] GetControlPointBlendWeights()
        {
            throw new NotImplementedException();
        }

        public void SetControlPointIWCount(int pCount)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}

