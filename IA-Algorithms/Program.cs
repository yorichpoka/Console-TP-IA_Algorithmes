using IA_Algorithms.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA_Algorithms
{
    partial class Program
    {
        #region BFS
        //static void bfs(Node node)
        //{
        //    Queue<Node> queue = new Queue<Node>();
        //    queue.Enqueue(node);
        //    while (queue.Count>0)
        //    {
        //        node = queue.Dequeue();
        //        Console.Write(node.data + " ");

        //        if (node.left != null)
        //        {
        //            queue.Enqueue(node.left);
        //        }
        //        if (node.right != null)
        //        {
        //            queue.Enqueue(node.right);
        //        }
        //    }
        //}

        static void bfs(Node node)
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(node);

            while (queue.Count > 0)
            {
                node = queue.Dequeue();

                // -- Afficher -- //
                Console.Write(node.ID + " -> ");

                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }
        }
        #endregion
        
        static void Main(string[] args)
        {
            #region Commentaires 
            //Node tree = treeCreator();
            //Console.Write("BFS --> ");

            //// -- Afficher l'arbre -- //
            //bfs(tree);

            //// -- Chercher une vakeur -- //
            //var resultat = Node.Rechercher("E", 4, tree);

            //// -- Aficher le resultat de la recherche -- //
            //if (resultat == null)
            //{
            //    Console.WriteLine("Aucun résultat trouvé.");
            //}
            //else
            //{
            //    Console.WriteLine("Trouvé: " + resultat.data);
            //}

            //// -- Modifier le noeud -- //
            //Node.Modifier("POKA", ref resultat);

            //Console.WriteLine("Je suis bien modifié");

            //// -- Afficher le noeud modifié -- //
            //bfs(resultat);

            //// -- Passer à la ligne -- //
            //Console.WriteLine();

            //// -- Afficher l'arbre -- //
            //bfs(tree);

            //// -- AJouter un noeud -- //
            //Node.Ajouter(
            //    new Node("Loic"),
            //    new Node("ulrich", new Node("POKA Junior"), null),
            //    "G",
            //    2,
            //    ref tree
            //);

            //// -- Passer à la ligne -- //
            //Console.WriteLine();

            //Console.WriteLine("Je suis bien ajouté");

            //// -- Afficher le noeud ajouté -- //
            //bfs(tree);
            #endregion


            int size_table;

            // -- Message -- //
            Console.Write("- > Taille du jeu: ");

            // -- Get size table -- //
            size_table = int.Parse(Console.ReadLine());

            // -- Update size id -- //
            Node.size_max_id = (size_table * size_table).ToString().Length;

            // -- Create node -- //
            Node node = new Node();
            Node node_clone = new Node();

            // -- Generate array -- //
            node.Generate(size_table);

            #region Create food
            // -- Create food -- //
            string food;

            // -- Message -- //
            Console.Write("- > Valeur de la nourriture: ");

            // -- Get size table -- //
            food = Console.ReadLine();
            #endregion

            // -- Generate food -- //
            Node.Insert_food(size_table, food, node);

            // -- Displays bfs -- //
            bfs(node);

            // -- Message -- //
            Console.WriteLine("\n -> Affichage du jeu <- \n");
            
            // -- Afficher -- //
            node.Afficher_BFS(node, size_table, food.Length);

            #region Create body
            // -- Create food -- //
            string body;

            // -- Message -- //
            Console.Write("- > Corps du serpent: ");

            // -- Get size table -- //
            body = Console.ReadLine();
            #endregion

            // -- Message -- //
            Console.WriteLine(" -> Parcourt du serpent dans le jeu <-");
            
            // -- Generate food -- //
            Node.Generate_Snake(food, body, node);

            // -- Message -- //
            Console.WriteLine(" -> Rendu du jeu avec le passage serpent <- \n");

            // -- Afficher -- //
            node.Afficher_BFS(node, size_table);

            // -- Bloquer l'ecran -- //
            Console.ReadLine();
        }
    }

   
}
