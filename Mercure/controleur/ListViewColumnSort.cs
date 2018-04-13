using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace Mercure.controleur
{
    class ListViewColumnSort : IComparer
    {
        // Specifies the column to be sorted
        private int Column_Sort;
        // Specifies the order in which to sort (i.e. 'Ascending').
        private SortOrder Order_Sort;

        // Class constructor.  Initializes various elements
        public ListViewColumnSort()
        {
            // Initialize the column to '0'
            Column_Sort = 0;
            // Initialize the sort order to 'none'
            Order_Sort = SortOrder.Ascending;
        }

        /// <summary>
        /// This method is inherited from the IComparer interface.  It compares the two objects passed using a case insensitive comparison.
        /// </summary>
        /// <param name="x">First object to be compared</param>
        /// <param name="y">Second object to be compared</param>
        /// <returns>The result of the comparison. "0" if equal, negative if 'x' is less than 'y' and positive if 'x' is greater than 'y'</returns>
        public int Compare(object X, object Y)
        {
            int Result;
            ListViewItem listviewX, listviewY;

            // Cast the objects to be compared to ListViewItem objects
            listviewX = (ListViewItem)X;
            listviewY = (ListViewItem)Y;

            float FloatX;
            float FloatY;
            if (float.TryParse(((ListViewItem)X).SubItems[Column_Sort].Text, out FloatX)
                && float.TryParse(((ListViewItem)Y).SubItems[Column_Sort].Text, out FloatY))
            {
                Result = FloatX >= FloatY ? (FloatX == FloatY ? 0 : 1) : -1; 
            }
            else
            {
                int IntX;
                int IntY;
                if ( int.TryParse(((ListViewItem)X).SubItems[Column_Sort].Text, out IntX)
                && int.TryParse(((ListViewItem)Y).SubItems[Column_Sort].Text, out IntY))
                {
                    Result = IntX >= IntY ? (IntX == IntY ? 0 : 1) : -1;
                }
                else
                {
                    Result = string.Compare(listviewX.SubItems[Column_Sort].Text, listviewY.SubItems[Column_Sort].Text);
                }
            }

            // Calculate correct return value based on object comparison
            if (Order_Sort == SortOrder.Ascending)
            {
                // Ascending sort is selected, return normal result of compare operation
                return Result;
            }
            else if (Order_Sort == SortOrder.Descending)
            {
                // Descending sort is selected, return negative result of compare operation
                return (-Result);
            }
            else
            {
                // Return '0' to indicate they are equal
                return 0;
            }
        }
    
        // Gets or sets the number of the column to which to apply the sorting operation (Defaults to '0').
        public int SortColumn
        {
            set
            {
                Column_Sort = value;
            }
            get
            {
                return Column_Sort;
            }
        }

        // Gets or sets the order of sorting to apply (for example, 'Ascending' or 'Descending').
        public SortOrder Order
        {
            set
            {
                Order_Sort = value;
            }
            get
            {
                return Order_Sort;
            }
        }
    }
}
