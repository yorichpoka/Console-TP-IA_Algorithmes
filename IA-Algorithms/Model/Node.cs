using System;
using System.Collections.Generic;

namespace IA_Algorithms.Model
{
    public class Node : ICloneable
    {
        // -- Variables -- //
        public Node left;
        public Node right;
        public Boolean isEmpty;
        public static int id = 0;
        public string ID = null;
        public static int size_max_id;
        public string value;
        private string iD;

        // -- Constructeur de node -- //
        public Node(Boolean isEmpty, Node left, Node right)
        {
            this.isEmpty = isEmpty;
            this.left = left;
            this.right = right;
            Node.id++;
            this.ID = Generate_ID(Node.id);
        }

        // -- Constructeur de node -- //
        public Node(Boolean isEmpty, Nullable<Boolean> isLeft)
        {
            this.isEmpty = isEmpty;
            this.left = null;
            this.right = null;
            Node.id++;
            this.ID = Generate_ID(Node.id);
        }
        public void Afficher(Node node, int length_foot_value)
        {
            string empty_value = Generate_Space(length_foot_value);

            while (node != null)
            {
                // -- Display -- //
                Console.Write("   [" + (string.IsNullOrEmpty(node.value) ? empty_value
                                                                         : node.value)  + "]");

                while (node.left != null)
                {
                    // -- Afficher -- //
                    Console.Write(" - [" + (string.IsNullOrEmpty(node.left.value) ? empty_value
                                                                                  : node.left.value) + "]");

                    // -- Go to next -- //
                    node.left = node.left.left;
                }

                // -- Next line -- //
                Console.WriteLine("\n   ");

                // -- Go to next -- //
                node = node.right;
            }
        }

        public void Afficher(Node node)
        {
            while (node != null)
            {
                // -- Display -- //
                Console.Write("   [" + node.value + "]");

                while (node.left != null)
                {
                    // -- Afficher -- //
                    Console.Write(" - [" + node.left.value + "]");

                    // -- Go to next -- //
                    node.left = node.left.left;
                }

                // -- Next line -- //
                Console.WriteLine("\n   ");

                // -- Go to next -- //
                node = node.right;
            }
        }

        public void Afficher_BFS(Node node, int size_table)
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(node);
            int i = size_table;

