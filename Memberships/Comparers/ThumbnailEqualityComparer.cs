using Memberships.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Memberships.Comparers
{
    public class ThumbnailEqualityComparer : IEqualityComparer<ThumbnailModel>
    {
        bool IEqualityComparer<ThumbnailModel>.Equals(ThumbnailModel thumb1, ThumbnailModel thumb2)
        {
            return thumb1.ProductId.Equals(thumb2.ProductId);
        }

        int IEqualityComparer<ThumbnailModel>.GetHashCode(ThumbnailModel thumb)
        {
            return thumb.ProductId;
        }
    }
}