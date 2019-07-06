using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SoftserveLabyrinth {

	class Program {
		public Dictionary<int, List<Field>> MapToDraw { get; set; }

		private static void Main(string[] args) {
			Console.WriteLine("Enter sizes of the labyrinth: ");
			string sizesOfLabyrinth = Console.ReadLine();
			int bombsCount = int.Parse(Console.ReadLine());
			string[] splittedSizesOfLabyrinth = 
				Regex.Split(sizesOfLabyrinth, ", ");

			int widthOfLabyrinth = 
				int.Parse(splittedSizesOfLabyrinth[0]);

			int heightOfLabyrinth = 
				int.Parse(splittedSizesOfLabyrinth[1]);
		}
	}

	class Point {
		public int X { get; set; }
		public int Y { get; set; }
	}

	class Field : Point {

	}

	class Player : Field {

	}

	class Wall : Field {

	}

	class Bomb : Field {

	}

	interface Move {
		void Move(Direction direction);
	}

	enum Direction {
		UP,
		DOWN,
		LEFT,
		RIGHT
	};

	interface IMap {
		void DrawMap();
	}

	class Map : IMap {
		public void DrawMap() {
			
		}
	}

	class Movement : Move {
		private Dictionary<Direction, Tuple<int, int>> directions = 
			new Dictionary<Direction, Tuple<int, int>>() {
				{ Direction.UP, new Tuple<int, int>(0, 1) },
				{ Direction.DOWN, new Tuple<int, int>(0, -1) },
				{ Direction.LEFT, new Tuple<int, int>(-1, 0) },
				{ Direction.RIGHT, new Tuple<int, int>(1, 0) }
		};

		public void Move(Direction direction) {
			
		}
	}
}
