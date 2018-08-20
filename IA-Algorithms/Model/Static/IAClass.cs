using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA_Algorithms.Model.Static
{
    public class IAClass
    {
        public static Node arbre()
        {
            Node n5_1 = new Node("M");
            Node n5_2 = new Node("S");
            Node n5_3 = new Node("H");
            Node n5_4 = new Node("W");
            Node n5_5 = new Node("C");
            Node n5_6 = new Node("Z");
            Node n5_7 = new Node("L");
            Node n5_8 = new Node("R");
            Node n5_9 = new Node("2");
            Node n5_10 = new Node("B");
            Node n5_11 = new Node("Q");
            Node n5_12 = new Node("K");
            Node n5_13 = new Node("G");
            Node n5_14 = new Node("1");
            Node n5_15 = new Node("I");
            Node n5_16 = new Node("5");

            Node n4_1 = new Node("4");
            Node n4_2 = new Node("X");
            Node n4_3 = new Node("D");
            Node n4_4 = new Node("3");
            Node n4_5 = new Node("P");
            Node n4_6 = new Node("J");
            Node n4_7 = new Node("Y");
            Node n4_8 = new Node("V");

            Node n3_1 = new Node("E");
            Node n3_2 = new Node("U");
            Node n3_3 = new Node("F");
            Node n3_4 = new Node("O");

            Node n2_1 = new Node("T");
            Node n2_2 = new Node("N");

            Node n1_1 = new Node("A");

            // -- N4 -- //
            // -- 1
            n4_1.left   = n5_1;
            n4_1.right  = n5_2;
            // -- 2
            n4_2.left   = n5_3;
            n4_2.right  = n5_4;
            // -- 3
            n4_3.left   = n5_5;
            n4_3.right  = n5_6;
            // -- 4
            n4_4.left   = n5_7;
            n4_4.right  = n5_8;
            // -- 5
            n4_5.left   = n5_9;
            n4_5.right  = n5_10;
            // -- 6
            n4_6.left   = n5_11;
            n4_6.right  = n5_12;
            // -- 7
            n4_7.left   = n5_12;
            n4_7.right  = n5_14;
            // -- 8
            n4_8.left   = n5_15;
            n4_8.right  = n5_16;

            // -- N3 -- //
            // -- 1
            n3_1.left = n4_1;
            n3_1.right = n4_2;
            // -- 2
            n3_2.left = n4_3;
            n3_2.right = n4_4;
            // -- 3
            n3_3.left = n4_5;
            n3_3.right = n4_6;
            // -- 4
            n3_4.left = n4_7;
            n3_4.right = n4_8;

            // -- N2 -- //
            // -- 1
            n2_1.left = n3_1;
            n2_1.right = n3_2;
            // -- 2
            n2_2.left = n3_3;
            n2_2.right = n3_4;

            // -- N1 -- //
            // -- 1
            n1_1.left   = n2_1;
            n1_1.right  = n2_2;

            return n1_1;
        }

        public static Node arbre2()
        {
            //Node n5_1 = new Node("M");
            //Node n5_2 = new Node("S");
            //Node n5_3 = new Node("H");
            //Node n5_4 = new Node("W");
            //Node n5_5 = new Node("C");
            //Node n5_6 = new Node("Z");
            //Node n5_7 = new Node("L");
            //Node n5_8 = new Node("R");
            //Node n5_9 = new Node("2");
            //Node n5_10 = new Node("B");
            //Node n5_11 = new Node("Q");
            //Node n5_12 = new Node("K");
            //Node n5_13 = new Node("G");
            //Node n5_14 = new Node("1");
            //Node n5_15 = new Node("I");
            //Node n5_16 = new Node("5");

            //Node n4_1 = new Node("4");
            //Node n4_2 = new Node("X");
            //Node n4_3 = new Node("D");
            //Node n4_4 = new Node("3");
            //Node n4_5 = new Node("P");
            //Node n4_6 = new Node("J");
            //Node n4_7 = new Node("Y");
            //Node n4_8 = new Node("V");

            Node n3_1 = new Node("E");
            Node n3_2 = new Node("U");
            Node n3_3 = new Node("F");
            Node n3_4 = new Node("O");

            Node n2_1 = new Node("T");
            Node n2_2 = new Node("N");

            Node n1_1 = new Node("A");

            //// -- N4 -- //
            //// -- 1
            //n4_1.left = n5_1;
            //n4_1.right = n5_2;
            //// -- 2
            //n4_2.left = n5_3;
            //n4_2.right = n5_4;
            //// -- 3
            //n4_3.left = n5_5;
            //n4_3.right = n5_6;
            //// -- 4
            //n4_4.left = n5_7;
            //n4_4.right = n5_8;
            //// -- 5
            //n4_5.left = n5_9;
            //n4_5.right = n5_10;
            //// -- 6
            //n4_6.left = n5_11;
            //n4_6.right = n5_12;
            //// -- 7
            //n4_7.left = n5_12;
            //n4_7.right = n5_14;
            //// -- 8
            //n4_8.left = n5_15;
            //n4_8.right = n5_16;

            // -- N3 -- //
            // -- 1
            //n3_1.left = n4_1;
            //n3_1.right = n4_2;
            //// -- 2
            //n3_2.left = n4_3;
            //n3_2.right = n4_4;
            //// -- 3
            //n3_3.left = n4_5;
            //n3_3.right = n4_6;
            //// -- 4
            //n3_4.left = n4_7;
            //n3_4.right = n4_8;

            // -- N2 -- //
            // -- 1
            n2_1.left = n3_1;
            n2_1.right = n3_2;
            // -- 2
            n2_2.left = n3_3;
            n2_2.right = n3_4;

            // -- N1 -- //
            // -- 1
            n1_1.left = n2_1;
            n1_1.right = n2_2;

            return n1_1;
        }
    }
}
