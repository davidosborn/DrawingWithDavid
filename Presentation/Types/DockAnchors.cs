using System;
using System.Collections;

namespace DrawingWithDavid.Presentation
{
	struct DockAnchors : IEnumerable
	{
		public Nullable<DockAnchor> Left, Top, Right, Bottom;

		public IEnumerator GetEnumerator()
		{
			if (Left   != null) yield return Left;
			if (Top    != null) yield return Top;
			if (Right  != null) yield return Right;
			if (Bottom != null) yield return Bottom;
		}
	}
}
