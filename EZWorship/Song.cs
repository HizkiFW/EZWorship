using System.Collections.Generic;

namespace EZWorship {
	internal class Song {

		private string songName;
		private string[] lyrics;

		public Song(string songName) {
			this.songName = songName;
		}

		public void loadLyrics(string path) {
			string text = System.IO.File.ReadAllText(path);
			this.lyrics = text.Replace("\r\n", "\n").Split(new string[] { "\n\n" }, System.StringSplitOptions.None);
		}

		public string[] getLyrics() {
			return this.lyrics;
		}

		public override string ToString() {
			return this.songName;
		}
	}
}