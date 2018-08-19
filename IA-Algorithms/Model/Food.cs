using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA_Algorithms.Model
{
    public class Food
    {
        public string value;
        public int x;
        public int y;
        public int id;

        public Food(int size_table)
        {
            this.x = new Random().Next(1, size_table);
            this.y = new Random().Next(1, size_table);
            this.id = new Random().Next(1, size_table);
        }

        public Food(int size_table, string value)
        {
            // -- Check if nu ll -- //
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                throw new Exception("Food parameter is invalid!");
            }

            this.x = new Random().Next(1, size_table);
            this.y = new Random().Next(1, size_table);
            this.id = new Random().Next(1, (size_table * size_table));
            this.value = value;
        }
    }
}