            while (queue.Count > 0)
            {
                node = queue.Dequeue();

                // -- Display -- //
                if (i == size_table)
                {
                    // -- Display -- //
                    Console.Write("   [" + node.value + "]");
                }
                else if (i > size_table)
                {
                    // -- Afficher -- //
                    Console.Write(" - [" + node.value + "]");
                }

                size_table--;

                if (size_table == 0)
                {
                    // -- Next line -- //
                    Console.WriteLine("\n   ");

                    size_table = i;
                }

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

        public void Afficher_BFS(Node node, int size_table, int length_foot_value)
        {
            string empty_value = Generate_Space(length_foot_value);

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(node);
            int i = size_table;

            while (queue.Count > 0)
            {
                node = queue.Dequeue();

                // -- Display -- //
                if (i == size_table)
                {
                    // -- Display -- //
                    Console.Write("   [" + (string.IsNullOrEmpty(node.value) ? empty_value
                                                                             : node.value) + "]");
                }
                else if (i > size_table)
                {
                    // -- Afficher -- //
                    Console.Write(" - [" + (string.IsNullOrEmpty(node.value) ? empty_value
                                                                             : node.value) + "]");
                }

                size_table--;

                if (size_table == 0)
                {
                    // -- Next line -- //
                    Console.WriteLine("\n   ");

                    size_table = i;
                }

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

        public Node()
        {
            this.isEmpty = false;
            this.left = null;
            this.right = null;
            Node.id++;
            this.ID = Generate_ID(Node.id);
            //Console.Write(this.ID + ", -> ");
        }

        public Node(string value)
        {
            this.value = value;
        }

        public Node(Node left, Node right, string value, string iD, bool isEmpty)
        {
            this.left = left;
            this.right = right;
            this.value = value;
            this.iD = iD;
            this.isEmpty = isEmpty;
        }

        // -- Generate snake -- //
        public static void Generate_Snake(string food_value, string body, Node node)
        {
            string space = new Node().Generate_Space(Math.Abs(food_value.Length - body.Length), ' ');

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(node);
            Boolean found = false;

            while (queue.Count > 0)
            {
                node = queue.Dequeue();

                // -- Update body snake -- //
                if (string.IsNullOrEmpty(node.value) || string.IsNullOrWhiteSpace(node.value) || node.value != food_value)
                {
                    node.value = (!found) ? (food_value.Length > body.Length) ? space + body
                                                                              : body
                                          : new Node().Generate_Space(
                                              (food_value.Length > body.Length) ? food_value.Length
                                                                                : body.Length, ' ');
                }
                else
                {
                    found = true;

                    node.value = (food_value.Length < body.Length) ? space + node.value
                                                                   : node.value;
                }

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

        // -- insert food -- //
        public static void Insert_food(int size_table, string value, Node node)
        {
            Food food = new Food(size_table, value);
            
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(node);

            while (queue.Count > 0)
            {
                node = queue.Dequeue();

                // -- add food -- //
                if (int.Parse(node.ID) == food.id)
                {
                    node.value = value;
                }

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

        // -- Construct for array -- //
        public void Generate(int size)
        {
            int size_left = size - 1;
            int[] tab = new int[size];

            for(int i = 0; i < size; i++)
            {
                tab[i] = size_left;
            }

            this.Generate_Array(size - 1,tab);
        }
        private void Generate_Array(int size_right, int[] tab_size_left)
        {
            if (size_right >= 0)
            {
                // -- Create children -- //
                this.left = new Node();

                // -- Generate children left -- //
                this.left.Generate_Array_Left(tab_size_left[size_right]);

                if (size_right != 0)
                {
                    // -- Create child -- //
                    this.right = new Node();

                    size_right--;

                    // -- Generate child rigth -- //
                    this.right.Generate_Array(size_right, tab_size_left);
                }
            }
        }
        private string Generate_ID(int id)
        {
            string empty = "";

            for(int i = 1; i <= (size_max_id - (id.ToString().Length)); i++)
            {
                empty += "";
            }

            return
                empty += id;
        }
        private string Generate_Space(int length)
        {
            string empty = "";

            for (int i = 1; i <= length; i++)
            {
                empty += " ";
            }

            return
                empty;
        }
        private string Generate_Space(int length, Char value)
        {
            string empty = "";

            for (int i = 1; i <= length; i++)
            {
                empty += value;
            }

            return
                empty;
        }
        private void Generate_Array(ref int size, ref Node node)
        {
            if ((size - 1) > 0)
            {
                node.right = new Node();

                size--;

                node.right.Generate_Array(ref size, ref node.right);
            }
        }
        private void Generate_Array_Right(int size)
        {
            if ((size - 1) > 0)
            {
                this.right = new Node();

                size--;

                this.right.Generate_Array_Right(size);
            }
        }
        private void Generate_Array(int size_right, int size_left)
        {
            if ((size_right - 1) > 0)
            {
                this.right = new Node();
                this.left = new Node();

                this.left.Generate_Array_Left(size_left);
                
                size_right--;

                this.right.Generate_Array_Right(size_right);
            }
        }
        private void Generate_Array_Left(int decrement)
        {
            if ((decrement - 1) > 0)
            {
                this.left = new Node();

                decrement--;

                this.left.Generate_Array_Left(decrement);
            }
        }


        // -- Rechercher un noeud -- //
        private static Node Rechercher(Boolean valeur, ref Node noeud)
        {
            Queue<Node> queue = new Queue<Node>();

            queue.Enqueue(noeud);

            while (queue.Count > 0)
            {
                // -- Réccupérer l'arbre en cours -- //
                noeud = queue.Dequeue();

                // -- 2couter la valeur -- //
                if (noeud.isEmpty == valeur)
                {
                    return noeud;
                }

                if (noeud.left != null)
                {
                    queue.Enqueue(noeud.left);
                }
                if (noeud.right != null)
                {
                    queue.Enqueue(noeud.right);
                }
            }

            // -- Retourner pour dire que rien n'a trouvé -- //
            return null;
        }
        private static Node Rechercher(Boolean valeur, int occurence, ref Node noeud)
        {
            int occurence_trouver = 0;
            Queue<Node> queue = new Queue<Node>();

            queue.Enqueue(noeud);

            while (queue.Count > 0)
            {
                // -- Réccupérer l'arbre en cours -- //
                noeud = queue.Dequeue();

                // -- 2couter la valeur -- //
                if (noeud.isEmpty == valeur)
                {
                    // -- INcrémenter le nombre de recherche -- //
                    occurence_trouver++;

                    // -- Teste du nombre d'occurence -- //
                    if (occurence_trouver == occurence)
                    {
                        return noeud;
                    }
                }

                if (noeud.left != null)
                {
                    queue.Enqueue(noeud.left);
                }
                if (noeud.right != null)
                {
                    queue.Enqueue(noeud.right);
                }
            }

            // -- Retourner pour dire que rien n'a trouvé -- //
            return null;
        }
        private static Node Rechercher(Boolean valeur, int occurence, Node noeud)
        {
            int occurence_trouver = 0;
            Queue<Node> queue = new Queue<Node>();

            queue.Enqueue(noeud);

            while (queue.Count > 0)
            {
                // -- Réccupérer l'arbre en cours -- //
                noeud = queue.Dequeue();

                // -- 2couter la valeur -- //
                if (noeud.isEmpty == valeur)
                {
                    // -- INcrémenter le nombre de recherche -- //
                    occurence_trouver++;

                    // -- Teste du nombre d'occurence -- //
                    if (occurence_trouver == occurence)
                    {
                        return noeud;
                    }
                }

                if (noeud.left != null)
                {
                    queue.Enqueue(noeud.left);
                }
                if (noeud.right != null)
                {
                    queue.Enqueue(noeud.right);
                }
            }

            // -- Retourner pour dire que rien n'a trouvé -- //
            return null;
        }

        // -- MOdifier un noeud -- //
        private static void Modifier(Boolean valeur, ref Node noeud)
        {
            noeud.isEmpty = valeur;
        }

        // -- Ajouter un node dans une liste -- //
        #region Ajouter
        private static void Ajouter(Node fils_gauche, Node fils_droite, Boolean valeur, int occurence, ref Node noeud)
        {
            // -- Recherche du noeud -- //
            var resultat = Node.Rechercher(valeur, occurence, ref noeud);

            // -- 2couter le résltat -- //
            if (resultat == null)
            {
                throw new Exception("La valeur ou l'occurence de ce noeud n'existe pas.");
            }

            // -- Ajouter les fils -- //
            resultat.left = fils_gauche;
            resultat.right = fils_droite;
        }
        
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        #endregion
    }
}