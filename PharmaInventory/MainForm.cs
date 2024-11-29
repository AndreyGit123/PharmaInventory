using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PharmaInventory.Controllers;
using PharmaInventory.DAO;
using PharmaInventory.Data;
using PharmaInventory.Forms;
using PharmaInventory.Models;
using PharmaInventory.Services;
using Microsoft.EntityFrameworkCore;
using System.Xml;

namespace PharmaInventory
{
    public partial class MainForm : Form
    {
        public readonly PharmaController _pharmaController;
        public MainForm()
        {
            InitializeComponent();
            var context = new ApplicationDbContext();
            var pharmaRepository = new PharmaRepository(context);
            var pharmaService = new PharmaService(pharmaRepository);
            _pharmaController = new PharmaController(pharmaService);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadMed();

        }

       
        private void LoadMed()
        {
            flowLayoutPanel.WrapContents = true;
            flowLayoutPanel.AutoScroll = true;
            var meds = _pharmaController.GetAllMed();
            flowLayoutPanel.Controls.Clear();
            foreach (var med in meds)
            {
                AddMedCard(med);
            }
        }


      
        private void AddMedCard(PharmaItem pharmaItem)
        {
            var cardPanel = new Panel
            {
                Size = new Size(370, 160),
                BackColor = Color.LightYellow,
                Margin = new Padding(30),
                Padding = new Padding(10)


            };

            // Delete Icon (Text-Based)
            var deleteIcon = new Label
            {
                Text = "✖", // Unicode character for 'X' symbol
                Font = new Font("Segoe UI", 8, FontStyle.Bold),
                ForeColor = Color.Red,
                Cursor = Cursors.Hand,
                Location = new Point(cardPanel.Width - 30, 5),
                AutoSize = true
            };
            deleteIcon.Click += (sender, e) => DeleteMed(pharmaItem);
            cardPanel.Controls.Add(deleteIcon);

            var editIcon = new Label
            {
                Text = "✏", // Unicode character for pencil
                Font = new Font("Segoe UI", 8, FontStyle.Bold),
                ForeColor = Color.Gold,
                Cursor = Cursors.Hand,
                Location = new Point(cardPanel.Width - 60, 5),
                AutoSize = true
            };
            editIcon.Click += (sender, e) => UpdateMed(pharmaItem);
            cardPanel.Controls.Add(editIcon);

            var courseLabel = new Label
            {
                Text = $"{pharmaItem.MedName}",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.DarkSlateGray,
                Location = new Point(10, 10),
                AutoSize = true
            };
            cardPanel.Controls.Add(courseLabel);

            var manufactureDate = new Label
            {
                Text = $"Manufacture Date: {pharmaItem.MedManufactureDate.ToString("yyyy-MM-dd")}",  
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.DimGray,
                Location = new Point(10, 35),
                AutoSize = true
            };
            cardPanel.Controls.Add(manufactureDate);

            var expiryDate = new Label
            {
                Text = $"Expiry Date: {pharmaItem.MedExpireDate:yyyy-MM-dd}",
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                ForeColor = Color.Gray,
                Location = new Point(10, 60),
                AutoSize = true
            };
            cardPanel.Controls.Add(expiryDate);
            var description = new Label
            {
                Text = $"Description: {pharmaItem.MedDescription}",
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                ForeColor = Color.Gray,
                Location = new Point(10, 60),
                AutoSize = true
            };
            cardPanel.Controls.Add(description);



            var viewDetails = new LinkLabel
            {
                Text = "View Details",
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                ForeColor = Color.Blue,
                Location = new Point(20, 55),
                AutoSize = true
            };
            // Calculate the position for bottom right corner
            viewDetails.Location = new Point(cardPanel.Width - viewDetails.Width - 10, cardPanel.Height - viewDetails.Height - 10);
            viewDetails.LinkClicked += (sender, e) => ShowNoteDetails(pharmaItem);
            cardPanel.Controls.Add(viewDetails);

            flowLayoutPanel.Controls.Add(cardPanel);
        }

        private void ShowNoteDetails(PharmaItem pharmaItem)
        {
            string details = $"Medicine Name: {pharmaItem.MedName}\n" +
                             $"Description: {pharmaItem.MedDescription}\n"+
                             $"Manufacture Date: {pharmaItem.MedManufactureDate:yyyy-MM-dd}\n" +
                             $"Expiry Date: {pharmaItem.MedExpireDate:yyyy-MM-dd}";
                           
            MessageBox.Show(details, "Medicine Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void UpdateMed(PharmaItem pharmaItem)
        {
            // Logic to update the subject
            var updateForm = new UpdateForm(pharmaItem);
            updateForm.MedUpdated += (updatedMed) =>
            {
                // Update the specific note in the list immediately
                LoadMed(); // Reload all notes to reflect changes
            };
            //addNoteForm.NoteAdded += LoadNotes;
            updateForm.ShowDialog();
        }

        private void DeleteMed(PharmaItem pharmaItem)
        {
            var confirmResult = MessageBox.Show($"Are you sure to delete {pharmaItem.MedName}?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                _pharmaController.DeleteMed(pharmaItem.Id);
                LoadMed(); // Refresh the subjects list
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addBtn_Click_1(object sender, EventArgs e)
        {
            var addForm = new AddForm();
            addForm.MedAdded += LoadMed;
            addForm.ShowDialog();
           
        }
    }
}
