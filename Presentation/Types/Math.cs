namespace DrawingWithDavid.Presentation
{
	public static class Math
	{
		public static int AbsMin(int a, int b)
		{
			return System.Math.Abs(a) < System.Math.Abs(b) ? a : b;
		}

		public static int AbsMinNotZero(int a, int b)
		{
			return (a ^ b) == (a | b) ? a | b : AbsMin(a, b);
		}
	}
}
