﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace challenge298
{
    class Program
    {
        static void Main(string[] args)
        {

            /* [2017-01-09] Challenge #298 [Hard] Functional Maze solving
             * 
             * Borrowing from adventofcode.com, http://adventofcode.com/2016/day/24, solve the following maze returning the path (length) visiting nodes labelled 1 to 7 starting from 0. 
             * # are walls. May not travel diagonally. Correct answer for path length with this input is 460
             * 
             * 
            ###################################################################################################################################################################################
            #.....#.#.....#...#....4#.....#.#...#.........#...#...............#...................#...#.#...........#.#...........#.#.#.#.........#.#.......#...#...........#.....#...#7..#.#.#
            ###.#.#.###.#.#.###.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.###.#.###.#.###.#.#.#.###.###.#.#####.###.#.#.###.#.#.#.#.#.#.#.#.#.#.#.#.###.#####.#.#.#.#.#####.#.#.#.###.#.#.#.#.#####.#.#.#.#
            #.#.....#.#.#...#.........#.....#.....#.......#.#.#.............#.#.#.#.....#.#.......#.....#.........#...#.......#.....#.#.#.............#...........#.#.....#.#.....#.......#.#.#
            #.#.#.#.#.#.#.#.#.#.#####.#####.###.###.#.###.#.###.###.#.#####.#.#.#.#.#.###.#.#.###.#.#.#.#.###.#########.###########.#.#.###.#.#.###.###.#.###.###.#.#.#####.#.###.#.#####.#.###
            #...........#...#...#.....#.....#...#.#...#.#.....#.........#...#...#.....#.....#.#.#...#...#...#...#.....#.......#...#...#...............#...#...#.............#.....#.#.....#...#
            ###.#.#.###.#.#.#.#.###.#.###.#####.#.#.#.#.#.###.###.###.#.#.#.###.#.#.#.#.###.#.#.#.###.#####.#########.#.#.#.#.#.###.#.#.#.#.#####.#.#.#.#.###.#.#.#.#.#.#.#.#####.#.###.#.#.#.#
            #3#...#.#.#.#.........#...............#...#.#.....#...#.....#...#.......#...#.....#.#.#...#.....#...#.....#.#.#.....#.....#...........#.#.#.#.....#.#.........#.#...#.#.#.#...#...#
            #.###.###.#######.###.#.###.#.#.#.###.###.#######.###.#.#####.#####.#.#.#.#.#######.###.###.###.###.###.#.#########.#.#.#.#.#.#####.###.#.###.#.###.#.#####.###.###.###.#.#.#.###.#
            #.#...#.....#.#.............#.....#.#.....#.#.....#.#.#.....#.....#.......#.....#.................#...........#...#.#.....#...#.....#...#.......#.#.....#...#...#.#.#...#...#...#.#
            #.###.###.###.#.#.#.#####.#.###.#.#.###.#.#.#.#.#.#.#.#.#.#####.#####.#.#.#.#.#.#.###########.#.#.#.#.#.###.#.#.#.#.#.#.#.#.#.###.#.#.#####.#####.#.###.#.#.#.#.#.#.#####.#.###.#.#
            #.....#.......#.#.#.#.#...............#...#.#.#.#...#...........#.....#.#...#.................#...#.#.#...#.............#...#.........#...............#...#.#.#.....#.....#.....#.#
            #####.#.#######.#.###.#.#.#.#.###.#.#.#.###.###.###.#.#.#.#.#.#.###.#.#.#.#.#######.###.#.###.#.#.#.###.#.#.###.###.#.#.#.#.#####.#####.#.###.#####.###.#.#.#####.#.#.#####.#.#.#.#
            #.#...#.........#...#.#...#.......#...#.#.......#...#.#.........#.#.#...#.#.#.#.........#.#.#.......#...#...#...#.#...#.......#...#.....#...#...#.#...#...#...#...........#...#.#.#
            #.#####.#.###.#.#.#######.#.###.#.#.#.#########.#.#.#.#.#####.#.#.#######.#.#.###########.#.#########.###.#.#.#.#.###.#.#.###.#########.#.#.#.###.#.#.###.#.#.###.#####.#.###.#.#.#
            #.......#.......#...#.#.#...#...#.....#.#...#...#.#.#.#.#...#.....#.#...#...#.............#.......#.......#...#.#.............#.......#.....#...#...#.#.....#.............#...#.#.#
            #.#####.###.#####.#.#.#.#.#.#.#.#.#.#.#.#.###.###.#.###.###.#.#.###.#.#.#.#.###.#.###.#.#.#.#.#.#.#.#######.#.#.###.#.#.#.#.###.#.###.###.#####.#.#.#.#.#####.###.#.###.#####.###.#
            #..6#...#...#...#...#.#.....#...#.#.#...#...........#.#.#...#.#.#.....#.....#.#.#.....#.......#.................#.#.....#.#.........#...#...#...........#.#2....#.#.......#.#.#.#.#
            #.###.###.#.###.#####.#####.#.###.###.#.###.#.#####.#.#.#.#.#.#.###.#.#.#.#.#.#.#.#.#.#.###.#######.#.#.#.#.#####.#.#.#######.###.#####.###.#####.#####.#.#####.###.#######.###.###
            #.#.....#...#...#...........#.#.......#.#...#.#.............#...#...#.....#...#.....#.......#.......#.......#...#...#.......#...#.......#.#...#...#.........#...#...#...#.......#.#
            #.#.###.#.#.#.#.###.#######.#.#.###.###.#####.###.#.###.#######.#####.#####.#.#####.#.###.#.#.#.#.#####.###.#.#.#.#.#.#.#.#.#############.###.#.#.#.###.#.#.###.#.#.#.#.#####.#.#.#
            #...#.........#.....#...#.#...#.....#...#...#.......#.....#...#...#...#...#.............#.#...#.............#.....#...#.#.#.......#.....#.....#.....#...........#...#...#.....#...#
            #.#######.#.#.###.#.#.#.#.#.###.#.#.#.###.#.###.#.#.#.#####.#.#.#.#.#.#.#.#.#####.#####.#####.#.#######.###.#.#.###.#.###.#.#.#.#.#.###.#.#.###.#.#.#######.###.#.###.#.#.#.#.###.#
            #.....#.......#...#.#...#.....#...#.#...........#.....#.....#.#.#...#.....#.................#.........#.#.......#...........#...#...#.......#0#...#.....#.......#.#...........#...#
            #.#.#.#.#.###.#.#.#.###.###.#.#.###.#.#.#####.#######.#.#.#.#.#.###.###.###.#.#####.###.#####.#.#.###.###.###.###.#####.###.#.#.#.#.#.###.#.#.#.#.#.###.#.###.#.#.#.#.#.#.#####.###
            #.#.#...#...#.#.......#.............#...........................#.......#...........#.#...#...#.#...#.....#...#.#.#.#.#.#.......#.#...#...#...#...............#.......#.....#.....#
            #.#.###.#.#.#.#.#.#####.#.#####.#.#.###.#.#.#.#.#############.#.###.#.#.#.#.#####.#.#.###.#.###.#.#.#######.###.#.#.#.#.#.###.#.#####.#.###.###.#######.#.###.#####.#.#.#.#######.#
            #...#.......#.....#...#...#...#.....#5....#...#.......#.#.#...#...........#.#.......#.#...#.#.......#.#.#...#...#.....#.............#...#...#.....#.................#.....#.#...#.#
            #######.#.#.#######.#####.###.#.#.#######.#.#.#.#.#.#.#.#.#.###.#.###.#.#.#.###.###.#.#.#.###.#.###.#.#.###.#.###.#####.###.#######.#.#.#.#.#.#.#.#########.###.#.#.#.#.#.#.#.#.###
            #.#.........#...........#.........#.........#.#.#...........#...#.....#...................#...........#...#...#...#.#.......#...#.....#.#.#.....#.#.............#.........#.#...#.#
            #.#.#.###.#.###.#.###.#.###.#.#######.#.###.#.#.#.#########.#.###.#.#####.###.#.#.###.#.#.#.###.#.#####.###.#.###.#.#.###.#.#.#.#.#.#.#.#.###.#.#.###.#.#####.#.#.#######.#.#####.#
            #.........#.#.....#.....#...#...#.......#.....#.................#...#...#.....#...#...#.#.#.#...#...........#.#.....#.#.....#...#.#...#.......#.........#.....#.....#.......#...#.#
            #.#####.#.#.#.#.#.#.#####.###.###.#.#####.###.#####.###.#.#.#.#.#.###.#.#.#.#.#.#####.###.###.#.#.#.#.#.###.#.#.#.#.#.#.#.#####.#.#.#.#.#.#########.#.#.#.###.#.###.#.#.#.#.#.#.###
            #.......#...#...#.....#.#...#...#...#.#.............#.....#.............#.#.......#.......#...#...#...#.....#.......#...#...........#.#...#.#.......#...........#.#.....#.....#...#
            #.#.#.#.#.###.#.#.#.#.#.#.#.#.#.#.#.#.#.###.#.#.#####.#.###.#.#.#####.#.#.#.#####.#.#.###.###.#.#.#.#.#.#.#.#####.#.#.#####.###.###.###.###.#.#.#.#.#.#.#########.#####.#.#.#.#.#.#
            #.#.#.#.............#...#...#.#.....#...........#.........#...#.#.#...#.#.........#.........#.........#.....#.........#...#...#...#..1#.....#.#.#...#.#.....#...#...........#.....#
            ###################################################################################################################################################################################
            
             * This is a fairly large maze, and you may wish to resort to one of the main graph algorithms that minimize how often a node cost is calculated. Namely Astar... though there are other options.
             * 
            */

            // 1. Import the maaze into an array

            // Want each node to be a data point in the array, it's 37 rows by 179 cols
            // Make one giant string then chop it up into individual bits?
            // Or enter the maze into an array as one?
            // Either way want to avoid it being static (ie avoid using 37 and 179), want it to know when to start the next row

            string[] lines = System.IO.File.ReadAllLines((Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName) + "\\maze.txt");

            #region Not Used Array
            string[,] raw_maze =   {{"###################################################################################################################################################################################"}, 
                                    {"#.....#.#.....#...#....4#.....#.#...#.........#...#...............#...................#...#.#...........#.#...........#.#.#.#.........#.#.......#...#...........#.....#...#7..#.#.#"},
                                    {"###.#.#.###.#.#.###.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.###.#.###.#.###.#.#.#.###.###.#.#####.###.#.#.###.#.#.#.#.#.#.#.#.#.#.#.#.###.#####.#.#.#.#.#####.#.#.#.###.#.#.#.#.#####.#.#.#.#"},
                                    {"#.#.....#.#.#...#.........#.....#.....#.......#.#.#.............#.#.#.#.....#.#.......#.....#.........#...#.......#.....#.#.#.............#...........#.#.....#.#.....#.......#.#.#"},
                                    {"#.#.#.#.#.#.#.#.#.#.#####.#####.###.###.#.###.#.###.###.#.#####.#.#.#.#.#.###.#.#.###.#.#.#.#.###.#########.###########.#.#.###.#.#.###.###.#.###.###.#.#.#####.#.###.#.#####.#.###"},
                                    {"#...........#...#...#.....#.....#...#.#...#.#.....#.........#...#...#.....#.....#.#.#...#...#...#...#.....#.......#...#...#...............#...#...#.............#.....#.#.....#...#"},
                                    {"###.#.#.###.#.#.#.#.###.#.###.#####.#.#.#.#.#.###.###.###.#.#.#.###.#.#.#.#.###.#.#.#.###.#####.#########.#.#.#.#.#.###.#.#.#.#.#####.#.#.#.#.###.#.#.#.#.#.#.#.#####.#.###.#.#.#.#"},
                                    {"#3#...#.#.#.#.........#...............#...#.#.....#...#.....#...#.......#...#.....#.#.#...#.....#...#.....#.#.#.....#.....#...........#.#.#.#.....#.#.........#.#...#.#.#.#...#...#"},
                                    {"#.###.###.#######.###.#.###.#.#.#.###.###.#######.###.#.#####.#####.#.#.#.#.#######.###.###.###.###.###.#.#########.#.#.#.#.#.#####.###.#.###.#.###.#.#####.###.###.###.#.#.#.###.#"},
                                    {"#.#...#.....#.#.............#.....#.#.....#.#.....#.#.#.....#.....#.......#.....#.................#...........#...#.#.....#...#.....#...#.......#.#.....#...#...#.#.#...#...#...#.#"},
                                    {"#.###.###.###.#.#.#.#####.#.###.#.#.###.#.#.#.#.#.#.#.#.#.#####.#####.#.#.#.#.#.#.###########.#.#.#.#.#.###.#.#.#.#.#.#.#.#.#.###.#.#.#####.#####.#.###.#.#.#.#.#.#.#####.#.###.#.#"},
                                    {"#.....#.......#.#.#.#.#...............#...#.#.#.#...#...........#.....#.#...#.................#...#.#.#...#.............#...#.........#...............#...#.#.#.....#.....#.....#.#"},
                                    {"#####.#.#######.#.###.#.#.#.#.###.#.#.#.###.###.###.#.#.#.#.#.#.###.#.#.#.#.#######.###.#.###.#.#.#.###.#.#.###.###.#.#.#.#.#####.#####.#.###.#####.###.#.#.#####.#.#.#####.#.#.#.#"},
                                    {"#.#...#.........#...#.#...#.......#...#.#.......#...#.#.........#.#.#...#.#.#.#.........#.#.#.......#...#...#...#.#...#.......#...#.....#...#...#.#...#...#...#...........#...#.#.#"},
                                    {"#.#####.#.###.#.#.#######.#.###.#.#.#.#########.#.#.#.#.#####.#.#.#######.#.#.###########.#.#########.###.#.#.#.#.###.#.#.###.#########.#.#.#.###.#.#.###.#.#.###.#####.#.###.#.#.#"},
                                    {"#.......#.......#...#.#.#...#...#.....#.#...#...#.#.#.#.#...#.....#.#...#...#.............#.......#.......#...#.#.............#.......#.....#...#...#.#.....#.............#...#.#.#"},
                                    {"#.#####.###.#####.#.#.#.#.#.#.#.#.#.#.#.#.###.###.#.###.###.#.#.###.#.#.#.#.###.#.###.#.#.#.#.#.#.#.#######.#.#.###.#.#.#.#.###.#.###.###.#####.#.#.#.#.#####.###.#.###.#####.###.#"},
                                    {"#..6#...#...#...#...#.#.....#...#.#.#...#...........#.#.#...#.#.#.....#.....#.#.#.....#.......#.................#.#.....#.#.........#...#...#...........#.#2....#.#.......#.#.#.#.#"},
                                    {"#.###.###.#.###.#####.#####.#.###.###.#.###.#.#####.#.#.#.#.#.#.###.#.#.#.#.#.#.#.#.#.#.###.#######.#.#.#.#.#####.#.#.#######.###.#####.###.#####.#####.#.#####.###.#######.###.###"},
                                    {"#.#.....#...#...#...........#.#.......#.#...#.#.............#...#...#.....#...#.....#.......#.......#.......#...#...#.......#...#.......#.#...#...#.........#...#...#...#.......#.#"},
                                    {"#.#.###.#.#.#.#.###.#######.#.#.###.###.#####.###.#.###.#######.#####.#####.#.#####.#.###.#.#.#.#.#####.###.#.#.#.#.#.#.#.#.#############.###.#.#.#.###.#.#.###.#.#.#.#.#####.#.#.#"},
                                    {"#...#.........#.....#...#.#...#.....#...#...#.......#.....#...#...#...#...#.............#.#...#.............#.....#...#.#.#.......#.....#.....#.....#...........#...#...#.....#...#"},
                                    {"#.#######.#.#.###.#.#.#.#.#.###.#.#.#.###.#.###.#.#.#.#####.#.#.#.#.#.#.#.#.#####.#####.#####.#.#######.###.#.#.###.#.###.#.#.#.#.#.###.#.#.###.#.#.#######.###.#.###.#.#.#.#.###.#"},
                                    {"#.#.#.#.#.###.#.#.#.###.###.#.#.###.#.#.#####.#######.#.#.#.#.#.###.###.###.#.#####.###.#####.#.#.###.###.###.###.#####.###.#.#.#.#.#.###.#.#.#.#.#.###.#.###.#.#.#.#.#.#.#####.###"},
                                    {"#.#.#...#...#.#.......#.............#...........................#.......#...........#.#...#...#.#...#.....#...#.#.#.#.#.#.......#.#...#...#...#...............#.......#.....#.....#"},
                                    {"#.#.###.#.#.#.#.#.#####.#.#####.#.#.###.#.#.#.#.#############.#.###.#.#.#.#.#####.#.#.###.#.###.#.#.#######.###.#.#.#.#.#.###.#.#####.#.###.###.#######.#.###.#####.#.#.#.#######.#"},
                                    {"#...#.......#.....#...#...#...#.....#5....#...#.......#.#.#...#...........#.#.......#.#...#.#.......#.#.#...#...#.....#.............#...#...#.....#.................#.....#.#...#.#"},
                                    {"#######.#.#.#######.#####.###.#.#.#######.#.#.#.#.#.#.#.#.#.###.#.###.#.#.#.###.###.#.#.#.###.#.###.#.#.###.#.###.#####.###.#######.#.#.#.#.#.#.#.#########.###.#.#.#.#.#.#.#.#.###"},
                                    {"#.#.#.###.#.###.#.###.#.###.#.#######.#.###.#.#.#.#########.#.###.#.#####.###.#.#.###.#.#.#.###.#.#####.###.#.###.#.#.###.#.#.#.#.#.#.#.#.###.#.#.###.#.#####.#.#.#######.#.#####.#"},
                                    {"#.........#.#.....#.....#...#...#.......#.....#.................#...#...#.....#...#...#.#.#.#...#...........#.#.....#.#.....#...#.#...#.......#.........#.....#.....#.......#...#.#"},
                                    {"#.#####.#.#.#.#.#.#.#####.###.###.#.#####.###.#####.###.#.#.#.#.#.###.#.#.#.#.#.#####.###.###.#.#.#.#.#.###.#.#.#.#.#.#.#.#####.#.#.#.#.#.#########.#.#.#.###.#.###.#.#.#.#.#.#.###"},
                                    {"#.......#...#...#.....#.#...#...#...#.#.............#.....#.............#.#.......#.......#...#...#...#.....#.......#...#...........#.#...#.#.......#...........#.#.....#.....#...#"},
                                    {"#.#.#.#.#.###.#.#.#.#.#.#.#.#.#.#.#.#.#.###.#.#.#####.#.###.#.#.#####.#.#.#.#####.#.#.###.###.#.#.#.#.#.#.#.#####.#.#.#####.###.###.###.###.#.#.#.#.#.#.#########.#####.#.#.#.#.#.#"},
                                    {"#.#.#.#.............#...#...#.#.....#...........#.........#...#.#.#...#.#.........#.........#.........#.....#.........#...#...#...#..1#.....#.#.#...#.#.....#...#...........#.....#"},
                                    {"###################################################################################################################################################################################"}};
            
            #endregion

            string[,] maze;
            char[] chars;

            for (int i = 0; i < lines.Length; i++)
            {
                chars = lines[i].ToCharArray();
            };
            
            //loop through each row and character, converting it into an individual 
            // there is another row

            //string[,] maze = 

            // 2. Set up the rules for the "patherfinder player" - use a class?
            // ie go up, down, left, right
            // what to do when hit #, what to do when hit

            // 3. Run algorithm for deducing the quickest route
            // If there is a . in any of the adjacent nodes, add this to the "open set" to explore
            // Keep going until each node has been explored, stop if the distance is greater than the current maximum
            // Each path will have a path (set of instructions) and a distance

            Console.ReadKey(); 
        }
    }
}
