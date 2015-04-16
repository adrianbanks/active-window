using System.Collections.Generic;

namespace ActiveWindow.Windows
{
    internal sealed class ForegroundWindowInfoEqualityComparer : IEqualityComparer<ForegroundWindowInfo>
    {
        public bool Equals(ForegroundWindowInfo x, ForegroundWindowInfo y)
        {
            if (ReferenceEquals(x, y))
            {
                return true;
            }

            if (ReferenceEquals(x, null) && !ReferenceEquals(y, null))
            {
                return false;
            }

            if (!ReferenceEquals(x, null) && ReferenceEquals(y, null))
            {
                return false;
            }

            return string.Equals(x.Path, y.Path)
                   && string.Equals(x.WindowTitle, y.WindowTitle);
        }

        public int GetHashCode(ForegroundWindowInfo obj)
        {
            int hashCode = 17;

            if (obj == null)
            {
                return hashCode;
            }

            hashCode = (hashCode * 23) + (obj.Path != null ? obj.Path.GetHashCode() : 29);
            hashCode = (hashCode * 23) + (obj.WindowTitle != null ? obj.WindowTitle.GetHashCode() : 29);
            return hashCode;
        }
    }
}
