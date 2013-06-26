using System;

namespace DrawingWithDavid.Presentation
{
	public enum Side
	{
		Left,
		Top,
		Right,
		Bottom
	}

	[Flags]
	public enum SideFlags
	{
		None   = 0x0,
		Left   = 0x1,
		Top    = 0x2,
		Right  = 0x4,
		Bottom = 0x8,
		All    = Left | Top | Right | Bottom
	}
}
