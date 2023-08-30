using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteApp
{
    public partial class NoteApp : Form
    {
        DataTable notes = new DataTable();
        bool editing = false;  
        
        public NoteApp()
        {
            InitializeComponent();
        }

        private void NoteApp_Load(object sender, EventArgs e)
        {
            notes.Columns.Add("Titlu");
            notes.Columns.Add("Scrie");

            previousNotes.DataSource = notes;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                notes.Rows[previousNotes.CurrentCell.RowIndex].Delete();
            }
            catch(Exception ex) { 
                Console.WriteLine("Not a valid note!");
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {

        }

        private void NewNoteButton_Click(object sender, EventArgs e)
        {
            titleBox.Text = "";
            noteBox.Text = "";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }
    }
}
