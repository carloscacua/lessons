using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrank
{
    public static class KnightL
    {
        public static void solution(int n)
        {
            var  visited = new List<bool[]>();

            for (int a = 1; a < n; a++)
            {
                for (int b = 1; b < n; b++)
                {
                    var q = new Queue<Node>();
                    visited.Clear();

                    for (int i = 0; i < n; i++) {
                        visited.Add(new bool[n]);
                        for (int j = 0; j < n; j++)
                            visited[i][j] = false;
                    }

                    q.Enqueue(new Node(0, 0, 0));

                    while (q.Any())
                    {
                        var node = q.Dequeue();

                        if (node.x == n-1 && node.y == n-1)
                        {
                            Console.Write("{0} ", node.c);
                            break;
                        }

                        if (0 <= node.x && node.x < n && 0 <= node.y && node.y < n && !visited[node.x][node.y])
                        {
                            visited[node.x][node.y] = true;
                            q.Enqueue(new Node(node.x + a, node.y + b, node.c + 1));
                            q.Enqueue(new Node(node.x - a, node.y - b, node.c + 1));
                            q.Enqueue(new Node(node.x - a, node.y + b, node.c + 1));
                            q.Enqueue(new Node(node.x + a, node.y - b, node.c + 1));
                            q.Enqueue(new Node(node.x + b, node.y + a, node.c + 1));
                            q.Enqueue(new Node(node.x - b, node.y - a, node.c + 1));
                            q.Enqueue(new Node(node.x - b, node.y + a, node.c + 1));
                            q.Enqueue(new Node(node.x + b, node.y - a, node.c + 1));
                        }
                    }
                    if (!q.Any())
                        Console.Write("-1 ");
                }
                Console.WriteLine("");

            }
        }
    }

    public struct Node
    {
        public int x, y, c;
        public Node(int _x, int _y, int _c)
        {
            x = _x;
            y = _y;
            c = _c;
        }
    }
}
