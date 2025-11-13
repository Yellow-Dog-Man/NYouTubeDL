namespace NYoutubeDL.Helpers
{
	#region Using

	using System.Collections.Generic;

	#endregion

	[Option]
	internal class MultiEnumOption<T> : BaseOption<IList<T>>
	{
		internal MultiEnumOption(string paramString) : base(paramString) { }

		public override string ToString()
		{
			if (this.Value == null || this.Value.Count == 0)
				return string.Empty;

			return $"{this.ParamString} {string.Join($" {this.ParamString} ", this.Value)}";
		}
	}
}
