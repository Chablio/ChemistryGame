using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class HandsMovements : MonoBehaviour
{
    class Program
    {
        static void Main()
        {
            // Create a DataTable with some sample data
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Name", typeof(string));

            // Add some rows to the table
            table.Rows.Add(1, "Item 1");
            table.Rows.Add(2, "Item 2");
            table.Rows.Add(3, "Item 3");
            table.Rows.Add(4, "Item 4");
            table.Rows.Add(5, "Item 5");

            // Call a method to pick an item from the table by its ID
            DataRow pickedItem = PickItemFromTable(table, 3);

            // Display the picked item
            if (pickedItem != null)
            {
                Console.WriteLine($"Picked item: ID = {pickedItem["ID"]}, Name = {pickedItem["Name"]}");
            }
            else
            {
                Console.WriteLine("Item not found in the table.");
            }
        }

        static DataRow PickItemFromTable(DataTable table, int id)
        {
            // Loop through the rows of the table to find the item with the specified ID
            foreach (DataRow row in table.Rows)
            {
                if ((int)row["ID"] == id)
                {
                    // Return the DataRow representing the picked item
                    return row;
                }
            }

            // If the item is not found, return null
            return null;
        }
    }
}
