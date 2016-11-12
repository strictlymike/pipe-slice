using System;
using System.Collections.Generic;

namespace line_word {
	class line {
		static public int Main(string [] args)
		{
			Dictionary<int, bool> line_nrs = new Dictionary<int, bool>();
			int i = 1;
			string line;

			if (args.Length == 0) {
				return PrintLineNrs();
			}

			foreach (string arg in args) {
				int parsed = 0;
				try {
					parsed = int.Parse(arg);
				} catch (Exception) { }

				if (parsed <= 0) {
					Console.WriteLine("Invalid line number: {0}", arg);
					return 1;
				}

				if (!line_nrs.ContainsKey(parsed)) {
					line_nrs.Add(parsed, true);
				}
			}

			while ((line = Console.ReadLine()) != null) {
				if (line_nrs.ContainsKey(i)) {
					Console.WriteLine(line);
				}
				i++;
			}

			return 0;
		}

		static public int PrintLineNrs() {
			string line;
			int i = 1;
			while ((line = Console.ReadLine()) != null) {
				Console.WriteLine("{0}: {1}", i, line);
				i++;
			}

			return 0;
		}
	}
}
