using System;
using System.Collections.Generic;

namespace line_word {
	class word {
		static public int Main(string [] args)
		{
			List<int> word_nrs = new List<int>();
			int i = 1;
			string line;

			if (args.Length == 0) {
				return PrintWordNrs();
			}

			foreach (string arg in args) {
				int parsed = 0;
				try {
					parsed = int.Parse(arg);
				} catch (Exception) { }

				if (parsed == 0) {
					Console.WriteLine("Invalid word index: {0}", arg);
					return 1;
				}

				word_nrs.Add(parsed);
			}

			while ((line = NormalizeWS(Console.ReadLine())) != null) {
				int j = 1;

				string [] words = line.Split();
				int words_count = words.Length;

				foreach (int nr in word_nrs) {
					int index = nr;

					index = (nr < 0)? (words_count + nr): (nr - 1);

					if ((index >= 0) && (index < words_count)) {
						if (j > 1) { /* Spacing for j>1 */
							Console.Write(" {0}", words[index]);
						} else { /* No spacing for j==1 */
							Console.Write("{0}", words[index]);
						}
					}
					j++;
				}
				Console.WriteLine("");

				i++;
			}

			return 0;
		}

		static public int PrintWordNrs()
		{
			string line;
			int i = 1;
			while ((line = NormalizeWS(Console.ReadLine())) != null) {
				int j = 1;

				Console.WriteLine("Line {0}:", i);

				foreach (string word in line.Split()) {
					Console.WriteLine("\t{0}: {1}", j, word);
					j++;
				}

				i++;
			}

			return 0;
		}

		static public string NormalizeWS(string s) {
			string ret;
			if (s == null) {
				ret = null;
			} else {
				ret = System.Text.RegularExpressions.Regex.Replace(s,
						@"\s+"," ").Trim();
			}
			return ret;
		}
	}
}
